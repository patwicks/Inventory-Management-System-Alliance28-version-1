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

        private void UserControlTransaction_Load(object sender, EventArgs e)
        {
            //style grid
            styleDataGrid();
            //load data transaction - withdrawal
            loadTransactions();
        }

        //load the data on gridView function
        public void loadTransactions()
        {
            string status = "Active";
            string loadQuery = "SELECT TRANSACTION_ID, CLIENT_NAME, PRODUCT_NAME, ITEM_CODE, QUANTITY, WARRANTY, TRANSACTION_TYPE, TIMESTAMP, IMAGE  FROM table_withdrawal WHERE STATUS = '" + status + "' ORDER BY TIMESTAMP ASC";
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
            dataGridTransaction.DataSource = dt;



            connection.Close();

        }

        //Styled datagridproduct
        public void styleDataGrid()
        {
            dataGridTransaction.RowTemplate.Height = 50;

            dataGridTransaction.Columns[0].Width = 50; //Copy
            dataGridTransaction.Columns[1].Width = 250; //Transaction ID
            dataGridTransaction.Columns[2].Width = 200; //Client Name
            dataGridTransaction.Columns[3].Width = 200; //Product Name
            dataGridTransaction.Columns[4].Width = 150; //Item code
            dataGridTransaction.Columns[5].Width = 100; //Quantity
            dataGridTransaction.Columns[6].Width = 200; //Warranty

            dataGridTransaction.Columns[7].Width = 150; //Transaction type
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
            DataTable dt;
            string status = "Active";

            connection.Open();

            adapter = new MySqlDataAdapter("SELECT TRANSACTION_ID, CLIENT_NAME, ITEM_CODE, PRODUCT_NAME, TRANSACTION_TYPE, WARRANTY, QUANTITY, TIMESTAMP, IMAGE  FROM table_withdrawal WHERE (TRANSACTION_ID LIKE '" + txtSearch.Text + "%' || CLIENT_NAME LIKE '" + txtSearch.Text + "%') AND (STATUS='" + status + "') ", connection);
            dt = new DataTable();

            adapter.Fill(dt);


            dt.Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            foreach (DataRow row in dt.Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"/Images/" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridTransaction.DataSource = dt;

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
                delTransaction.Show();
            }
            else if (dataGridTransaction.Columns[e.ColumnIndex].Name == "RETURN")
            {
                //
            }
        }
    }
}
