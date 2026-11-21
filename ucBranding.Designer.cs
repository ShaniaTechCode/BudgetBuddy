namespace BudgetBuddy
{
    partial class ucBranding
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
            this.lblTagline = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sideDesignLeft = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sideDesignLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTagline
            // 
            this.lblTagline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTagline.BackColor = System.Drawing.Color.Transparent;
            this.lblTagline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(141)))), ((int)(((byte)(184)))));
            this.lblTagline.Location = new System.Drawing.Point(112, 428);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(367, 33);
            this.lblTagline.TabIndex = 12;
            this.lblTagline.Text = "Spend Smart, Budget Better";
            // 
            // sideDesignLeft
            // 
            this.sideDesignLeft.BackColor = System.Drawing.Color.Transparent;
            this.sideDesignLeft.Image = global::BudgetBuddy.Properties.Resources.LOGO;
            this.sideDesignLeft.Location = new System.Drawing.Point(79, 3);
            this.sideDesignLeft.Name = "sideDesignLeft";
            this.sideDesignLeft.ShadowDecoration.Parent = this.sideDesignLeft;
            this.sideDesignLeft.Size = new System.Drawing.Size(434, 419);
            this.sideDesignLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sideDesignLeft.TabIndex = 13;
            this.sideDesignLeft.TabStop = false;
            // 
            // ucBranding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.sideDesignLeft);
            this.Controls.Add(this.lblTagline);
            this.Name = "ucBranding";
            this.Size = new System.Drawing.Size(583, 489);
            ((System.ComponentModel.ISupportInitialize)(this.sideDesignLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTagline;
        private Guna.UI2.WinForms.Guna2PictureBox sideDesignLeft;
    }
}
