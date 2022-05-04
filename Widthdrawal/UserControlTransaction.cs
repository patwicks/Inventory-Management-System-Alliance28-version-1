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
using Microsoft.VisualBasic;

namespace Inventory_System_Management_Alliance28.Widthdrawal
{
    public partial class UserControlTransaction : UserControl
    {
        public UserControlTransaction()
        {
            InitializeComponent();
        }
        //Global variable
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        MySqlDataAdapter dataAdapter;
        DataSet ds;

        //limit
        int maxCount = 10;
        int pageVal;
        int totalRow;

  

        private void UserControlTransaction_Load(object sender, EventArgs e)
        {
            //style grid
            styleDataGrid();
            //load data transaction - withdrawal
            loadTransactions();
            pageVal = 0;

            //row counter
            countTransactions();
        }

        //count the total transaction

        public void countTransactions()
        {
            string status = "Active";
            string searchQuery = "SELECT TRANSACTION_ID FROM table_withdrawal WHERE STATUS = '" + status + "'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dt = new DataTable();

            adapter.SelectCommand = searchCommand;
            dt.Clear();
            adapter.Fill(dt);
            totalRow = dt.Rows.Count;
        }

        //load the data on gridView function
        public void loadTransactions()
        {
            string status = "Active";
            string loadQuery = "SELECT TRANSACTION_ID, CLIENT_NAME, PRODUCT_NAME, ITEM_CODE, QUANTITY, WARRANTY, TRANSACTION_TYPE, TIMESTAMP, IMAGE  FROM table_withdrawal WHERE STATUS = '" + status + "' ORDER BY TIMESTAMP DESC";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);

            connection.Open();

            dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = loadCommand;
            ds = new DataSet();
            dataAdapter.Fill(ds, pageVal, maxCount, "table_widthdrawal");

            ds.Tables[0].Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridTransaction.DataSource = ds.Tables[0];

            connection.Close();
            txtSearch.Text = null;

        }

