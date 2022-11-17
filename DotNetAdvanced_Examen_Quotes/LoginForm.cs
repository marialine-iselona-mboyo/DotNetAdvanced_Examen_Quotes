using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetAdvanced_Examen_Quotes
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }





        //LOGIN CODE
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + 
                                                          "AttachDbFilename=C:\\DotNet_Advanced\\UserDB.mdf;" +
                                                          "Integrated Security=True;" +
                                                          "Connect Timeout=30");

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Users WHERE username = '"+tbUsername.Text+"' AND password = '"+tbPassword.Text+"' ", connection);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if(dtbl.Rows.Count == 1 )
            {
                try
                {
                    MessageBox.Show("Successfulle Logged in!");

                    Quotes quotes = new Quotes();
                    this.Hide();
                    quotes.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("The username or password not valid");

                    tbUsername.Clear();
                    tbPassword.Clear();
                    tbUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("All informations are required!");
            }
        }
    }
}
