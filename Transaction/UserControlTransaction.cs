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

namespace Inventory_System_Management_Alliance28.Transaction
{
    public partial class UserControlTransaction : UserControl
    {
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        public UserControlTransaction()
        {
            InitializeComponent();
        }
        private void UserControlTransaction_Load(object sender, EventArgs e)
        {
            //load transaction data / withdrawal
            loadTransaction();
            //Grid style
            styleDataProductGrid();
        }

        public void loadTransaction()
        {
            string status = "Active";
            string searchQuery = "SELECT TRANSACTION_ID, CLIENT_NAME, ITEM_CODE, PRODUCT_NAME, WARRANTY, QUANTITY, TRANSACTION_TYPE,  TIMESTAMP FROM table_withdrawal WHERE STATUS = '" + status +"'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            connection.Open();


            dataAdapter.SelectCommand = loadCommand;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            //dt.Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            //foreach (DataRow row in dt.Rows)
            //{
            //    row["PICTURE"] = File.ReadAllBytes(Directory.GetCurrentDirectory() + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            //}
            dataGridTransaction.DataSource = dt;

            connection.Close();

        }

        //
        private void styleDataProductGrid()
        {
            dataGridTransaction.RowTemplate.Height = 50;

            dataGridTransaction.Columns[0].Width = 200;
            dataGridTransaction.Columns[1].Width = 150;
            dataGridTransaction.Columns[2].Width = 150;
            dataGridTransaction.Columns[3].Width = 150;
            dataGridTransaction.Columns[4].Width = 150;
            dataGridTransaction.Columns[5].Width = 200;
            dataGridTransaction.Columns[6].Width = 150;
            dataGridTransaction.Columns[7].Width = 150;
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
