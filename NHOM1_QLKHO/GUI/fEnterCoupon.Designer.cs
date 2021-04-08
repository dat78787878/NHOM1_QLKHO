namespace NHOM1_QLKHO.GUI
{
    partial class fEnterCoupon
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
            this.dgvEnterCoupon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSLN = new System.Windows.Forms.TextBox();
            this.cbbMNV = new System.Windows.Forms.ComboBox();
            this.cbbMMH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNN = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnterCoupon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEnterCoupon
            // 
            this.dgvEnterCoupon.AllowUserToAddRows = false;
            this.dgvEnterCoupon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEnterCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnterCoupon.Location = new System.Drawing.Point(24, 255);
            this.dgvEnterCoupon.Name = "dgvEnterCoupon";
            this.dgvEnterCoupon.RowHeadersWidth = 62;
            this.dgvEnterCoupon.RowTemplate.Height = 28;
            this.dgvEnterCoupon.Size = new System.Drawing.Size(1136, 389);
            this.dgvEnterCoupon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(756, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 220);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(268, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 58);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(22, 144);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(228, 26);
            this.txtTimKiem.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(286, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 58);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(156, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 58);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 58);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNN);
            this.groupBox1.Controls.Add(this.txtSLN);
            this.groupBox1.Controls.Add(this.cbbMNV);
            this.groupBox1.Controls.Add(this.cbbMMH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // txtSLN
            // 
            this.txtSLN.Location = new System.Drawing.Point(466, 129);
            this.txtSLN.Name = "txtSLN";
            this.txtSLN.Size = new System.Drawing.Size(238, 26);
            this.txtSLN.TabIndex = 11;
            // 
            // cbbMNV
            // 
            this.cbbMNV.FormattingEnabled = true;
            this.cbbMNV.Location = new System.Drawing.Point(131, 129);
            this.cbbMNV.Name = "cbbMNV";
            this.cbbMNV.Size = new System.Drawing.Size(204, 28);
            this.cbbMNV.TabIndex = 9;
            // 
            // cbbMMH
            // 
            this.cbbMMH.FormattingEnabled = true;
            this.cbbMMH.Location = new System.Drawing.Point(131, 42);
            this.cbbMMH.Name = "cbbMMH";
            this.cbbMMH.Size = new System.Drawing.Size(204, 28);
            this.cbbMMH.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số lượng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã mặt hàng";
            // 
            // dtNN
            // 
            this.dtNN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNN.Location = new System.Drawing.Point(466, 42);
            this.dtNN.Name = "dtNN";
            this.dtNN.Size = new System.Drawing.Size(238, 26);
            this.dtNN.TabIndex = 12;
            // 
            // fEnterCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 656);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvEnterCoupon);
            this.Name = "fEnterCoupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEnterCoupon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnterCoupon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEnterCoupon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSLN;
        private System.Windows.Forms.ComboBox cbbMNV;
        private System.Windows.Forms.ComboBox cbbMMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNN;
    }
}