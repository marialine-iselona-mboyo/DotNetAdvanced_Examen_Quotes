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
    public partial class HappyQuotes : Form
    {
        public HappyQuotes()
        {
            InitializeComponent();
        }

        
        //CLOSE THE WINDOW
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //CALL THE "NEXT" METHOD
        //EVERY TIME YOU OPEN THIS WINDOW, THE QUOTE WILL CHANGE
        private void HappyQuotes_Load(object sender, EventArgs e)
        {
            Next();
        }


        //CALL THE "NEXT" METHOD BY CLICKING ON THE NEXT BUTTON
        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
        }




        //GENERATRE RANDOM QUOTE
        void Next()
        {
            List<string> happyQuotes = new List<string>();

            Random random = new Random();

            StreamReader quoteReader = new StreamReader("HappyQuotes.txt");

            string line = "";

            while (!quoteReader.EndOfStream)
            {
                line = quoteReader.ReadLine();
                happyQuotes.Add(line);
            }

            lblHappy.Text = happyQuotes[random.Next(1, happyQuotes.Count)];
        }
    }
}
