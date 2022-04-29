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
           if(MessageBox.Show("Are you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            //DatagridView data Show
            userControlDashboard1.recent_added();
            userControlDashboard1.recent_withdraw();
            userControlTransaction1.loadTransactions();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            activeTabIndicator.Top = btnProduct.Top;
            userControlProduct1.BringToFront();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            activeTabIndicator.Top = btnTransaction.Top;
            userControlTransaction1.BringToFront();
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
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            activeTabIndicator.Top = btnAccount.Top;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            activeTabIndicator.Top = btnLogout.Top;
            if (MessageBox.Show("Are you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                Login loginForm = new Login();
                this.Hide();
                loginForm.Show();
            }
            
        }
    }
}
