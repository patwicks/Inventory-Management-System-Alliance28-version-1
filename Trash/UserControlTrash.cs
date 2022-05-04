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

namespace Inventory_System_Management_Alliance28.Trash
{
    public partial class UserControlTrash : UserControl
    {
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        MySqlDataAdapter dataAdapter, dataAdapter2;
        DataSet ds, ds2;
        public UserControlTrash()
        {
            InitializeComponent();
            //deleted product
            loadDeletedProducts();
            styleDataProductGrid();

            //Deleted Transaction
            loadDeletedTransactions();
            styleDataGridDelTransaction();

            cbMenu.SelectedIndex = 0;
        }

       
        //=========== LOAD DELETED PRODUCTS ==============//
        public void loadDeletedProducts()
        {
            string status = "Deleted";
            string loadQuery = "SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, TIMESTAMP, IMAGE FROM table_products WHERE STATUS = '" + status + "' ORDER BY PRODUCTNAME DESC";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);

            dataAdapter = new MySqlDataAdapter();
            ds = new DataSet();

            connection.Open();


            dataAdapter.SelectCommand = loadCommand;
            dataAdapter.Fill(ds);

            ds.Tables[0].Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridDeletedProduct.DataSource = ds.Tables[0];
            connection.Close();

        }

        //Styled datagridproduct
        private void styleDataProductGrid()
        {
            dataGridDeletedProduct.RowTemplate.Height = 40;

            dataGridDeletedProduct.Columns[1].Width = 50;
            dataGridDeletedProduct.Columns[1].Width = 150;
            dataGridDeletedProduct.Columns[2].Width = 200;
            dataGridDeletedProduct.Columns[3].Width = 150;
            dataGridDeletedProduct.Columns[4].Width = 150;
            dataGridDeletedProduct.Columns[5].Width = 150;
            dataGridDeletedProduct.Columns[6].Width = 200;
            dataGridDeletedProduct.Columns[7].Width = 150;
            dataGridDeletedProduct.Columns[8].Width = 150;
            dataGridDeletedProduct.Columns[9].Width = 100;
  


            foreach (DataGridViewColumn column in dataGridDeletedProduct.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }
            dataGridDeletedProduct.EnableHeadersVisualStyles = false;
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMenu.SelectedIndex == 0)
            {
                dataGridDeletedProduct.Visible = true;
                dataGridDeletedTransaction.Visible = false;
                lbHeaderText.Text = "Deleted Products";
            }
            else if (cbMenu.SelectedIndex == 1)
            {
                dataGridDeletedProduct.Visible = false;
                dataGridDeletedTransaction.Visible = true;
                lbHeaderText.Text = "Deleted Transactions";
            }
        }

        //=========== END ==============//

        //=========== LOAD DELETED TRANSACTION ==============//
        //load the data on gridView function
        public void loadDeletedTransactions()
        {
            string status = "Deleted";
            string loadQuery = "SELECT TRANSACTION_ID, CLIENT_NAME, PRODUCT_NAME, ITEM_CODE, QUANTITY, WARRANTY, TRANSACTION_TYPE, TIMESTAMP, IMAGE  FROM table_withdrawal WHERE STATUS = '" + status + "' ORDER BY TIMESTAMP DESC";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);

            connection.Open();

            dataAdapter2 = new MySqlDataAdapter();
            dataAdapter2.SelectCommand = loadCommand;
            ds2 = new DataSet();
            dataAdapter2.Fill(ds2);

            ds2.Tables[0].Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridDeletedTransaction.DataSource = ds2.Tables[0];

            connection.Close();

        }

        //Styled datagridTransaction
        public void styleDataGridDelTransaction()
        {
            dataGridDeletedTransaction.RowTemplate.Height = 40;

            dataGridDeletedTransaction.Columns[0].Width = 50; //Delete
            dataGridDeletedTransaction.Columns[1].Width = 318; //Transaction ID
            dataGridDeletedTransaction.Columns[2].Width = 200; //Client Name
            dataGridDeletedTransaction.Columns[3].Width = 200; //Product Name
            dataGridDeletedTransaction.Columns[4].Width = 150; //Item code
            dataGridDeletedTransaction.Columns[5].Width = 100; //Quantity
            dataGridDeletedTransaction.Columns[6].Width = 200; //Warranty

            dataGridDeletedTransaction.Columns[7].Width = 200; //Transaction type
            dataGridDeletedTransaction.Columns[8].Width = 200; //Withdrawal Date
            dataGridDeletedTransaction.Columns[9].Width = 150; //Image
            dataGridDeletedTransaction.Columns[10].Width = 100; //Picture


            foreach (DataGridViewColumn column in dataGridDeletedTransaction.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }
            dataGridDeletedTransaction.EnableHeadersVisualStyles = false;
        }
        //=========== END ==============//
    }
}
