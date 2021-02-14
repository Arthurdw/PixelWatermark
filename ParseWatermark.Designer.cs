
namespace PixelwiseWatermark
{
    partial class ParseWatermark
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ImagePreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(12, 53);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(605, 457);
            this.ResultBox.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(13, 13);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(604, 34);
            this.ProgressBar.TabIndex = 1;
            // 
            // ImagePreview
            // 
            this.ImagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagePreview.Location = new System.Drawing.Point(623, 13);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(500, 500);
            this.ImagePreview.TabIndex = 2;
            this.ImagePreview.TabStop = false;
            // 
            // ParseWatermark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 522);
            this.Controls.Add(this.ImagePreview);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ResultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ParseWatermark";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parse Watermark";
            this.Shown += new System.EventHandler(this.StartParse);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.PictureBox ImagePreview;
    }
}