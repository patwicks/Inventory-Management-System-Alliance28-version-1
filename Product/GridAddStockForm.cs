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

namespace Inventory_System_Management_Alliance28.Product
{
    public partial class GridAddStockForm : Form
    {
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        public GridAddStockForm()
        {
            InitializeComponent();
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT PRODUCTNAME, QUANTITY,IMAGE,WARRANTY FROM table_products WHERE ITEMCODE = '" + txtItemCode.Text + "'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataReader reader;

            connection.Open();

            reader = searchCommand.ExecuteReader();
            try
            {

                if (txtItemCode.Text.Length >= 8)
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //MessageBox.Show("Item found");

                            txtProductName.Text = reader.GetValue(0).ToString();
                            txtCurrentStock.Text = reader.GetValue(1).ToString();
                            lbImage.Text = reader.GetValue(2).ToString();
                            txtCategory.Text = reader.GetValue(3).ToString();


                            Image image = Image.FromFile(Application.StartupPath + @"\Images\" + lbImage.Text);
                            pbItemImage.Image = image;
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            reader.Dispose();
            reader.Close();
            connection.Close();
        }
        private void GridAddStockForm_Load(object sender, EventArgs e)
        {
            txtItemCode.Select();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            //Validation

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
            else if (txtAdditional.Text == "")
            {
                error.Visible = true;
                error.Text = "Add Stock QUANTITY is required!";
            }
            else if (!int.TryParse(txtAdditional.Text, out int n))
            {
                error.Visible = true;
                error.Text = "Please input numerical value on ADDITIONAL STOCK!";
            }
            else if (Int32.Parse(txtAdditional.Text) <= 0)
            {
                error.Visible = true;
                error.Text = "Invalid QUANTITY!";
            }
            else
            {

                if (MessageBox.Show("Add Stock the Product?", "Add Stock Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                       AddStock();
                       MessageBox.Show("Successfully Added Stock!");
                       error.Visible = false;
                       error.Text = "";
                       Close();
                }
            }


        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Add stock in product items
        public void AddStock()
        {
            int val1 = Convert.ToInt32(txtCurrentStock.Text);
            int val2 = Convert.ToInt32(txtAdditional.Text);
            int total = val1 + val2;

            txtAdditional.Text = total.ToString();

            string updateQuery = "UPDATE table_products SET QUANTITY = '" + txtAdditional.Text + "' WHERE ITEMCODE='" + txtItemCode.Text + "'";
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
