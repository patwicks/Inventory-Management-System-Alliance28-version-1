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
    public partial class UserControlDashboard : UserControl
    {
        //Global variable
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        int counter, _counter;
        public UserControlDashboard()
        {
            InitializeComponent();

        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {   //recent added items
            recent_added();

            //Count Transaction
            countTransactions();
           //countprod 
            countProducts();

            //count Deleted products
            countDeletedProducts();

            //count account registered
            countAccounts();

            //recent withdraw item
            recent_withdraw();

            //datagrid
            datagrid_design();

          
            //current time and data
            //lbCurrentTime.Text = DateTime.Now.ToLongTimeString();
            lbCurrenDate.Text = DateTime.Now.ToLongDateString();
        }

        //count products
        public void countProducts()
        {
            string status = "Active";
            string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
            string searchQuery = "SELECT ITEMCODE FROM table_products WHERE STATUS ='" + status + "'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dt = new DataTable();

            adapter.SelectCommand = searchCommand;
            dt.Clear();
            adapter.Fill(dt);
            lbProduct.Text = dt.Rows.Count.ToString();
        }

        //count Deleted products
        public void countDeletedProducts()
        {
            string status = "Deleted";
            string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
            string searchQuery = "SELECT ITEMCODE FROM table_products WHERE STATUS ='"+ status +"'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dt = new DataTable();

            adapter.SelectCommand = searchCommand;
            dt.Clear();
            adapter.Fill(dt);
            lbDeletedItem.Text = dt.Rows.Count.ToString();
        }
        //count transactions
        public void countTransactions()
        {
            string status = "Active";
            string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
            string searchQuery = "SELECT TRANSACTION_ID FROM table_withdrawal WHERE STATUS = '" + status + "'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dt = new DataTable();

            adapter.SelectCommand = searchCommand;
            dt.Clear();
            adapter.Fill(dt);
            lbTransaction.Text = dt.Rows.Count.ToString();
        }

        //count account registered

        //count transactions
        public void countAccounts()
        {
            string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
            string searchQuery = "SELECT * FROM table_account";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dt = new DataTable();

            adapter.SelectCommand = searchCommand;
            dt.Clear();
            adapter.Fill(dt);
            lbAccount.Text = dt.Rows.Count.ToString();
        }
        //datagrid design
        public void datagrid_design()
        {
            dataGridProduct.RowTemplate.Height = 54;
            dataGridProduct.Columns[0].Width = 50;
            dataGridProduct.Columns[1].Width = 200;
            dataGridProduct.Columns[2].Width = 249;

            dataGridrecentW.RowTemplate.Height = 54;
            dataGridrecentW.Columns[0].Width = 50;
            dataGridrecentW.Columns[1].Width = 200;
            dataGridrecentW.Columns[2].Width = 249;

            //

            foreach (DataGridViewColumn column in dataGridProduct.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            foreach (DataGridViewColumn column in dataGridrecentW.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            dataGridProduct.EnableHeadersVisualStyles = false;
            dataGridrecentW.EnableHeadersVisualStyles = false;
        }
        //load recet withdraw items
        public void recent_withdraw()
        {
            string status = "Active";
            string loadQuery = "SELECT TRANSACTION_ID,ITEM_CODE,PRODUCT_NAME,QUANTITY,WARRANTY,TRANSACTION_TYPE,CLIENT_NAME,TIMESTAMP,IMAGE FROM table_withdrawal WHERE STATUS='"+ status +"' ORDER BY TIMESTAMP DESC LIMIT 5";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            connection.Open();

            dataAdapter.SelectCommand = loadCommand;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            dt.Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            foreach (DataRow row in dt.Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            _counter = dt.Rows.Count;
            dataGridrecentW.DataSource = dt;

            connection.Close();

            if (_counter > 0)
            {
                panelBgWithdraw.Visible = false;
                panelBgWithdraw.SendToBack();
            }
            else
            {
                panelBgWithdraw.Visible = true;
                panelBgWithdraw.BringToFront();
            }
        }
        //load recent added items
        public void recent_added()
        {
            string status = "Active";
            string loadQuery = "SELECT ITEMCODE,PRODUCTNAME,CATEGORY,QUANTITY,WARRANTY,DESCRIPTION,IMAGE,TIMESTAMP FROM TABLE_PRODUCTS WHERE STATUS = '"+ status +"' ORDER BY TIMESTAMP DESC LIMIT 5";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            connection.Open();


            dataAdapter.SelectCommand = loadCommand;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            dt.Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            foreach (DataRow row in dt.Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridProduct.DataSource = dt;
            counter = dt.Rows.Count;

            connection.Close();


            if (counter > 0)
            {
                panelBgProd.Visible = false;
                panelBgProd.SendToBack();
            }
            else
            {
                panelBgProd.Visible = true;
                panelBgProd.BringToFront();
            }
        }
       


        private void clock_Tick(object sender, EventArgs e)
        {
            lbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void dataGridProduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //wrong
        }

        private void dataGridrecentW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Wrong
            
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridProduct.Columns[e.ColumnIndex].Name == "VIEW")
            {
                Details ViewForm = new Details();
                //RECENT ADDED ITEM
                dataGridProduct.CurrentRow.Selected = true;
                ViewForm.itemCode = dataGridProduct.Rows[e.RowIndex].Cells["ITEMCODE"].FormattedValue.ToString();
                ViewForm.productName = dataGridProduct.Rows[e.RowIndex].Cells["PRODUCTNAME"].FormattedValue.ToString();
                ViewForm.productCategory = dataGridProduct.Rows[e.RowIndex].Cells["CATEGORY"].FormattedValue.ToString();
                ViewForm.productQuantity = dataGridProduct.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString();
                ViewForm.productWarranty = dataGridProduct.Rows[e.RowIndex].Cells["WARRANTY"].FormattedValue.ToString();
                ViewForm.productDescription = dataGridProduct.Rows[e.RowIndex].Cells["DESCRIPTION"].FormattedValue.ToString();
                ViewForm.productImageName = dataGridProduct.Rows[e.RowIndex].Cells["IMAGE"].FormattedValue.ToString();
                ViewForm.productTimestamp = dataGridProduct.Rows[e.RowIndex].Cells["TIMESTAMP"].FormattedValue.ToString();
                ViewForm.ShowDialog();


            }
        }

        private void dataGridrecentW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //RECENT WITHDRAW ITEM
            if (dataGridrecentW.Columns[e.ColumnIndex].Name == "wVIEW")
            {
                ViewFormWithdraw Withdrawform = new ViewFormWithdraw();
                dataGridrecentW.CurrentRow.Selected = true;
                Withdrawform.Wtransaction_id = dataGridrecentW.Rows[e.RowIndex].Cells["TRANSACTION_ID"].FormattedValue.ToString();
                Withdrawform.Witemcode = dataGridrecentW.Rows[e.RowIndex].Cells["ITEM_CODE"].FormattedValue.ToString();
                Withdrawform.Wproductname = dataGridrecentW.Rows[e.RowIndex].Cells["PRODUCT_NAME"].FormattedValue.ToString();
                Withdrawform.Wquantity = dataGridrecentW.Rows[e.RowIndex].Cells["PQUANTITY"].FormattedValue.ToString();
                Withdrawform.Wtransaction_type = dataGridrecentW.Rows[e.RowIndex].Cells["TRANSACTION_TYPE"].FormattedValue.ToString();
                Withdrawform.Wclient_name = dataGridrecentW.Rows[e.RowIndex].Cells["CLIENT_NAME"].FormattedValue.ToString();
                Withdrawform.Wtimestamp = dataGridrecentW.Rows[e.RowIndex].Cells["PTIMESTAMP"].FormattedValue.ToString();
                Withdrawform.Wimage = dataGridrecentW.Rows[e.RowIndex].Cells["PIMAGE"].FormattedValue.ToString();
                Withdrawform.Wwarranty = dataGridrecentW.Rows[e.RowIndex].Cells["WARRANTY"].FormattedValue.ToString();
                Withdrawform.ShowDialog();
            }
        }

       
    }
}
