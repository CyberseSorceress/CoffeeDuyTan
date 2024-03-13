namespace DoAnCaNhan
{
    partial class frm_HoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ThoiGian = new System.Windows.Forms.TextBox();
            this.cb_ViTri = new System.Windows.Forms.ComboBox();
            this.cb_ThanhToan = new System.Windows.Forms.ComboBox();
            this.cb_MaNV = new System.Windows.Forms.ComboBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaHoaDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxt_ThongTin = new System.Windows.Forms.RichTextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_XoaHD = new System.Windows.Forms.Button();
            this.btn_GhiHD = new System.Windows.Forms.Button();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_MaHang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ThoiGian);
            this.groupBox1.Controls.Add(this.cb_ViTri);
            this.groupBox1.Controls.Add(this.cb_ThanhToan);
            this.groupBox1.Controls.Add(this.cb_MaNV);
            this.groupBox1.Controls.Add(this.txt_TenNV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_MaHoaDon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txt_ThoiGian
            // 
            this.txt_ThoiGian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ThoiGian.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThoiGian.Location = new System.Drawing.Point(116, 76);
            this.txt_ThoiGian.Name = "txt_ThoiGian";
            this.txt_ThoiGian.ReadOnly = true;
            this.txt_ThoiGian.Size = new System.Drawing.Size(297, 27);
            this.txt_ThoiGian.TabIndex = 13;
            // 
            // cb_ViTri
            // 
            this.cb_ViTri.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ViTri.FormattingEnabled = true;
            this.cb_ViTri.Items.AddRange(new object[] {
            "Bàn 1",
            "Bàn 2 ",
            "Bàn 3 ",
            "Bàn 4"});
            this.cb_ViTri.Location = new System.Drawing.Point(116, 125);
            this.cb_ViTri.Name = "cb_ViTri";
            this.cb_ViTri.Size = new System.Drawing.Size(297, 27);
            this.cb_ViTri.TabIndex = 12;
            this.cb_ViTri.Text = "Bàn 1";
            // 
            // cb_ThanhToan
            // 
            this.cb_ThanhToan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ThanhToan.FormattingEnabled = true;
            this.cb_ThanhToan.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Nợ :)"});
            this.cb_ThanhToan.Location = new System.Drawing.Point(706, 130);
            this.cb_ThanhToan.Name = "cb_ThanhToan";
            this.cb_ThanhToan.Size = new System.Drawing.Size(207, 27);
            this.cb_ThanhToan.TabIndex = 11;
            this.cb_ThanhToan.Text = "Tiền mặt";
            // 
            // cb_MaNV
            // 
            this.cb_MaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaNV.FormattingEnabled = true;
            this.cb_MaNV.Location = new System.Drawing.Point(642, 31);
            this.cb_MaNV.Name = "cb_MaNV";
            this.cb_MaNV.Size = new System.Drawing.Size(271, 27);
            this.cb_MaNV.TabIndex = 10;
            this.cb_MaNV.SelectedIndexChanged += new System.EventHandler(this.cb_MaNV_SelectedIndexChanged);
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNV.Location = new System.Drawing.Point(642, 81);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.ReadOnly = true;
            this.txt_TenNV.Size = new System.Drawing.Size(271, 27);
            this.txt_TenNV.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(535, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phương thức thanh toán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(535, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(535, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhân viên:";
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHoaDon.Location = new System.Drawing.Point(116, 32);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(297, 27);
            this.txt_MaHoaDon.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vị trí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thời gian:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hoá đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxt_ThongTin);
            this.groupBox2.Controls.Add(this.btn_Reset);
            this.groupBox2.Controls.Add(this.btn_Xuat);
            this.groupBox2.Controls.Add(this.dgv_HoaDon);
            this.groupBox2.Controls.Add(this.btn_ThanhToan);
            this.groupBox2.Controls.Add(this.btn_XoaHD);
            this.groupBox2.Controls.Add(this.btn_GhiHD);
            this.groupBox2.Controls.Add(this.txt_DonGia);
            this.groupBox2.Controls.Add(this.txt_TenHang);
            this.groupBox2.Controls.Add(this.txt_GiamGia);
            this.groupBox2.Controls.Add(this.txt_ThanhTien);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cb_MaHang);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 409);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thanh toán";
            // 
            // rtxt_ThongTin
            // 
            this.rtxt_ThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_ThongTin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_ThongTin.Location = new System.Drawing.Point(668, 172);
            this.rtxt_ThongTin.Name = "rtxt_ThongTin";
            this.rtxt_ThongTin.Size = new System.Drawing.Size(284, 170);
            this.rtxt_ThongTin.TabIndex = 28;
            this.rtxt_ThongTin.Text = "";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Reset.Location = new System.Drawing.Point(292, 128);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(121, 38);
            this.btn_Reset.TabIndex = 26;
            this.btn_Reset.Text = "Làm Mới";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xuat.FlatAppearance.BorderSize = 0;
            this.btn_Xuat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Xuat.Location = new System.Drawing.Point(811, 128);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(141, 38);
            this.btn_Xuat.TabIndex = 23;
            this.btn_Xuat.Text = "Xuất hoá đơn";
            this.btn_Xuat.UseVisualStyleBackColor = false;
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Tong_Click);
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_HoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HoaDon.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HoaDon.Location = new System.Drawing.Point(6, 172);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.ReadOnly = true;
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HoaDon.Size = new System.Drawing.Size(654, 170);
            this.dgv_HoaDon.TabIndex = 22;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_ThanhToan.Location = new System.Drawing.Point(6, 357);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(946, 46);
            this.btn_ThanhToan.TabIndex = 21;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_XoaHD
            // 
            this.btn_XoaHD.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_XoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XoaHD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHD.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_XoaHD.Location = new System.Drawing.Point(155, 128);
            this.btn_XoaHD.Name = "btn_XoaHD";
            this.btn_XoaHD.Size = new System.Drawing.Size(121, 38);
            this.btn_XoaHD.TabIndex = 20;
            this.btn_XoaHD.Text = "Xoá";
            this.btn_XoaHD.UseVisualStyleBackColor = false;
            this.btn_XoaHD.Click += new System.EventHandler(this.btn_XoaHD_Click);
            // 
            // btn_GhiHD
            // 
            this.btn_GhiHD.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_GhiHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_GhiHD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GhiHD.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_GhiHD.Location = new System.Drawing.Point(24, 128);
            this.btn_GhiHD.Name = "btn_GhiHD";
            this.btn_GhiHD.Size = new System.Drawing.Size(121, 38);
            this.btn_GhiHD.TabIndex = 18;
            this.btn_GhiHD.Text = "Ghi";
            this.btn_GhiHD.UseVisualStyleBackColor = false;
            this.btn_GhiHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(747, 37);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(179, 27);
            this.txt_DonGia.TabIndex = 15;
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenHang.Location = new System.Drawing.Point(440, 37);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.ReadOnly = true;
            this.txt_TenHang.Size = new System.Drawing.Size(179, 27);
            this.txt_TenHang.TabIndex = 14;
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GiamGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiamGia.Location = new System.Drawing.Point(440, 81);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.Size = new System.Drawing.Size(179, 27);
            this.txt_GiamGia.TabIndex = 13;
            this.txt_GiamGia.TextChanged += new System.EventHandler(this.txt_GiamGia_TextChanged);
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ThanhTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhTien.Location = new System.Drawing.Point(747, 82);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(179, 27);
            this.txt_ThanhTien.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(657, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Thành tiền:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(657, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 19);
            this.label13.TabIndex = 9;
            this.label13.Text = "Đơn giá:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(329, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Giảm giá (%):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(329, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tên hàng:";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoLuong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(97, 83);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(179, 27);
            this.txt_SoLuong.TabIndex = 4;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng:";
            // 
            // cb_MaHang
            // 
            this.cb_MaHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaHang.FormattingEnabled = true;
            this.cb_MaHang.Location = new System.Drawing.Point(97, 39);
            this.cb_MaHang.Name = "cb_MaHang";
            this.cb_MaHang.Size = new System.Drawing.Size(179, 27);
            this.cb_MaHang.TabIndex = 2;
            this.cb_MaHang.SelectedIndexChanged += new System.EventHandler(this.cb_MaHang_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã hàng:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá Đơn";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_MaHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_ThanhToan;
        private System.Windows.Forms.ComboBox cb_MaNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_MaHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_XoaHD;
        private System.Windows.Forms.Button btn_GhiHD;
        private System.Windows.Forms.ComboBox cb_ViTri;
        private System.Windows.Forms.Button btn_Xuat;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.RichTextBox rtxt_ThongTin;
        private System.Windows.Forms.TextBox txt_ThoiGian;
        private System.Windows.Forms.Timer timer1;
    }
}