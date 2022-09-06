namespace QuanLyCuaHangViTinh
{
    partial class frmSanPham
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
            this.label7 = new System.Windows.Forms.Label();
            this.listSP = new System.Windows.Forms.ListView();
            this.MaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaNhaCungCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaLoaiSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGiaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LuongTonKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rdMaSP = new System.Windows.Forms.RadioButton();
            this.rdTenSP = new System.Windows.Forms.RadioButton();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(988, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.listSP);
            this.groupBox3.Controls.Add(this.rdMaSP);
            this.groupBox3.Controls.Add(this.rdTenSP);
            this.groupBox3.Controls.Add(this.btSearch);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(962, 330);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nhập thông tin cần tìm kiếm:";
            // 
            // listSP
            // 
            this.listSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSP,
            this.TenSP,
            this.MaNhaCungCap,
            this.MaLoaiSP,
            this.DonGiaSP,
            this.LuongTonKho});
            this.listSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSP.FullRowSelect = true;
            this.listSP.GridLines = true;
            this.listSP.HideSelection = false;
            this.listSP.Location = new System.Drawing.Point(10, 65);
            this.listSP.Name = "listSP";
            this.listSP.Size = new System.Drawing.Size(942, 259);
            this.listSP.TabIndex = 11;
            this.listSP.UseCompatibleStateImageBehavior = false;
            this.listSP.View = System.Windows.Forms.View.Details;
            // 
            // MaSP
            // 
            this.MaSP.Text = "Mã Sản Phẩm";
            this.MaSP.Width = 120;
            // 
            // TenSP
            // 
            this.TenSP.Text = "Tên Sản Phẩm";
            this.TenSP.Width = 300;
            // 
            // MaNhaCungCap
            // 
            this.MaNhaCungCap.Text = "Mã NCC";
            this.MaNhaCungCap.Width = 120;
            // 
            // MaLoaiSP
            // 
            this.MaLoaiSP.Text = "Mã Loại SP";
            this.MaLoaiSP.Width = 120;
            // 
            // DonGiaSP
            // 
            this.DonGiaSP.Text = "Đơn Giá";
            this.DonGiaSP.Width = 120;
            // 
            // LuongTonKho
            // 
            this.LuongTonKho.Text = "Tồn Kho";
            this.LuongTonKho.Width = 120;
            // 
            // rdMaSP
            // 
            this.rdMaSP.AutoSize = true;
            this.rdMaSP.Location = new System.Drawing.Point(721, 28);
            this.rdMaSP.Name = "rdMaSP";
            this.rdMaSP.Size = new System.Drawing.Size(74, 24);
            this.rdMaSP.TabIndex = 10;
            this.rdMaSP.Text = "Mã SP";
            this.rdMaSP.UseVisualStyleBackColor = true;
            // 
            // rdTenSP
            // 
            this.rdTenSP.AutoSize = true;
            this.rdTenSP.Checked = true;
            this.rdTenSP.Location = new System.Drawing.Point(633, 28);
            this.rdTenSP.Name = "rdTenSP";
            this.rdTenSP.Size = new System.Drawing.Size(79, 24);
            this.rdTenSP.TabIndex = 9;
            this.rdTenSP.TabStop = true;
            this.rdTenSP.Text = "Tên SP";
            this.rdTenSP.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(810, 24);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(142, 35);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(367, 26);
            this.txtSearch.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.btClose);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtMaLoaiSP);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 193);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(169, 152);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(152, 35);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(643, 152);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(152, 35);
            this.btClose.TabIndex = 15;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click_1);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(327, 152);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(152, 35);
            this.btEdit.TabIndex = 13;
            this.btEdit.Text = "Sửa ";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(485, 152);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(152, 35);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(683, 109);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(265, 26);
            this.txtSoLuong.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(683, 71);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(265, 26);
            this.txtDonGia.TabIndex = 9;
            // 
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Location = new System.Drawing.Point(683, 31);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(265, 26);
            this.txtMaLoaiSP.TabIndex = 8;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(208, 111);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(297, 26);
            this.txtMaNCC.TabIndex = 7;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(208, 71);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(297, 26);
            this.txtTenSP.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đơn Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã loại sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(8, 33);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(109, 20);
            this.lb.TabIndex = 16;
            this.lb.Text = "Mã sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(208, 31);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(297, 26);
            this.txtMaSP.TabIndex = 17;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 585);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listSP;
        private System.Windows.Forms.ColumnHeader MaSP;
        private System.Windows.Forms.ColumnHeader TenSP;
        private System.Windows.Forms.ColumnHeader MaNhaCungCap;
        private System.Windows.Forms.ColumnHeader MaLoaiSP;
        private System.Windows.Forms.ColumnHeader DonGiaSP;
        private System.Windows.Forms.ColumnHeader LuongTonKho;
        private System.Windows.Forms.RadioButton rdMaSP;
        private System.Windows.Forms.RadioButton rdTenSP;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lb;
    }
}