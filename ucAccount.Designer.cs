namespace BudgetBuddy
{
    partial class ucAccount
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
            this.pnlAccountInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAccountDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAccounttitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmail_PhoneNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangePhoto = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBoxEmail_PhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSaveChanges = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlAccountInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAccountInformation
            // 
            this.pnlAccountInformation.BorderColor = System.Drawing.Color.SeaGreen;
            this.pnlAccountInformation.BorderRadius = 20;
            this.pnlAccountInformation.BorderThickness = 2;
            this.pnlAccountInformation.Controls.Add(this.guna2PictureBox1);
            this.pnlAccountInformation.Controls.Add(this.btnEdit);
            this.pnlAccountInformation.Controls.Add(this.btnChangePhoto);
            this.pnlAccountInformation.Controls.Add(this.lblAccountDescription);
            this.pnlAccountInformation.Controls.Add(this.lblAccounttitle);
            this.pnlAccountInformation.Controls.Add(this.txtBoxUsername);
            this.pnlAccountInformation.Controls.Add(this.lblUsername);
            this.pnlAccountInformation.Controls.Add(this.txtBoxEmail_PhoneNumber);
            this.pnlAccountInformation.Controls.Add(this.btnSaveChanges);
            this.pnlAccountInformation.Controls.Add(this.lblPass);
            this.pnlAccountInformation.Controls.Add(this.txtBoxFullName);
            this.pnlAccountInformation.Controls.Add(this.lblEmail_PhoneNumber);
            this.pnlAccountInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccountInformation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
            this.pnlAccountInformation.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountInformation.Name = "pnlAccountInformation";
            this.pnlAccountInformation.ShadowDecoration.Parent = this.pnlAccountInformation;
            this.pnlAccountInformation.Size = new System.Drawing.Size(799, 547);
            this.pnlAccountInformation.TabIndex = 19;
            // 
            // lblAccountDescription
            // 
            this.lblAccountDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountDescription.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblAccountDescription.Location = new System.Drawing.Point(25, 62);
            this.lblAccountDescription.Name = "lblAccountDescription";
            this.lblAccountDescription.Size = new System.Drawing.Size(220, 20);
            this.lblAccountDescription.TabIndex = 20;
            this.lblAccountDescription.Text = "Update your personal information";
            // 
            // lblAccounttitle
            // 
            this.lblAccounttitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAccounttitle.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccounttitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.lblAccounttitle.Location = new System.Drawing.Point(25, 21);
            this.lblAccounttitle.Name = "lblAccounttitle";
            this.lblAccounttitle.Size = new System.Drawing.Size(308, 37);
            this.lblAccounttitle.TabIndex = 19;
            this.lblAccounttitle.Text = "Account Information";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsername.Location = new System.Drawing.Point(316, 291);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 20);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPass.Location = new System.Drawing.Point(316, 203);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(183, 20);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Email or Phone Number";
            // 
            // lblEmail_PhoneNumber
            // 
            this.lblEmail_PhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail_PhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail_PhoneNumber.Location = new System.Drawing.Point(316, 114);
            this.lblEmail_PhoneNumber.Name = "lblEmail_PhoneNumber";
            this.lblEmail_PhoneNumber.Size = new System.Drawing.Size(79, 20);
            this.lblEmail_PhoneNumber.TabIndex = 2;
            this.lblEmail_PhoneNumber.Text = "Full Name";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.BorderRadius = 100;
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.Image = global::BudgetBuddy.Properties.Resources.userprofile;
            this.guna2PictureBox1.Location = new System.Drawing.Point(39, 114);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(220, 220);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 15;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = global::BudgetBuddy.Properties.Resources.edit_Icon;
            this.btnEdit.ImageOffset = new System.Drawing.Point(-4, -4);
            this.btnEdit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnEdit.Location = new System.Drawing.Point(316, 384);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(183, 45);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextOffset = new System.Drawing.Point(-2, 0);
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.BorderRadius = 15;
            this.btnChangePhoto.CheckedState.Parent = this.btnChangePhoto;
            this.btnChangePhoto.CustomImages.Parent = this.btnChangePhoto;
            this.btnChangePhoto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btnChangePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePhoto.ForeColor = System.Drawing.Color.White;
            this.btnChangePhoto.HoverState.Parent = this.btnChangePhoto;
            this.btnChangePhoto.Image = global::BudgetBuddy.Properties.Resources.changephotoIcon;
            this.btnChangePhoto.ImageOffset = new System.Drawing.Point(-1, -6);
            this.btnChangePhoto.ImageSize = new System.Drawing.Size(35, 35);
            this.btnChangePhoto.Location = new System.Drawing.Point(39, 350);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.ShadowDecoration.Parent = this.btnChangePhoto;
            this.btnChangePhoto.Size = new System.Drawing.Size(220, 45);
            this.btnChangePhoto.TabIndex = 22;
            this.btnChangePhoto.Text = "CHANGE PHOTO";
            this.btnChangePhoto.TextOffset = new System.Drawing.Point(-1, 1);
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(217)))));
            this.txtBoxUsername.BorderRadius = 10;
            this.txtBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxUsername.DefaultText = "";
            this.txtBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsername.DisabledState.Parent = this.txtBoxUsername;
            this.txtBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsername.FocusedState.Parent = this.txtBoxUsername;
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.txtBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.txtBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsername.HoverState.Parent = this.txtBoxUsername;
            this.txtBoxUsername.IconLeft = global::BudgetBuddy.Properties.Resources.user;
            this.txtBoxUsername.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.txtBoxUsername.Location = new System.Drawing.Point(316, 318);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.PasswordChar = '\0';
            this.txtBoxUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtBoxUsername.PlaceholderText = "";
            this.txtBoxUsername.ReadOnly = true;
            this.txtBoxUsername.SelectedText = "";
            this.txtBoxUsername.ShadowDecoration.Parent = this.txtBoxUsername;
            this.txtBoxUsername.Size = new System.Drawing.Size(413, 45);
            this.txtBoxUsername.TabIndex = 15;
            this.txtBoxUsername.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txtBoxEmail_PhoneNumber
            // 
            this.txtBoxEmail_PhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(217)))));
            this.txtBoxEmail_PhoneNumber.BorderRadius = 10;
            this.txtBoxEmail_PhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxEmail_PhoneNumber.DefaultText = "";
            this.txtBoxEmail_PhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxEmail_PhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxEmail_PhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmail_PhoneNumber.DisabledState.Parent = this.txtBoxEmail_PhoneNumber;
            this.txtBoxEmail_PhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxEmail_PhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmail_PhoneNumber.FocusedState.Parent = this.txtBoxEmail_PhoneNumber;
            this.txtBoxEmail_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.txtBoxEmail_PhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtBoxEmail_PhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxEmail_PhoneNumber.HoverState.Parent = this.txtBoxEmail_PhoneNumber;
            this.txtBoxEmail_PhoneNumber.IconLeft = global::BudgetBuddy.Properties.Resources.email;
            this.txtBoxEmail_PhoneNumber.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.txtBoxEmail_PhoneNumber.Location = new System.Drawing.Point(316, 230);
            this.txtBoxEmail_PhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxEmail_PhoneNumber.Name = "txtBoxEmail_PhoneNumber";
            this.txtBoxEmail_PhoneNumber.PasswordChar = '\0';
            this.txtBoxEmail_PhoneNumber.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtBoxEmail_PhoneNumber.PlaceholderText = "";
            this.txtBoxEmail_PhoneNumber.ReadOnly = true;
            this.txtBoxEmail_PhoneNumber.SelectedText = "";
            this.txtBoxEmail_PhoneNumber.ShadowDecoration.Parent = this.txtBoxEmail_PhoneNumber;
            this.txtBoxEmail_PhoneNumber.Size = new System.Drawing.Size(413, 45);
            this.txtBoxEmail_PhoneNumber.TabIndex = 13;
            this.txtBoxEmail_PhoneNumber.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BorderRadius = 15;
            this.btnSaveChanges.CheckedState.Parent = this.btnSaveChanges;
            this.btnSaveChanges.CustomImages.Parent = this.btnSaveChanges;
            this.btnSaveChanges.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(162)))), ((int)(((byte)(39)))));
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.HoverState.Parent = this.btnSaveChanges;
            this.btnSaveChanges.Image = global::BudgetBuddy.Properties.Resources.saveIcon;
            this.btnSaveChanges.ImageOffset = new System.Drawing.Point(0, -5);
            this.btnSaveChanges.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSaveChanges.Location = new System.Drawing.Point(517, 384);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.ShadowDecoration.Parent = this.btnSaveChanges;
            this.btnSaveChanges.Size = new System.Drawing.Size(212, 45);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "SAVE CHANGES";
            this.btnSaveChanges.TextOffset = new System.Drawing.Point(0, 1);
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(222)))), ((int)(((byte)(217)))));
            this.txtBoxFullName.BorderRadius = 10;
            this.txtBoxFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxFullName.DefaultText = "";
            this.txtBoxFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFullName.DisabledState.Parent = this.txtBoxFullName;
            this.txtBoxFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFullName.FocusedState.Parent = this.txtBoxFullName;
            this.txtBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.txtBoxFullName.ForeColor = System.Drawing.Color.Black;
            this.txtBoxFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxFullName.HoverState.Parent = this.txtBoxFullName;
            this.txtBoxFullName.IconLeft = global::BudgetBuddy.Properties.Resources.user;
            this.txtBoxFullName.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.txtBoxFullName.Location = new System.Drawing.Point(316, 141);
            this.txtBoxFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.PasswordChar = '\0';
            this.txtBoxFullName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtBoxFullName.PlaceholderText = "";
            this.txtBoxFullName.ReadOnly = true;
            this.txtBoxFullName.SelectedText = "";
            this.txtBoxFullName.ShadowDecoration.Parent = this.txtBoxFullName;
            this.txtBoxFullName.Size = new System.Drawing.Size(413, 45);
            this.txtBoxFullName.TabIndex = 3;
            this.txtBoxFullName.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // ucAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.pnlAccountInformation);
            this.Name = "ucAccount";
            this.Size = new System.Drawing.Size(799, 547);
            this.Load += new System.EventHandler(this.ucAccount_Load);
            this.pnlAccountInformation.ResumeLayout(false);
            this.pnlAccountInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlAccountInformation;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxEmail_PhoneNumber;
        private Guna.UI2.WinForms.Guna2Button btnSaveChanges;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPass;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxFullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail_PhoneNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccounttitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccountDescription;
        private Guna.UI2.WinForms.Guna2Button btnChangePhoto;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
