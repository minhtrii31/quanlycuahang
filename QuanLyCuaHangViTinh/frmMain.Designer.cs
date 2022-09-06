namespace QuanLyCuaHangViTinh
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSP = new System.Windows.Forms.Button();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btNCC = new System.Windows.Forms.Button();
            this.btBaoHanh = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CỬA HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btNhanVien
            // 
            this.btNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanVien.Location = new System.Drawing.Point(17, 28);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(149, 63);
            this.btNhanVien.TabIndex = 1;
            this.btNhanVien.Text = "Nhân viên";
            this.btNhanVien.UseVisualStyleBackColor = true;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btBaoHanh);
            this.groupBox1.Controls.Add(this.btNCC);
            this.groupBox1.Controls.Add(this.btKhachHang);
            this.groupBox1.Controls.Add(this.btSP);
            this.groupBox1.Controls.Add(this.btNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btSP
            // 
            this.btSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSP.Location = new System.Drawing.Point(169, 28);
            this.btSP.Name = "btSP";
            this.btSP.Size = new System.Drawing.Size(149, 63);
            this.btSP.TabIndex = 2;
            this.btSP.Text = "Sản phẩm";
            this.btSP.UseVisualStyleBackColor = true;
            this.btSP.Click += new System.EventHandler(this.btSP_Click);
            // 
            // btKhachHang
            // 
            this.btKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhachHang.Location = new System.Drawing.Point(321, 28);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.Size = new System.Drawing.Size(149, 63);
            this.btKhachHang.TabIndex = 3;
            this.btKhachHang.Text = "Khách hàng";
            this.btKhachHang.UseVisualStyleBackColor = true;
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // btNCC
            // 
            this.btNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNCC.Location = new System.Drawing.Point(473, 28);
            this.btNCC.Name = "btNCC";
            this.btNCC.Size = new System.Drawing.Size(149, 63);
            this.btNCC.TabIndex = 4;
            this.btNCC.Text = "Nhà cung cấp";
            this.btNCC.UseVisualStyleBackColor = true;
            this.btNCC.Click += new System.EventHandler(this.btNCC_Click);
            // 
            // btBaoHanh
            // 
            this.btBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaoHanh.Location = new System.Drawing.Point(250, 97);
            this.btBaoHanh.Name = "btBaoHanh";
            this.btBaoHanh.Size = new System.Drawing.Size(149, 63);
            this.btBaoHanh.TabIndex = 5;
            this.btBaoHanh.Text = "Bảo hành";
            this.btBaoHanh.UseVisualStyleBackColor = true;
            this.btBaoHanh.Click += new System.EventHandler(this.btBaoHanh_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(25, 246);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(60, 24);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "label2";
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(485, 232);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(149, 38);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 276);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btBaoHanh;
        private System.Windows.Forms.Button btNCC;
        private System.Windows.Forms.Button btKhachHang;
        private System.Windows.Forms.Button btSP;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Timer timer1;
    }
}