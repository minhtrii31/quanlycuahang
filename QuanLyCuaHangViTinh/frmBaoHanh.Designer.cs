namespace QuanLyCuaHangViTinh
{
    partial class frmBaoHanh
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
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.txtNgayGiaoHang = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaBH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBH = new System.Windows.Forms.ListView();
            this.MaBaoHanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaHoaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayGiaoHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoanThanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(854, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẢO HÀNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btClose);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.txtNgayGiaoHang);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.txtMaBH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảo hành";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(691, 91);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(126, 40);
            this.btClose.TabIndex = 15;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(546, 91);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(126, 40);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(546, 17);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(126, 40);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(691, 17);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(126, 40);
            this.btEdit.TabIndex = 13;
            this.btEdit.Text = "Sửa ";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // txtNgayGiaoHang
            // 
            this.txtNgayGiaoHang.Location = new System.Drawing.Point(135, 105);
            this.txtNgayGiaoHang.Name = "txtNgayGiaoHang";
            this.txtNgayGiaoHang.Size = new System.Drawing.Size(386, 26);
            this.txtNgayGiaoHang.TabIndex = 5;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(135, 62);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(386, 26);
            this.txtMaHD.TabIndex = 4;
            // 
            // txtMaBH
            // 
            this.txtMaBH.Location = new System.Drawing.Point(135, 19);
            this.txtMaBH.Name = "txtMaBH";
            this.txtMaBH.Size = new System.Drawing.Size(386, 26);
            this.txtMaBH.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày giao hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã hoá đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bảo hành:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBH);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 331);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bảo hành";
            // 
            // listBH
            // 
            this.listBH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaBaoHanh,
            this.MaHoaDon,
            this.NgayGiaoHang,
            this.HoanThanh});
            this.listBH.FullRowSelect = true;
            this.listBH.GridLines = true;
            this.listBH.HideSelection = false;
            this.listBH.Location = new System.Drawing.Point(10, 57);
            this.listBH.Name = "listBH";
            this.listBH.Size = new System.Drawing.Size(807, 268);
            this.listBH.TabIndex = 19;
            this.listBH.UseCompatibleStateImageBehavior = false;
            this.listBH.View = System.Windows.Forms.View.Details;
            // 
            // MaBaoHanh
            // 
            this.MaBaoHanh.Text = "Mã Bảo Hành";
            this.MaBaoHanh.Width = 200;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.Text = "Mã Hoá Đơn";
            this.MaHoaDon.Width = 200;
            // 
            // NgayGiaoHang
            // 
            this.NgayGiaoHang.Text = "Ngày Giao Hàng";
            this.NgayGiaoHang.Width = 200;
            // 
            // HoanThanh
            // 
            this.HoanThanh.Text = "Bảo Hành Xong";
            this.HoanThanh.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(191, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(386, 26);
            this.textBox4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mã bảo hành:";
            // 
            // frmBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảo Hành";
            this.Load += new System.EventHandler(this.frmBaoHanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNgayGiaoHang;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaBH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listBH;
        private System.Windows.Forms.ColumnHeader MaBaoHanh;
        private System.Windows.Forms.ColumnHeader MaHoaDon;
        private System.Windows.Forms.ColumnHeader NgayGiaoHang;
        private System.Windows.Forms.ColumnHeader HoanThanh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
    }
}