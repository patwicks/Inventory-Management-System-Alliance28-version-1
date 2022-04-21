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
using System.IO;

namespace Inventory_System_Management_Alliance28
{
    public partial class AddProduct : Form
    {
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        string category = "";
        string warranty = "";
        public AddProduct()
        {
            InitializeComponent();
        }

        //close icon in picturebox
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //save button
        private void btnSave_Click(object sender, EventArgs e)
        {

            string searchQuery = "SELECT ITEMCODE FROM table_products WHERE ITEMCODE='" + txtItemCode.Text + "'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataReader reader;

            connection.Open();
            reader = searchCommand.ExecuteReader();
            try
            {
                //check if there's an empty textfield

                if (txtItemCode.Text == "" || txtProductName.Text == "" || category == "" || warranty == "" || txtQuantity.Text == "" || txtDescription.Text == "")
                {
                    error.Visible = true;
                    error.Text = "Please fill out the form correctly!";
                }
                //check if Item code character lenght is correct
                else if (txtItemCode.Text.Length != 8 || txtItemCode.Text.Length > 12)
                {
                    error.Visible = true;
                    error.Text = "ITEM CODE must be 8 or less than 12 characters!";

                }
                //check if quantity textfield is has numeric value
                else if (!int.TryParse(txtQuantity.Text, out int n))
                {

                    error.Visible = true;
                    error.Text = "Invalid QUANITY, please enter numeric value!";
                }
                else if (lbImageFileName.Text == "")
                {
                    error.Visible = true;
                    error.Text = "Please select an Image!";
                }
                else
                {


                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            error.Visible = true;
                            error.Text = "ITEM CODE or PRODUCT already existed";
                        }
                    }
                    else
                    {
                        //ask for confirmation before updating the product
                        if (MessageBox.Show("Save the product?", "Save Product", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            saveNewProduct();
                        }
                        
                    }
                }

            }
            catch (Exception ex)
            {
                error.Visible = true;
                //error.Text = "Something went wrong, try again!";

                error.Text = ex.Message;
            }

            reader.Close();
            connection.Close();

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = cbCategory.SelectedItem.ToString();
        }

        private void cbWarranty_SelectedIndexChanged(object sender, EventArgs e)
        {
            warranty = cbWarranty.SelectedItem.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*jpg; *jpeg; *png;) | *jpg; *jpeg; *png;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                lbImageFileName.Text = openFile.FileName;
                pbItemImage.Image = new Bitmap(openFile.FileName);
                pbItemImage.ImageLocation = openFile.FileName;
                pbItemImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //function to save the new product

        private void saveNewProduct()
        {
            string insertQuery = "INSERT INTO table_products(ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, IMAGE) VALUES('" + txtItemCode.Text + "', '" + txtProductName.Text + "','" + category + "', '" + txtQuantity.Text + "','" + warranty + "','" + txtDescription.Text + "', '" + Path.GetFileName(pbItemImage.ImageLocation) + "')";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

            connection.Open();
            int returnValue = insertCommand.ExecuteNonQuery();

            try
            {

                if (returnValue == 1)
                {
                    MessageBox.Show("Product successfully added!");
                    this.Hide();
                }
                else
                {
                    error.Text = "Failed to add the product, try again.";
                }

            }
            catch (Exception ex)
            {

                error.Text = "Something went wrong please try again.";
                error.Text = ex.Message;
            }
            connection.Close();
            File.Copy(lbImageFileName.Text, Application.StartupPath + @"\Images\" + Path.GetFileName(pbItemImage.ImageLocation));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //ask for confirmation before updating the product
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
            }
        }
    }
}
