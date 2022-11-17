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
    public partial class SadQuotes : Form
    {
        public SadQuotes()
        {
            InitializeComponent();
        }

        //CLOSE THE WINDOW
        private void btnExitSad_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //CALL THE "NEXT" METHOD
        //EVERY TIME YOU OPEN THIS WINDOW, THE QUOTE WILL CHANGE
        private void SadQuotes_Load(object sender, EventArgs e)
        {
            Next();
        }



        //CALL THE "NEXT" METHOD BY CLICKING ON THE NEXT BUTTON
        private void btnNextSad_Click(object sender, EventArgs e)
        {
            Next();
        }



        //GENERATRE RANDOM QUOTE
        void Next()
        {
            List<string> sadQuotes = new List<string>();

            Random random = new Random();

            StreamReader quoteReader = new StreamReader("SadQuotes.txt");

            string line = "";

            while (!quoteReader.EndOfStream)
            {
                line = quoteReader.ReadLine();
                sadQuotes.Add(line);
            }

            lblSad.Text = sadQuotes[random.Next(1, sadQuotes.Count)];
        }


    }
}
