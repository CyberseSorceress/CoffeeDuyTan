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
    public partial class frm_DangKy : Form
    {
        ClassChung chung = new ClassChung();
        public frm_DangKy()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (txt_MatkhauChecked.Text != txt_MatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_MatkhauChecked.Text = "";
                txt_MatkhauChecked.Focus();
            }
            else 
            {
                string sql = "Insert into DANHSACHTAIKHOAN values ('" + txt_TenDangNhap.Text + "','" + txt_MatKhau.Text + "')";
                int ketqua = chung.ThemSuaXoa(sql);
                if(ketqua >= 1)
                { 
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Đăng ký thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_MatkhauChecked_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
