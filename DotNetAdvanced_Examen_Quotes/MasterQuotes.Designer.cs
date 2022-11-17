namespace DotNetAdvanced_Examen_Quotes
{
    partial class MasterQuotes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moodQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.happyQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loveQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moodQuotesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1333, 46);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moodQuotesToolStripMenuItem
            // 
            this.moodQuotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.happyQuotesToolStripMenuItem,
            this.loveQuotesToolStripMenuItem,
            this.sadQuotesToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.moodQuotesToolStripMenuItem.Name = "moodQuotesToolStripMenuItem";
            this.moodQuotesToolStripMenuItem.Size = new System.Drawing.Size(206, 42);
            this.moodQuotesToolStripMenuItem.Text = "Mood Quotes";
            // 
            // happyQuotesToolStripMenuItem
            // 
            this.happyQuotesToolStripMenuItem.Name = "happyQuotesToolStripMenuItem";
            this.happyQuotesToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.happyQuotesToolStripMenuItem.Text = "Happy Quotes";
            this.happyQuotesToolStripMenuItem.Click += new System.EventHandler(this.happyQuotesToolStripMenuItem_Click);
            // 
            // loveQuotesToolStripMenuItem
            // 
            this.loveQuotesToolStripMenuItem.Name = "loveQuotesToolStripMenuItem";
            this.loveQuotesToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.loveQuotesToolStripMenuItem.Text = "Love Quotes";
            this.loveQuotesToolStripMenuItem.Click += new System.EventHandler(this.loveQuotesToolStripMenuItem_Click);
            // 
            // sadQuotesToolStripMenuItem
            // 
            this.sadQuotesToolStripMenuItem.Name = "sadQuotesToolStripMenuItem";
            this.sadQuotesToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.sadQuotesToolStripMenuItem.Text = "Sad Quotes";
            this.sadQuotesToolStripMenuItem.Click += new System.EventHandler(this.sadQuotesToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MasterQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 753);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Poor Richard", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterQuotes";
            this.Text = "MasterQuotes";
            this.Load += new System.EventHandler(this.MasterQuotes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem moodQuotesToolStripMenuItem;
        private ToolStripMenuItem happyQuotesToolStripMenuItem;
        private ToolStripMenuItem loveQuotesToolStripMenuItem;
        private ToolStripMenuItem sadQuotesToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}