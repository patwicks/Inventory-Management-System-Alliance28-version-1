
namespace Inventory_System_Management_Alliance28
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnStocks = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.btnTrash = new System.Windows.Forms.PictureBox();
            this.btnTransaction = new System.Windows.Forms.PictureBox();
            this.btnProduct = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.PictureBox();
            this.activeTabIndicator = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.userControlDashboard1 = new Inventory_System_Management_Alliance28.UserControlDashboard();
            this.userControlProduct1 = new Inventory_System_Management_Alliance28.UserControlProduct();
            this.userControlTransaction1 = new Inventory_System_Management_Alliance28.Widthdrawal.UserControlTransaction();
            this.userControlStocks1 = new Inventory_System_Management_Alliance28.Stocks.UserControlStocks();
            this.userControlDelete1 = new Inventory_System_Management_Alliance28.Delete.UserControlDelete();
            this.panelSideMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Controls.Add(this.btnStocks);
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnTrash);
            this.panelSideMenu.Controls.Add(this.btnTransaction);
            this.panelSideMenu.Controls.Add(this.btnProduct);
            this.panelSideMenu.Controls.Add(this.btnDashboard);
            this.panelSideMenu.Controls.Add(this.activeTabIndicator);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 800);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.lbUsername);
            this.panel2.Controls.Add(this.lbAccountType);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 741);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 59);
            this.panel2.TabIndex = 13;
            // 
            // btnSetting
            // 
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(218, 7);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(25, 45);
            this.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSetting.TabIndex = 4;
            this.btnSetting.TabStop = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            this.btnSetting.MouseHover += new System.EventHandler(this.btnSetting_MouseHover);
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(65, 34);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(147, 16);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Admin";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAccountType
            // 
            this.lbAccountType.Location = new System.Drawing.Point(65, 8);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(147, 21);
            this.lbAccountType.TabIndex = 1;
            this.lbAccountType.Text = "Administrator";
            this.lbAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnStocks
            // 
            this.btnStocks.Image = ((System.Drawing.Image)(resources.GetObject("btnStocks.Image")));
            this.btnStocks.Location = new System.Drawing.Point(7, 277);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(243, 54);
            this.btnStocks.TabIndex = 12;
            this.btnStocks.TabStop = false;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(7, 388);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(243, 54);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash.Image")));
            this.btnTrash.Location = new System.Drawing.Point(7, 333);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(243, 54);
            this.btnTrash.TabIndex = 9;
            this.btnTrash.TabStop = false;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.Location = new System.Drawing.Point(7, 222);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(243, 54);
            this.btnTransaction.TabIndex = 8;
            this.btnTransaction.TabStop = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.Location = new System.Drawing.Point(7, 167);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(243, 54);
            this.btnProduct.TabIndex = 7;
            this.btnProduct.TabStop = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(7, 112);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(243, 54);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // activeTabIndicator
            // 
            this.activeTabIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.activeTabIndicator.Location = new System.Drawing.Point(0, 111);
            this.activeTabIndicator.Name = "activeTabIndicator";
            this.activeTabIndicator.Size = new System.Drawing.Size(6, 55);
            this.activeTabIndicator.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 111);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALLIANCE28";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1391, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1252, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDashboard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userControlDashboard1.Location = new System.Drawing.Point(255, 48);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(6);
            this.userControlDashboard1.MaximumSize = new System.Drawing.Size(1020, 750);
            this.userControlDashboard1.MinimumSize = new System.Drawing.Size(1020, 750);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(1020, 750);
            this.userControlDashboard1.TabIndex = 6;
            // 
            // userControlProduct1
            // 
            this.userControlProduct1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlProduct1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userControlProduct1.Location = new System.Drawing.Point(255, 48);
            this.userControlProduct1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlProduct1.MaximumSize = new System.Drawing.Size(1020, 750);
            this.userControlProduct1.MinimumSize = new System.Drawing.Size(1020, 750);
            this.userControlProduct1.Name = "userControlProduct1";
            this.userControlProduct1.Size = new System.Drawing.Size(1020, 750);
            this.userControlProduct1.TabIndex = 5;
            // 
            // userControlTransaction1
            // 
            this.userControlTransaction1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlTransaction1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userControlTransaction1.Location = new System.Drawing.Point(255, 48);
            this.userControlTransaction1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlTransaction1.Name = "userControlTransaction1";
            this.userControlTransaction1.Size = new System.Drawing.Size(1020, 750);
            this.userControlTransaction1.TabIndex = 4;
            // 
            // userControlStocks1
            // 
            this.userControlStocks1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.userControlStocks1.Location = new System.Drawing.Point(255, 48);
            this.userControlStocks1.Margin = new System.Windows.Forms.Padding(6);
            this.userControlStocks1.MaximumSize = new System.Drawing.Size(1020, 750);
            this.userControlStocks1.Name = "userControlStocks1";
            this.userControlStocks1.Size = new System.Drawing.Size(1020, 750);
            this.userControlStocks1.TabIndex = 3;
            // 
            // userControlDelete1
            // 
            this.userControlDelete1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDelete1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userControlDelete1.Location = new System.Drawing.Point(255, 48);
            this.userControlDelete1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlDelete1.MaximumSize = new System.Drawing.Size(1020, 750);
            this.userControlDelete1.MinimumSize = new System.Drawing.Size(1020, 750);
            this.userControlDelete1.Name = "userControlDelete1";
            this.userControlDelete1.Size = new System.Drawing.Size(1020, 750);
            this.userControlDelete1.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.userControlDashboard1);
            this.Controls.Add(this.userControlProduct1);
            this.Controls.Add(this.userControlTransaction1);
            this.Controls.Add(this.userControlStocks1);
            this.Controls.Add(this.userControlDelete1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.Activated += new System.EventHandler(this.Home_Activated);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel activeTabIndicator;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.PictureBox btnTrash;
        private System.Windows.Forms.PictureBox btnTransaction;
        private System.Windows.Forms.PictureBox btnProduct;
        private System.Windows.Forms.PictureBox btnDashboard;
        private System.Windows.Forms.PictureBox btnStocks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox btnSetting;
        private Stocks.UserControlStocks userControlStocks1;
        private Widthdrawal.UserControlTransaction userControlTransaction1;
        private UserControlProduct userControlProduct1;
        private UserControlDashboard userControlDashboard1;
        private Delete.UserControlDelete userControlDelete1;
    }
}