namespace DotNetAdvanced_Examen_Quotes
{
    partial class HappyQuotes
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
            this.labelHappy = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHappy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHappy
            // 
            this.labelHappy.AutoSize = true;
            this.labelHappy.Font = new System.Drawing.Font("Poor Richard", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHappy.Location = new System.Drawing.Point(260, 42);
            this.labelHappy.Name = "labelHappy";
            this.labelHappy.Size = new System.Drawing.Size(233, 44);
            this.labelHappy.TabIndex = 0;
            this.labelHappy.Text = "Happy Quotes";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(491, 308);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 66);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(136, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 66);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHappy
            // 
            this.lblHappy.AutoSize = true;
            this.lblHappy.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHappy.Location = new System.Drawing.Point(44, 110);
            this.lblHappy.MaximumSize = new System.Drawing.Size(600, 600);
            this.lblHappy.MinimumSize = new System.Drawing.Size(700, 175);
            this.lblHappy.Name = "lblHappy";
            this.lblHappy.Size = new System.Drawing.Size(700, 175);
            this.lblHappy.TabIndex = 4;
            this.lblHappy.Text = "This is were the happy quotes \r\nare gonna be shown";
            // 
            // HappyQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(776, 396);
            this.Controls.Add(this.lblHappy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.labelHappy);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HappyQuotes";
            this.Text = "HappyQuotes";
            this.Load += new System.EventHandler(this.HappyQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelHappy;
        private Button btnNext;
        private Button btnExit;
        private Label lblHappy;
    }
}