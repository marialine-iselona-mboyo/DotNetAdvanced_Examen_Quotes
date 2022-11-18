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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        //BACK TO HOME PAGE
        private void linkLabelHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }


        //BACK TO LOGIN PAGE
        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        
        
        //REGISTER CODE
        private void btnReg_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + 
                                                          "AttachDbFilename=C:\\DotNet_Advanced\\UserDB.mdf;" +
                                                          "Integrated Security=True;" +
                                                          "Connect Timeout=30");

            if (tbUsernameReg.Text.Length > 0 && tbPasswordReg.Text.Length > 0)
            {
                try
                {
                    string ins = "INSERT INTO [tbl_Users](Username, Password) VALUES ('" + tbUsernameReg.Text + "', '" + tbPasswordReg.Text + "')";

                    connection.Open();
                    SqlCommand cmd = new SqlCommand(ins, connection);

                        try
                        {
                    //connection.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Successfully registered");

                            Quotes quoteform = new Quotes();
                            quoteform.Show();
                            this.Hide();

                    //connection.Close();
                        }
                        catch 
                        {
                            MessageBox.Show("Failed to register");
                            tbUsernameReg.Clear();
                            tbPasswordReg.Clear();
                            tbUsernameReg.Focus();
                        }

                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to Database");
                }
            }
            else
            {
                MessageBox.Show("All informations are required!");
            }
        }
    }
}