        //Styled datagridTransaction
        public void styleDataGrid()
        {
            dataGridTransaction.RowTemplate.Height = 59;

            dataGridTransaction.Columns[0].Width = 50; //Copy
            dataGridTransaction.Columns[1].Width = 318; //Transaction ID
            dataGridTransaction.Columns[2].Width = 200; //Client Name
            dataGridTransaction.Columns[3].Width = 200; //Product Name
            dataGridTransaction.Columns[4].Width = 150; //Item code
            dataGridTransaction.Columns[5].Width = 100; //Quantity
            dataGridTransaction.Columns[6].Width = 200; //Warranty

            dataGridTransaction.Columns[7].Width = 200; //Transaction type
            dataGridTransaction.Columns[8].Width = 200; //Withdrawal Date
            dataGridTransaction.Columns[9].Width = 150; //Image
            dataGridTransaction.Columns[10].Width = 100; //Picture
            dataGridTransaction.Columns[11].Width = 50; //Delete
            dataGridTransaction.Columns[12].Width = 50; //Return


            foreach (DataGridViewColumn column in dataGridTransaction.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            dataGridTransaction.EnableHeadersVisualStyles = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter adapter;
            DataSet ds;
            string status = "Active";

            connection.Open();


            if (txtSearch.Text != "") {

                adapter = new MySqlDataAdapter("SELECT TRANSACTION_ID, CLIENT_NAME, PRODUCT_NAME, ITEM_CODE, QUANTITY, WARRANTY, TRANSACTION_TYPE, TIMESTAMP, IMAGE  FROM table_withdrawal WHERE (TRANSACTION_ID LIKE '" + txtSearch.Text + "%' || CLIENT_NAME LIKE '" + txtSearch.Text + "%') AND (STATUS='" + status + "') ", connection);
                ds = new DataSet();

                adapter.Fill(ds);


                ds.Tables[0].Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"/Images/" + Path.GetFileName(row["IMAGE"].ToString()));
                }
                dataGridTransaction.DataSource = ds.Tables[0];

                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                loadTransactions();
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }
            connection.Close();
        }

        private void dataGridTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridTransaction.Columns[e.ColumnIndex].Name == "COPY")
            {
                dataGridTransaction.CurrentRow.Selected = true;
                System.Windows.Forms.Clipboard.SetText(dataGridTransaction.Rows[e.RowIndex].Cells["TRANSACTION_ID"].FormattedValue.ToString());
                MessageBox.Show("Copied to clipboard " + dataGridTransaction.Rows[e.RowIndex].Cells["TRANSACTION_ID"].FormattedValue.ToString());
            }
            else if(dataGridTransaction.Columns[e.ColumnIndex].Name == "DELETE")
            {
                dataGridTransaction.CurrentRow.Selected = true;
                DeleteTransaction delTransaction = new DeleteTransaction();
                delTransaction.transactionId = dataGridTransaction.Rows[e.RowIndex].Cells["TRANSACTION_ID"].FormattedValue.ToString();
                delTransaction.productName = dataGridTransaction.Rows[e.RowIndex].Cells["PRODUCT_NAME"].FormattedValue.ToString();
                delTransaction.clientName = dataGridTransaction.Rows[e.RowIndex].Cells["CLIENT_NAME"].FormattedValue.ToString();
                delTransaction.itemCode = dataGridTransaction.Rows[e.RowIndex].Cells["ITEM_CODE"].FormattedValue.ToString();
                delTransaction.warranty = dataGridTransaction.Rows[e.RowIndex].Cells["WARRANTY"].FormattedValue.ToString();
                delTransaction.quantity = dataGridTransaction.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString();
                delTransaction.transactionType = dataGridTransaction.Rows[e.RowIndex].Cells["TRANSACTION_TYPE"].FormattedValue.ToString();
                delTransaction.withdrawalDate = dataGridTransaction.Rows[e.RowIndex].Cells["WITHDRAWAL_DATE"].FormattedValue.ToString();
                delTransaction.image = dataGridTransaction.Rows[e.RowIndex].Cells["IMAGE"].FormattedValue.ToString();
                delTransaction.ShowDialog();
            }
            else if (dataGridTransaction.Columns[e.ColumnIndex].Name == "RETURN")
            {
                dataGridTransaction.CurrentRow.Selected = true;
                ReturnItem returnForm = new ReturnItem();
                returnForm.transactionId = dataGridTransaction.Rows[e.RowIndex].Cells["TRANSACTION_ID"].FormattedValue.ToString();
                returnForm.productName = dataGridTransaction.Rows[e.RowIndex].Cells["PRODUCT_NAME"].FormattedValue.ToString();
                returnForm.clientName = dataGridTransaction.Rows[e.RowIndex].Cells["CLIENT_NAME"].FormattedValue.ToString();
                returnForm.itemCode = dataGridTransaction.Rows[e.RowIndex].Cells["ITEM_CODE"].FormattedValue.ToString();
                returnForm.warranty = dataGridTransaction.Rows[e.RowIndex].Cells["WARRANTY"].FormattedValue.ToString();
                returnForm.quantity = dataGridTransaction.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString();
                returnForm.transactionType = dataGridTransaction.Rows[e.RowIndex].Cells["TRANSACTION_TYPE"].FormattedValue.ToString();
                returnForm.withdrawalDate = dataGridTransaction.Rows[e.RowIndex].Cells["WITHDRAWAL_DATE"].FormattedValue.ToString();
                returnForm.image = dataGridTransaction.Rows[e.RowIndex].Cells["IMAGE"].FormattedValue.ToString();
                returnForm.ShowDialog();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadTransactions();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ReturnHistory returnForm = new ReturnHistory();
            returnForm.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageVal = pageVal + 10;
            if (pageVal > totalRow)
            {
                pageVal = 0;
            }
            ds.Clear();
            dataAdapter.Fill(ds, pageVal, maxCount, "table_widthdrawal");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pageVal = pageVal - 10;
            if(pageVal <= 0)
            {
                pageVal = 0;
            }
            ds.Clear();
            dataAdapter.Fill(ds, pageVal, maxCount, "table_widthdrawal");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            }

        }
    }
}
