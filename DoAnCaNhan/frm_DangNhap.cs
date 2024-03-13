using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan
{
    public partial class frm_DangNhap : Form
    {
        ClassChung chung = new ClassChung();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void chk_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
             txt_MatKhau.UseSystemPasswordChar = !chk_HienThiMK.Checked;
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Đóng ứng dụng?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from DANHSACHTAIKHOAN where TAIKHOAN = '" + txt_TenDangNhap.Text + "' and MATKHAU = '" + txt_MatKhau.Text + "'";
            int kq = (int)chung.Laygiatri(sql);
            if (kq >= 1)
            {
                frm_Main m = new frm_Main();
                m.Show();
            }

            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = "";
            txt_MatKhau.Text = "";
        }

        private void btn_ĐangKy_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DangKy"] == null) 
            { 
            frm_DangKy DangKy = new frm_DangKy();
            DangKy.Show();
            }
            else Application.OpenForms["frm_DangKy"].Activate();
        }
    }
}
