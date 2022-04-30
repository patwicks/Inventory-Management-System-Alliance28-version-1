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

namespace Inventory_System_Management_Alliance28.Stocks
{
    public partial class AddStock : Form
    {
        //Public variables --> will get and store the value from current sellected Row on DataGridView
        public string itemCode { get; set; }
        public string productName { get; set; }
        public string productCategory { get; set; }
        public string productQuantity { get; set; }
        public string productImageName { get; set; }

        public AddStock()
        {
            InitializeComponent();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            txtItemCode.Text = itemCode;
            txtProductName.Text = productName;
            txtCategory.Text = productCategory;
            txtCurrentStock.Text = productQuantity;

            Image image = Image.FromFile(Application.StartupPath + @"\Images\" + productImageName);
            pbItemImage.Image = image;
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel adding Stock?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            int valCurrent = int.Parse(txtCurrentStock.Text);
            int valAdd;
            int total;
            if (txtAdditional.Text != "" && int.TryParse(txtAdditional.Text, out int n))
            {
                valAdd = int.Parse(txtAdditional.Text);
                total = valCurrent + valAdd;
                lbTotal.Text = total.ToString();
            }

            string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
            string AddStockQuery = "UPDATE table_products SET QUANTITY='" + lbTotal.Text + "' WHERE ITEMCODE='" + txtItemCode.Text + "'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand addCommand = new MySqlCommand(AddStockQuery, connection);
            MySqlDataReader reader;

            connection.Open();
            try
            {

                if (txtAdditional.Text == "")
                {
                    error.Visible = true;
                    error.Text = "Addtional Stock is required!";
                }
                else if (!int.TryParse(txtAdditional.Text, out int nn))
                {
                    error.Visible = true;
                    error.Text = "Input should be a numeric value!";
                }
                else if (int.Parse(txtAdditional.Text) <= 0)
                {
                    error.Visible = true;
                    error.Text = "Invalid Quantity!";
                }

                else
                {
                    //execute update command
                    if (MessageBox.Show("Add " + lbTotal.Text + " stock to product " + txtItemCode.Text + " ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        reader = addCommand.ExecuteReader();
                        MessageBox.Show("Stocks successfully added!");
                        Hide();
                    }

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong on adding Stock");
            }

            connection.Close();
        }
    }
}
