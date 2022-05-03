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

namespace Inventory_System_Management_Alliance28.Stocks
{
    public partial class UserControlStocks : UserControl
    {
        //Global variable
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        public UserControlStocks()
        {
            InitializeComponent();
        }

        private void UserControlStocks_Load(object sender, EventArgs e)
        {

            loadStocks();

            datagridtyle();
            
        }

        //load out of stock products
        public void loadStocks()
        {
            string status = "Active";
            string loadQuery = "SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, IMAGE FROM table_products WHERE ( QUANTITY <= 5) AND STATUS = '" + status + "'";
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
            dataGridStocks.DataSource = dt;



            connection.Close();
        }

        //style datagridview
        public void datagridtyle()
        {
            dataGridStocks.RowTemplate.Height = 50;

            dataGridStocks.Columns[0].Width = 50; //icon
            dataGridStocks.Columns[1].Width = 150; //Item code
            dataGridStocks.Columns[2].Width = 413; //product name
            dataGridStocks.Columns[3].Width = 150; // category
            dataGridStocks.Columns[4].Width = 150; // Quantity
            dataGridStocks.Columns[5].Width = 100; //image
            dataGridStocks.Columns[6].Width = 100; //picture



            foreach (DataGridViewColumn column in dataGridStocks.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            }




            dataGridStocks.EnableHeadersVisualStyles = false;
        }

        private void dataGridStocks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 4 & e.Value != null)
            {

                int val = int.Parse(e.Value.ToString());
                if (val == 0)
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 153, 153);
                }
                else if( val <=5 )
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 204, 204);
                }

            }
        }

        private void dataGridStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridStocks.Columns[e.ColumnIndex].Name == "ADD")
            {

                Stocks.AddStock addStockForm = new Stocks.AddStock();

                dataGridStocks.CurrentRow.Selected = true;
                addStockForm.itemCode = dataGridStocks.Rows[e.RowIndex].Cells["ITEMCODE"].FormattedValue.ToString();
                addStockForm.productName = dataGridStocks.Rows[e.RowIndex].Cells["PRODUCTNAME"].FormattedValue.ToString();
                addStockForm.productCategory = dataGridStocks.Rows[e.RowIndex].Cells["CATEGORY"].FormattedValue.ToString();
                addStockForm.productQuantity = dataGridStocks.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString();
                addStockForm.productImageName = dataGridStocks.Rows[e.RowIndex].Cells["IMAGE"].FormattedValue.ToString();
                addStockForm.ShowDialog();
            }
            //
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadStocks();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Print Excell
            if (dataGridStocks.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcellApp = new Microsoft.Office.Interop.Excel.Application();
                xcellApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridStocks.Columns.Count + 1; i++)
                {
                    xcellApp.Cells[1, i] = dataGridStocks.Columns[i - 1].HeaderText;
                    // Remove the Value of headertext on last column - PICTURE headertext
                    if (i == 7)
                    {
                        xcellApp.Cells[1, 7] = null;

                    }
                    else if (i == 6)
                    {
                        // Remove the Value of headertext on column Image
                        xcellApp.Cells[1, 6] = null;

                    }


                }

                for (int i = 0; i < dataGridStocks.Rows.Count; i++)
                {
                    //Start printing Value on Column 4 or to Item Code Column
                    for (int j = 1; j < dataGridStocks.Columns.Count; j++)
                    {

                        xcellApp.Cells[i + 2, j + 1] = dataGridStocks.Rows[i].Cells[j].Value.ToString();

                        //Break the loop if J value is equal to 10 (Image) Column - Picture and Image cell Value will not be included

                        if (j == 4)
                        {
                            break;
                        }


                    }
                }
                xcellApp.Columns.AutoFit();
                xcellApp.Visible = true;
            }
        }
    }
}
