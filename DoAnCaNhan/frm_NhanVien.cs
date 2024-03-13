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
    public partial class frm_NhanVien : Form
    {
        ClassChung chung = new ClassChung();
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void pic_NhanVien_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hãy Chọn Ảnh";
            open.Filter = "Chọn Ảnh JPG|* .jpg|Chọn Ảnh PNG|* .png|Tất cả File|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pic_NhanVien.Image = Image.FromFile(open.FileName);
            }
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NHANVIEN values ('" + txt_MaNV.Text + "',N'" + txt_HoTen.Text + "',N'" + cb_GioiTinh.Text 
                + "', Convert(datetime,'" + date_Ngaysinh.Text + "', 103),'" + txt_SDT.Text + "',N'" + txt_DiaChi.Text + "')";
            int ketqua = chung.ThemSuaXoa(sql);
            if (ketqua >= 1) MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Taidulieu();
        }

        public void Taidulieu()
        {
            string sql = "Select * from NHANVIEN";
            dgv_NhanVien.DataSource = chung.Taidulieu(sql);
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            string sql = "Update NHANVIEN set HOTEN = N'" + txt_HoTen.Text + "', GIOITINH = N'" + cb_GioiTinh.Text 
                + "',NGAYSINH = Convert (datetime,'" + date_Ngaysinh.Text + "',103), SDT = '" + txt_SDT.Text +"', DIACHI = N'"+ txt_DiaChi.Text 
                + "' where MANV ='" + txt_MaNV.Text + "'";
            int ketqua = chung.ThemSuaXoa(sql);
            if (ketqua >= 1) MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Sửa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Taidulieu();
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            string sql = "Delete NHANVIEN where MANV ='" + txt_MaNV.Text + "'";
            int ketqua = chung.ThemSuaXoa(sql);
            if (ketqua >= 1) MessageBox.Show("Xoá nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Xoá nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Taidulieu();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            Taidulieu();
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dgv_NhanVien.CurrentRow.Cells["MANV"].Value.ToString();
            txt_HoTen.Text = dgv_NhanVien.CurrentRow.Cells["HOTEN"].Value.ToString();
            cb_GioiTinh.Text = dgv_NhanVien.CurrentRow.Cells["GIOITINH"].Value.ToString();
            date_Ngaysinh.Text = dgv_NhanVien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_SDT.Text = dgv_NhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            txt_DiaChi.Text = dgv_NhanVien.CurrentRow.Cells["DIACHI"].Value.ToString();
        }
    }
}
