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
        MySqlDataAdapter dataAdapter;
        DataSet ds;

        //limit
        int maxCount = 10;
        int pageVal;
        int totalRow;

        public UserControlProduct()
        {
            InitializeComponent();

           

        }
        Product.Information Info = new Product.Information();

        private void UserControlProduct_Load(object sender, EventArgs e)
        {
            styleDataProductGrid();
            loadProducts();
            exportProducts();

            //counter
            countProducts();
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
            totalRow = dt.Rows.Count;

            if (totalRow > 0)
            {
                panelBg.Visible = false;
                panelBg.SendToBack();
            }
            else
            {
                panelBg.Visible = true;
                panelBg.BringToFront();
            }
        }

        //Styled datagridproduct
        private void styleDataProductGrid()
        {
            dataGridProduct.RowTemplate.Height = 57;

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
            addForm.ShowDialog();
        }

        //load products

        //load the data on gridView function
        public void loadProducts()
        {
            string status = "Active";
            string loadQuery = "SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, TIMESTAMP, IMAGE FROM table_products WHERE STATUS = '" + status + "' ORDER BY PRODUCTNAME DESC";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);
            
            dataAdapter = new MySqlDataAdapter();
            ds = new DataSet();

            connection.Open();


                dataAdapter.SelectCommand = loadCommand;
                dataAdapter.Fill(ds, pageVal, maxCount, "table_products");

                ds.Tables[0].Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
                }
                dataGridProduct.DataSource = ds.Tables[0];

            connection.Close();
            txtSearch.Text = null;

        }
        //Export products base on another data table

        public void exportProducts()
        {
            string status = "Active";
            string loadQuery = "SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, TIMESTAMP FROM table_products WHERE STATUS = '" + status + "' ORDER BY PRODUCTNAME DESC";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, connection);

            MySqlDataAdapter adapterExport = new MySqlDataAdapter();
            DataSet dataSetExport = new DataSet();

            connection.Open();

            try
            {
                adapterExport.SelectCommand = loadCommand;
                adapterExport.Fill(dataSetExport);
                dtExport.DataSource = dataSetExport.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while Exporting data!");
            }

            connection.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProducts();
            countProducts();
            exportProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter adapter;
            DataSet ds;
            string status = "Active";

            connection.Open();

            if(txtSearch.Text != "")
            {
                adapter = new MySqlDataAdapter("SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, TIMESTAMP , IMAGE  FROM table_products WHERE (PRODUCTNAME LIKE '" + txtSearch.Text + "%' || ITEMCODE LIKE '" + txtSearch.Text + "%') AND (STATUS='" + status + "') ", connection);
                ds = new DataSet();

                adapter.Fill(ds, pageVal, maxCount, "table_products");


                ds.Tables[0].Columns.Add("PICTURE", Type.GetType("System.Byte[]"));

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
                }
                dataGridProduct.DataSource = ds.Tables[0];
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                loadProducts();
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }

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
                deleteForm.ShowDialog();
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

                editForm.ShowDialog();
            }
            else if (dataGridProduct.Columns[e.ColumnIndex].Name == "WITHDRAW")
            {
                GridWithdrawForm GWForm = new GridWithdrawForm();

                GWForm.itemCode = dataGridProduct.Rows[e.RowIndex].Cells["ITEMCODE"].FormattedValue.ToString();
                GWForm.productName = dataGridProduct.Rows[e.RowIndex].Cells["PRODUCTNAME"].FormattedValue.ToString();
                GWForm.productQuantity = dataGridProduct.Rows[e.RowIndex].Cells["QUANTITY"].FormattedValue.ToString();
                GWForm.productImage = dataGridProduct.Rows[e.RowIndex].Cells["IMAGE"].FormattedValue.ToString();
                GWForm.productWarranty = dataGridProduct.Rows[e.RowIndex].Cells["WARRANTY"].FormattedValue.ToString();
                GWForm.ShowDialog();
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


            wForm.ShowDialog();
        }
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            Product.GridAddStockForm GASForm = new Product.GridAddStockForm();
            GASForm.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                //Print Excell
                if (dtExport.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application xcellApp = new Microsoft.Office.Interop.Excel.Application();
                    xcellApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dtExport.Columns.Count + 1; i++)
                    {
                        xcellApp.Cells[1, i] = dtExport.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dtExport.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtExport.Columns.Count; j++)
                        {

                            xcellApp.Cells[i + 2, j + 1] = dtExport.Rows[i].Cells[j].Value.ToString();
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
                MessageBox.Show("Something went wrong while exporting product data, try again!");
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageVal = pageVal + 10;
            if (pageVal > totalRow)
            {
                pageVal = 0;
            }
            ds.Clear();
            dataAdapter.Fill(ds, pageVal, maxCount, "table_products");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pageVal = pageVal - 10;
            if (pageVal <= 0)
            {
                pageVal = 0;
            }
            ds.Clear();
            dataAdapter.Fill(ds, pageVal, maxCount, "table_products");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Images\" + Path.GetFileName(row["IMAGE"].ToString()));
            }
        }
    }
}
