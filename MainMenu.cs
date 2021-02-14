using System;
using System.Windows.Forms;

namespace PixelwiseWatermark
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            InitializeProgram();
        }

        /// <summary>
        /// Initializes all default parameters for the program.
        /// </summary>
        private void InitializeProgram()
        {
            FileDialogHandler.Filter = "Image Formats (*.PNG;*.JPEG;*.JPG;*.BMP;*.WEBP)|*.PNG;*.JPEG;*.JPG;*.BMP;*.WEBP";
        }

        private void NewWatermark_Click(object sender, EventArgs e)
        {
            // The file path of the selected file.
            string fp = FileDialogHandler.OpenFileSelector();

            // If a file has been selected:
            if (fp != null) new GenerateWatermark(fp).Show();
            else
            {
                DialogResult dr = MessageBox.Show("Oops...", "No file has been selected!", MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Asterisk);

                if (dr == DialogResult.Retry) this.NewWatermark_Click(sender, e);
            }
        }

        private void ParseWatermark_Click(object sender, EventArgs e)
            => MessageBox.Show(@"This has not yet been implemented!", @"Oops...", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
    }
}