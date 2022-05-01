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

namespace Inventory_System_Management_Alliance28
{
    public partial class UserControlProduct : UserControl
    {
        //Global variable
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
        

        public UserControlProduct()
        {
            InitializeComponent();
            
        }

        Product.Information Info = new Product.Information();

        private void UserControlProduct_Load(object sender, EventArgs e)
        {
            styleDataProductGrid();
            loadProducts();
            
        }
       
        //Styled datagridproduct
        private void styleDataProductGrid()
        {
            dataGridProduct.RowTemplate.Height = 50;
            dataGridProduct.Columns[1].Width = 50;
            dataGridProduct.Columns[1].Width = 150;
            dataGridProduct.Columns[2].Width = 200;
            dataGridProduct.Columns[3].Width = 150;
            dataGridProduct.Columns[4].Width = 150;
            dataGridProduct.Columns[5].Width = 150;
            dataGridProduct.Columns[6].Width = 200;
            dataGridProduct.Columns[7].Width = 150;
            dataGridProduct.Columns[8].Width = 150;
            dataGridProduct.Columns[9].Width = 100;
            dataGridProduct.Columns[10].Width = 50;
            dataGridProduct.Columns[11].Width = 50;
            dataGridProduct.Columns[12].Width = 50;


            foreach (DataGridViewColumn column in dataGridProduct.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
               
            }

           


            dataGridProduct.EnableHeadersVisualStyles = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addForm = new AddProduct();
            addForm.Show();
        }

        //load products

        //load the data on gridView function
        public void loadProducts()
        {
            string status = "Active";
            string loadQuery = "SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, TIMESTAMP, IMAGE FROM table_products WHERE STATUS = '" + status + "' ORDER BY PRODUCTNAME DESC";
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

           

            connection.Close();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter adapter;
            DataTable dt;
            string status = "Active";

            connection.Open();

            adapter = new MySqlDataAdapter("SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, TIMESTAMP , IMAGE  FROM table_products WHERE (PRODUCTNAME LIKE '" + txtSearch.Text + "%' || ITEMCODE LIKE '" + txtSearch.Text + "%') AND (STATUS='"+ status +"') ", connection);
            dt = new DataTable();
            
            adapter.Fill(dt);


            dt.Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

            foreach (DataRow row in dt.Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"/Images/" + Path.GetFileName(row["IMAGE"].ToString()));
            }
            dataGridProduct.DataSource = dt;

            connection.Close();
        }

