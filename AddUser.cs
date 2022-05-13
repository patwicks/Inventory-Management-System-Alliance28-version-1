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

    public partial class AddUser : Form
    {
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        string idToBeUpdated;
        int counter;
        public AddUser()
        {
            InitializeComponent();
            dataGridStyle();
            counter = 0;
        }
        private void AddUser_Activated(object sender, EventArgs e)
        {
            //activated form

            fetchDataUser();

            //count user account

            countUserAccount();

            //
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            txtUsername.Select();
        }

        private void dataGridStyle()
        {
            dtUserAccount.RowTemplate.Height = 30;
            dtUserAccount.Columns[0].Width = 5;
            dtUserAccount.Columns[1].Width = 100;
            dtUserAccount.Columns[2].Width = 100;
            dtUserAccount.Columns[3].Width = 150;
            dtUserAccount.Columns[4].Width = 25;
            dtUserAccount.Columns[5].Width = 25;
           
            foreach (DataGridViewColumn column in dtUserAccount.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            dtUserAccount.EnableHeadersVisualStyles = false;
        }

        //fetch data
        private void fetchDataUser()
        {

            string type = "User Account";
            string loadQuery = "SELECT id, username, password, accountType FROM table_account WHERE accountType='"+type+"'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            connection.Open();

            try
            {

                dataAdapter.SelectCommand = loadCommand;
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                
                dtUserAccount.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Can't load any data, try again!");
            }

            connection.Close();

        }

        //Counter

        private void countUserAccount()
        {

            string type = "User Account";
            string loadQuery = "SELECT id, username, password, accountType FROM table_account WHERE accountType='" + type + "'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            connection.Open();

            try
            {

                dataAdapter.SelectCommand = loadCommand;
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                counter = dt.Rows.Count;

                if(counter >= 2)
                {
                    error.Visible = true;
                    error.Text = "You have reached the maximum number of User Accounts!";
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    error.Visible = false;
                    error.Text = "";
                    txtUsername.Enabled = true;
                    txtPassword.Enabled = true;
                    btnSave.Enabled = true;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Can't load any data, try again!");
            }

            connection.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //search if there is already an administrator account
            string searchQuery = "SELECT username FROM table_account WHERE username ='"+txtUsername.Text+"'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataReader reader;



            connection.Open();
            reader = searchCommand.ExecuteReader();

            try
            {
               
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    error.Visible = true;
                    error.Text = "Please complete the form!";
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
                else if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        error.Visible = true;
                        error.Text = "Username is already taken!";
                    }
                }
                else
                {
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

        private void insertAccount()
        {
            string insertQuery = "INSERT INTO table_account(username, password, accountType) VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtAccountType.Text + "')";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

            connection.Open();
            int returnValue = insertCommand.ExecuteNonQuery();

            try
            {
                if (returnValue != 1)
                {
                    error.Visible = true;
                    error.Text = "Failed to register, try again!";
                }
                else
                {
                    error.Visible = false;
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    txtUsername.Select();

                    fetchDataUser();
                    countUserAccount();
                }
            }
            catch (Exception)
            {
                error.Visible = true;
                error.Text = "Something went wrong, try again!";
            }

            connection.Close();
        }

        private void dtUserAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtUserAccount.Columns[e.ColumnIndex].Name == "DELETE")
            {
                dtUserAccount.CurrentRow.Selected = true;
                string idToBeDeleted = dtUserAccount.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();

                string deletQuery = "DELETE FROM table_account WHERE id='" + idToBeDeleted + "'";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand deleteCommand = new MySqlCommand(deletQuery, connection);
                MySqlDataReader reader;
                connection.Open();
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this account [ username = "+ dtUserAccount.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString() + " ] ?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        reader = deleteCommand.ExecuteReader();
                        fetchDataUser();
                        countUserAccount();

                        txtPassword.Text = "";
                        txtUsername.Text = "";

                        MessageBox.Show("Deleted Successfully!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong try again! " + ex.Message);
                }
                connection.Close();

            }
            else if (dtUserAccount.Columns[e.ColumnIndex].Name == "EDIT")
            {
                dtUserAccount.CurrentRow.Selected = true;
                
                idToBeUpdated = dtUserAccount.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();

                txtUsername.Text = dtUserAccount.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();
                txtPassword.Text = dtUserAccount.Rows[e.RowIndex].Cells["password"].FormattedValue.ToString();
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;

                btnUpdate.Visible = true;
                btnCancel.Visible = true;

                btnSave.Enabled = false;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

            btnUpdate.Visible = false;
            btnCancel.Visible = false;

            if(counter >= 2)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
            txtUsername.Select();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //initialize Sql things
            string updatedQuery = "UPDATE table_account SET username='" + txtUsername.Text + "',  password='" + txtPassword.Text + "' WHERE id = '" + idToBeUpdated + "'";
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

                        if (counter >= 2)
                        {
                            txtUsername.Enabled = false;
                            txtPassword.Enabled = false;
                        }
                        else
                        {
                            btnSave.Enabled = true;
                            txtUsername.Enabled = true;
                            txtPassword.Enabled = true;

                            txtUsername.Select();
                        }

                        btnCancel.Visible = false;
                        btnUpdate.Visible = false;



                        MessageBox.Show("Account updated successfully!");
                    }

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, try gain!" + ex.Message);
            }
        }

        private void dtUserAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtUserAccount.Columns[e.ColumnIndex].Name == "PASSWORD" && e.Value != null)
            {
                e.Value = new String('•', e.Value.ToString().Length);
            }
        }
    }
}
