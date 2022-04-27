using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Inventory_System_Management_Alliance28
{
    public partial class EditForm : Form
    {

        //Public variables --> will get and store the value from current sellected Row on DataGridView
        public string itemCode { get; set; }
        public string productName { get; set; }
        public string productCategory { get; set; }
        public string productQuantity { get; set; }
        public string productWarranty { get; set; }
        public string productDescription { get; set; }
        public string productImageName { get; set; }
        //end

        //Local Variables

        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        string category = "";
        string warranty = "";


        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            //Select first the text produtc name field
            txtProductName.Select();

            txtItemCode.Text = itemCode;
            txtProductName.Text = productName;
            cbCategory.SelectedItem = productCategory;
            txtQuantity.Text = productQuantity;
            txtDescription.Text = productDescription;
            cbWarranty.SelectedItem = productWarranty;

            Image img = Image.FromFile(Application.StartupPath + @"\Images\" + productImageName);
            pbItemImage.Image = img;

            if(lbImageFileName.Text == "")
            {
                updateIMG.Text = productImageName;
            }
        }

        
        //Codes for Updating prosucts

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //initialize Sql things
            string updatedQuery = "UPDATE table_products SET PRODUCTNAME='"+ txtProductName.Text + "',  CATEGORY='" + category + "',  QUANTITY='" + txtQuantity.Text + "',  WARRANTY='" + warranty + "',  DESCRIPTION='" + txtDescription.Text + "', IMAGE= '"+ updateIMG.Text +"' WHERE ITEMCODE = '"+ txtItemCode.Text +"'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand updateCommand = new MySqlCommand(updatedQuery, connection);
            MySqlDataReader reader;


            connection.Open();
            
            try {

                //check if there's an empty textfield

                if (txtItemCode.Text == "" || txtProductName.Text == "" || category == "" || warranty == "" || txtQuantity.Text == "" || txtDescription.Text == "" || updateIMG.Text == "")
                {
                    error.Visible = true;
                    error.Text = "Please fill out the form correctly!";
                }
                //check if quantity textfield is has numeric value
                else if (!int.TryParse(txtQuantity.Text, out int n))
                {
                    error.Visible = true;
                    error.Text = "Invalid QUANITY, please enter numeric value!";
                }
                else
                {
                    //ask for confirmation before updating the product
                    if(MessageBox.Show("Are you sure you want to update this Product?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //execute update command
                        reader = updateCommand.ExecuteReader();
                        MessageBox.Show("Updated Successfully!");
                        Hide();
                        error.Visible = false;
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

            //Make a copy of new Product image file
            if(lbImageFileName.Text != "")
            {
               
                File.Copy(lbImageFileName.Text, Application.StartupPath + @"\Images\" + Path.GetFileName(pbItemImage.ImageLocation), true);
    
            }

        }

        //ComboBoxes Select

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

                updateIMG.Text = Path.GetFileName(pbItemImage.ImageLocation);

                //Check if Image already existed

                string path = Application.StartupPath + @"\Images\" + Path.GetFileName(pbItemImage.ImageLocation);
                bool fileExist = File.Exists(path);

                if (fileExist)
                {

                    if (MessageBox.Show("Image already Existed!", "WARNING", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        //Reset the value if the Image file is already existing in the folder

                        Image img = Image.FromFile(Application.StartupPath + @"\Images\" + productImageName);
                        pbItemImage.Image = img;
                        updateIMG.Text = productImageName;
                        lbImageFileName.Text = "";
                    }
 
                }
            }
        }
        //Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //ask for confirmation before updating the product
            if (MessageBox.Show("Are you sure you want to cancel?", "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
            }
                
        }
        //Close form Button
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
