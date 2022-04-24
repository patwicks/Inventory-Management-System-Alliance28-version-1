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
    public partial class GridWithdrawForm : Form
    {
        public string itemCode { get; set; }
        public string productName { get; set; }
        public string productQuantity { get; set; }
        public string productImage { get; set; }
        public string productWarranty { get; set; }
        public GridWithdrawForm()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void GridWithdrawForm_Load(object sender, EventArgs e)
        {
            txtItemCode.Text = itemCode;
            txtProductName.Text = productName;
            txtCurrentStock.Text = productQuantity;
            txtWarranty.Text = productWarranty;
            

            Image image = Image.FromFile(Application.StartupPath + @"\Images\" + productImage);
            pbItemImage.Image = image;
        }

        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
       

        

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Guid myuuid = Guid.NewGuid();
            string transactionID = myuuid.ToString();
            //Sql staffs here
            string transactionType = "Widthraw";
            string insertQuery = "INSERT INTO table_withdrawal(TRANSACTION_ID, ITEM_CODE, PRODUCT_NAME, QUANTITY, WARRANTY, TRANSACTION_TYPE, CLIENT_NAME,IMAGE) VALUES('" + transactionID + "', '" + txtItemCode.Text + "', '" + txtProductName.Text + "', '" + txtQuantity.Text + "' , '" + txtWarranty.Text + "', '" + transactionType + "' , '" + txtClientName.Text + "', '" + productImage + "' )";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

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

                if (MessageBox.Show("Withdraw the Product?", "Widthrawal Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int returnValue = insertCommand.ExecuteNonQuery();

                    if (returnValue == 1)
                    {
                        subtractStock();
                        MessageBox.Show("Successfully Withdraw Item!");
                        error.Visible = false;
                        error.Text = "";
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Withdraw Item!");
                    }
                }
            }

            connection.Close();
        }

        //Subtract the stock in withrawal item

        public void subtractStock()
        {
            int val1 = Convert.ToInt32(txtCurrentStock.Text);
            int val2 = Convert.ToInt32(txtQuantity.Text);
            int total = val1 - val2;

            lbNewNoStock.Text = total.ToString();

            string updateQuery = "UPDATE table_products SET QUANTITY = '" + lbNewNoStock.Text + "' WHERE ITEMCODE='" + txtItemCode.Text + "'";
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
