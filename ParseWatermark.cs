using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PixelwiseWatermark
{
    public partial class ParseWatermark : Form
    {
        private Image img;

        public ParseWatermark(string source)
        {
            InitializeComponent();
            InitializeParse(source);
        }

        private void InitializeParse(string source)
        {
            this.img = Image.FromFile(source);
        }

        private string ParseMessage(Image img)
        {
            ImagePreview.BackgroundImage = this.img;
            Bitmap bm = new Bitmap(img);
            Rectangle rect = new Rectangle(0, 0, bm.Width, bm.Height);
            BitmapData bmd = bm.LockBits(rect, ImageLockMode.ReadOnly, bm.PixelFormat);
            IntPtr pointer = bmd.Scan0;

            int byteCount = Math.Abs(bmd.Stride) * bm.Height;
            byte[] data = new byte[byteCount];
            ProgressBar.Maximum = data.Length + 1;
            ProgressBar.Step = 1;
            ProgressBar.Value = 0;
            ProgressBar.Minimum = 0;

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
                    return "ERROR";

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

            string message = "";

            for (int i = 0; i < data.Length; i += skipSize)
            {
                for (int j = 0; j < skipSize; j++)
                {
                    string bin = Convert.ToString(data[i + j], 2);
                    message += bin.Substring(bin.Length - 1);
                    ProgressBar.PerformStep();
                }
            }
            return message;
        }

        private void StartParse(object sender, EventArgs e)
        {
            ResultBox.Text = @"Parsing...";
            string message = this.ParseMessage(this.img);
            ResultBox.Text = @"Encoding...";
            ResultBox.Text = Encoding.UTF8.GetString(GetBytesFromBinaryString(message));
        }

        public byte[] GetBytesFromBinaryString(string binary)
        {
            var list = new List<byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                string t = binary.Substring(i, 8);
                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }
    }
}