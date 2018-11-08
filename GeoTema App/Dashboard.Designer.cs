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
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.KodeordLabel = new System.Windows.Forms.Label();
            this.BrugernavnLabel = new System.Windows.Forms.Label();
            this.GeoTemaPic = new System.Windows.Forms.PictureBox();
            this.BrugernavnBox = new System.Windows.Forms.TextBox();
            this.KodeordBox = new System.Windows.Forms.TextBox();
            this.LogIndKnap = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeoTemaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDashboard.BackgroundImage")));
            this.panelDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDashboard.Controls.Add(this.panelAdmin);
            this.panelDashboard.Controls.Add(this.LogIndKnap);
            this.panelDashboard.Controls.Add(this.KodeordBox);
            this.panelDashboard.Controls.Add(this.BrugernavnBox);
            this.panelDashboard.Controls.Add(this.KodeordLabel);
            this.panelDashboard.Controls.Add(this.BrugernavnLabel);
            this.panelDashboard.Controls.Add(this.GeoTemaPic);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(609, 336);
            this.panelDashboard.TabIndex = 0;
            // 
            // KodeordLabel
            // 
            this.KodeordLabel.AutoSize = true;
            this.KodeordLabel.BackColor = System.Drawing.Color.Transparent;
            this.KodeordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeordLabel.Location = new System.Drawing.Point(159, 170);
            this.KodeordLabel.Name = "KodeordLabel";
            this.KodeordLabel.Size = new System.Drawing.Size(90, 26);
            this.KodeordLabel.TabIndex = 9;
            this.KodeordLabel.Text = "Kodeord:";
            // 
            // BrugernavnLabel
            // 
            this.BrugernavnLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrugernavnLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrugernavnLabel.Location = new System.Drawing.Point(159, 126);
            this.BrugernavnLabel.Name = "BrugernavnLabel";
            this.BrugernavnLabel.Size = new System.Drawing.Size(115, 26);
            this.BrugernavnLabel.TabIndex = 8;
            this.BrugernavnLabel.Text = "Brugernavn:";
            this.BrugernavnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeoTemaPic
            // 
            this.GeoTemaPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeoTemaPic.BackColor = System.Drawing.Color.Transparent;
            this.GeoTemaPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GeoTemaPic.BackgroundImage")));
            this.GeoTemaPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GeoTemaPic.Location = new System.Drawing.Point(34, 12);
            this.GeoTemaPic.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.GeoTemaPic.Name = "GeoTemaPic";
            this.GeoTemaPic.Size = new System.Drawing.Size(541, 70);
            this.GeoTemaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeoTemaPic.TabIndex = 6;
            this.GeoTemaPic.TabStop = false;
            // 
            // BrugernavnBox
            // 
            this.BrugernavnBox.Location = new System.Drawing.Point(280, 132);
            this.BrugernavnBox.Name = "BrugernavnBox";
            this.BrugernavnBox.Size = new System.Drawing.Size(156, 20);
            this.BrugernavnBox.TabIndex = 12;
            // 
            // KodeordBox
            // 
            this.KodeordBox.Location = new System.Drawing.Point(280, 175);
            this.KodeordBox.Name = "KodeordBox";
            this.KodeordBox.PasswordChar = '*';
            this.KodeordBox.Size = new System.Drawing.Size(156, 20);
            this.KodeordBox.TabIndex = 13;
            // 
            // LogIndKnap
            // 
            this.LogIndKnap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LogIndKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIndKnap.Location = new System.Drawing.Point(232, 223);
            this.LogIndKnap.Name = "LogIndKnap";
            this.LogIndKnap.Size = new System.Drawing.Size(75, 23);
            this.LogIndKnap.TabIndex = 14;
            this.LogIndKnap.Text = "LOG IND";
            this.LogIndKnap.UseVisualStyleBackColor = false;
            this.LogIndKnap.Click += new System.EventHandler(this.LogIndKnap_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(609, 336);
            this.panelAdmin.TabIndex = 15;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 336);
            this.Controls.Add(this.panelDashboard);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "GeoTema";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeoTemaPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label KodeordLabel;
        private System.Windows.Forms.Label BrugernavnLabel;
        private System.Windows.Forms.PictureBox GeoTemaPic;
        private System.Windows.Forms.TextBox KodeordBox;
        private System.Windows.Forms.TextBox BrugernavnBox;
        private System.Windows.Forms.Button LogIndKnap;
        private System.Windows.Forms.Panel panelAdmin;
    }
}

