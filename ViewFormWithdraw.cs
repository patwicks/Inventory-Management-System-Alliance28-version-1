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
    public partial class ViewFormWithdraw : Form
    {
        //RECENT WITHDRAW ITEMS
        public string Wtransaction_id { get; set; }
        public string Witemcode { get; set; }
        public string Wproductname { get; set; }
        public string Wquantity { get; set; }
        public string Wtransaction_type { get; set; }
        public string Wclient_name { get; set; }
        public string Wtimestamp { get; set; }
        public string Wimage { get; set; }

        public ViewFormWithdraw()
        {

            InitializeComponent();
        }

        private void ViewFormWithdraw_Load(object sender, EventArgs e)
        {
            txtItemCode.Text = Witemcode;
            txttransactionid.Text = Wtransaction_id;
            txtProductName.Text = Wproductname;
            txtQuantity.Text = Wquantity;
            txttransaction_type.Text = Wtransaction_type;
            txtclient_name.Text = Wclient_name;
            txtDateAdded.Text = Wtimestamp;

            Image img = Image.FromFile(Application.StartupPath + @"\Images\" + Wimage);
            pbItemImage.Image = img;
        }
    }
}
