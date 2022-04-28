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
using Microsoft.VisualBasic;

namespace Inventory_System_Management_Alliance28.Widthdrawal
{
   
   
    public partial class DeleteTransaction : Form
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
        public DeleteTransaction()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void DeleteTransaction_Load(object sender, EventArgs e)
        {
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string status = "Deleted";
            string deleteQuery = "UPDATE table_withdrawal SET STATUS='" + status + "' WHERE ITEMCODE='" + txtTransactionID.Text + "' ";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
            MySqlDataReader reader;

            connection.Open();
            try
            {


                string message, title, defaultValue;
                object value;

                message = "Please enter the Transaction ID to delete this Transaction / " + txtTransactionID.Text + " /:";
                title = "Delete Confirmation";
                defaultValue = "";
                value = Interaction.InputBox(message, title, defaultValue);

                if (value.ToString() == txtTransactionID.Text)
                {
                    reader = deleteCommand.ExecuteReader();
                    MessageBox.Show("Transaction with ID of / " + txtTransactionID.Text + " / was succesfully Deleted!");
                    Hide();
                }
                else
                {
                    MessageBox.Show("Try again...");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, try again!");
            }
            connection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel deleting?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
            }
        }
    }
}
