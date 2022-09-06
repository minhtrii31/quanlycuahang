namespace QuanLyCuaHangViTinh
{
    partial class frmNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtCaTruc = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listNV = new System.Windows.Forms.ListView();
            this.MaNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTenNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaCuaHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChucVuNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDTNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoiVP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChiNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinhNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LuongNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThuongNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SNVang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SNNghi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CaTruc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GhiChu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1267, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btClose);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.txtCaTruc);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtMaCH);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm nhân viên";
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(994, 84);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(109, 35);
            this.btClose.TabIndex = 23;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(879, 33);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(109, 35);
            this.btAdd.TabIndex = 20;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(994, 33);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(109, 35);
            this.btEdit.TabIndex = 21;
            this.btEdit.Text = "Sửa ";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(1109, 33);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(109, 35);
            this.btDelete.TabIndex = 22;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // txtCaTruc
            // 
            this.txtCaTruc.Location = new System.Drawing.Point(579, 96);
            this.txtCaTruc.Name = "txtCaTruc";
            this.txtCaTruc.Size = new System.Drawing.Size(254, 26);
            this.txtCaTruc.TabIndex = 13;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(579, 59);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(254, 26);
            this.txtChucVu.TabIndex = 12;
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(579, 25);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(254, 26);
            this.txtMaCH.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(125, 127);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(254, 26);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(125, 93);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(254, 26);
            this.txtSDT.TabIndex = 9;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(125, 59);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(254, 26);
            this.txtNgaySinh.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(125, 25);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(254, 26);
            this.txtTen.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ca trực:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã cửa hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listNV);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1242, 391);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // listNV
            // 
            this.listNV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNhanVien,
            this.HoTenNhanVien,
            this.MaCuaHang,
            this.ChucVuNV,
            this.SDTNV,
            this.LoiVP,
            this.DiaChiNV,
            this.NgaySinhNV,
            this.LuongNhanVien,
            this.ThuongNhanVien,
            this.HeSoLuong,
            this.SNVang,
            this.SNNghi,
            this.CaTruc,
            this.GhiChu});
            this.listNV.FullRowSelect = true;
            this.listNV.GridLines = true;
            this.listNV.HideSelection = false;
            this.listNV.Location = new System.Drawing.Point(6, 60);
            this.listNV.Name = "listNV";
            this.listNV.Size = new System.Drawing.Size(1230, 325);
            this.listNV.TabIndex = 25;
            this.listNV.UseCompatibleStateImageBehavior = false;
            this.listNV.View = System.Windows.Forms.View.Details;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Text = "Mã NV";
            this.MaNhanVien.Width = 70;
            // 
            // HoTenNhanVien
            // 
            this.HoTenNhanVien.Text = "Họ Tên";
            this.HoTenNhanVien.Width = 150;
            // 
            // MaCuaHang
            // 
            this.MaCuaHang.Text = "Mã CH";
            this.MaCuaHang.Width = 70;
            // 
            // ChucVuNV
            // 
            this.ChucVuNV.Text = "Chức Vụ";
            this.ChucVuNV.Width = 80;
            // 
            // SDTNV
            // 
            this.SDTNV.Text = "SĐT";
            this.SDTNV.Width = 100;
            // 
            // LoiVP
            // 
            this.LoiVP.Text = "Lỗi VP";
            this.LoiVP.Width = 70;
            // 
            // DiaChiNV
            // 
            this.DiaChiNV.Text = "Địa Chỉ";
            this.DiaChiNV.Width = 100;
            // 
            // NgaySinhNV
            // 
            this.NgaySinhNV.Text = "Ngày Sinh";
            this.NgaySinhNV.Width = 100;
            // 
            // LuongNhanVien
            // 
            this.LuongNhanVien.Text = "Lương";
            this.LuongNhanVien.Width = 70;
            // 
            // ThuongNhanVien
            // 
            this.ThuongNhanVien.Text = "Lương Thưởng";
            this.ThuongNhanVien.Width = 70;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.Text = "Hệ Số";
            this.HeSoLuong.Width = 70;
            // 
            // SNVang
            // 
            this.SNVang.Text = "Vắng";
            this.SNVang.Width = 70;
            // 
            // SNNghi
            // 
            this.SNNghi.Text = "Nghỉ";
            this.SNNghi.Width = 70;
            // 
            // CaTruc
            // 
            this.CaTruc.Text = "Ca";
            this.CaTruc.Width = 50;
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "Ghi Chú";
            this.GhiChu.Width = 70;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(732, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(472, 24);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(254, 26);
            this.textBox8.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã số nhân viên:";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCaTruc;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listNV;
        private System.Windows.Forms.ColumnHeader MaNhanVien;
        private System.Windows.Forms.ColumnHeader HoTenNhanVien;
        private System.Windows.Forms.ColumnHeader MaCuaHang;
        private System.Windows.Forms.ColumnHeader ChucVuNV;
        private System.Windows.Forms.ColumnHeader SDTNV;
        private System.Windows.Forms.ColumnHeader LoiVP;
        private System.Windows.Forms.ColumnHeader DiaChiNV;
        private System.Windows.Forms.ColumnHeader NgaySinhNV;
        private System.Windows.Forms.ColumnHeader LuongNhanVien;
        private System.Windows.Forms.ColumnHeader ThuongNhanVien;
        private System.Windows.Forms.ColumnHeader HeSoLuong;
        private System.Windows.Forms.ColumnHeader SNVang;
        private System.Windows.Forms.ColumnHeader SNNghi;
        private System.Windows.Forms.ColumnHeader CaTruc;
        private System.Windows.Forms.ColumnHeader GhiChu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
    }
}