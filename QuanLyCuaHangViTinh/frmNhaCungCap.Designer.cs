namespace QuanLyCuaHangViTinh
{
    partial class frmNhaCungCap
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
            this.btClose = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listNCC = new System.Windows.Forms.ListView();
            this.MaNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuongSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TGGiao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTGGiao = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(868, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHÀ CUNG CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(747, 511);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(109, 35);
            this.btClose.TabIndex = 19;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(402, 511);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(109, 35);
            this.btAdd.TabIndex = 16;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listNCC);
            this.groupBox3.Controls.Add(this.rdMa);
            this.groupBox3.Controls.Add(this.rdTen);
            this.groupBox3.Controls.Add(this.btSearch);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(844, 280);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // listNCC
            // 
            this.listNCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNCC,
            this.TenNCC,
            this.MaSP,
            this.MaCH,
            this.SoLuongSP,
            this.TGGiao});
            this.listNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNCC.FullRowSelect = true;
            this.listNCC.GridLines = true;
            this.listNCC.HideSelection = false;
            this.listNCC.Location = new System.Drawing.Point(10, 65);
            this.listNCC.Name = "listNCC";
            this.listNCC.Size = new System.Drawing.Size(823, 201);
            this.listNCC.TabIndex = 11;
            this.listNCC.UseCompatibleStateImageBehavior = false;
            this.listNCC.View = System.Windows.Forms.View.Details;
            // 
            // MaNCC
            // 
            this.MaNCC.Text = "Mã NCC";
            this.MaNCC.Width = 80;
            // 
            // TenNCC
            // 
            this.TenNCC.Text = "Tên NCC";
            this.TenNCC.Width = 150;
            // 
            // MaSP
            // 
            this.MaSP.Text = "Mã Sản Phẩm";
            this.MaSP.Width = 150;
            // 
            // MaCH
            // 
            this.MaCH.Text = "Mã Cửa Hàng";
            this.MaCH.Width = 150;
            // 
            // SoLuongSP
            // 
            this.SoLuongSP.Text = "Số Lượng";
            this.SoLuongSP.Width = 100;
            // 
            // TGGiao
            // 
            this.TGGiao.Text = "Thời Gian Giao";
            this.TGGiao.Width = 180;
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Location = new System.Drawing.Point(622, 26);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(86, 24);
            this.rdMa.TabIndex = 10;
            this.rdMa.Text = "Mã NCC";
            this.rdMa.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Checked = true;
            this.rdTen.Location = new System.Drawing.Point(510, 26);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(91, 24);
            this.rdTen.TabIndex = 9;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Tên NCC";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(724, 23);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(109, 35);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(482, 26);
            this.txtSearch.TabIndex = 8;
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(517, 511);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(109, 35);
            this.btEdit.TabIndex = 17;
            this.btEdit.Text = "Sửa ";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(632, 511);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(109, 35);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaCH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTGGiao);
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 163);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTGGiao
            // 
            this.txtTGGiao.Location = new System.Drawing.Point(538, 77);
            this.txtTGGiao.Name = "txtTGGiao";
            this.txtTGGiao.Size = new System.Drawing.Size(295, 26);
            this.txtTGGiao.TabIndex = 7;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(538, 28);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(295, 26);
            this.txtSL.TabIndex = 6;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(121, 74);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(272, 26);
            this.txtTenNCC.TabIndex = 5;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(121, 28);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(272, 26);
            this.txtMaNCC.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thời gian giao:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên NCC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NCC:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(121, 118);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(272, 26);
            this.txtMaSP.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã sản phẩm:";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(538, 121);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(295, 26);
            this.txtMaCH.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã cửa hàng:";
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 559);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listNCC;
        private System.Windows.Forms.ColumnHeader MaNCC;
        private System.Windows.Forms.ColumnHeader TenNCC;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTGGiao;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader MaSP;
        private System.Windows.Forms.ColumnHeader MaCH;
        private System.Windows.Forms.ColumnHeader SoLuongSP;
        private System.Windows.Forms.ColumnHeader TGGiao;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.Label label7;
    }
}