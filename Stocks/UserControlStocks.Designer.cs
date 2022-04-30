
namespace Inventory_System_Management_Alliance28.Stocks
{
    partial class UserControlStocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStocks));
            this.dataGridStocks = new System.Windows.Forms.DataGridView();
            this.ADD = new System.Windows.Forms.DataGridViewImageColumn();
            this.ITEMCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Dashboard = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStocks
            // 
            this.dataGridStocks.AllowUserToAddRows = false;
            this.dataGridStocks.AllowUserToDeleteRows = false;
            this.dataGridStocks.AllowUserToResizeColumns = false;
            this.dataGridStocks.AllowUserToResizeRows = false;
            this.dataGridStocks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridStocks.ColumnHeadersHeight = 50;
            this.dataGridStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ADD,
            this.ITEMCODE,
            this.PRODUCTNAME,
            this.CATEGORY,
            this.QUANTITY,
            this.IMAGE,
            this.Column9});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStocks.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridStocks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dataGridStocks.Location = new System.Drawing.Point(2, 67);
            this.dataGridStocks.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridStocks.MultiSelect = false;
            this.dataGridStocks.Name = "dataGridStocks";
            this.dataGridStocks.ReadOnly = true;
            this.dataGridStocks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridStocks.RowHeadersVisible = false;
            this.dataGridStocks.RowHeadersWidth = 50;
            this.dataGridStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStocks.Size = new System.Drawing.Size(1015, 678);
            this.dataGridStocks.TabIndex = 7;
            this.dataGridStocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStocks_CellContentClick);
            this.dataGridStocks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridStocks_CellFormatting);
            // 
            // ADD
            // 
            this.ADD.HeaderText = "";
            this.ADD.Image = ((System.Drawing.Image)(resources.GetObject("ADD.Image")));
            this.ADD.Name = "ADD";
            this.ADD.ReadOnly = true;
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
            this.Column9.Width = 200;
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dashboard.Location = new System.Drawing.Point(11, 15);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(152, 28);
            this.Dashboard.TabIndex = 8;
            this.Dashboard.Text = "Out of Stock";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(136)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(863, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 30);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UserControlStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.dataGridStocks);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1020, 750);
            this.Name = "UserControlStocks";
            this.Size = new System.Drawing.Size(1020, 750);
            this.Load += new System.EventHandler(this.UserControlStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridStocks;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.DataGridViewImageColumn ADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.Button btnRefresh;
    }
}
