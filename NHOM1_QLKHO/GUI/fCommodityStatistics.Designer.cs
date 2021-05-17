namespace NHOM1_QLKHO.GUI
{
    partial class fCommodityStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvCommodity = new System.Windows.Forms.DataGridView();
            this.CommodityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommodityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfManufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProducerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCommodityName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCommodity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Hàng Tồn Kho";
            // 
            // dtgvCommodity
            // 
            this.dtgvCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCommodity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommodityCode,
            this.CommodityName,
            this.DateOfManufacture,
            this.ExpiryDate,
            this.ProducerCode,
            this.Amount});
            this.dtgvCommodity.Location = new System.Drawing.Point(23, 163);
            this.dtgvCommodity.Name = "dtgvCommodity";
            this.dtgvCommodity.Size = new System.Drawing.Size(764, 315);
            this.dtgvCommodity.TabIndex = 1;
            // 
            // CommodityCode
            // 
            this.CommodityCode.DataPropertyName = "CommodityCode";
            this.CommodityCode.HeaderText = "Mã Hàng Hóa";
            this.CommodityCode.Name = "CommodityCode";
            // 
            // CommodityName
            // 
            this.CommodityName.DataPropertyName = "CommodityName";
            this.CommodityName.HeaderText = "Tên Hàng Hóa";
            this.CommodityName.Name = "CommodityName";
            this.CommodityName.Width = 180;
            // 
            // DateOfManufacture
            // 
            this.DateOfManufacture.DataPropertyName = "DateOfManufacture";
            this.DateOfManufacture.HeaderText = "Ngày Sản Xuất";
            this.DateOfManufacture.Name = "DateOfManufacture";
            this.DateOfManufacture.Width = 120;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.HeaderText = "Hạn Sử Dụng";
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Width = 120;
            // 
            // ProducerCode
            // 
            this.ProducerCode.DataPropertyName = "ProducerCode";
            this.ProducerCode.HeaderText = "Mã NSX";
            this.ProducerCode.Name = "ProducerCode";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.Name = "Amount";
            // 
            // txtCommodityName
            // 
            this.txtCommodityName.Location = new System.Drawing.Point(533, 118);
            this.txtCommodityName.Name = "txtCommodityName";
            this.txtCommodityName.Size = new System.Drawing.Size(160, 20);
            this.txtCommodityName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(712, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(56, 115);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Xem";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fCommodityStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCommodityName);
            this.Controls.Add(this.dtgvCommodity);
            this.Controls.Add(this.label1);
            this.Name = "fCommodityStatistics";
            this.Text = "fCommodityStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCommodity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvCommodity;
        private System.Windows.Forms.TextBox txtCommodityName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommodityCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommodityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfManufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProducerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
    }
}