
namespace Inventory_System_Management_Alliance28.Delete
{
    partial class UserControlDelete
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDelete));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbHeaderText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.Dashboard = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridDeletedProduct = new System.Windows.Forms.DataGridView();
            this.DELETE_PRODUCT = new System.Windows.Forms.DataGridViewImageColumn();
            this.ITEMCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WARRANTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridDeletedTransaction = new System.Windows.Forms.DataGridView();
            this.DELETE_TRANSACTION = new System.Windows.Forms.DataGridViewImageColumn();
            this.TRANSACTION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSACTION_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WITHDRAWAL_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICTURE = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelBgProd = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBgTrans = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeletedProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeletedTransaction)).BeginInit();
            this.panelBgProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBgTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbHeaderText);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.Dashboard);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 60);
            this.panel3.TabIndex = 16;
            // 
            // lbHeaderText
            // 
            this.lbHeaderText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderText.Location = new System.Drawing.Point(88, 24);
            this.lbHeaderText.Name = "lbHeaderText";
            this.lbHeaderText.Size = new System.Drawing.Size(231, 19);
            this.lbHeaderText.TabIndex = 15;
            this.lbHeaderText.Text = "Header Text";
            this.lbHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbMenu);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(534, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 29);
            this.panel1.TabIndex = 14;
            // 
            // cbMenu
            // 
            this.cbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Items.AddRange(new object[] {
            "DELETED TRANSACTIONS",
            "DELETED PRODUCTS"});
            this.cbMenu.Location = new System.Drawing.Point(-1, -1);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(347, 25);
            this.cbMenu.TabIndex = 2;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dashboard.Location = new System.Drawing.Point(18, 15);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(71, 28);
            this.Dashboard.TabIndex = 13;
            this.Dashboard.Text = "Trash";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(136)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(887, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridDeletedProduct
            // 
            this.dataGridDeletedProduct.AllowUserToAddRows = false;
            this.dataGridDeletedProduct.AllowUserToDeleteRows = false;
            this.dataGridDeletedProduct.AllowUserToResizeColumns = false;
            this.dataGridDeletedProduct.AllowUserToResizeRows = false;
            this.dataGridDeletedProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDeletedProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDeletedProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridDeletedProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDeletedProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridDeletedProduct.ColumnHeadersHeight = 50;
            this.dataGridDeletedProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DELETE_PRODUCT,
            this.ITEMCODE,
            this.PRODUCTNAME,
            this.CATEGORY,
            this.QUANTITY,
            this.WARRANTY,
            this.DESCRIPTION,
            this.IMAGE,
            this.Column9});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDeletedProduct.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridDeletedProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dataGridDeletedProduct.Location = new System.Drawing.Point(1, 66);
            this.dataGridDeletedProduct.MultiSelect = false;
            this.dataGridDeletedProduct.Name = "dataGridDeletedProduct";
            this.dataGridDeletedProduct.ReadOnly = true;
            this.dataGridDeletedProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridDeletedProduct.RowHeadersVisible = false;
            this.dataGridDeletedProduct.RowHeadersWidth = 50;
            this.dataGridDeletedProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDeletedProduct.Size = new System.Drawing.Size(1018, 680);
            this.dataGridDeletedProduct.TabIndex = 17;
            this.dataGridDeletedProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeletedProduct_CellContentClick);
            // 
            // DELETE_PRODUCT
            // 
            this.DELETE_PRODUCT.HeaderText = "";
            this.DELETE_PRODUCT.Image = ((System.Drawing.Image)(resources.GetObject("DELETE_PRODUCT.Image")));
            this.DELETE_PRODUCT.Name = "DELETE_PRODUCT";
            this.DELETE_PRODUCT.ReadOnly = true;
            this.DELETE_PRODUCT.Width = 50;
            // 
            // ITEMCODE
            // 
            this.ITEMCODE.DataPropertyName = "ITEMCODE";
            this.ITEMCODE.HeaderText = "ITEM CODE";
            this.ITEMCODE.Name = "ITEMCODE";
            this.ITEMCODE.ReadOnly = true;
            this.ITEMCODE.ToolTipText = "Click to Copy";
            // 
            // PRODUCTNAME
            // 
            this.PRODUCTNAME.DataPropertyName = "PRODUCTNAME";
            this.PRODUCTNAME.HeaderText = "PRODUCT NAME";
            this.PRODUCTNAME.Name = "PRODUCTNAME";
            this.PRODUCTNAME.ReadOnly = true;
            // 
            // CATEGORY
            // 
            this.CATEGORY.DataPropertyName = "CATEGORY";
            this.CATEGORY.HeaderText = "CATEGORY";
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.ReadOnly = true;
            // 
            // QUANTITY
            // 
            this.QUANTITY.DataPropertyName = "QUANTITY";
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            // 
            // WARRANTY
            // 
            this.WARRANTY.DataPropertyName = "WARRANTY";
            this.WARRANTY.HeaderText = "WARRANTY";
            this.WARRANTY.Name = "WARRANTY";
            this.WARRANTY.ReadOnly = true;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            // 
            // IMAGE
            // 
            this.IMAGE.DataPropertyName = "IMAGE";
            this.IMAGE.HeaderText = "IMAGE";
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.ReadOnly = true;
            this.IMAGE.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "PICTURE";
            this.Column9.HeaderText = "PICTURE";
            this.Column9.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridDeletedTransaction
            // 
            this.dataGridDeletedTransaction.AllowUserToAddRows = false;
            this.dataGridDeletedTransaction.AllowUserToDeleteRows = false;
            this.dataGridDeletedTransaction.AllowUserToResizeColumns = false;
            this.dataGridDeletedTransaction.AllowUserToResizeRows = false;
            this.dataGridDeletedTransaction.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDeletedTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDeletedTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridDeletedTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDeletedTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridDeletedTransaction.ColumnHeadersHeight = 50;
            this.dataGridDeletedTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DELETE_TRANSACTION,
            this.TRANSACTION_ID,
            this.CLIENT_NAME,
            this.PRODUCT_NAME,
            this.ITEM_CODE,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.TRANSACTION_TYPE,
            this.WITHDRAWAL_DATE,
            this.dataGridViewTextBoxColumn3,
            this.PICTURE});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDeletedTransaction.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridDeletedTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dataGridDeletedTransaction.Location = new System.Drawing.Point(1, 66);
            this.dataGridDeletedTransaction.MultiSelect = false;
            this.dataGridDeletedTransaction.Name = "dataGridDeletedTransaction";
            this.dataGridDeletedTransaction.ReadOnly = true;
            this.dataGridDeletedTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridDeletedTransaction.RowHeadersVisible = false;
            this.dataGridDeletedTransaction.RowHeadersWidth = 50;
            this.dataGridDeletedTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridDeletedTransaction.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridDeletedTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDeletedTransaction.Size = new System.Drawing.Size(1018, 680);
            this.dataGridDeletedTransaction.TabIndex = 18;
            this.dataGridDeletedTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeletedTransaction_CellContentClick);
            // 
            // DELETE_TRANSACTION
            // 
            this.DELETE_TRANSACTION.HeaderText = "";
            this.DELETE_TRANSACTION.Image = ((System.Drawing.Image)(resources.GetObject("DELETE_TRANSACTION.Image")));
            this.DELETE_TRANSACTION.Name = "DELETE_TRANSACTION";
            this.DELETE_TRANSACTION.ReadOnly = true;
            this.DELETE_TRANSACTION.Width = 13;
            // 
            // TRANSACTION_ID
            // 
            this.TRANSACTION_ID.DataPropertyName = "TRANSACTION_ID";
            this.TRANSACTION_ID.HeaderText = "TRANSACTION ID";
            this.TRANSACTION_ID.Name = "TRANSACTION_ID";
            this.TRANSACTION_ID.ReadOnly = true;
            this.TRANSACTION_ID.Width = 182;
            // 
            // CLIENT_NAME
            // 
            this.CLIENT_NAME.DataPropertyName = "CLIENT_NAME";
            this.CLIENT_NAME.HeaderText = "CLIENT NAME";
            this.CLIENT_NAME.Name = "CLIENT_NAME";
            this.CLIENT_NAME.ReadOnly = true;
            this.CLIENT_NAME.Width = 152;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.PRODUCT_NAME.HeaderText = "PRODUCT NAME";
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.ReadOnly = true;
            this.PRODUCT_NAME.Width = 175;
            // 
            // ITEM_CODE
            // 
            this.ITEM_CODE.DataPropertyName = "ITEM_CODE";
            this.ITEM_CODE.HeaderText = "ITEM CODE";
            this.ITEM_CODE.Name = "ITEM_CODE";
            this.ITEM_CODE.ReadOnly = true;
            this.ITEM_CODE.Width = 134;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QUANTITY";
            this.dataGridViewTextBoxColumn1.HeaderText = "QUANTITY";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 127;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WARRANTY";
            this.dataGridViewTextBoxColumn2.HeaderText = "WARRANTY";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 137;
            // 
            // TRANSACTION_TYPE
            // 
            this.TRANSACTION_TYPE.DataPropertyName = "TRANSACTION_TYPE";
            this.TRANSACTION_TYPE.HeaderText = "TRANSACTION TYPE";
            this.TRANSACTION_TYPE.Name = "TRANSACTION_TYPE";
            this.TRANSACTION_TYPE.ReadOnly = true;
            this.TRANSACTION_TYPE.Width = 202;
            // 
            // WITHDRAWAL_DATE
            // 
            this.WITHDRAWAL_DATE.DataPropertyName = "TIMESTAMP";
            this.WITHDRAWAL_DATE.HeaderText = "WITHDRAWAL DATE";
            this.WITHDRAWAL_DATE.Name = "WITHDRAWAL_DATE";
            this.WITHDRAWAL_DATE.ReadOnly = true;
            this.WITHDRAWAL_DATE.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IMAGE";
            this.dataGridViewTextBoxColumn3.HeaderText = "IMAGE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 101;
            // 
            // PICTURE
            // 
            this.PICTURE.DataPropertyName = "PICTURE";
            this.PICTURE.HeaderText = "PICTURE";
            this.PICTURE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.PICTURE.Name = "PICTURE";
            this.PICTURE.ReadOnly = true;
            // 
            // panelBgProd
            // 
            this.panelBgProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelBgProd.Controls.Add(this.pictureBox1);
            this.panelBgProd.Controls.Add(this.label1);
            this.panelBgProd.Location = new System.Drawing.Point(3, 118);
            this.panelBgProd.Name = "panelBgProd";
            this.panelBgProd.Size = new System.Drawing.Size(1017, 631);
            this.panelBgProd.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1019, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(0, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1020, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Deleted Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBgTrans
            // 
            this.panelBgTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelBgTrans.Controls.Add(this.pictureBox2);
            this.panelBgTrans.Controls.Add(this.label2);
            this.panelBgTrans.Location = new System.Drawing.Point(1, 117);
            this.panelBgTrans.Name = "panelBgTrans";
            this.panelBgTrans.Size = new System.Drawing.Size(1017, 631);
            this.panelBgTrans.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1019, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label2.Location = new System.Drawing.Point(0, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1020, 60);
            this.label2.TabIndex = 0;
            this.label2.Text = "No Deleted Transactions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBgTrans);
            this.Controls.Add(this.panelBgProd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridDeletedProduct);
            this.Controls.Add(this.dataGridDeletedTransaction);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1020, 750);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "UserControlDelete";
            this.Size = new System.Drawing.Size(1020, 750);
            this.Load += new System.EventHandler(this.UserControlDelete_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeletedProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeletedTransaction)).EndInit();
            this.panelBgProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBgTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.DataGridView dataGridDeletedProduct;
        private System.Windows.Forms.DataGridViewImageColumn DELETE_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn WARRANTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridView dataGridDeletedTransaction;
        private System.Windows.Forms.DataGridViewImageColumn DELETE_TRANSACTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTION_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn WITHDRAWAL_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn PICTURE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.Panel panelBgProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHeaderText;
        private System.Windows.Forms.Panel panelBgTrans;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}
