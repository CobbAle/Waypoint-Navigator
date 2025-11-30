namespace WaypointNavigator
{
    partial class LoginRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegister));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxEmailAddress = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblPasswordMatch = new System.Windows.Forms.Label();
            this.tbxEmailRegister = new System.Windows.Forms.TextBox();
            this.lblEmailRegister = new System.Windows.Forms.Label();
            this.lblReenterPassword = new System.Windows.Forms.Label();
            this.tbxPasswordReenter = new System.Windows.Forms.TextBox();
            this.tbxLastNameRegister = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnRegisterAccount = new System.Windows.Forms.Button();
            this.tbxPasswordRegister = new System.Windows.Forms.TextBox();
            this.tbxFirstNameRegister = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.btnRegister);
            this.pnlLogin.Controls.Add(this.tbxPassword);
            this.pnlLogin.Controls.Add(this.tbxEmailAddress);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.lblEmailAddress);
            this.pnlLogin.Location = new System.Drawing.Point(3, 9);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(776, 426);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(188, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(188, 140);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 35);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.Location = new System.Drawing.Point(188, 60);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(212, 31);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.Text = "ComputerScience!";
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxEmailAddress
            // 
            this.tbxEmailAddress.Location = new System.Drawing.Point(188, 20);
            this.tbxEmailAddress.Name = "tbxEmailAddress";
            this.tbxEmailAddress.Size = new System.Drawing.Size(212, 31);
            this.tbxEmailAddress.TabIndex = 2;
            this.tbxEmailAddress.Text = "k.lean@poolehigh.poole.sch.uk";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(62, 51);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(175, 40);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Password";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(108, 20);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(107, 40);
            this.lblEmailAddress.TabIndex = 0;
            this.lblEmailAddress.Text = "Email";
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.lblPasswordMatch);
            this.pnlRegister.Controls.Add(this.tbxEmailRegister);
            this.pnlRegister.Controls.Add(this.lblEmailRegister);
            this.pnlRegister.Controls.Add(this.lblReenterPassword);
            this.pnlRegister.Controls.Add(this.tbxPasswordReenter);
            this.pnlRegister.Controls.Add(this.tbxLastNameRegister);
            this.pnlRegister.Controls.Add(this.lblLastName);
            this.pnlRegister.Controls.Add(this.btnRegisterAccount);
            this.pnlRegister.Controls.Add(this.tbxPasswordRegister);
            this.pnlRegister.Controls.Add(this.tbxFirstNameRegister);
            this.pnlRegister.Controls.Add(this.lblPassword);
            this.pnlRegister.Controls.Add(this.lblFirstName);
            this.pnlRegister.Cursor = System.Windows.Forms.Cursors.No;
            this.pnlRegister.Location = new System.Drawing.Point(6, 6);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(776, 426);
            this.pnlRegister.TabIndex = 2;
            this.pnlRegister.Visible = false;
            // 
            // lblPasswordMatch
            // 
            this.lblPasswordMatch.AutoSize = true;
            this.lblPasswordMatch.Location = new System.Drawing.Point(211, 167);
            this.lblPasswordMatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordMatch.Name = "lblPasswordMatch";
            this.lblPasswordMatch.Size = new System.Drawing.Size(205, 25);
            this.lblPasswordMatch.TabIndex = 11;
            this.lblPasswordMatch.Text = "Password do not match!";
            this.lblPasswordMatch.Visible = false;
            // 
            // tbxEmailRegister
            // 
            this.tbxEmailRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEmailRegister.Location = new System.Drawing.Point(188, 64);
            this.tbxEmailRegister.Name = "tbxEmailRegister";
            this.tbxEmailRegister.Size = new System.Drawing.Size(170, 31);
            this.tbxEmailRegister.TabIndex = 3;
            // 
            // lblEmailRegister
            // 
            this.lblEmailRegister.AutoSize = true;
            this.lblEmailRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEmailRegister.Location = new System.Drawing.Point(50, 59);
            this.lblEmailRegister.Name = "lblEmailRegister";
            this.lblEmailRegister.Size = new System.Drawing.Size(204, 33);
            this.lblEmailRegister.TabIndex = 10;
            this.lblEmailRegister.Text = "Email Address";
            // 
            // lblReenterPassword
            // 
            this.lblReenterPassword.AutoSize = true;
            this.lblReenterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReenterPassword.Location = new System.Drawing.Point(11, 143);
            this.lblReenterPassword.Name = "lblReenterPassword";
            this.lblReenterPassword.Size = new System.Drawing.Size(264, 33);
            this.lblReenterPassword.TabIndex = 9;
            this.lblReenterPassword.Text = "Re-Enter password";
            // 
            // tbxPasswordReenter
            // 
            this.tbxPasswordReenter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPasswordReenter.Location = new System.Drawing.Point(188, 147);
            this.tbxPasswordReenter.Name = "tbxPasswordReenter";
            this.tbxPasswordReenter.Size = new System.Drawing.Size(170, 31);
            this.tbxPasswordReenter.TabIndex = 5;
            this.tbxPasswordReenter.UseSystemPasswordChar = true;
            this.tbxPasswordReenter.TextChanged += new System.EventHandler(this.tbxPasswordReenter_TextChanged);
            // 
            // tbxLastNameRegister
            // 
            this.tbxLastNameRegister.Location = new System.Drawing.Point(471, 20);
            this.tbxLastNameRegister.Name = "tbxLastNameRegister";
            this.tbxLastNameRegister.Size = new System.Drawing.Size(170, 31);
            this.tbxLastNameRegister.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLastName.Location = new System.Drawing.Point(364, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(156, 33);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // btnRegisterAccount
            // 
            this.btnRegisterAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRegisterAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterAccount.FlatAppearance.BorderSize = 0;
            this.btnRegisterAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegisterAccount.ForeColor = System.Drawing.Color.White;
            this.btnRegisterAccount.Location = new System.Drawing.Point(471, 117);
            this.btnRegisterAccount.Name = "btnRegisterAccount";
            this.btnRegisterAccount.Size = new System.Drawing.Size(170, 50);
            this.btnRegisterAccount.TabIndex = 6;
            this.btnRegisterAccount.Text = "Register";
            this.btnRegisterAccount.UseVisualStyleBackColor = false;
            this.btnRegisterAccount.Click += new System.EventHandler(this.btnRegisterAccount_Click);
            // 
            // tbxPasswordRegister
            // 
            this.tbxPasswordRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPasswordRegister.Location = new System.Drawing.Point(188, 121);
            this.tbxPasswordRegister.Name = "tbxPasswordRegister";
            this.tbxPasswordRegister.Size = new System.Drawing.Size(170, 31);
            this.tbxPasswordRegister.TabIndex = 4;
            this.tbxPasswordRegister.UseSystemPasswordChar = true;
            // 
            // tbxFirstNameRegister
            // 
            this.tbxFirstNameRegister.Location = new System.Drawing.Point(188, 20);
            this.tbxFirstNameRegister.Name = "tbxFirstNameRegister";
            this.tbxFirstNameRegister.Size = new System.Drawing.Size(170, 31);
            this.tbxFirstNameRegister.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPassword.Location = new System.Drawing.Point(90, 117);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(143, 33);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblFirstName.Location = new System.Drawing.Point(81, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(159, 33);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // LoginRegister
            // 
            this.AccessibleName = "Waypoint Navigator";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlRegister);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginRegister";
            this.Text = "Waypoint Navigator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxEmailAddress;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRegisterAccount;
        private System.Windows.Forms.TextBox tbxPasswordRegister;
        private System.Windows.Forms.TextBox tbxFirstNameRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxLastNameRegister;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxEmailRegister;
        private System.Windows.Forms.Label lblEmailRegister;
        private System.Windows.Forms.Label lblReenterPassword;
        private System.Windows.Forms.TextBox tbxPasswordReenter;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblPasswordMatch;
    }
}

