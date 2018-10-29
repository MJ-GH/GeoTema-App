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
            this.BrugernavnBox = new System.Windows.Forms.TextBox();
            this.BrugernavnLabel = new System.Windows.Forms.Label();
            this.KodeordLabel = new System.Windows.Forms.Label();
            this.KodeordBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
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
            // BrugernavnBox
            // 
            this.BrugernavnBox.Location = new System.Drawing.Point(50, 149);
            this.BrugernavnBox.Name = "BrugernavnBox";
            this.BrugernavnBox.Size = new System.Drawing.Size(174, 20);
            this.BrugernavnBox.TabIndex = 1;
            // 
            // BrugernavnLabel
            // 
            this.BrugernavnLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrugernavnLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrugernavnLabel.Location = new System.Drawing.Point(45, 120);
            this.BrugernavnLabel.Name = "BrugernavnLabel";
            this.BrugernavnLabel.Size = new System.Drawing.Size(115, 26);
            this.BrugernavnLabel.TabIndex = 2;
            this.BrugernavnLabel.Text = "Brugernavn:";
            this.BrugernavnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KodeordLabel
            // 
            this.KodeordLabel.AutoSize = true;
            this.KodeordLabel.BackColor = System.Drawing.Color.Transparent;
            this.KodeordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeordLabel.Location = new System.Drawing.Point(45, 185);
            this.KodeordLabel.Name = "KodeordLabel";
            this.KodeordLabel.Size = new System.Drawing.Size(90, 26);
            this.KodeordLabel.TabIndex = 3;
            this.KodeordLabel.Text = "Kodeord:";
            // 
            // KodeordBox
            // 
            this.KodeordBox.Location = new System.Drawing.Point(50, 214);
            this.KodeordBox.Name = "KodeordBox";
            this.KodeordBox.PasswordChar = '*';
            this.KodeordBox.Size = new System.Drawing.Size(174, 20);
            this.KodeordBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(50, 260);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LOG IND";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 336);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.KodeordBox);
            this.Controls.Add(this.KodeordLabel);
            this.Controls.Add(this.BrugernavnLabel);
            this.Controls.Add(this.BrugernavnBox);
            this.Controls.Add(this.GeoTemaPic);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "GeoTema - Login";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GeoTemaPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GeoTemaPic;
        private System.Windows.Forms.Label BrugernavnLabel;
        private System.Windows.Forms.Label KodeordLabel;
        private System.Windows.Forms.TextBox KodeordBox;
        private System.Windows.Forms.TextBox BrugernavnBox;
        private System.Windows.Forms.Button LoginButton;
    }
}

