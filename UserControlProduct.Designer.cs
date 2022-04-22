
namespace Inventory_System_Management_Alliance28
{
    partial class UserControlProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlProduct));
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.ITEMCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WARRANTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEADDED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.WITHDRAW = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.AllowUserToResizeColumns = false;
            this.dataGridProduct.AllowUserToResizeRows = false;
            this.dataGridProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProduct.ColumnHeadersHeight = 50;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEMCODE,
            this.PRODUCTNAME,
            this.CATEGORY,
            this.QUANTITY,
            this.WARRANTY,
            this.DESCRIPTION,
            this.DATEADDED,
            this.IMAGE,
            this.Column9,
            this.EDIT,
            this.DELETE,
            this.WITHDRAW});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dataGridProduct.Location = new System.Drawing.Point(3, 64);
            this.dataGridProduct.MultiSelect = false;
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridProduct.RowHeadersVisible = false;
            this.dataGridProduct.RowHeadersWidth = 50;
            this.dataGridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduct.Size = new System.Drawing.Size(1014, 680);
            this.dataGridProduct.TabIndex = 0;
            this.dataGridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(682, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 30);
            this.panel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSearch.Location = new System.Drawing.Point(29, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(19, 21);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(115, 30);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(136)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(261, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(678, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by Product name or Code:";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(140, 21);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(115, 30);
            this.btnWithdraw.TabIndex = 5;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // ITEMCODE
            // 
            this.ITEMCODE.DataPropertyName = "ITEMCODE";
            this.ITEMCODE.Frozen = true;
            this.ITEMCODE.HeaderText = "";
            this.ITEMCODE.Name = "ITEMCODE";
            this.ITEMCODE.ReadOnly = true;
            // 
            // PRODUCTNAME
            // 
            this.PRODUCTNAME.DataPropertyName = "PRODUCTNAME";
            this.PRODUCTNAME.Frozen = true;
            this.PRODUCTNAME.HeaderText = "PRODUCT NAME";
            this.PRODUCTNAME.Name = "PRODUCTNAME";
            this.PRODUCTNAME.ReadOnly = true;
            // 
            // CATEGORY
            // 
            this.CATEGORY.DataPropertyName = "CATEGORY";
            this.CATEGORY.Frozen = true;
            this.CATEGORY.HeaderText = "CATEGORY";
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.ReadOnly = true;
            // 
            // QUANTITY
            // 
            this.QUANTITY.DataPropertyName = "QUANTITY";
            this.QUANTITY.Frozen = true;
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            // 
            // WARRANTY
            // 
            this.WARRANTY.DataPropertyName = "WARRANTY";
            this.WARRANTY.Frozen = true;
            this.WARRANTY.HeaderText = "WARRANTY";
            this.WARRANTY.Name = "WARRANTY";
            this.WARRANTY.ReadOnly = true;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.Frozen = true;
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            // 
            // DATEADDED
            // 
            this.DATEADDED.DataPropertyName = "TIMESTAMP";
            this.DATEADDED.Frozen = true;
            this.DATEADDED.HeaderText = "DATE ADDED";
            this.DATEADDED.Name = "DATEADDED";
            this.DATEADDED.ReadOnly = true;
            // 
            // IMAGE
            // 
            this.IMAGE.DataPropertyName = "IMAGE";
            this.IMAGE.Frozen = true;
            this.IMAGE.HeaderText = "IMAGE";
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.ReadOnly = true;
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
            // EDIT
            // 
            this.EDIT.HeaderText = "";
            this.EDIT.Image = ((System.Drawing.Image)(resources.GetObject("EDIT.Image")));
            this.EDIT.Name = "EDIT";
            this.EDIT.ReadOnly = true;
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "";
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            // 
            // WITHDRAW
            // 
            this.WITHDRAW.Description = "WITHDRAW";
            this.WITHDRAW.HeaderText = "";
            this.WITHDRAW.Image = ((System.Drawing.Image)(resources.GetObject("WITHDRAW.Image")));
            this.WITHDRAW.Name = "WITHDRAW";
            this.WITHDRAW.ReadOnly = true;
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridProduct);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1020, 750);
            this.MinimumSize = new System.Drawing.Size(1020, 750);
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(1020, 750);
            this.Load += new System.EventHandler(this.UserControlProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn WARRANTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEADDED;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn EDIT;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
        private System.Windows.Forms.DataGridViewImageColumn WITHDRAW;
    }
}
