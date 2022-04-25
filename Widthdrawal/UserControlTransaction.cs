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
            string loadQuery = "SELECT TRANSACTION_ID, CLIENT_NAME, ITEM_CODE, PRODUCT_NAME, TRANSACTION_TYPE, WARRANTY, QUANTITY, TIMESTAMP  FROM table_withdrawal WHERE STATUS = '" + status + "' ORDER BY TIMESTAMP ASC";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            connection.Open();


            dataAdapter.SelectCommand = loadCommand;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            //dt.Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            //foreach (DataRow row in dt.Rows)
            //{
            //    row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            //}
            dataGridTransaction.DataSource = dt;



            connection.Close();

        }

        //Styled datagridproduct
        public void styleDataGrid()
        {
            dataGridTransaction.RowTemplate.Height = 50;

            //dataGridTransaction.Columns[0].Width = 200;
            //dataGridTransaction.Columns[1].Width = 200;
            //dataGridTransaction.Columns[2].Width = 150;
            //dataGridTransaction.Columns[3].Width = 150;
            //dataGridTransaction.Columns[4].Width = 150;
            //dataGridTransaction.Columns[5].Width = 150;
            //dataGridTransaction.Columns[6].Width = 150;
            //dataGridTransaction.Columns[7].Width = 150;

            //dataGridTransaction.Columns[8].Width = 150;
            //dataGridTransaction.Columns[9].Width = 100;
            //dataGridTransaction.Columns[10].Width = 50;
            //dataGridTransaction.Columns[11].Width = 50;
            //dataGridTransaction.Columns[12].Width = 50;


            foreach (DataGridViewColumn column in dataGridTransaction.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }




            dataGridTransaction.EnableHeadersVisualStyles = false;
        }
    }
}
