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
            this.gunaShape2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaShape2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShape2
            // 
            this.gunaShape2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShape2.Image = global::BudgetBuddy.Properties.Resources.SHAPE;
            this.gunaShape2.Location = new System.Drawing.Point(-115, -198);
            this.gunaShape2.Name = "gunaShape2";
            this.gunaShape2.ShadowDecoration.Parent = this.gunaShape2;
            this.gunaShape2.Size = new System.Drawing.Size(377, 375);
            this.gunaShape2.TabIndex = 7;
            this.gunaShape2.TabStop = false;
            // 
            // ucSideDesignLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.gunaShape2);
            this.Name = "ucSideDesignLeft";
            this.Size = new System.Drawing.Size(484, 472);
            ((System.ComponentModel.ISupportInitialize)(this.gunaShape2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox gunaShape2;
    }
}
