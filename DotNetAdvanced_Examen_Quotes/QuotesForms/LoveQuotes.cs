using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetAdvanced_Examen_Quotes
{
    public partial class LoveQuotes : Form
    {
        public LoveQuotes()
        {
            InitializeComponent();
        }



        //CLOSE LOVE WINDOW
        private void btnExitLove_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //CALL THE "NEXT" METHOD
        //EVERY TIME YOU OPEN THIS WINDOW, THE QUOTE WILL CHANGE
        private void LoveQuotes_Load(object sender, EventArgs e)
        {
            Next();
        }


        //CALL THE "NEXT" METHOD BY CLICKING ON THE NEXT BUTTON
        private void btnLove_Click(object sender, EventArgs e)
        {
            Next();
        }



        //GENERATRE RANDOM QUOTE
        void Next()
        {
            List<string> loveQuotes = new List<string>();

            Random random = new Random();

            StreamReader quoteReader = new StreamReader("LoveQuotes.txt");

            string line = "";

            while(!quoteReader.EndOfStream)
            {
                line = quoteReader.ReadLine();
                loveQuotes.Add(line);
            }

            lblLove.Text = loveQuotes[random.Next(1, loveQuotes.Count)];
        }
    }
}
