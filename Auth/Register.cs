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
    public partial class Register : Form
    {
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        public Register()
        {
            InitializeComponent();
        }

        private void lnButtonLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Load(object sender, EventArgs e)
        {
          //nothing
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //search if there is already an administrator account

            string searchQuery = "SELECT accountType FROM table_account";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataReader reader;

            connection.Open();

            reader = searchCommand.ExecuteReader();

            try
            {

                if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
                {
                    error.Visible = true;
                    error.Text = "Please complete the form!";
                }
                else if(txtUsername.Text.Length < 4) 
                {
                    error.Visible = true;
                    error.Text = "Username is too short!";
                }
                else if (txtPassword.Text.Length < 6)
                {
                    error.Visible = true;
                    error.Text = "Password must be atleast 6 Characters!";
                }
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    error.Visible = true;
                    error.Text = "Password doesn't matched!";
                }
                else if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        error.Visible = true;
                        error.Text = "You can only make one administrator Account!";
                    }
                }
                else
                {

                    //insert the administrator account

                    error.Visible = false;
                    insertAccount();

                }

            }
            catch (Exception)
            {
                error.Visible = true;
                error.Text = "Something went wrong, try again!";
            }
            connection.Close();
        }


        //insert funtion

        private void insertAccount()
        {
            string insertQuery = "INSERT INTO table_account(username, password, accountType) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtAccountType.Text+"')";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

            connection.Open();
            int returnValue = insertCommand.ExecuteNonQuery();

            try {
                if(returnValue != 1)
                {
                    error.Visible = true;
                    error.Text = "Failed to register, try again!";
                }
                else
                {
                    error.Visible = false;
                    MessageBox.Show("Successfully registered!");
                    this.Hide();
                    Login loginForm = new Login();
                    loginForm.Show();
                }
            } catch(Exception)
            {
                error.Visible = true;
                error.Text = "Something went wrong, try again!";
            }
        }
        //Show and Hide Password
        private void btnshowp_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                btnhidep.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnhidep_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnshowp.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }
        //end
        
        //Show and Hide Confrim Password
        private void btnshowcp_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '•')
            {
                btnhidecp.BringToFront();
                txtConfirmPassword.PasswordChar = '\0';
            }
        }

        private void btnhidecp_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '\0')
            {
                btnshowcp.BringToFront();
                txtConfirmPassword.PasswordChar = '•';
            }
        }
        //end
    }
}
