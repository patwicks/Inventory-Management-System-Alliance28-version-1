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
            string loadQuery = "SELECT TRANSACTION_ID, CLIENT_NAME, ITEM_CODE, PRODUCT_NAME, TRANSACTION_TYPE, WARRANTY, QUANTITY, TIMESTAMP, IMAGE  FROM table_withdrawal WHERE STATUS = '" + status + "' ORDER BY TIMESTAMP ASC";
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
            dataGridTransaction.Columns[6].Width = 200; //Transaction Type

            dataGridTransaction.Columns[7].Width = 150; //Warranty
            dataGridTransaction.Columns[8].Width = 200; //Withdrawal Date
            dataGridTransaction.Columns[9].Width = 150; //Image
            dataGridTransaction.Columns[10].Width = 50;
            //dataGridTransaction.Columns[11].Width = 50;


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
        }
    }
}
