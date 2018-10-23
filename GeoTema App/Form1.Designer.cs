namespace GeoTema_App
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.GeoTemaPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GeoTemaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // GeoTemaPic
            // 
            this.GeoTemaPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeoTemaPic.BackColor = System.Drawing.Color.Transparent;
            this.GeoTemaPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeoTemaPic.BackgroundImage")));
            this.GeoTemaPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GeoTemaPic.Location = new System.Drawing.Point(25, 12);
            this.GeoTemaPic.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.GeoTemaPic.Name = "GeoTemaPic";
            this.GeoTemaPic.Size = new System.Drawing.Size(541, 70);
            this.GeoTemaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeoTemaPic.TabIndex = 0;
            this.GeoTemaPic.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 336);
            this.Controls.Add(this.GeoTemaPic);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeoTemaPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GeoTemaPic;
    }
}

