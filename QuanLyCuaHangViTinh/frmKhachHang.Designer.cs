namespace QuanLyCuaHangViTinh
{
    partial class frmKhachHang
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listKH = new System.Windows.Forms.ListView();
            this.MaKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChiKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SdtKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sodiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HanMuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLanMua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rdCode = new System.Windows.Forms.RadioButton();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChiKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1262, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.listKH);
            this.groupBox3.Controls.Add(this.rdCode);
            this.groupBox3.Controls.Add(this.rdName);
            this.groupBox3.Controls.Add(this.btSearch);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1234, 402);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nhập thông tin cần tìm kiếm:";
            // 
            // listKH
            // 
            this.listKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.DiaChiKH,
            this.SdtKH,
            this.Sodiem,
            this.HanMuc,
            this.SoLanMua,
            this.GhiChu});
            this.listKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKH.FullRowSelect = true;
            this.listKH.GridLines = true;
            this.listKH.HideSelection = false;
            this.listKH.LabelEdit = true;
            this.listKH.Location = new System.Drawing.Point(13, 66);
            this.listKH.Name = "listKH";
            this.listKH.Size = new System.Drawing.Size(1208, 330);
            this.listKH.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listKH.TabIndex = 11;
            this.listKH.UseCompatibleStateImageBehavior = false;
            this.listKH.View = System.Windows.Forms.View.Details;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.Text = "Mã Khách Hàng";
            this.MaKhachHang.Width = 150;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.Text = "Tên Khách Hàng";
            this.TenKhachHang.Width = 200;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.Text = "Địa Chỉ";
            this.DiaChiKH.Width = 170;
            // 
            // SdtKH
            // 
            this.SdtKH.Text = "Số Điện Thoại";
            this.SdtKH.Width = 203;
            // 
            // Sodiem
            // 
            this.Sodiem.Text = "Số Điểm Tích";
            this.Sodiem.Width = 120;
            // 
            // HanMuc
            // 
            this.HanMuc.Text = "Hạn Mức";
            this.HanMuc.Width = 120;
            // 
            // SoLanMua
            // 
            this.SoLanMua.Text = "Số Lần Mua";
            this.SoLanMua.Width = 120;
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "Ghi Chú";
            this.GhiChu.Width = 120;
            // 
            // rdCode
            // 
            this.rdCode.AutoSize = true;
            this.rdCode.Location = new System.Drawing.Point(998, 35);
            this.rdCode.Name = "rdCode";
            this.rdCode.Size = new System.Drawing.Size(75, 24);
            this.rdCode.TabIndex = 10;
            this.rdCode.Text = "Mã KH";
            this.rdCode.UseVisualStyleBackColor = true;
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Checked = true;
            this.rdName.Location = new System.Drawing.Point(897, 35);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(80, 24);
            this.rdName.TabIndex = 9;
            this.rdName.TabStop = true;
            this.rdName.Text = "Tên KH";
            this.rdName.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(1089, 28);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(132, 35);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(273, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(604, 26);
            this.txtSearch.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btClose);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChiKhachHang);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1234, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(781, 34);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(440, 26);
            this.txtSoDienThoai.TabIndex = 7;
            // 
            // txtDiaChiKhachHang
            // 
            this.txtDiaChiKhachHang.Location = new System.Drawing.Point(167, 78);
            this.txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            this.txtDiaChiKhachHang.Size = new System.Drawing.Size(453, 26);
            this.txtDiaChiKhachHang.TabIndex = 6;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(167, 34);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(453, 26);
            this.txtTenKhachHang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng:";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(150, 127);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(179, 40);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(402, 127);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(179, 40);
            this.btEdit.TabIndex = 9;
            this.btEdit.Text = "Sửa ";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(906, 127);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(179, 40);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(654, 127);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(179, 40);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(781, 78);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(440, 26);
            this.txtDiem.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số điểm tích:";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 646);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listKH;
        private System.Windows.Forms.ColumnHeader MaKhachHang;
        private System.Windows.Forms.ColumnHeader TenKhachHang;
        private System.Windows.Forms.ColumnHeader DiaChiKH;
        private System.Windows.Forms.ColumnHeader SdtKH;
        private System.Windows.Forms.ColumnHeader Sodiem;
        private System.Windows.Forms.ColumnHeader HanMuc;
        private System.Windows.Forms.ColumnHeader SoLanMua;
        private System.Windows.Forms.ColumnHeader GhiChu;
        private System.Windows.Forms.RadioButton rdCode;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChiKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label2;
    }
}