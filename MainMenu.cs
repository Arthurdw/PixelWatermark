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
            string fp = FileDialogHandler.OpenFileSelector();

            // If a file has been selected:
            if (fp != null) new GenerateWatermark(fp).Show();
            else this.HandleError(this.NewWatermark_Click, sender, e);
        }

        private void ParseWatermark_Click(object sender, EventArgs e)
        {
            string fp = FileDialogHandler.OpenFileSelector();

            // If a file has been selected:
            if (fp != null) new ParseWatermark(fp).Show();
            else this.HandleError(this.ParseWatermark_Click, sender, e);
        }

        private void HandleError(Action<object, EventArgs> retryCallback, object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"No file has been selected!", @"Oops...", MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Asterisk);

            if (dr == DialogResult.Retry) retryCallback(sender, e);
        }
    }
}