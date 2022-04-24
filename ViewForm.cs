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
    public partial class Details : Form
    {//Public variables --> will get and store the value from current sellected Row on DataGridView
       //RECENT ADDED ITEMS
        public string itemCode { get; set; }
        public string productName { get; set; }
        public string productCategory { get; set; }
        public string productQuantity { get; set; }
        public string productWarranty { get; set; }
        public string productDescription { get; set; }
        public string productImageName { get; set; }
        public string productTimestamp { get; set; }

        //end
        public Details()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            //Select first the text produtc name field
            txtProductName.Select();



            txtItemCode.Text = itemCode;
            txtProductName.Text = productName;
            txtCategory.Text = productCategory;
            txtQuantity.Text = productQuantity;
            txtDescription.Text = productDescription;
            txtWarranty.Text = productWarranty;
            txtDateAdded.Text = productTimestamp;

            Image img = Image.FromFile(Application.StartupPath + @"\Images\" + productImageName);
            pbItemImage.Image = img;
        }
    }
}
