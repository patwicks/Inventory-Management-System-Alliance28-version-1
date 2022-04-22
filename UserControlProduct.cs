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

        private void UserControlProduct_Load(object sender, EventArgs e)
        {
            styleDataProductGrid();
            loadProducts();
        }
        //Styled datagridproduct
        private void styleDataProductGrid()
        {
            dataGridProduct.RowTemplate.Height = 50;
            dataGridProduct.Columns[0].Width = 150;
            dataGridProduct.Columns[1].Width = 200;
            dataGridProduct.Columns[2].Width = 150;
            dataGridProduct.Columns[3].Width = 150;
            dataGridProduct.Columns[4].Width = 150;
            dataGridProduct.Columns[5].Width = 200;
            dataGridProduct.Columns[6].Width = 150;
            dataGridProduct.Columns[7].Width = 150;
            dataGridProduct.Columns[9].Width = 50;
            dataGridProduct.Columns[10].Width = 50;
            dataGridProduct.Columns[11].Width = 50;


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
            string loadQuery = "SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, TIMESTAMP, IMAGE FROM table_products ORDER BY PRODUCTNAME ASC";
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

            connection.Open();

            adapter = new MySqlDataAdapter("SELECT ITEMCODE, PRODUCTNAME, CATEGORY, QUANTITY, WARRANTY, DESCRIPTION, TIMESTAMP , IMAGE  FROM table_products WHERE PRODUCTNAME LIKE '" + txtSearch.Text + "%' || ITEMCODE LIKE '" + txtSearch.Text + "%' ", connection);
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
                GWForm.Show();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm wForm = new WithdrawForm();


            wForm.Show();
        }
    }
}
