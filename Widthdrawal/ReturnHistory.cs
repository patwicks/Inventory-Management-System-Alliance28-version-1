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

namespace Inventory_System_Management_Alliance28.Widthdrawal
{
    public partial class ReturnHistory : Form
    {

        int counter;
        public ReturnHistory()
        {
            InitializeComponent();
            counter = 0;
        }
        //Global variable
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";

        private void ReturnHistory_Load(object sender, EventArgs e)
        {
            //grid style
            dataGridStyle();
            //load data
            loadData();
        }

        //load data
        private void loadData()
        {
            string status = "Return";
            string loadQuery = "SELECT TRANSACTION_ID, CLIENT_NAME, PRODUCT_NAME, ITEM_CODE, QUANTITY, TIMESTAMP FROM table_withdrawal WHERE STATUS = '" + status + "' ORDER BY TIMESTAMP DESC";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            connection.Open();

            try {

                dataAdapter.SelectCommand = loadCommand;
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                counter = dt.Rows.Count;
                dataGridReturnList.DataSource = dt;
            } catch(Exception)
            {
                MessageBox.Show("Can't load any data, try again!");
            }

            connection.Close();

            if(counter == 0)
            {
                btnDeleteAll.Enabled = false;
            }
            else
            {
                btnDeleteAll.Enabled = true;
            }
        }

        private void dataGridStyle()
        {
            dataGridReturnList.RowTemplate.Height = 30;
            dataGridReturnList.Columns[0].Width = 50; 
            dataGridReturnList.Columns[1].Width = 250; 
            dataGridReturnList.Columns[2].Width = 200; 
            dataGridReturnList.Columns[3].Width = 200; 
            dataGridReturnList.Columns[4].Width = 150;
            dataGridReturnList.Columns[5].Width = 100;
            dataGridReturnList.Columns[6].Width = 150;

            foreach (DataGridViewColumn column in dataGridReturnList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            dataGridReturnList.EnableHeadersVisualStyles = false;
        }

        private void dataGridReturnList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridReturnList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                dataGridReturnList.CurrentRow.Selected = true;
                string idToBeDeleted = dataGridReturnList.Rows[e.RowIndex].Cells["TRANSACTION_ID"].FormattedValue.ToString();

                string deletQuery = "DELETE FROM table_withdrawal WHERE TRANSACTION_ID='" + idToBeDeleted + "'";

                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand deleteCommand = new MySqlCommand(deletQuery, connection);
                MySqlDataReader reader;
                connection.Open();
                try {
                    if(MessageBox.Show("After deleting this transaction data with the ID of [ "+ idToBeDeleted + " ] data will not be recover anymore, Do you want to continue?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        reader = deleteCommand.ExecuteReader();
                        MessageBox.Show("Deleted Successfully!");
                        loadData();
                    }   
                
                } catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong try again! " + ex.Message);
                }
                connection.Close();
                
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try {

                //Print Excell
                if (dataGridReturnList.Rows.Count > 0 )
                {
                    Microsoft.Office.Interop.Excel.Application xcellApp = new Microsoft.Office.Interop.Excel.Application();
                    xcellApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dataGridReturnList.Columns.Count + 1; i++)
                    {
                        xcellApp.Cells[1, i] = dataGridReturnList.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridReturnList.Rows.Count; i++)
                    {
                        for (int j = 1; j < dataGridReturnList.Columns.Count; j++)
                        {

                            xcellApp.Cells[i + 2, j + 1] = dataGridReturnList.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    xcellApp.Columns.AutoFit();
                    xcellApp.Visible = true;
                }
                else
                {
                    MessageBox.Show("No Data available on product table!");
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong while creating backup, try again!");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            string status="Return";
            string deletQuery = "DELETE FROM table_withdrawal WHERE STATUS='" + status + "'";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand deleteCommand = new MySqlCommand(deletQuery, connection);
            MySqlDataReader reader;

            connection.Open();
            try {
                if (MessageBox.Show("These data cannot be recover after deleting. DELETE ALL?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    reader = deleteCommand.ExecuteReader();
                    MessageBox.Show("All data deleted successfully!");
                    loadData();
                }

            } catch (Exception)
            {
                MessageBox.Show("Something went wrong on deleting data, try again!");
            }
            connection.Close();

        }
    }
}
