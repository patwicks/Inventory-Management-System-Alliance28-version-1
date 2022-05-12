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

namespace Inventory_System_Management_Alliance28.Delete
{
    public partial class UserControlDelete : UserControl
    {
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        MySqlDataAdapter dataAdapter, dataAdapter2;
        DataSet ds, ds2;

        int counter, _counter;

        public UserControlDelete()
        {
            InitializeComponent();


            styleDataProductGrid();
            styleDataGridDelTransaction();

            countProducts();
            countTransactions();

            cbMenu.SelectedIndex = 0;

        }

        private void UserControlDelete_Load(object sender, EventArgs e)
        {
            //nothing
        }
        //==================================Product table==================================//

        private void dataGridDeletedProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridDeletedProduct.Columns[e.ColumnIndex].Name == "DELETE_PRODUCT")
            {
                dataGridDeletedProduct.CurrentRow.Selected = true;
                string idToBeDeleted = dataGridDeletedProduct.Rows[e.RowIndex].Cells["ITEMCODE"].FormattedValue.ToString();

                string deletQuery = "DELETE FROM table_products WHERE ITEMCODE='" + idToBeDeleted + "'";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand deleteCommand = new MySqlCommand(deletQuery, connection);
                MySqlDataReader reader;
                connection.Open();
                try
                {
                    if (MessageBox.Show("Delete this product data permanently?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        reader = deleteCommand.ExecuteReader();
                        MessageBox.Show("Deleted Successfully!");
                        loadDeletedProducts();
                        countProducts();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong try again! " + ex.Message);
                }
                connection.Close();


            }

        }



        //count products
        public void countProducts()
        {

            try
            {
                string status = "Deleted";
                string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
                string searchQuery = "SELECT ITEMCODE FROM table_products WHERE STATUS ='" + status + "'";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                DataTable dt = new DataTable();
                connection.Open();
                adapter.SelectCommand = searchCommand;
                dt.Clear();
                adapter.Fill(dt);

                counter = dt.Rows.Count;

                connection.Close();

                if (counter > 0)
                {
                    panelBgProd.Visible = false;
                }
                else
                {
                    panelBgProd.Visible = true;
                }
                panelBgTrans.Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while counting data product from database!");
            }
        }
        //=========== LOAD DELETED PRODUCTS ==============//
        public void loadDeletedProducts()
        {
            string status = "Deleted";
            string loadQuery = "SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, IMAGE FROM table_products WHERE STATUS = '" + status + "' ORDER BY PRODUCTNAME DESC";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);

            dataAdapter = new MySqlDataAdapter();
            ds = new DataSet();
            connection.Open();
            try
            {
                dataAdapter.SelectCommand = loadCommand;
                dataAdapter.Fill(ds);

                ds.Tables[0].Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
                }
                dataGridDeletedProduct.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while fetching data from database!");
            }
            connection.Close();

        }

        //Styled datagridproduct
        private void styleDataProductGrid()
        {
            dataGridDeletedProduct.RowTemplate.Height = 40;

            dataGridDeletedProduct.Columns[0].Width = 50;
            dataGridDeletedProduct.Columns[1].Width = 150;
            dataGridDeletedProduct.Columns[2].Width = 200;
            dataGridDeletedProduct.Columns[3].Width = 150;
            dataGridDeletedProduct.Columns[4].Width = 150;
            dataGridDeletedProduct.Columns[5].Width = 150;
            dataGridDeletedProduct.Columns[6].Width = 200;
            dataGridDeletedProduct.Columns[7].Width = 150;
            dataGridDeletedProduct.Columns[8].Width = 100;


            foreach (DataGridViewColumn column in dataGridDeletedProduct.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }
            dataGridDeletedProduct.EnableHeadersVisualStyles = false;
        }


        //==================================Transaction table==================================//


        public void loadDeletedTransactions()
        {
            string status = "Deleted";
            string loadQuery = "SELECT TRANSACTION_ID, CLIENT_NAME, PRODUCT_NAME, ITEM_CODE, QUANTITY, WARRANTY, TRANSACTION_TYPE, TIMESTAMP, IMAGE  FROM table_withdrawal WHERE STATUS = '" + status + "' ORDER BY TIMESTAMP DESC";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);

            connection.Open();
            try
            {
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

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while fetching data from database!");
            }
            connection.Close();

        }

        //Delete Transaction permanently
        private void dataGridDeletedTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDeletedTransaction.Columns[e.ColumnIndex].Name == "DELETE_TRANSACTION")
            {
                dataGridDeletedTransaction.CurrentRow.Selected = true;
                string idToBeDeleted = dataGridDeletedTransaction.Rows[e.RowIndex].Cells["TRANSACTION_ID"].FormattedValue.ToString();

                string deletQuery = "DELETE FROM table_withdrawal WHERE TRANSACTION_ID='" + idToBeDeleted + "'";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand deleteCommand = new MySqlCommand(deletQuery, connection);
                MySqlDataReader reader;
                connection.Open();
                try
                {
                    if (MessageBox.Show("Delete this transaction data permanently?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        reader = deleteCommand.ExecuteReader();
                        MessageBox.Show("Deleted Successfully!");
                        loadDeletedTransactions();
                        countTransactions();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong try again! " + ex.Message);
                }
                connection.Close();

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDeletedTransactions();
            loadDeletedProducts();

            countTransactions();
            countProducts();
        }

        //count Deleted transactions
        public void countTransactions()
        {
            try
            {

                string status = "Deleted";
                string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
                string searchQuery = "SELECT TRANSACTION_ID FROM table_withdrawal WHERE STATUS = '" + status + "'";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                connection.Open();
                DataTable dt = new DataTable();

                adapter.SelectCommand = searchCommand;
                dt.Clear();
                adapter.Fill(dt);
                _counter = dt.Rows.Count;
                connection.Close();
                if (_counter > 0)
                {
                    panelBgTrans.Visible = false;

                }
                else
                {

                    panelBgTrans.Visible = true;

                }

                panelBgProd.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while fetching data from database!");
            }
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


        //Menu


        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMenu.SelectedIndex == 0)
            {
                dataGridDeletedProduct.Visible = false;
                dataGridDeletedTransaction.Visible = true;
                lbHeaderText.Text = "Deleted Transactions";

                if (_counter > 0)
                {
                    panelBgTrans.Visible = false;

                }
                else
                {

                    panelBgTrans.Visible = true;

                }

                panelBgProd.Visible = false;

            }
            else if (cbMenu.SelectedIndex == 1)
            {
                dataGridDeletedProduct.Visible = true;
                dataGridDeletedTransaction.Visible = false;
                lbHeaderText.Text = "Deleted Products";

                if (counter > 0)
                {
                    panelBgProd.Visible = false;
                }
                else
                {
                    panelBgProd.Visible = true;
                }
                panelBgTrans.Visible = false;
            }
        }
    }
}
