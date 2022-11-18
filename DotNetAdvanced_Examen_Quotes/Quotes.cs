using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DotNetAdvanced_Examen_Quotes
{
    public partial class Quotes : Form
    {
        public Quotes()
        {
            InitializeComponent();
        }



        //BACK TO HOME
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your viste! See you next time!");
            
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }



        //DIFFERENT MOODS QUOTES
        private void moodQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterQuotes moods = new MasterQuotes();
            moods.Show();
            this.Hide();
        }



        //CALL THE ... METHOD
        //EVERY TIME YOU OPEN THIS WINDOW, THE QUOTE WILL CHANGE
        private void Quotes_Load(object sender, EventArgs e)
        {
            Generate();
        }



        //CALL THE "GENERATE" METHOD BY CLICKING ON THE NEXT BUTTON
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }


        //QUOTES GENEREATOR
        void Generate()
        {
            List<string> list = new List<string>();

            Random random = new Random();

            StreamReader streamReader = new StreamReader("TodaysQuotes.txt");

            string line;

            while(!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();
                list.Add(line);
            }
            lblQuotes.Text = list[random.Next(list.Count)];
        }
    }
}
