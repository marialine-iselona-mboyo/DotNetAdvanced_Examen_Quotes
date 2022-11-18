namespace DotNetAdvanced_Examen_Quotes
{
    partial class LoveQuotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLove = new System.Windows.Forms.Button();
            this.btnExitLove = new System.Windows.Forms.Button();
            this.lblLove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Love Quotes";
            // 
            // btnLove
            // 
            this.btnLove.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLove.Location = new System.Drawing.Point(473, 315);
            this.btnLove.Name = "btnLove";
            this.btnLove.Size = new System.Drawing.Size(130, 69);
            this.btnLove.TabIndex = 2;
            this.btnLove.Text = "Next";
            this.btnLove.UseVisualStyleBackColor = true;
            this.btnLove.Click += new System.EventHandler(this.btnLove_Click);
            // 
            // btnExitLove
            // 
            this.btnExitLove.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitLove.Location = new System.Drawing.Point(173, 315);
            this.btnExitLove.Name = "btnExitLove";
            this.btnExitLove.Size = new System.Drawing.Size(130, 69);
            this.btnExitLove.TabIndex = 3;
            this.btnExitLove.Text = "Exit";
            this.btnExitLove.UseVisualStyleBackColor = true;
            this.btnExitLove.Click += new System.EventHandler(this.btnExitLove_Click);
            // 
            // lblLove
            // 
            this.lblLove.AutoSize = true;
            this.lblLove.Font = new System.Drawing.Font("Pristina", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLove.Location = new System.Drawing.Point(41, 124);
            this.lblLove.MaximumSize = new System.Drawing.Size(600, 600);
            this.lblLove.MinimumSize = new System.Drawing.Size(700, 150);
            this.lblLove.Name = "lblLove";
            this.lblLove.Size = new System.Drawing.Size(700, 150);
            this.lblLove.TabIndex = 4;
            this.lblLove.Text = "This is were the love quotes \r\nare gonna be shown";
            // 
            // LoveQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(776, 396);
            this.Controls.Add(this.lblLove);
            this.Controls.Add(this.btnExitLove);
            this.Controls.Add(this.btnLove);
            this.Controls.Add(this.label1);
            this.Name = "LoveQuotes";
            this.Text = "LoveQuotes";
            this.Load += new System.EventHandler(this.LoveQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnLove;
        private Button btnExitLove;
        private Label lblLove;
    }
}