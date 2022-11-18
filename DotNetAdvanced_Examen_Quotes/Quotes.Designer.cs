namespace DotNetAdvanced_Examen_Quotes
{
    partial class Quotes
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
            this.lblQuotes = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moodQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(275, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s Quote";
            // 
            // lblQuotes
            // 
            this.lblQuotes.AutoSize = true;
            this.lblQuotes.Location = new System.Drawing.Point(64, 164);
            this.lblQuotes.MaximumSize = new System.Drawing.Size(500, 200);
            this.lblQuotes.MinimumSize = new System.Drawing.Size(700, 150);
            this.lblQuotes.Name = "lblQuotes";
            this.lblQuotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQuotes.Size = new System.Drawing.Size(700, 150);
            this.lblQuotes.TabIndex = 1;
            this.lblQuotes.Text = "Fetched from an API, this is were the \r\nrandom quotes will be shown";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moodsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 46);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moodsToolStripMenuItem
            // 
            this.moodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moodQuotesToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.moodsToolStripMenuItem.Name = "moodsToolStripMenuItem";
            this.moodsToolStripMenuItem.Size = new System.Drawing.Size(83, 42);
            this.moodsToolStripMenuItem.Text = "File";
            // 
            // moodQuotesToolStripMenuItem
            // 
            this.moodQuotesToolStripMenuItem.Name = "moodQuotesToolStripMenuItem";
            this.moodQuotesToolStripMenuItem.Size = new System.Drawing.Size(310, 46);
            this.moodQuotesToolStripMenuItem.Text = "Mood Quotes";
            this.moodQuotesToolStripMenuItem.Click += new System.EventHandler(this.moodQuotesToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(310, 46);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(309, 347);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(171, 60);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Quotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblQuotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Quotes";
            this.Text = "Quotes";
            this.Load += new System.EventHandler(this.Quotes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblQuotes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem moodsToolStripMenuItem;
        private Button btnGenerate;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem moodQuotesToolStripMenuItem;
    }
}