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

namespace Inventory_System_Management_Alliance28.Widthdrawal
{
    public partial class ReturnItem : Form
    {
        public string transactionId { get; set; }
        public string clientName { get; set; }
        public string productName { get; set; }
        public string itemCode { get; set; }
        public string quantity { get; set; }
        public string warranty { get; set; }
        public string transactionType { get; set; }
        public string withdrawalDate { get; set; }
        public string image { get; set; }

        //local Global variable
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        public ReturnItem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReturnItem_Load(object sender, EventArgs e)
        {
            //Select field

            txtTotalReturn.Select();

            txtTransactionID.Text = transactionId;
            txtClientName.Text = clientName;
            txtProductName.Text = productName;
            txtItemCode.Text = itemCode;
            txtQuantity.Text = quantity;
            txtWarranty.Text = warranty;
            txtTransactionType.Text = transactionType;
            txtWithdrawalDate.Text = withdrawalDate;

            Image IMAGE = Image.FromFile(Application.StartupPath + @"\Images\" + image);
            pbItemImage.Image = IMAGE;

            //get the current stock first

            getTheCurrentStock();

            //create new ID for return TransacID + currentDateTime

            string str = DateTime.Now.ToString(); ;
            string[] charsToRemove = new string[] { "/", ":", " " };
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            }

            string newTransactionID = (txtTransactionID.Text +"-"+ str);
            lbNewID.Text = newTransactionID;

        }

        private void getTheCurrentStock()
        {
            string searchQuery = "SELECT QUANTITY FROM table_products WHERE ITEMCODE ='" + txtItemCode.Text + "' ";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataReader reader;
            connection.Open();
            try {

                reader = searchCommand.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                       lbCurrentStock.Text = reader.GetValue(0).ToString();
                    }
                }
            
            } 
            catch(Exception)
            {
                MessageBox.Show("Cannot find the products quantity!");
            }
            connection.Close();
        }

        private void txtTotalReturn_TextChanged(object sender, EventArgs e)
        {
            //
        }

        

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTotalReturn.Text, out int n))
            {
                error.Visible = true;
                error.Text = "Please input valid Quantity!";
            }
            else if (int.Parse(txtTotalReturn.Text) <= 0)
            {
                error.Visible = true;
                error.Text = "Input must be greater than Zero!";
            }
            else if (int.Parse(txtTotalReturn.Text) > int.Parse(txtQuantity.Text))
            {
                error.Visible = true;
                error.Text = "Please input valid Quantity!";
            }
            else
            {
                error.Visible = false;

                if(int.Parse(txtTotalReturn.Text ) == int.Parse(txtQuantity.Text))
                {
                    removeToTransaction();
                    
                }
                else
                {
                    //update transaction by quantity
                    updateTransaction();
                }
            }
        }

        //remove
        private void removeToTransaction()
        {
            string status = "Return";
            string removeQuery = "UPDATE table_withdrawal SET STATUS='" + status + "' WHERE TRANSACTION_ID='" + txtTransactionID.Text + "' ";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand removeCommand = new MySqlCommand(removeQuery, connection);
            MySqlDataReader reader;



            connection.Open();

            try
            {

                if (MessageBox.Show("Do you want to return this Items?", "Return Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    reader = removeCommand.ExecuteReader();
                    updateQuantityProduct();
                    MessageBox.Show("Returned succesfully!");
                    Close();
                } 
              
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, try again!");
            }

            connection.Close();
        }

        private void updateQuantityProduct()
        {
            int val = int.Parse(txtTotalReturn.Text) + int.Parse(lbCurrentStock.Text);
            string newQuantity = val.ToString();
            string updateQuery = "UPDATE table_products SET QUANTITY='" + newQuantity + "' WHERE ITEMCODE='" + txtItemCode.Text + "' ";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
            MySqlDataReader reader;

            connection.Open();
            try { 
                //execute update command
                reader = updateCommand.ExecuteReader();
            } catch(Exception)
            {
                MessageBox.Show("Something went wrong on updating Quantity!");
            }
            connection.Close();
        }

        //Update transaction if the return items is not equal to total withdraw items
        private void updateTransaction()
        {
            int totalReturn = int.Parse(txtTotalReturn.Text);
            int currentValue = int.Parse(txtQuantity.Text);

            int val = currentValue - totalReturn;

            string newQuantity = val.ToString();
            string updateQuery = "UPDATE table_withdrawal SET QUANTITY='" + newQuantity + "' WHERE TRANSACTION_ID='" + txtTransactionID.Text + "' ";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
            MySqlDataReader reader;

            connection.Open();

            try
            {

                if (MessageBox.Show("Do you want to return this Items?", "Return Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    reader = updateCommand.ExecuteReader();
                    updateQuantityProduct();
                    saveReturnItemTransaction();
                    MessageBox.Show("Returned succesfully!");
                    Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, try again!");
            }

            connection.Close();
        }

        //Save the Return Transaction

        private void saveReturnItemTransaction()
        {
            //Sql staffs here
            string transactionType = "Widthraw";
            string status = "Return";

            string insertQuery = "INSERT INTO table_withdrawal(TRANSACTION_ID, ITEM_CODE, PRODUCT_NAME, QUANTITY, WARRANTY, TRANSACTION_TYPE, CLIENT_NAME, STATUS, IMAGE) VALUES('" + lbNewID.Text + "', '" + txtItemCode.Text + "', '" + txtProductName.Text + "', '" + txtTotalReturn.Text + "' , '" + txtWarranty.Text + "', '" + transactionType + "' , '" + txtClientName.Text + "', '" + status + "', '" + image + "' )";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

            connection.Open();
            try {

               insertCommand.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Something Went wrong on saving Return Transaction! "  + ex.Message);
            }

            connection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel returning item process?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}