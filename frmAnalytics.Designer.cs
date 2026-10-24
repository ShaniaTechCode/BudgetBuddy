namespace BudgetBuddy
{
    partial class frmAnalytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalytics));
            this.pnlSidebarAnalytics = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnalytics = new Guna.UI2.WinForms.Guna2Button();
            this.btnExpenses = new Guna.UI2.WinForms.Guna2Button();
            this.btnIncome = new Guna.UI2.WinForms.Guna2Button();
            this.btnBudget = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlMainContentAnalytics = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSidebarAnalytics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidebarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebarAnalytics
            // 
            this.pnlSidebarAnalytics.AutoSize = true;
            this.pnlSidebarAnalytics.BackColor = System.Drawing.Color.Transparent;
            this.pnlSidebarAnalytics.Controls.Add(this.btnLogOut);
            this.pnlSidebarAnalytics.Controls.Add(this.btnSettings);
            this.pnlSidebarAnalytics.Controls.Add(this.btnAnalytics);
            this.pnlSidebarAnalytics.Controls.Add(this.btnExpenses);
            this.pnlSidebarAnalytics.Controls.Add(this.btnIncome);
            this.pnlSidebarAnalytics.Controls.Add(this.btnBudget);
            this.pnlSidebarAnalytics.Controls.Add(this.btnDashboard);
            this.pnlSidebarAnalytics.Controls.Add(this.sidebarLogo);
            this.pnlSidebarAnalytics.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebarAnalytics.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(105)))));
            this.pnlSidebarAnalytics.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarAnalytics.Name = "pnlSidebarAnalytics";
            this.pnlSidebarAnalytics.ShadowDecoration.Parent = this.pnlSidebarAnalytics;
            this.pnlSidebarAnalytics.Size = new System.Drawing.Size(252, 1041);
            this.pnlSidebarAnalytics.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 15;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = global::BudgetBuddy.Properties.Resources.logoutlogo1;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnLogOut.ImageSize = new System.Drawing.Size(27, 27);
            this.btnLogOut.Location = new System.Drawing.Point(12, 795);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(225, 50);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btnSettings
            // 
            this.btnSettings.BorderRadius = 15;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::BudgetBuddy.Properties.Resources.settingsLogo;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnSettings.ImageSize = new System.Drawing.Size(27, 27);
            this.btnSettings.Location = new System.Drawing.Point(13, 677);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(225, 50);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BorderRadius = 15;
            this.btnAnalytics.CheckedState.Parent = this.btnAnalytics;
            this.btnAnalytics.CustomImages.Parent = this.btnAnalytics;
            this.btnAnalytics.FillColor = System.Drawing.Color.Transparent;
            this.btnAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnAnalytics.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnAnalytics.HoverState.Parent = this.btnAnalytics;
            this.btnAnalytics.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalytics.Image")));
            this.btnAnalytics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAnalytics.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnAnalytics.ImageSize = new System.Drawing.Size(27, 27);
            this.btnAnalytics.Location = new System.Drawing.Point(14, 599);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnAnalytics.ShadowDecoration.Parent = this.btnAnalytics;
            this.btnAnalytics.Size = new System.Drawing.Size(225, 50);
            this.btnAnalytics.TabIndex = 6;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BorderRadius = 15;
            this.btnExpenses.CheckedState.Parent = this.btnExpenses;
            this.btnExpenses.CustomImages.Parent = this.btnExpenses;
            this.btnExpenses.FillColor = System.Drawing.Color.Transparent;
            this.btnExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnExpenses.HoverState.Parent = this.btnExpenses;
            this.btnExpenses.Image = global::BudgetBuddy.Properties.Resources.expensesLogo;
            this.btnExpenses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExpenses.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnExpenses.ImageSize = new System.Drawing.Size(27, 27);
            this.btnExpenses.Location = new System.Drawing.Point(14, 526);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnExpenses.ShadowDecoration.Parent = this.btnExpenses;
            this.btnExpenses.Size = new System.Drawing.Size(225, 50);
            this.btnExpenses.TabIndex = 5;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btnIncome
            // 
            this.btnIncome.BorderRadius = 15;
            this.btnIncome.CheckedState.Parent = this.btnIncome;
            this.btnIncome.CustomImages.Parent = this.btnIncome;
            this.btnIncome.FillColor = System.Drawing.Color.Transparent;
            this.btnIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnIncome.HoverState.Parent = this.btnIncome;
            this.btnIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnIncome.Image")));
            this.btnIncome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIncome.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnIncome.ImageSize = new System.Drawing.Size(27, 27);
            this.btnIncome.Location = new System.Drawing.Point(14, 459);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnIncome.ShadowDecoration.Parent = this.btnIncome;
            this.btnIncome.Size = new System.Drawing.Size(225, 50);
            this.btnIncome.TabIndex = 4;
            this.btnIncome.Text = "Income";
            this.btnIncome.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btnBudget
            // 
            this.btnBudget.BorderRadius = 15;
            this.btnBudget.CheckedState.Parent = this.btnBudget;
            this.btnBudget.CustomImages.Parent = this.btnBudget;
            this.btnBudget.FillColor = System.Drawing.Color.Transparent;
            this.btnBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudget.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBudget.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnBudget.HoverState.Parent = this.btnBudget;
            this.btnBudget.Image = global::BudgetBuddy.Properties.Resources.budgetLogo;
            this.btnBudget.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBudget.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnBudget.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBudget.Location = new System.Drawing.Point(12, 387);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnBudget.ShadowDecoration.Parent = this.btnBudget;
            this.btnBudget.Size = new System.Drawing.Size(225, 50);
            this.btnBudget.TabIndex = 3;
            this.btnBudget.Text = "Budget";
            this.btnBudget.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 15;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(80)))));
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::BudgetBuddy.Properties.Resources.dashboardLogo;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(40, 0);
            this.btnDashboard.ImageSize = new System.Drawing.Size(27, 27);
            this.btnDashboard.Location = new System.Drawing.Point(12, 317);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(225, 50);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffset = new System.Drawing.Point(15, 0);
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
            // pnlMainContentAnalytics
            // 
            this.pnlMainContentAnalytics.AutoScroll = true;
            this.pnlMainContentAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.pnlMainContentAnalytics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContentAnalytics.Location = new System.Drawing.Point(252, 0);
            this.pnlMainContentAnalytics.Name = "pnlMainContentAnalytics";
            this.pnlMainContentAnalytics.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainContentAnalytics.ShadowDecoration.Parent = this.pnlMainContentAnalytics;
            this.pnlMainContentAnalytics.Size = new System.Drawing.Size(1652, 1041);
            this.pnlMainContentAnalytics.TabIndex = 23;
            // 
            // frmAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlMainContentAnalytics);
            this.Controls.Add(this.pnlSidebarAnalytics);
            this.Name = "frmAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebarAnalytics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidebarLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSidebarAnalytics;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnAnalytics;
        private Guna.UI2.WinForms.Guna2Button btnExpenses;
        private Guna.UI2.WinForms.Guna2Button btnIncome;
        private Guna.UI2.WinForms.Guna2Button btnBudget;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2PictureBox sidebarLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlMainContentAnalytics;
    }
}