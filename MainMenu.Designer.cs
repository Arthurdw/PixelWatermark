
using System.Windows.Forms;

namespace PixelwiseWatermark
{
    partial class MainMenu
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
            this.NewWatermark = new System.Windows.Forms.Button();
            this.ParseWatermark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewWatermark
            // 
            this.NewWatermark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NewWatermark.FlatAppearance.BorderSize = 0;
            this.NewWatermark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.NewWatermark.Location = new System.Drawing.Point(12, 12);
            this.NewWatermark.Margin = new System.Windows.Forms.Padding(0);
            this.NewWatermark.Name = "NewWatermark";
            this.NewWatermark.Size = new System.Drawing.Size(290, 57);
            this.NewWatermark.TabIndex = 0;
            this.NewWatermark.TabStop = false;
            this.NewWatermark.Text = "GENERATE NEW";
            this.NewWatermark.UseVisualStyleBackColor = false;
            this.NewWatermark.Click += new System.EventHandler(this.NewWatermark_Click);
            // 
            // ParseWatermark
            // 
            this.ParseWatermark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ParseWatermark.FlatAppearance.BorderSize = 0;
            this.ParseWatermark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParseWatermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.ParseWatermark.Location = new System.Drawing.Point(12, 77);
            this.ParseWatermark.Margin = new System.Windows.Forms.Padding(0);
            this.ParseWatermark.Name = "ParseWatermark";
            this.ParseWatermark.Size = new System.Drawing.Size(290, 57);
            this.ParseWatermark.TabIndex = 1;
            this.ParseWatermark.TabStop = false;
            this.ParseWatermark.Text = "GET WATERMARK";
            this.ParseWatermark.UseVisualStyleBackColor = false;
            this.ParseWatermark.Click += new System.EventHandler(this.ParseWatermark_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 147);
            this.Controls.Add(this.ParseWatermark);
            this.Controls.Add(this.NewWatermark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixelwise Watermarking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewWatermark;
        private Button ParseWatermark;
    }
}

