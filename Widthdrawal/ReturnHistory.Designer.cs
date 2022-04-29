
namespace Inventory_System_Management_Alliance28.Widthdrawal
{
    partial class ReturnHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnHistory));
            this.dataGridReturnList = new System.Windows.Forms.DataGridView();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.TRANSACTION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETURNED_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturnList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReturnList
            // 
            this.dataGridReturnList.AllowUserToAddRows = false;
            this.dataGridReturnList.AllowUserToDeleteRows = false;
            this.dataGridReturnList.AllowUserToResizeColumns = false;
            this.dataGridReturnList.AllowUserToResizeRows = false;
            this.dataGridReturnList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridReturnList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridReturnList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridReturnList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReturnList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridReturnList.ColumnHeadersHeight = 50;
            this.dataGridReturnList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DELETE,
            this.TRANSACTION_ID,
            this.CLIENT_NAME,
            this.PRODUCT_NAME,
            this.ITEM_CODE,
            this.QUANTITY,
            this.RETURNED_DATE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridReturnList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridReturnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridReturnList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dataGridReturnList.Location = new System.Drawing.Point(0, 0);
            this.dataGridReturnList.MultiSelect = false;
            this.dataGridReturnList.Name = "dataGridReturnList";
            this.dataGridReturnList.ReadOnly = true;
            this.dataGridReturnList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridReturnList.RowHeadersVisible = false;
            this.dataGridReturnList.RowHeadersWidth = 50;
            this.dataGridReturnList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridReturnList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReturnList.Size = new System.Drawing.Size(974, 594);
            this.dataGridReturnList.TabIndex = 2;
            this.dataGridReturnList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReturnList_CellContentClick);
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "";
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            this.DELETE.Width = 13;
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
            // QUANTITY
            // 
            this.QUANTITY.DataPropertyName = "QUANTITY";
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            this.QUANTITY.Width = 127;
            // 
            // RETURNED_DATE
            // 
            this.RETURNED_DATE.DataPropertyName = "TIMESTAMP";
            this.RETURNED_DATE.HeaderText = "RETURNED DATE";
            this.RETURNED_DATE.Name = "RETURNED_DATE";
            this.RETURNED_DATE.ReadOnly = true;
            this.RETURNED_DATE.Width = 200;
            // 
            // ReturnHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 594);
            this.Controls.Add(this.dataGridReturnList);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReturnHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Item History";
            this.Load += new System.EventHandler(this.ReturnHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturnList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReturnList;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETURNED_DATE;
    }
}