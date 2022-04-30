using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System_Management_Alliance28.Product
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            panelRed.BackColor = Color.FromArgb(255, 153, 153);
            panelRedLight.BackColor = Color.FromArgb(255, 204, 204);
            panelGreen.BackColor = Color.FromArgb(153, 255, 204);
        }
    }
}
