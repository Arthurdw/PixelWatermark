
namespace PixelwiseWatermark
{
    partial class GenerateWatermark
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
            this.ImagePreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WatermarkMessageInput = new System.Windows.Forms.TextBox();
            this.GenerateWatermarkButton = new System.Windows.Forms.Button();
            this.SaveGeneratedWatermarkButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePreview
            // 
            this.ImagePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagePreview.Location = new System.Drawing.Point(12, 12);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(500, 500);
            this.ImagePreview.TabIndex = 0;
            this.ImagePreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Watermark message:";
            // 
            // WatermarkMessageInput
            // 
            this.WatermarkMessageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.WatermarkMessageInput.Location = new System.Drawing.Point(180, 518);
            this.WatermarkMessageInput.Name = "WatermarkMessageInput";
            this.WatermarkMessageInput.Size = new System.Drawing.Size(332, 26);
            this.WatermarkMessageInput.TabIndex = 2;
            this.WatermarkMessageInput.TextChanged += new System.EventHandler(this.WatermarkMessageInput_TextChanged);
            // 
            // GenerateWatermarkButton
            // 
            this.GenerateWatermarkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GenerateWatermarkButton.FlatAppearance.BorderSize = 0;
            this.GenerateWatermarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateWatermarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GenerateWatermarkButton.Location = new System.Drawing.Point(12, 558);
            this.GenerateWatermarkButton.Margin = new System.Windows.Forms.Padding(0);
            this.GenerateWatermarkButton.Name = "GenerateWatermarkButton";
            this.GenerateWatermarkButton.Size = new System.Drawing.Size(245, 33);
            this.GenerateWatermarkButton.TabIndex = 3;
            this.GenerateWatermarkButton.TabStop = false;
            this.GenerateWatermarkButton.Text = "GENERATE";
            this.GenerateWatermarkButton.UseVisualStyleBackColor = false;
            this.GenerateWatermarkButton.Click += new System.EventHandler(this.GenerateWatermarkButton_Click);
            // 
            // SaveGeneratedWatermarkButton
            // 
            this.SaveGeneratedWatermarkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveGeneratedWatermarkButton.FlatAppearance.BorderSize = 0;
            this.SaveGeneratedWatermarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveGeneratedWatermarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SaveGeneratedWatermarkButton.Location = new System.Drawing.Point(267, 558);
            this.SaveGeneratedWatermarkButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveGeneratedWatermarkButton.Name = "SaveGeneratedWatermarkButton";
            this.SaveGeneratedWatermarkButton.Size = new System.Drawing.Size(245, 33);
            this.SaveGeneratedWatermarkButton.TabIndex = 4;
            this.SaveGeneratedWatermarkButton.TabStop = false;
            this.SaveGeneratedWatermarkButton.Text = "SAVE";
            this.SaveGeneratedWatermarkButton.UseVisualStyleBackColor = false;
            this.SaveGeneratedWatermarkButton.Click += new System.EventHandler(this.SaveGeneratedWatermarkButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 246);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(500, 30);
            this.ProgressBar.TabIndex = 5;
            // 
            // GenerateWatermark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 605);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.SaveGeneratedWatermarkButton);
            this.Controls.Add(this.GenerateWatermarkButton);
            this.Controls.Add(this.WatermarkMessageInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImagePreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenerateWatermark";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixelwise Watermarking";
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WatermarkMessageInput;
        private System.Windows.Forms.Button GenerateWatermarkButton;
        private System.Windows.Forms.Button SaveGeneratedWatermarkButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}