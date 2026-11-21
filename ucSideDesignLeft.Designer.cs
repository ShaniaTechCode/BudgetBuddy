namespace BudgetBuddy
{
    partial class ucSideDesignLeft
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
            this.sideDesignLeft = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sideDesignLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // sideDesignLeft
            // 
            this.sideDesignLeft.BackColor = System.Drawing.Color.Transparent;
            this.sideDesignLeft.Image = global::BudgetBuddy.Properties.Resources.sideDesign;
            this.sideDesignLeft.Location = new System.Drawing.Point(-77, -109);
            this.sideDesignLeft.Name = "sideDesignLeft";
            this.sideDesignLeft.ShadowDecoration.Parent = this.sideDesignLeft;
            this.sideDesignLeft.Size = new System.Drawing.Size(251, 229);
            this.sideDesignLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sideDesignLeft.TabIndex = 2;
            this.sideDesignLeft.TabStop = false;
            // 
            // ucSideDesignLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.sideDesignLeft);
            this.Name = "ucSideDesignLeft";
            this.Size = new System.Drawing.Size(484, 472);
            ((System.ComponentModel.ISupportInitialize)(this.sideDesignLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox sideDesignLeft;
    }
}
