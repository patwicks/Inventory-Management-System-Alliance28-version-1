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
    public partial class WithdrawForm : Form
    {

        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
           txtItemCode.Select();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            string status = "Active";
            string searchQuery = "SELECT PRODUCTNAME, QUANTITY,IMAGE,WARRANTY FROM table_products WHERE ITEMCODE = '" + txtItemCode.Text +"' AND STATUS='"+status+"'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataReader reader;

            connection.Open();

            reader = searchCommand.ExecuteReader();
            try {

                if (txtItemCode.Text.Length >= 8 || txtItemCode.Text.Length < 13)
                {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            //MessageBox.Show("Item found");

                            txtProductName.Text = reader.GetValue(0).ToString();
                            txtCurrentStock.Text = reader.GetValue(1).ToString();
                            lbImage.Text = reader.GetValue(2).ToString();
                            txtWarranty.Text = reader.GetValue(3).ToString();


                            Image image = Image.FromFile(Application.StartupPath + @"\Images\" + lbImage.Text);
                            pbItemImage.Image = image;

                            error.Visible = false;
                        }
                    }
                    else
                    {
                        error.Visible = true;
                        error.Text = "Product not found";


                        txtProductName.Text = "";
                        txtCurrentStock.Text = "";
                        lbImage.Text = "";
                        pbItemImage.Image = null;

                    }
                }
            
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            reader.Dispose();
            reader.Close();
            connection.Close();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            string status = "Active";
            Guid myuuid = Guid.NewGuid();
            string transactionID = myuuid.ToString();
            //Sql staffs here
            string transactionType = "Withdraw";
            string insertQuery = "INSERT INTO table_withdrawal(TRANSACTION_ID, ITEM_CODE, PRODUCT_NAME, QUANTITY, WARRANTY, TRANSACTION_TYPE, CLIENT_NAME,STATUS, IMAGE) VALUES('" + transactionID + "', '" + txtItemCode.Text + "', '" + txtProductName.Text + "', '" + txtQuantity.Text + "', '" + txtWarranty.Text + "', '" + transactionType + "' , '" + txtClientName.Text + "', '"+ status +"' ,'" + lbImage.Text + "' )";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

           


            //Validation

            try {
                connection.Open();

                if (txtItemCode.Text == "")
                {
                    error.Visible = true;
                    error.Text = "ITEM CODE is required!";

                }
                else if (txtItemCode.Text.Length < 8)
                {
                    error.Visible = true;
                    error.Text = "Invalid ITEM CODE!";
                }
                else if (txtClientName.Text == "")
                {
                    error.Visible = true;
                    error.Text = "CLIENT NAME is required!";
                }
                else if (txtQuantity.Text == "")
                {
                    error.Visible = true;
                    error.Text = "Withdrawal QUANTITY is required!";
                }
                else if (!int.TryParse(txtQuantity.Text, out int n))
                {
                    error.Visible = true;
                    error.Text = "Please input numerical value on QUANTITY!";
                }
                else if (Int32.Parse(txtQuantity.Text) <= 0)
                {
                    error.Visible = true;
                    error.Text = "Invalid QUANTITY!";
                }
                else if (Int32.Parse(txtQuantity.Text) > Int32.Parse(txtCurrentStock.Text))
                {
                    error.Visible = true;
                    error.Text = "Out of STOCK!";
                }
                else
                {

                    if (MessageBox.Show("Withdraw the Product?", "Widthrawal Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int returnValue = insertCommand.ExecuteNonQuery();

                        if (returnValue == 1)
                        {
                            subtractStock();
                            MessageBox.Show("Successfully Withdraw Item!");
                            error.Visible = false;
                            error.Text = "";
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to Withdraw Item!");
                        }
                    }
                }

                connection.Close();
            } catch(Exception)
            {
                MessageBox.Show("Somthing went wrong, try again!");
            }
           
            

        }

        //Subtract the stock in withrawal item

        public void subtractStock()
        {
            int val1 = Convert.ToInt32(txtCurrentStock.Text);
            int val2 = Convert.ToInt32(txtQuantity.Text);
            int total = val1 - val2;

            lbNewNoStock.Text = total.ToString();

            string updateQuery = "UPDATE table_products SET QUANTITY = '"+lbNewNoStock.Text+"' WHERE ITEMCODE='"+txtItemCode.Text +"'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
            MySqlDataReader reader;
            //execute update command
            connection.Open();
            reader = updateCommand.ExecuteReader();
            connection.Close();
        }
    }
}
