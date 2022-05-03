
namespace Inventory_System_Management_Alliance28.Widthdrawal
{
    partial class UserControlTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTransaction));
            this.dataGridTransaction = new System.Windows.Forms.DataGridView();
            this.Dashboard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNext = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPrev = new System.Windows.Forms.Label();
            this.RETURN = new System.Windows.Forms.DataGridViewImageColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.PICTURE = new System.Windows.Forms.DataGridViewImageColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WITHDRAWAL_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSACTION_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WARRANTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSACTION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COPY = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridTransaction
            // 
            this.dataGridTransaction.AllowUserToAddRows = false;
            this.dataGridTransaction.AllowUserToDeleteRows = false;
            this.dataGridTransaction.AllowUserToResizeColumns = false;
            this.dataGridTransaction.AllowUserToResizeRows = false;
            this.dataGridTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridTransaction.ColumnHeadersHeight = 50;
            this.dataGridTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COPY,
            this.TRANSACTION_ID,
            this.CLIENT_NAME,
            this.PRODUCT_NAME,
            this.ITEM_CODE,
            this.QUANTITY,
            this.WARRANTY,
            this.TRANSACTION_TYPE,
            this.WITHDRAWAL_DATE,
            this.IMAGE,
            this.PICTURE,
            this.DELETE,
            this.RETURN});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTransaction.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dataGridTransaction.Location = new System.Drawing.Point(0, 81);
            this.dataGridTransaction.MultiSelect = false;
            this.dataGridTransaction.Name = "dataGridTransaction";
            this.dataGridTransaction.ReadOnly = true;
            this.dataGridTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridTransaction.RowHeadersVisible = false;
            this.dataGridTransaction.RowHeadersWidth = 50;
            this.dataGridTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTransaction.Size = new System.Drawing.Size(1020, 660);
            this.dataGridTransaction.TabIndex = 1;
            this.dataGridTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTransaction_CellContentClick);
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Dashboard.Location = new System.Drawing.Point(18, 34);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(179, 28);
            this.Dashboard.TabIndex = 8;
            this.Dashboard.Text = "Withdraw Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(686, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search by Transaction ID/Client Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(690, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 30);
            this.panel1.TabIndex = 9;
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
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(136)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(551, 38);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 30);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(430, 38);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(115, 30);
            this.btnHistory.TabIndex = 12;
            this.btnHistory.Text = "Return History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lbPrev);
            this.panel2.Controls.Add(this.lbNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 762);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 38);
            this.panel2.TabIndex = 14;
            // 
            // lbNext
            // 
            this.lbNext.AutoSize = true;
            this.lbNext.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNext.Location = new System.Drawing.Point(581, 16);
            this.lbNext.Name = "lbNext";
            this.lbNext.Size = new System.Drawing.Size(34, 15);
            this.lbNext.TabIndex = 3;
            this.lbNext.Text = "NEXT";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(463, 14);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(20, 20);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(561, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(20, 20);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHistory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 79);
            this.panel3.TabIndex = 15;
            // 
            // lbPrev
            // 
            this.lbPrev.AutoSize = true;
            this.lbPrev.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrev.Location = new System.Drawing.Point(403, 16);
            this.lbPrev.Name = "lbPrev";
            this.lbPrev.Size = new System.Drawing.Size(59, 15);
            this.lbPrev.TabIndex = 4;
            this.lbPrev.Text = "PREVIOUS";
            // 
            // RETURN
            // 
            this.RETURN.HeaderText = "";
            this.RETURN.Image = ((System.Drawing.Image)(resources.GetObject("RETURN.Image")));
            this.RETURN.Name = "RETURN";
            this.RETURN.ReadOnly = true;
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "";
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            // 
            // PICTURE
            // 
            this.PICTURE.DataPropertyName = "PICTURE";
            this.PICTURE.HeaderText = "PICTURE";
            this.PICTURE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.PICTURE.Name = "PICTURE";
            this.PICTURE.ReadOnly = true;
            // 
            // IMAGE
            // 
            this.IMAGE.DataPropertyName = "IMAGE";
            this.IMAGE.HeaderText = "IMAGE";
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.ReadOnly = true;
            this.IMAGE.Visible = false;
            this.IMAGE.Width = 101;
            // 
            // WITHDRAWAL_DATE
            // 
            this.WITHDRAWAL_DATE.DataPropertyName = "TIMESTAMP";
            this.WITHDRAWAL_DATE.HeaderText = "WITHDRAWAL DATE";
            this.WITHDRAWAL_DATE.Name = "WITHDRAWAL_DATE";
            this.WITHDRAWAL_DATE.ReadOnly = true;
            this.WITHDRAWAL_DATE.Width = 200;
            // 
            // TRANSACTION_TYPE
            // 
            this.TRANSACTION_TYPE.DataPropertyName = "TRANSACTION_TYPE";
            this.TRANSACTION_TYPE.HeaderText = "TRANSACTION TYPE";
            this.TRANSACTION_TYPE.Name = "TRANSACTION_TYPE";
            this.TRANSACTION_TYPE.ReadOnly = true;
            this.TRANSACTION_TYPE.Width = 202;
            // 
            // WARRANTY
            // 
            this.WARRANTY.DataPropertyName = "WARRANTY";
            this.WARRANTY.HeaderText = "WARRANTY";
            this.WARRANTY.Name = "WARRANTY";
            this.WARRANTY.ReadOnly = true;
            this.WARRANTY.Width = 137;
            // 
            // QUANTITY
            // 
            this.QUANTITY.DataPropertyName = "QUANTITY";
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ReadOnly = true;
            this.QUANTITY.Width = 127;
            // 
            // ITEM_CODE
            // 
            this.ITEM_CODE.DataPropertyName = "ITEM_CODE";
            this.ITEM_CODE.HeaderText = "ITEM CODE";
            this.ITEM_CODE.Name = "ITEM_CODE";
            this.ITEM_CODE.ReadOnly = true;
            this.ITEM_CODE.Width = 134;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.PRODUCT_NAME.HeaderText = "PRODUCT NAME";
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.ReadOnly = true;
            this.PRODUCT_NAME.Width = 175;
            // 
            // CLIENT_NAME
            // 
            this.CLIENT_NAME.DataPropertyName = "CLIENT_NAME";
            this.CLIENT_NAME.HeaderText = "CLIENT NAME";
            this.CLIENT_NAME.Name = "CLIENT_NAME";
            this.CLIENT_NAME.ReadOnly = true;
            this.CLIENT_NAME.Width = 152;
            // 
            // TRANSACTION_ID
            // 
            this.TRANSACTION_ID.DataPropertyName = "TRANSACTION_ID";
            this.TRANSACTION_ID.HeaderText = "TRANSACTION ID";
            this.TRANSACTION_ID.Name = "TRANSACTION_ID";
            this.TRANSACTION_ID.ReadOnly = true;
            this.TRANSACTION_ID.Width = 182;
            // 
            // COPY
            // 
            this.COPY.HeaderText = "";
            this.COPY.Image = ((System.Drawing.Image)(resources.GetObject("COPY.Image")));
            this.COPY.Name = "COPY";
            this.COPY.ReadOnly = true;
            this.COPY.Width = 13;
            // 
            // UserControlTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridTransaction);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlTransaction";
            this.Size = new System.Drawing.Size(1020, 800);
            this.Load += new System.EventHandler(this.UserControlTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTransaction;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnPrevious;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.Label lbNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbPrev;
        private System.Windows.Forms.DataGridViewImageColumn COPY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn WARRANTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTION_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn WITHDRAWAL_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE;
        private System.Windows.Forms.DataGridViewImageColumn PICTURE;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
        private System.Windows.Forms.DataGridViewImageColumn RETURN;
    }
}
