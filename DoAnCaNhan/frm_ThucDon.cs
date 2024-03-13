using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnCaNhan
{
    public partial class frm_ThucDon : Form
    {
        ClassChung chung = new ClassChung();
        public frm_ThucDon()
        {
            InitializeComponent();
        }
        public void Taidulieu()
        {
            string sql = "Select * from THUCDON";
            dgv_ThucDon.DataSource = chung.Taidulieu(sql);
        }

        private void btn_ThemTD_Click(object sender, EventArgs e)
        {
            string sql = "Insert into THUCDON values ('" + txt_MaHang.Text + "',N'" + txt_Ten.Text + "',N'" + cb_PhanLoai.Text 
                + "','" + txt_GiaTien.Text + "')";
            int ketqua = chung.ThemSuaXoa(sql);
            if (ketqua >= 1) MessageBox.Show("Thêm mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thêm mặt hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Taidulieu();
        }

        private void btn_SuaTD_Click(object sender, EventArgs e)
        {
            string sql = "Update THUCDON set TENHANG = N'" + txt_Ten.Text + "', PHANLOAI = N'" + cb_PhanLoai.Text 
                +"', GIATIEN = '" + txt_GiaTien.Text + "' where MAHANG = '" + txt_MaHang.Text + "'";
            int ketqua = chung.ThemSuaXoa(sql);
            if (ketqua >= 1) MessageBox.Show("Sửa mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Sửa mặt hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Taidulieu();
        }

        private void btn_XoaTD_Click(object sender, EventArgs e)
        {
            string sql = "Delete THUCDON where MAHANG ='" + txt_MaHang.Text + "'";
            int ketqua = chung.ThemSuaXoa(sql);
            if (ketqua >= 1) MessageBox.Show("Xoá mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Xoá mặt hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Taidulieu();
        }

        private void dgv_ThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHang.Text = dgv_ThucDon.CurrentRow.Cells["MAHANG"].Value.ToString();
            txt_Ten.Text = dgv_ThucDon.CurrentRow.Cells["TENHANG"].Value.ToString();
            cb_PhanLoai.Text = dgv_ThucDon.CurrentRow.Cells["PHANLOAI"].Value.ToString();
            txt_GiaTien.Text = dgv_ThucDon.CurrentRow.Cells["GIATIEN"].Value.ToString();
        }

        private void frm_ThucDon_Load(object sender, EventArgs e)
        {
            Taidulieu();
        }
    }
}