        //DatagridView Cell Row Clicked

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridProduct.Columns[e.ColumnIndex].Name == "DELETE")
            {

                DeleteForm deleteForm = new DeleteForm();
                dataGridProduct.CurrentRow.Selected = true;
                deleteForm.itemCode = dataGridProduct.Rows[e.RowIndex].Cells["ITEMCODE"].FormattedValue.ToString();
                deleteForm.productName = dataGridProduct.Rows[e.RowIndex].Cells["PRODUCTNAME"].FormattedValue.ToString();
                deleteForm.productCategory = dataGridProduct.Rows[e.RowIndex].Cells["CATEGORY"].FormattedValue.ToString();
                deleteForm.productQuantity = dataGridProduct.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString();
                deleteForm.productWarranty = dataGridProduct.Rows[e.RowIndex].Cells["WARRANTY"].FormattedValue.ToString();
                deleteForm.productDescription = dataGridProduct.Rows[e.RowIndex].Cells["DESCRIPTION"].FormattedValue.ToString();
                deleteForm.productDateAdded = dataGridProduct.Rows[e.RowIndex].Cells["DATEADDED"].FormattedValue.ToString();
                deleteForm.productImageName = dataGridProduct.Rows[e.RowIndex].Cells["IMAGE"].FormattedValue.ToString();
                deleteForm.Show();

            }
            else if(dataGridProduct.Columns[e.ColumnIndex].Name == "EDIT")
            {
                EditForm editForm = new EditForm();
                dataGridProduct.CurrentRow.Selected = true;
                editForm.itemCode = dataGridProduct.Rows[e.RowIndex].Cells["ITEMCODE"].FormattedValue.ToString();
                editForm.productName = dataGridProduct.Rows[e.RowIndex].Cells["PRODUCTNAME"].FormattedValue.ToString();
                editForm.productCategory = dataGridProduct.Rows[e.RowIndex].Cells["CATEGORY"].FormattedValue.ToString();
                editForm.productQuantity = dataGridProduct.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString();
                editForm.productWarranty = dataGridProduct.Rows[e.RowIndex].Cells["WARRANTY"].FormattedValue.ToString();
                editForm.productDescription = dataGridProduct.Rows[e.RowIndex].Cells["DESCRIPTION"].FormattedValue.ToString();
                editForm.productImageName = dataGridProduct.Rows[e.RowIndex].Cells["IMAGE"].FormattedValue.ToString();

                editForm.Show();
            }
            else if (dataGridProduct.Columns[e.ColumnIndex].Name == "WITHDRAW")
            {
                GridWithdrawForm GWForm = new GridWithdrawForm();

                GWForm.itemCode = dataGridProduct.Rows[e.RowIndex].Cells["ITEMCODE"].FormattedValue.ToString();
                GWForm.productName = dataGridProduct.Rows[e.RowIndex].Cells["PRODUCTNAME"].FormattedValue.ToString();
                GWForm.productQuantity = dataGridProduct.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString();
                GWForm.productImage = dataGridProduct.Rows[e.RowIndex].Cells["IMAGE"].FormattedValue.ToString();
                GWForm.productWarranty = dataGridProduct.Rows[e.RowIndex].Cells["WARRANTY"].FormattedValue.ToString();
                GWForm.Show();
            }
            else if (dataGridProduct.Columns[e.ColumnIndex].Name == "CLIPBOARD")
            {
                dataGridProduct.CurrentRow.Selected = true;
                System.Windows.Forms.Clipboard.SetText(dataGridProduct.Rows[e.RowIndex].Cells["ITEMCODE"].FormattedValue.ToString());
                MessageBox.Show("Copied to clipboard " + dataGridProduct.Rows[e.RowIndex].Cells["ITEMCODE"].FormattedValue.ToString());
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm wForm = new WithdrawForm();


            wForm.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Print Excell
            if (dataGridProduct.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcellApp = new Microsoft.Office.Interop.Excel.Application();
                xcellApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridProduct.Columns.Count + 1; i++)
                {
                    xcellApp.Cells[1, i] = dataGridProduct.Columns[i - 1].HeaderText;
                    // Remove the Value of headertext on last column - PICTURE headertext
                    if (i == 13)
                    {
                        xcellApp.Cells[1, 13] = null;

                    }
                    else if(i==12)
                    {
                        // Remove the Value of headertext on column Image
                        xcellApp.Cells[1, 12] = null;

                    }


                }

                for (int i = 0; i < dataGridProduct.Rows.Count; i++)
                {
                    //Start printing Value on Column 4 or to Item Code Column
                    for (int j = 4; j < dataGridProduct.Columns.Count; j++)
                    {
                       
                            xcellApp.Cells[i + 2, j + 1] = dataGridProduct.Rows[i].Cells[j].Value.ToString();

                        //Break the loop if J value is equal to 10 (Image) Column - Picture and Image cell Value will not be included

                        if(j == 10)
                        {
                            break;
                        }
                        
                       
                    }
                }
                xcellApp.Columns.AutoFit();
                xcellApp.Visible = true;
            }
        }

        private void dataGridProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridProduct.Columns[e.ColumnIndex].Name == "QUANTITY" & e.Value != null)
            {

                int val = int.Parse(e.Value.ToString());

                if (val <= 0)
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 153, 153);
                }
                else if(val <= 5)
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 204, 204);
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(153, 255, 204);
                }
            }
        }

        private void pbInformation_MouseHover(object sender, EventArgs e)
        {
            //change the size when hovering the icon
            pbInformation.Height = 26;
            pbInformation.Width = 26;
            Info.Show();
        }

        private void pbInformation_MouseLeave(object sender, EventArgs e)
        {
            //reset the icon size when mouse leave
            pbInformation.Height = 24;
            pbInformation.Width = 24;
            Info.Hide();
        }
    }
}
