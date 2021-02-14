using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PixelwiseWatermark
{
    public partial class GenerateWatermark : Form
    {
        /// <summary>
        /// Initialize our generator window its default values.
        /// </summary>
        /// <param name="source">The image source path.</param>
        public GenerateWatermark(string source)
        {
            InitializeComponent();
            InitializeProgram(source);
        }

        private void InitializeProgram(string source)
        {
            this.SetButtonState(false);
            ProgressBar.Visible = false;
            ImagePreview.BackgroundImage = Image.FromFile(source);
        }

        // Gets triggered every time someone types/changes a character in the text box.
        private void WatermarkMessageInput_TextChanged(object sender, EventArgs e)
            => this.SetButtonState(!string.IsNullOrWhiteSpace(WatermarkMessageInput.Text));

        /// <summary>
        /// Set the default states for the two buttons that exist on the generator.
        /// </summary>
        /// <param name="state">Whether the buttons should be enabled/disabled.</param>
        private void SetButtonState(bool state)
        {
            GenerateWatermarkButton.Enabled = state;
            SaveGeneratedWatermarkButton.Enabled = state;
        }

        // Gets triggered when the generate button is clicked
        private void GenerateWatermarkButton_Click(object sender, EventArgs e)
        {
            this.SetIsInProgressState(true);
            ProgressBar.Minimum = 0;
            // byte[] data = this.GetImagePreviewBitmapData();

            Bitmap bm = new Bitmap(ImagePreview.BackgroundImage);
            Rectangle rect = new Rectangle(0, 0, bm.Width, bm.Height);
            BitmapData bmd = bm.LockBits(rect, ImageLockMode.ReadOnly, bm.PixelFormat);
            IntPtr pointer = bmd.Scan0;
            
            int byteCount = Math.Abs(bmd.Stride) * bm.Height;
            byte[] data = new byte[byteCount];
            ProgressBar.Maximum = data.Length + 3;
            ProgressBar.Step = 1;
            ProgressBar.Value = 0;

            Marshal.Copy(pointer, data, 0, byteCount);
            ProgressBar.PerformStep();

            int skipSize;

            switch (bm.PixelFormat)
            {
                case PixelFormat.Indexed:
                case PixelFormat.Gdi:
                case PixelFormat.Alpha:
                case PixelFormat.PAlpha:
                case PixelFormat.Extended:
                case PixelFormat.Canonical:
                case PixelFormat.Undefined:
                case PixelFormat.Format1bppIndexed:
                case PixelFormat.Format4bppIndexed:
                case PixelFormat.Format8bppIndexed:
                case PixelFormat.Format16bppGrayScale:
                    MessageBox.Show(@"The image pixel-format is currently not supported!", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.SetIsInProgressState(false);
                    return;
                case PixelFormat.Format16bppArgb1555:
                case PixelFormat.Format32bppArgb:
                case PixelFormat.Format32bppPArgb:
                case PixelFormat.Format64bppArgb:
                case PixelFormat.Format64bppPArgb:
                    skipSize = 4;
                    break;
                default:
                    skipSize = 3;
                    break;
            }

            int currentMessageIndex = 0;
            string binaryMessage = ToBinary(ConvertToByteArray(WatermarkMessageInput.Text, Encoding.ASCII)).Replace(" ", "00100000");

            for (int i = 0; i < data.Length; i += skipSize)
            {
                for (int j = 0; j < skipSize; j++)
                {
                    if (currentMessageIndex == binaryMessage.Length) currentMessageIndex = 0;
                    data[i + j] = GetNewBinaryValue(data[i + j], binaryMessage[currentMessageIndex]);
                    currentMessageIndex++;
                    ProgressBar.PerformStep();
                }
            }

            Marshal.Copy(data, 0, pointer, byteCount);
            ProgressBar.PerformStep();
            bm.UnlockBits(bmd);
            ProgressBar.PerformStep();
            ImagePreview.BackgroundImage = bm;
            this.SetIsInProgressState(false);
        }

        private byte GetNewBinaryValue(byte b, char c)
        {
            string bin = Convert.ToString(b, 2);
            return Convert.ToByte(bin.Remove(bin.Length - 1, 1) + c, 2);
        }

        private void SetIsInProgressState(bool state)
        {
            ProgressBar.Visible = state;
            WatermarkMessageInput.Enabled = !state;
            this.SetButtonState(!state);
        }

        public static byte[] ConvertToByteArray(string str, Encoding encoding) 
            => encoding.GetBytes(str);
        public static string ToBinary(byte[] data)
            => string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));

        private void SaveGeneratedWatermarkButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            if (string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                DialogResult dr = MessageBox.Show(@"No path was selected!", @"Oops...", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Hand);
                switch (dr)
                {
                    case DialogResult.Retry:
                        this.SaveGeneratedWatermarkButton_Click(sender, e);
                        break;
                }
            }

            string outPath = fbd.SelectedPath + "\\" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds() + ".png";

            ImagePreview.BackgroundImage.Save(outPath, ImageFormat.Png);
            this.Close();
        }
    }
}