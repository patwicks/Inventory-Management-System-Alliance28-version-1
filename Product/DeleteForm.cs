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

namespace Inventory_System_Management_Alliance28
{

    public partial class DeleteForm : Form
    {
        //Public variables --> will get and store the value from current sellected Row on DataGridView
        public string itemCode { get; set; }
        public string productName { get; set; }
        public string productCategory { get; set; }
        public string productQuantity { get; set; }
        public string productWarranty { get; set; }
        public string productDateAdded { get; set; }
        public string productDescription { get; set; }
        public string productImageName { get; set; }

        //end
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            txtItemCode.Text = itemCode;
            txtProductName.Text = productName;
            txtCategory.Text = productCategory;
            txtQuantity.Text = productQuantity;
            txtDescription.Text = productDescription;
            txtDateAdded.Text = productDateAdded;
            txtWarranty.Text = productWarranty;

            Image img = Image.FromFile(Application.StartupPath + @"\Images\" + productImageName);
            pbItemImage.Image = img;
        }
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string status = "Deleted";
            string deleteQuery = "UPDATE table_products SET STATUS='" + status + "' WHERE ITEMCODE='"+txtItemCode.Text +"' ";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
            MySqlDataReader reader;

            connection.Open();
            try
            {

                
                string message, title, defaultValue;
                object value;

                message = "Please enter the ITEM CODE to delete this product / "+ txtItemCode.Text +" /:";
                title = "Delete Confirmation";
                defaultValue = "";
                value = Interaction.InputBox(message, title, defaultValue);

                if(value.ToString() == txtItemCode.Text)
                {
                    reader = deleteCommand.ExecuteReader();
                    MessageBox.Show("Product with item code / " + txtItemCode.Text + " / was succesfully Deleted!");
                    Close();
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
            if(MessageBox.Show("Do you want to cancel deleting?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                Close();
            }
        }

        private void pbCopyID_MouseHover(object sender, EventArgs e)
        {
            pbCopyID.Width = 27;
            pbCopyID.Height = 22;
        }

        private void pbCopyID_MouseLeave(object sender, EventArgs e)
        {
            pbCopyID.Width = 25;
            pbCopyID.Height = 20;
        }

        private void pbCopyID_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtItemCode.Text);

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(pbCopyID, "Copied!");
        }

      
    }
}
