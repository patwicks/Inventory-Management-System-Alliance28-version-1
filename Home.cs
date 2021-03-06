using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Inventory_System_Management_Alliance28
{
    public partial class Home : Form
    {
        string connectionString = "server=localhost;username=root;password=admin;database=inventory_system";
       
        public string Id { get; set; }
    
        public Home()
        {
            InitializeComponent();
            
        }
        private void Home_Load(object sender, EventArgs e)
        {
            userControlDashboard1.BringToFront();
            string rootFolder = Application.StartupPath + @"\Images\";
            if(!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }
            
        }

 

        private void btnClose_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Do you want to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            //Nothing
        }
            // button tabs actions
        private void btnDashboard_Click(object sender, EventArgs e)
        {

            activeTabIndicator.Top = btnDashboard.Top;
            userControlDashboard1.BringToFront();
            //Dashboard Data Counter from public function - User Control Dashboard
            userControlDashboard1.countProducts();
            userControlDashboard1.countTransactions();
            userControlDashboard1.countDeletedProducts();
            //DatagridView data Show
            userControlDashboard1.recent_added();
            userControlDashboard1.recent_withdraw();


        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            activeTabIndicator.Top = btnProduct.Top;
            userControlProduct1.BringToFront();
            userControlProduct1.loadProducts();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            activeTabIndicator.Top = btnTransaction.Top;
            userControlTransaction1.BringToFront();
            userControlTransaction1.loadTransactions();
        }
        private void btnStocks_Click(object sender, EventArgs e)
        {
            activeTabIndicator.Top = btnStocks.Top;
            userControlStocks1.BringToFront();
            userControlStocks1.loadStocks();
        }
        private void btnTrash_Click(object sender, EventArgs e)
        {
            activeTabIndicator.Top = btnTrash.Top;
            userControlDelete1.BringToFront();

            userControlDelete1.loadDeletedProducts();
            userControlDelete1.countProducts();

            //Trash Transactions
            userControlDelete1.loadDeletedTransactions();
            userControlDelete1.countTransactions();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            activeTabIndicator.Top = btnLogout.Top;
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                Login loginForm = new Login();
                Close();
                loginForm.Show();
            }
            
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            //products
            userControlProduct1.loadProducts();
            userControlProduct1.countProducts();
            userControlProduct1.exportProducts();
            //Transactions
            userControlTransaction1.loadTransactions();
            userControlTransaction1.countTransactions();
            //Stocks
            userControlStocks1.loadStocks();
            //Trash product
            userControlDelete1.loadDeletedProducts();
            userControlDelete1.countProducts();

            //Trash Transactions
            userControlDelete1.loadDeletedTransactions();
            userControlDelete1.countTransactions();
            //searhc
            searchDetails();

        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            AccountSetting setting = new AccountSetting();
            setting.id = Id;
            setting.ShowDialog();
        }

        private void btnSetting_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(btnSetting, "Account settings");
        }

        //search
        private void searchDetails()
        {
            string searchQuery = "SELECT * FROM table_account WHERE id='" + Id + "' ";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
            MySqlDataReader reader;

            connection.Open();

            reader = searchCommand.ExecuteReader();

            try
            {

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lbUsername.Text = reader["username"].ToString();
                        lbAccountType.Text = reader["accountType"].ToString();

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, try again!");
            }

            reader.Close();
            connection.Close();
        }

    }
}
