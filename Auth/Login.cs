using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Inventory_System_Management_Alliance28
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbButtonRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
            string searchQuery = "SELECT username, password FROM table_account WHERE username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataReader reader;

            connection.Open();

            reader = searchCommand.ExecuteReader();

            try {

                if (txtUsername.Text == "")
                {
                    error.Visible = true;
                    error.Text = "USERNAME is required!";
                }
                else if(txtPassword.Text == "")
                {
                    error.Visible = true;
                    error.Text = "PASSWORD is required!";
                }
                else
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            error.Visible = true;
                            Home homeForm = new Home();
                            this.Hide();
                            homeForm.Show();
                        }
                    }
                    else
                    {
                        error.Visible = true;
                        error.Text = "Incorrect username or password";
                    }
                }
            
            } catch(Exception)
            {
                error.Visible = true;
                error.Text = "Something went wrong, try again!";
            }

            reader.Close();
            connection.Close();
        }
    }
}
