using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetAdvanced_Examen_Quotes
{
    public partial class MasterQuotes : Form
    {
        HappyQuotes happyQuotes = new HappyQuotes();
        LoveQuotes loveQuotes = new LoveQuotes();
        SadQuotes sadQuotes = new SadQuotes();

        public MasterQuotes()
        {
            InitializeComponent();
        }

        private void MasterQuotes_Load(object sender, EventArgs e)
        {

        }

        private void happyQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            happyQuotes.MdiParent = this;
            happyQuotes.Show();
        }

        private void loveQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loveQuotes.MdiParent = this;
            loveQuotes.Show();
        }

        private void sadQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sadQuotes.MdiParent = this;
            sadQuotes.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your viste! See you next time!");

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quotes mainQuotes = new Quotes();
            mainQuotes.Show();
            this.Close();
        }
    }
}
