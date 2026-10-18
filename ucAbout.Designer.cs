namespace BudgetBuddy
{
    partial class ucAbout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAbout = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTagline = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sidebarLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblAboutUs = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNotificationsDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNotificationstitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAbout
            // 
            this.pnlAbout.BorderColor = System.Drawing.Color.SeaGreen;
            this.pnlAbout.BorderRadius = 20;
            this.pnlAbout.BorderThickness = 2;
            this.pnlAbout.Controls.Add(this.lblTagline);
            this.pnlAbout.Controls.Add(this.sidebarLogo);
            this.pnlAbout.Controls.Add(this.lblAboutUs);
            this.pnlAbout.Controls.Add(this.lblNotificationsDescription);
            this.pnlAbout.Controls.Add(this.lblNotificationstitle);
            this.pnlAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAbout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pnlAbout.Location = new System.Drawing.Point(0, 0);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.ShadowDecoration.Parent = this.pnlAbout;
            this.pnlAbout.Size = new System.Drawing.Size(721, 535);
            this.pnlAbout.TabIndex = 22;
            // 
            // lblTagline
            // 
            this.lblTagline.BackColor = System.Drawing.Color.Transparent;
            this.lblTagline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.lblTagline.Location = new System.Drawing.Point(192, 332);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(367, 33);
            this.lblTagline.TabIndex = 22;
            this.lblTagline.Text = "Spend Smart, Budget Better";
            // 
            // sidebarLogo
            // 
            this.sidebarLogo.BackColor = System.Drawing.Color.Transparent;
            this.sidebarLogo.Image = global::BudgetBuddy.Properties.Resources.brandingLogo;
            this.sidebarLogo.Location = new System.Drawing.Point(244, 104);
            this.sidebarLogo.Name = "sidebarLogo";
            this.sidebarLogo.ShadowDecoration.Parent = this.sidebarLogo;
            this.sidebarLogo.Size = new System.Drawing.Size(242, 221);
            this.sidebarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sidebarLogo.TabIndex = 21;
            this.sidebarLogo.TabStop = false;
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = false;
            this.lblAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAboutUs.Location = new System.Drawing.Point(147, 389);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(478, 109);
            this.lblAboutUs.TabIndex = 2;
            this.lblAboutUs.Text = "Budget Buddy is your financial buddy, helping you manage your budget and expenses" +
    ", track your income, and achieve your financial goals.\r\n";
            // 
            // lblNotificationsDescription
            // 
            this.lblNotificationsDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblNotificationsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationsDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblNotificationsDescription.Location = new System.Drawing.Point(25, 62);
            this.lblNotificationsDescription.Name = "lblNotificationsDescription";
            this.lblNotificationsDescription.Size = new System.Drawing.Size(215, 20);
            this.lblNotificationsDescription.TabIndex = 20;
            this.lblNotificationsDescription.Text = "Learn more about Budget Buddy";
            // 
            // lblNotificationstitle
            // 
            this.lblNotificationstitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNotificationstitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationstitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.lblNotificationstitle.Location = new System.Drawing.Point(25, 21);
            this.lblNotificationstitle.Name = "lblNotificationstitle";
            this.lblNotificationstitle.Size = new System.Drawing.Size(83, 35);
            this.lblNotificationstitle.TabIndex = 19;
            this.lblNotificationstitle.Text = "About";
            // 
            // ucAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.pnlAbout);
            this.Name = "ucAbout";
            this.Size = new System.Drawing.Size(721, 535);
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlAbout;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAboutUs;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNotificationsDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNotificationstitle;
        private Guna.UI2.WinForms.Guna2PictureBox sidebarLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTagline;
    }
}
