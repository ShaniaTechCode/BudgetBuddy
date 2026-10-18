namespace BudgetBuddy
{
    partial class ucSideDesignRight
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
            this.gunaShape3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaShape3)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShape3
            // 
            this.gunaShape3.BackColor = System.Drawing.Color.Transparent;
            this.gunaShape3.Image = global::BudgetBuddy.Properties.Resources.SHAPE;
            this.gunaShape3.Location = new System.Drawing.Point(159, 84);
            this.gunaShape3.Name = "gunaShape3";
            this.gunaShape3.ShadowDecoration.Parent = this.gunaShape3;
            this.gunaShape3.Size = new System.Drawing.Size(98, 238);
            this.gunaShape3.TabIndex = 8;
            this.gunaShape3.TabStop = false;
            // 
            // ucSideDesignRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.gunaShape3);
            this.Name = "ucSideDesignRight";
            this.Size = new System.Drawing.Size(257, 312);
            ((System.ComponentModel.ISupportInitialize)(this.gunaShape3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox gunaShape3;
    }
}
