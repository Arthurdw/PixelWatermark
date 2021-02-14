using System.Windows.Forms;

namespace PixelwiseWatermark
{
    /// <summary>
    /// A way to easily reuse a <c>OpenFileDialog</c>.
    /// </summary>
    internal static class FileDialogHandler
    {
        public static string InitialDirectory = "C:\\";
        public static string Filter = "All files (*.*)|*.*";
        public static int FilterIndex = 1;
        public static bool RestoreDirectory = true;

        /// <summary>
        /// Open a <c>OpenFileDialog</c>.
        /// </summary>
        /// <returns>The filepath that was selected or null if none was selected.</returns>
        public static string OpenFileSelector()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Initialize our values:
                ofd.InitialDirectory = FileDialogHandler.InitialDirectory;
                ofd.Filter = FileDialogHandler.Filter;
                ofd.FilterIndex = FileDialogHandler.FilterIndex;
                ofd.RestoreDirectory = FileDialogHandler.RestoreDirectory;

                DialogResult dialog = ofd.ShowDialog();

                // Check if our dialog went successful.
                switch (dialog)
                {
                    case DialogResult.OK:
                        return ofd.FileName;

                    case DialogResult.Retry:
                        return FileDialogHandler.OpenFileSelector();

                    default:
                        return null;
                }
            }
        }
    }
}