namespace NHOM1_QLKHO.GUI
{
    partial class fCommodity
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
            this.dgvCommodity = new System.Windows.Forms.DataGridView();
            this.txtCommodityCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCommodityName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNSX = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProducerCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommodity
            // 
            this.dgvCommodity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommodity.Location = new System.Drawing.Point(140, 341);
            this.dgvCommodity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCommodity.Name = "dgvCommodity";
            this.dgvCommodity.RowHeadersWidth = 51;
            this.dgvCommodity.RowTemplate.Height = 24;
            this.dgvCommodity.Size = new System.Drawing.Size(1016, 293);
            this.dgvCommodity.TabIndex = 50;
            // 
            // txtCommodityCode
            // 
            this.txtCommodityCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommodityCode.Location = new System.Drawing.Point(328, 119);
            this.txtCommodityCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCommodityCode.Name = "txtCommodityCode";
            this.txtCommodityCode.Size = new System.Drawing.Size(171, 30);
            this.txtCommodityCode.TabIndex = 49;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1071, 283);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 37);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(889, 282);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(156, 37);
            this.txtTimKiem.TabIndex = 47;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1071, 163);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 36);
            this.btnRefresh.TabIndex = 46;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1071, 106);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 38);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(963, 163);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 38);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(963, 106);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCommodityName
            // 
            this.txtCommodityName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommodityName.Location = new System.Drawing.Point(328, 182);
            this.txtCommodityName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCommodityName.Multiline = true;
            this.txtCommodityName.Name = "txtCommodityName";
            this.txtCommodityName.Size = new System.Drawing.Size(171, 32);
            this.txtCommodityName.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tên Hàng Hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mã Hàng Hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 37;
            this.label1.Text = "Quản Lí Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ngày Sản Xuất";
            // 
            // dtpNSX
            // 
            this.dtpNSX.Location = new System.Drawing.Point(695, 116);
            this.dtpNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNSX.Name = "dtpNSX";
            this.dtpNSX.Size = new System.Drawing.Size(231, 22);
            this.dtpNSX.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "Hạn Sử Dụng";
            // 
            // dtpHSD
            // 
            this.dtpHSD.Location = new System.Drawing.Point(695, 170);
            this.dtpHSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(231, 22);
            this.dtpHSD.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 57;
            this.label6.Text = "Mã NSX";
            // 
            // txtProducerCode
            // 
            this.txtProducerCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducerCode.Location = new System.Drawing.Point(328, 237);
            this.txtProducerCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducerCode.Name = "txtProducerCode";
            this.txtProducerCode.Size = new System.Drawing.Size(171, 30);
            this.txtProducerCode.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-3, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 60;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(517, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 35);
            this.label7.TabIndex = 61;
            this.label7.Text = "Quản lý hàng hóa";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fCommodity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NHOM1_QLKHO.Properties.Resources.mau_background_don_gian_02_1024x768;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1272, 693);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProducerCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpHSD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNSX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCommodity);
            this.Controls.Add(this.txtCommodityCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCommodityName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fCommodity";
            this.Text = "fCommodity";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommodity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommodity;
        private System.Windows.Forms.TextBox txtCommodityCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCommodityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProducerCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}