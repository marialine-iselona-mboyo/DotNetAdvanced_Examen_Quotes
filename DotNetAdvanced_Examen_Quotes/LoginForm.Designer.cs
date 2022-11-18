namespace DotNetAdvanced_Examen_Quotes
{
    partial class LoginForm
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
            this.linkLabelHome = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLblReg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelHome
            // 
            this.linkLabelHome.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelHome.AutoSize = true;
            this.linkLabelHome.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelHome.LinkColor = System.Drawing.Color.Black;
            this.linkLabelHome.Location = new System.Drawing.Point(12, 9);
            this.linkLabelHome.Name = "linkLabelHome";
            this.linkLabelHome.Size = new System.Drawing.Size(98, 38);
            this.linkLabelHome.TabIndex = 14;
            this.linkLabelHome.TabStop = true;
            this.linkLabelHome.Text = "Home";
            this.linkLabelHome.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHome_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(496, 443);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(131, 62);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(420, 317);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(249, 39);
            this.tbPassword.TabIndex = 12;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(420, 217);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(249, 39);
            this.tbUsername.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(208, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(197, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please, Log in!";
            // 
            // linkLblReg
            // 
            this.linkLblReg.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLblReg.AutoSize = true;
            this.linkLblReg.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLblReg.LinkColor = System.Drawing.Color.Black;
            this.linkLblReg.Location = new System.Drawing.Point(129, 443);
            this.linkLblReg.Name = "linkLblReg";
            this.linkLblReg.Size = new System.Drawing.Size(280, 62);
            this.linkLblReg.TabIndex = 23;
            this.linkLblReg.TabStop = true;
            this.linkLblReg.Text = "Don\'t have an account? \r\nPlease Sign up!";
            this.linkLblReg.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLblReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblReg_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(866, 613);
            this.Controls.Add(this.linkLblReg);
            this.Controls.Add(this.linkLabelHome);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabelHome;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkLblReg;
    }
}