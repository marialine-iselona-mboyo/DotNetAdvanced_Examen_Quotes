namespace DotNetAdvanced_Examen_Quotes
{
    partial class SadQuotes
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
            this.btnExitSad = new System.Windows.Forms.Button();
            this.btnNextSad = new System.Windows.Forms.Button();
            this.lblSad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(283, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sad Quotes";
            // 
            // btnExitSad
            // 
            this.btnExitSad.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitSad.Location = new System.Drawing.Point(167, 315);
            this.btnExitSad.Name = "btnExitSad";
            this.btnExitSad.Size = new System.Drawing.Size(130, 69);
            this.btnExitSad.TabIndex = 5;
            this.btnExitSad.Text = "Exit";
            this.btnExitSad.UseVisualStyleBackColor = true;
            this.btnExitSad.Click += new System.EventHandler(this.btnExitSad_Click);
            // 
            // btnNextSad
            // 
            this.btnNextSad.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextSad.Location = new System.Drawing.Point(505, 315);
            this.btnNextSad.Name = "btnNextSad";
            this.btnNextSad.Size = new System.Drawing.Size(130, 69);
            this.btnNextSad.TabIndex = 4;
            this.btnNextSad.Text = "Next";
            this.btnNextSad.UseVisualStyleBackColor = true;
            this.btnNextSad.Click += new System.EventHandler(this.btnNextSad_Click);
            // 
            // lblSad
            // 
            this.lblSad.AutoSize = true;
            this.lblSad.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSad.Location = new System.Drawing.Point(42, 120);
            this.lblSad.MaximumSize = new System.Drawing.Size(600, 600);
            this.lblSad.MinimumSize = new System.Drawing.Size(700, 150);
            this.lblSad.Name = "lblSad";
            this.lblSad.Size = new System.Drawing.Size(700, 150);
            this.lblSad.TabIndex = 6;
            this.lblSad.Text = "This is were the love quotes \r\nare gonna be shown\r\n";
            // 
            // SadQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(776, 396);
            this.Controls.Add(this.lblSad);
            this.Controls.Add(this.btnExitSad);
            this.Controls.Add(this.btnNextSad);
            this.Controls.Add(this.label1);
            this.Name = "SadQuotes";
            this.Text = "SadQuotes";
            this.Load += new System.EventHandler(this.SadQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnExitSad;
        private Button btnNextSad;
        private Label lblSad;
    }
}