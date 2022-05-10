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
    public partial class AccountSetting : Form
    {
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        public string id { get; set; }

        public AccountSetting()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
        }

        private void AccountSetting_Load(object sender, EventArgs e)
        {
            
        }
        private void AccountSetting_Activated(object sender, EventArgs e)
        {
            searchDetails();
        }

        //search
        private void searchDetails()
        {
            string searchQuery = "SELECT * FROM table_account WHERE id='" + id + "' ";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataReader reader;

            connection.Open();

            reader = searchCommand.ExecuteReader();

            try
            {

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtUsername.Text= reader["username"].ToString();
                        txtPassword.Text = reader["password"].ToString();
                        txtAccountType.Text= reader["accountType"].ToString();

                    }
                }
            }
            catch (Exception)
            {
                error.Visible = true;
                error.Text = "Something went wrong, try again!";
            }

            reader.Close();
            connection.Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtUsername.Select();
            btnUpdate.Enabled = true;
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnEdit, "Edit");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //initialize Sql things
            string updatedQuery = "UPDATE table_account SET username='" + txtUsername.Text + "',  password='" + txtPassword.Text + "' WHERE id = '" + id + "'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand updateCommand = new MySqlCommand(updatedQuery, connection);
            MySqlDataReader reader;
            try
            {
                connection.Open();
                if (txtUsername.Text == "")
                {
                    error.Visible = true;
                    error.Text = "USERNAME is required!";
                }
                else if (txtPassword.Text == "")
                {
                    error.Visible = true;
                    error.Text = "PASSWORD is required!";
                }
                else if (txtUsername.Text.Length < 4)
                {
                    error.Visible = true;
                    error.Text = "Username is too short!";
                }
                else if (txtPassword.Text.Length < 6)
                {
                    error.Visible = true;
                    error.Text = "Password must be atleast 6 Characters!";
                }
                else
                {
                    error.Visible = false;

                    //ask for confirmation before updating the product
                    if (MessageBox.Show("Save the update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //execute update command
                        reader = updateCommand.ExecuteReader();
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                        txtAccountType.Text = "";
                        MessageBox.Show("Account updated successfully!");
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    }

                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong, try gain!" + ex.Message );
            }
        }

      
    }
}
