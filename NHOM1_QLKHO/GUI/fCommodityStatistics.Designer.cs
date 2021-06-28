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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(389, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 35);
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
            this.dtgvCommodity.Location = new System.Drawing.Point(44, 206);
            this.dtgvCommodity.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvCommodity.Name = "dtgvCommodity";
            this.dtgvCommodity.RowHeadersWidth = 51;
            this.dtgvCommodity.Size = new System.Drawing.Size(1139, 388);
            this.dtgvCommodity.TabIndex = 1;
            // 
            // CommodityCode
            // 
            this.CommodityCode.DataPropertyName = "CommodityCode";
            this.CommodityCode.HeaderText = "Mã Hàng Hóa";
            this.CommodityCode.MinimumWidth = 6;
            this.CommodityCode.Name = "CommodityCode";
            this.CommodityCode.Width = 125;
            // 
            // CommodityName
            // 
            this.CommodityName.DataPropertyName = "CommodityName";
            this.CommodityName.HeaderText = "Tên Hàng Hóa";
            this.CommodityName.MinimumWidth = 6;
            this.CommodityName.Name = "CommodityName";
            this.CommodityName.Width = 180;
            // 
            // DateOfManufacture
            // 
            this.DateOfManufacture.DataPropertyName = "DateOfManufacture";
            this.DateOfManufacture.HeaderText = "Ngày Sản Xuất";
            this.DateOfManufacture.MinimumWidth = 6;
            this.DateOfManufacture.Name = "DateOfManufacture";
            this.DateOfManufacture.Width = 120;
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.DataPropertyName = "ExpiryDate";
            this.ExpiryDate.HeaderText = "Hạn Sử Dụng";
            this.ExpiryDate.MinimumWidth = 6;
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Width = 120;
            // 
            // ProducerCode
            // 
            this.ProducerCode.DataPropertyName = "ProducerCode";
            this.ProducerCode.HeaderText = "Mã NSX";
            this.ProducerCode.MinimumWidth = 6;
            this.ProducerCode.Name = "ProducerCode";
            this.ProducerCode.Width = 125;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Số Lượng";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // txtCommodityName
            // 
            this.txtCommodityName.Location = new System.Drawing.Point(850, 148);
            this.txtCommodityName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommodityName.Name = "txtCommodityName";
            this.txtCommodityName.Size = new System.Drawing.Size(212, 22);
            this.txtCommodityName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1083, 145);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(155, 145);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refesh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 61;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fCommodityStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NHOM1_QLKHO.Properties.Resources.mau_background_don_gian_02_1024x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCommodityName);
            this.Controls.Add(this.dtgvCommodity);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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