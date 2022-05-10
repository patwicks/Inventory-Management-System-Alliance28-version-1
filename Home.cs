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


namespace Inventory_System_Management_Alliance28
{
    public partial class Home : Form
    {
        public string Username { get; set; }
        public string Id { get; set; }
        public string AccountType { get; set; }
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
            lbAccountType.Text = AccountType;
            lbUsername.Text = Username;
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
            userControlTrash2.BringToFront();
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
            userControlProduct1.exportProducts();
            //Transactions
            userControlTransaction1.loadTransactions();
            userControlTransaction1.countTransactions();
            //Stocks
            userControlStocks1.loadStocks();
            //Trash
            userControlTrash2.loadDeletedProducts();
            userControlTrash2.loadDeletedTransactions();

            //

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

    }
}
