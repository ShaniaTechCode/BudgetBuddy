namespace BudgetBuddy
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlSidebarDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnalytics = new Guna.UI2.WinForms.Guna2Button();
            this.btnExpenses = new Guna.UI2.WinForms.Guna2Button();
            this.btnIncome = new Guna.UI2.WinForms.Guna2Button();
            this.btnBudget = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlSidebarDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebarDashboard
            // 
            this.pnlSidebarDashboard.AutoSize = true;
            this.pnlSidebarDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pnlSidebarDashboard.Controls.Add(this.btnLogOut);
            this.pnlSidebarDashboard.Controls.Add(this.btnSettings);
            this.pnlSidebarDashboard.Controls.Add(this.btnAnalytics);
            this.pnlSidebarDashboard.Controls.Add(this.btnExpenses);
            this.pnlSidebarDashboard.Controls.Add(this.btnIncome);
            this.pnlSidebarDashboard.Controls.Add(this.btnBudget);
            this.pnlSidebarDashboard.Controls.Add(this.btnDashboard);
            this.pnlSidebarDashboard.Controls.Add(this.sidebarLogo);
            this.pnlSidebarDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebarDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.pnlSidebarDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarDashboard.Name = "pnlSidebarDashboard";
            this.pnlSidebarDashboard.ShadowDecoration.Parent = this.pnlSidebarDashboard;
            this.pnlSidebarDashboard.Size = new System.Drawing.Size(252, 1041);
            this.pnlSidebarDashboard.TabIndex = 5;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(252, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.ShadowDecoration.Parent = this.pnlMainContent;
            this.pnlMainContent.Size = new System.Drawing.Size(1652, 1041);
            this.pnlMainContent.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 15;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = global::BudgetBuddy.Properties.Resources.logoutLogo;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageOffset = new System.Drawing.Point(30, -5);
            this.btnLogOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogOut.Location = new System.Drawing.Point(12, 795);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(225, 50);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextOffset = new System.Drawing.Point(25, 2);
            // 
            // btnSettings
            // 
            this.btnSettings.BorderRadius = 15;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(30, -5);
            this.btnSettings.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSettings.Location = new System.Drawing.Point(13, 668);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(225, 50);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextOffset = new System.Drawing.Point(25, 2);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BorderRadius = 15;
            this.btnAnalytics.CheckedState.Parent = this.btnAnalytics;
            this.btnAnalytics.CustomImages.Parent = this.btnAnalytics;
            this.btnAnalytics.FillColor = System.Drawing.Color.Transparent;
            this.btnAnalytics.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnAnalytics.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnAnalytics.HoverState.Parent = this.btnAnalytics;
            this.btnAnalytics.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalytics.Image")));
            this.btnAnalytics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAnalytics.ImageOffset = new System.Drawing.Point(30, -5);
            this.btnAnalytics.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAnalytics.Location = new System.Drawing.Point(14, 599);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnAnalytics.ShadowDecoration.Parent = this.btnAnalytics;
            this.btnAnalytics.Size = new System.Drawing.Size(225, 50);
            this.btnAnalytics.TabIndex = 6;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.TextOffset = new System.Drawing.Point(25, 2);
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BorderRadius = 15;
            this.btnExpenses.CheckedState.Parent = this.btnExpenses;
            this.btnExpenses.CustomImages.Parent = this.btnExpenses;
            this.btnExpenses.FillColor = System.Drawing.Color.Transparent;
            this.btnExpenses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnExpenses.HoverState.Parent = this.btnExpenses;
            this.btnExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btnExpenses.Image")));
            this.btnExpenses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExpenses.ImageOffset = new System.Drawing.Point(30, -5);
            this.btnExpenses.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExpenses.Location = new System.Drawing.Point(14, 526);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnExpenses.ShadowDecoration.Parent = this.btnExpenses;
            this.btnExpenses.Size = new System.Drawing.Size(225, 50);
            this.btnExpenses.TabIndex = 5;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.TextOffset = new System.Drawing.Point(25, 2);
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BorderRadius = 15;
            this.btnIncome.CheckedState.Parent = this.btnIncome;
            this.btnIncome.CustomImages.Parent = this.btnIncome;
            this.btnIncome.FillColor = System.Drawing.Color.Transparent;
            this.btnIncome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnIncome.HoverState.Parent = this.btnIncome;
            this.btnIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnIncome.Image")));
            this.btnIncome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIncome.ImageOffset = new System.Drawing.Point(30, -5);
            this.btnIncome.ImageSize = new System.Drawing.Size(40, 40);
            this.btnIncome.Location = new System.Drawing.Point(14, 459);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnIncome.ShadowDecoration.Parent = this.btnIncome;
            this.btnIncome.Size = new System.Drawing.Size(225, 50);
            this.btnIncome.TabIndex = 4;
            this.btnIncome.Text = "Income";
            this.btnIncome.TextOffset = new System.Drawing.Point(25, 2);
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnBudget
            // 
            this.btnBudget.BorderRadius = 15;
            this.btnBudget.CheckedState.Parent = this.btnBudget;
            this.btnBudget.CustomImages.Parent = this.btnBudget;
            this.btnBudget.FillColor = System.Drawing.Color.Transparent;
            this.btnBudget.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudget.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBudget.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnBudget.HoverState.Parent = this.btnBudget;
            this.btnBudget.Image = ((System.Drawing.Image)(resources.GetObject("btnBudget.Image")));
            this.btnBudget.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBudget.ImageOffset = new System.Drawing.Point(30, -3);
            this.btnBudget.ImageSize = new System.Drawing.Size(45, 45);
            this.btnBudget.Location = new System.Drawing.Point(12, 387);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnBudget.ShadowDecoration.Parent = this.btnBudget;
            this.btnBudget.Size = new System.Drawing.Size(225, 50);
            this.btnBudget.TabIndex = 3;
            this.btnBudget.Text = "Budget";
            this.btnBudget.TextOffset = new System.Drawing.Point(25, 2);
            this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 15;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(35, -3);
            this.btnDashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDashboard.Location = new System.Drawing.Point(12, 317);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(225, 50);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffset = new System.Drawing.Point(25, 2);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // sidebarLogo
            // 
            this.sidebarLogo.BackColor = System.Drawing.Color.Transparent;
            this.sidebarLogo.Image = global::BudgetBuddy.Properties.Resources.sidebarLogo;
            this.sidebarLogo.Location = new System.Drawing.Point(7, 33);
            this.sidebarLogo.Name = "sidebarLogo";
            this.sidebarLogo.ShadowDecoration.Parent = this.sidebarLogo;
            this.sidebarLogo.Size = new System.Drawing.Size(242, 221);
            this.sidebarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sidebarLogo.TabIndex = 1;
            this.sidebarLogo.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebarDashboard);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebarDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidebarLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Panel pnlSidebarDashboard;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnAnalytics;
        private Guna.UI2.WinForms.Guna2Button btnExpenses;
        private Guna.UI2.WinForms.Guna2Button btnIncome;
        private Guna.UI2.WinForms.Guna2Button btnBudget;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Panel pnlMainContent;
        private Guna.UI2.WinForms.Guna2PictureBox sidebarLogo;
    }
}