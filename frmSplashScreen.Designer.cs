namespace BudgetBuddy
{
    partial class frmSplashScreen
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
            this.btnGetStarted = new Guna.UI2.WinForms.Guna2Button();
            this.ucSideDesignRight2 = new BudgetBuddy.ucSideDesignRight();
            this.ucBranding1 = new BudgetBuddy.ucBranding();
            this.ucSideDesignLeft1 = new BudgetBuddy.ucSideDesignLeft();
            this.ucSideDesignRight1 = new BudgetBuddy.ucSideDesignRight();
            this.SuspendLayout();
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetStarted.BorderRadius = 15;
            this.btnGetStarted.CheckedState.Parent = this.btnGetStarted;
            this.btnGetStarted.CustomImages.Parent = this.btnGetStarted;
            this.btnGetStarted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
            this.btnGetStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStarted.ForeColor = System.Drawing.Color.White;
            this.btnGetStarted.HoverState.Parent = this.btnGetStarted;
            this.btnGetStarted.Location = new System.Drawing.Point(779, 777);
            this.btnGetStarted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.ShadowDecoration.Parent = this.btnGetStarted;
            this.btnGetStarted.Size = new System.Drawing.Size(269, 66);
            this.btnGetStarted.TabIndex = 4;
            this.btnGetStarted.Text = "GET STARTED";
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // ucSideDesignRight2
            // 
            this.ucSideDesignRight2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ucSideDesignRight2.Location = new System.Drawing.Point(1583, 791);
            this.ucSideDesignRight2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSideDesignRight2.Name = "ucSideDesignRight2";
            this.ucSideDesignRight2.Size = new System.Drawing.Size(343, 384);
            this.ucSideDesignRight2.TabIndex = 11;
            // 
            // ucBranding1
            // 
            this.ucBranding1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucBranding1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ucBranding1.Location = new System.Drawing.Point(583, 225);
            this.ucBranding1.Margin = new System.Windows.Forms.Padding(5);
            this.ucBranding1.Name = "ucBranding1";
            this.ucBranding1.Size = new System.Drawing.Size(729, 552);
            this.ucBranding1.TabIndex = 10;
            // 
            // ucSideDesignLeft1
            // 
            this.ucSideDesignLeft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ucSideDesignLeft1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucSideDesignLeft1.Location = new System.Drawing.Point(0, 0);
            this.ucSideDesignLeft1.Margin = new System.Windows.Forms.Padding(5);
            this.ucSideDesignLeft1.Name = "ucSideDesignLeft1";
            this.ucSideDesignLeft1.Size = new System.Drawing.Size(282, 1175);
            this.ucSideDesignLeft1.TabIndex = 7;
            this.ucSideDesignLeft1.Load += new System.EventHandler(this.ucSideDesignLeft1_Load);
            // 
            // ucSideDesignRight1
            // 
            this.ucSideDesignRight1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSideDesignRight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ucSideDesignRight1.Location = new System.Drawing.Point(2060, 901);
            this.ucSideDesignRight1.Margin = new System.Windows.Forms.Padding(5);
            this.ucSideDesignRight1.Name = "ucSideDesignRight1";
            this.ucSideDesignRight1.Size = new System.Drawing.Size(326, 400);
            this.ucSideDesignRight1.TabIndex = 9;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1924, 1175);
            this.Controls.Add(this.ucSideDesignRight2);
            this.Controls.Add(this.ucBranding1);
            this.Controls.Add(this.btnGetStarted);
            this.Controls.Add(this.ucSideDesignLeft1);
            this.Controls.Add(this.ucSideDesignRight1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnGetStarted;
        private ucSideDesignRight ucSideDesignRight1;
        private ucSideDesignLeft ucSideDesignLeft1;
        private ucBranding ucBranding1;
        private ucSideDesignRight ucSideDesignRight2;
    }
}

