namespace DoAnCaNhan
{
    partial class frm_ThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_XoaTD = new System.Windows.Forms.Button();
            this.btn_SuaTD = new System.Windows.Forms.Button();
            this.btn_ThemTD = new System.Windows.Forms.Button();
            this.dgv_ThucDon = new System.Windows.Forms.DataGridView();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_PhanLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XoaTD
            // 
            this.btn_XoaTD.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_XoaTD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XoaTD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTD.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_XoaTD.Location = new System.Drawing.Point(275, 166);
            this.btn_XoaTD.Name = "btn_XoaTD";
            this.btn_XoaTD.Size = new System.Drawing.Size(87, 38);
            this.btn_XoaTD.TabIndex = 28;
            this.btn_XoaTD.Text = "Xoá";
            this.btn_XoaTD.UseVisualStyleBackColor = false;
            this.btn_XoaTD.Click += new System.EventHandler(this.btn_XoaTD_Click);
            // 
            // btn_SuaTD
            // 
            this.btn_SuaTD.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_SuaTD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SuaTD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTD.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_SuaTD.Location = new System.Drawing.Point(169, 166);
            this.btn_SuaTD.Name = "btn_SuaTD";
            this.btn_SuaTD.Size = new System.Drawing.Size(87, 38);
            this.btn_SuaTD.TabIndex = 27;
            this.btn_SuaTD.Text = "Sửa";
            this.btn_SuaTD.UseVisualStyleBackColor = false;
            this.btn_SuaTD.Click += new System.EventHandler(this.btn_SuaTD_Click);
            // 
            // btn_ThemTD
            // 
            this.btn_ThemTD.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ThemTD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThemTD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTD.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_ThemTD.Location = new System.Drawing.Point(64, 166);
            this.btn_ThemTD.Name = "btn_ThemTD";
            this.btn_ThemTD.Size = new System.Drawing.Size(87, 38);
            this.btn_ThemTD.TabIndex = 26;
            this.btn_ThemTD.Text = "Thêm";
            this.btn_ThemTD.UseVisualStyleBackColor = false;
            this.btn_ThemTD.Click += new System.EventHandler(this.btn_ThemTD_Click);
            // 
            // dgv_ThucDon
            // 
            this.dgv_ThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThucDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ThucDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_ThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ThucDon.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ThucDon.Location = new System.Drawing.Point(64, 228);
            this.dgv_ThucDon.Name = "dgv_ThucDon";
            this.dgv_ThucDon.ReadOnly = true;
            this.dgv_ThucDon.RowHeadersWidth = 51;
            this.dgv_ThucDon.RowTemplate.Height = 24;
            this.dgv_ThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ThucDon.Size = new System.Drawing.Size(661, 209);
            this.dgv_ThucDon.TabIndex = 25;
            this.dgv_ThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThucDon_CellClick);
            // 
            // txt_Ten
            // 
            this.txt_Ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(145, 118);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(217, 27);
            this.txt_Ten.TabIndex = 23;
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHang.Location = new System.Drawing.Point(145, 80);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.Size = new System.Drawing.Size(217, 27);
            this.txt_MaHang.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(240, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "CẬP NHẬT THỰC ĐƠN";
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GiaTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaTien.Location = new System.Drawing.Point(509, 119);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.Size = new System.Drawing.Size(216, 27);
            this.txt_GiaTien.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tên hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(422, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Phân loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(422, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Giá tiền:";
            // 
            // cb_PhanLoai
            // 
            this.cb_PhanLoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PhanLoai.FormattingEnabled = true;
            this.cb_PhanLoai.Items.AddRange(new object[] {
            "Thức Ăn",
            "Thức Uống"});
            this.cb_PhanLoai.Location = new System.Drawing.Point(509, 80);
            this.cb_PhanLoai.Name = "cb_PhanLoai";
            this.cb_PhanLoai.Size = new System.Drawing.Size(216, 27);
            this.cb_PhanLoai.TabIndex = 35;
            // 
            // frm_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 495);
            this.Controls.Add(this.cb_PhanLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_GiaTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XoaTD);
            this.Controls.Add(this.btn_SuaTD);
            this.Controls.Add(this.btn_ThemTD);
            this.Controls.Add(this.dgv_ThucDon);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_MaHang);
            this.Controls.Add(this.label2);
            this.Name = "frm_ThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực Đơn";
            this.Load += new System.EventHandler(this.frm_ThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_XoaTD;
        private System.Windows.Forms.Button btn_SuaTD;
        private System.Windows.Forms.Button btn_ThemTD;
        private System.Windows.Forms.DataGridView dgv_ThucDon;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GiaTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_PhanLoai;
    }
}