namespace DotNetAdvanced_Examen_Quotes
{
    partial class Register
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
            this.btnReg = new System.Windows.Forms.Button();
            this.tbPasswordReg = new System.Windows.Forms.TextBox();
            this.tbUsernameReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLblLogin = new System.Windows.Forms.LinkLabel();
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
            this.linkLabelHome.TabIndex = 21;
            this.linkLabelHome.TabStop = true;
            this.linkLabelHome.Text = "Home";
            this.linkLabelHome.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHome_LinkClicked);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReg.Location = new System.Drawing.Point(496, 457);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(134, 60);
            this.btnReg.TabIndex = 20;
            this.btnReg.Text = "Sign up";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbPasswordReg
            // 
            this.tbPasswordReg.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPasswordReg.Location = new System.Drawing.Point(420, 331);
            this.tbPasswordReg.Name = "tbPasswordReg";
            this.tbPasswordReg.PasswordChar = '*';
            this.tbPasswordReg.Size = new System.Drawing.Size(249, 39);
            this.tbPasswordReg.TabIndex = 19;
            // 
            // tbUsernameReg
            // 
            this.tbUsernameReg.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsernameReg.Location = new System.Drawing.Point(420, 231);
            this.tbUsernameReg.Name = "tbUsernameReg";
            this.tbUsernameReg.Size = new System.Drawing.Size(249, 39);
            this.tbUsernameReg.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(208, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(197, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 48);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please, Sign up!";
            // 
            // linkLblLogin
            // 
            this.linkLblLogin.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLblLogin.AutoSize = true;
            this.linkLblLogin.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLblLogin.LinkColor = System.Drawing.Color.Black;
            this.linkLblLogin.Location = new System.Drawing.Point(168, 457);
            this.linkLblLogin.Name = "linkLblLogin";
            this.linkLblLogin.Size = new System.Drawing.Size(256, 62);
            this.linkLblLogin.TabIndex = 22;
            this.linkLblLogin.TabStop = true;
            this.linkLblLogin.Text = "Already an account? \r\nPlease Sign in!";
            this.linkLblLogin.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLogin_LinkClicked);
            // 
            // Register
            // 
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(866, 613);
            this.Controls.Add(this.linkLblLogin);
            this.Controls.Add(this.linkLabelHome);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbPasswordReg);
            this.Controls.Add(this.tbUsernameReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabelHome;
        private Button btnReg;
        private TextBox tbPasswordReg;
        private TextBox tbUsernameReg;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkLblLogin;
    }
}