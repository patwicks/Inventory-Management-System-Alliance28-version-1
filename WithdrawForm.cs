using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System_Management_Alliance28
{
    public partial class WithdrawForm : Form
    {
        //Public variables --> will get and store the value from current sellected Row on DataGridView
        public string itemCode { get; set; }
        public string productName { get; set; }
        public string productQuantity { get; set; }

        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            txtItemCode.Text = itemCode;
            txtCurrentStock.Text = productQuantity;
            txtProductName.Text = productName;
        }
    }
}
