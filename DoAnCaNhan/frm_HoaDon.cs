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
    public partial class frm_HoaDon : Form
    {
        ClassChung chung = new ClassChung();
        public frm_HoaDon()
        {
            InitializeComponent();
        }
        public void Taidulieu()
        {
            string sql = "Select * from HOADON";
            dgv_HoaDon.DataSource = chung.Taidulieu(sql);
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            string sql = "Insert into HOADON values ('" + cb_MaHang.Text + "',N'" + txt_TenHang.Text 
                + "','" + txt_DonGia.Text + "','" + txt_SoLuong.Text + "','" + txt_GiamGia.Text + "','" + txt_ThanhTien.Text + "')";
            int ketqua = chung.ThemSuaXoa(sql);
            if (ketqua >= 1) MessageBox.Show("Ghi hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Ghi hoá đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Taidulieu();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            Taidulieu();
            string sqlloadNV = "Select MANV from NHANVIEN";
            cb_MaNV.DataSource = chung.Taidulieu(sqlloadNV);
            cb_MaNV.DisplayMember = "MANV";
            cb_MaNV.ValueMember = "MANV";

            string sqlloadMH = "Select MAHANG from THUCDON";
            cb_MaHang.DataSource = chung.Taidulieu(sqlloadMH);
            cb_MaHang.DisplayMember = "MAHANG";
            cb_MaHang.ValueMember = "MAHANG";

        }

        private void cb_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_MaNV.SelectedIndex != -1)
            {
                string manv = cb_MaNV.SelectedValue.ToString();
                using (var conn = new SqlConnection("data source=(localdb)\\mssqllocaldb;attachdbfilename=c:\\users\\ktvie\\source\\repos\\doancanhan\\doancanhan\\cfdt.mdf;integrated security=true;"))
            {
                    var sql = "select hoten from nhanvien where manv = @manv";
                    var cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@manv", manv);
                   conn.Open();
                    var reader = cmd.ExecuteReader();
                   if (reader.Read())
                   {
                       txt_TenNV.Text = reader["hoten"].ToString();
                   }
                }
            }
        }

        private void cb_MaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_MaHang.SelectedIndex != -1)
            {
                string maHang = cb_MaHang.SelectedValue.ToString();
                using (var conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ktvie\\source\\repos\\DoAnCaNhan\\DoAnCaNhan\\CFDT.mdf;Integrated Security=True;"))
                {
                    var sql = "SELECT TENHANG, GIATIEN FROM THUCDON WHERE MAHANG = @maHang";
                    var cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MAHANG", maHang);
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_TenHang.Text = reader["TENHANG"].ToString();
                        txt_DonGia.Text = reader["GIATIEN"].ToString();
                    }
                }
            }
        }
        private void TinhTien()
        {
            try
            {
                float donGia = float.Parse(txt_DonGia.Text);
                int soLuong = int.Parse(txt_SoLuong.Text);
                float giamGia = float.Parse(txt_GiamGia.Text);

                float thanhTien = donGia * soLuong * (1 - giamGia / 100);
                txt_ThanhTien.Text = thanhTien.ToString();
            }
            catch (Exception ex) { }
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void txt_GiamGia_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void btn_Tong_Click(object sender, EventArgs e)
        {
            var maHoaDon = txt_MaHoaDon.Text;
            var maNhanVien = cb_MaNV.Text;
            var thoiGian = txt_ThoiGian.Text;
            var tenNhanVien = txt_TenNV.Text;
            var viTri = cb_ViTri.Text;
            var phuongThucThanhToan = cb_ThanhToan.Text;
            try
            {
                using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ktvie\\source\\repos\\DoAnCaNhan\\DoAnCaNhan\\CFDT.mdf;Integrated Security=True"))
                {
                    var sql = "SELECT SUM(THANHTIEN) AS TONGTIEN FROM HOADON";
                    var cmd = new SqlCommand(sql, connection);
                    connection.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        var tongCong = reader["TONGTIEN"].ToString();
                        rtxt_ThongTin.Text = $"- Mã hóa đơn: {maHoaDon}\n" +
                                            $"- Mã nhân viên: {maNhanVien}\n" +
                                            $"- Tên nhân viên: {tenNhanVien}\n" +
                                            $"- Thời gian: {thoiGian}\n" +
                                            $"- Vị trí: {viTri}\n" +
                                            $"- Phương thức thanh toán: {phuongThucThanhToan}\n" +
                                            $"\n\t Tổng cộng: {tongCong} VND";
                    }
                }
            }
            catch (Exception){} 
        }
        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            string sql = "Delete HOADON where MAHANG ='" + cb_MaHang.Text + "'";
            int ketqua = chung.ThemSuaXoa(sql);
            if (ketqua >= 1) MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Taidulieu();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Xoá hết dữ liệu và nhập hoá đơn mới?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                txt_MaHoaDon.Text = "";
                txt_TenNV.Text = "";
                txt_TenHang.Text = "";
                txt_DonGia.Text = "";
                txt_SoLuong.Text = "";
                txt_GiamGia.Text = "";
                txt_ThanhTien.Text = "";
                rtxt_ThongTin.Text = "";

                try
                {
                    using (var conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ktvie\\source\\repos\\DoAnCaNhan\\DoAnCaNhan\\CFDT.mdf;Integrated Security=True"))
                    {
                        var sql = "DELETE FROM HOADON";
                        var cmd = new SqlCommand(sql, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Làm mới trang thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Taidulieu();
                    }
                }
                catch (Exception) { }
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn in hoá đơn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("In hoá đơn thành công!\r\nĐã thanh toán xong!", "Thông báo", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("Đã thanh toán xong!", "Thông báo", MessageBoxButtons.OK); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_ThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy\tHH:mm");
        }
    }
}
