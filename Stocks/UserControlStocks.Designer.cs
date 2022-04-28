
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridStocks = new System.Windows.Forms.DataGridView();
            this.ITEMCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WARRANTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEADDED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStocks.ColumnHeadersHeight = 50;
            this.dataGridStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEMCODE,
            this.PRODUCTNAME,
            this.CATEGORY,
            this.QUANTITY,
            this.WARRANTY,
            this.DESCRIPTION,
            this.DATEADDED,
            this.IMAGE,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStocks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridStocks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dataGridStocks.Location = new System.Drawing.Point(0, 54);
            this.dataGridStocks.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridStocks.MultiSelect = false;
            this.dataGridStocks.Name = "dataGridStocks";
            this.dataGridStocks.ReadOnly = true;
            this.dataGridStocks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridStocks.RowHeadersVisible = false;
            this.dataGridStocks.RowHeadersWidth = 50;
            this.dataGridStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStocks.Size = new System.Drawing.Size(1015, 691);
            this.dataGridStocks.TabIndex = 7;
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
            // DATEADDED
            // 
            this.DATEADDED.DataPropertyName = "TIMESTAMP";
            this.DATEADDED.HeaderText = "DATE ADDED";
            this.DATEADDED.Name = "DATEADDED";
            this.DATEADDED.ReadOnly = true;
            // 
            // IMAGE
            // 
            this.IMAGE.DataPropertyName = "IMAGE";
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
            this.Column9.Width = 200;
            // 
            // UserControlStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridStocks);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1020, 750);
            this.Name = "UserControlStocks";
            this.Size = new System.Drawing.Size(1020, 750);
            this.Load += new System.EventHandler(this.UserControlStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn WARRANTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEADDED;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
    }
}
