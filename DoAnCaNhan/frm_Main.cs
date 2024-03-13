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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_NgayGio.Text = DateTime.Now.ToString();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien nv = new frm_NhanVien();
                nv.MdiParent = this;
                nv.Show();
            }
            else Application.OpenForms["frm_NhanVien"].Activate();
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThucDon"] == null)
            {
                frm_ThucDon td = new frm_ThucDon();
                td.MdiParent = this;
                td.Show();
            }
            else Application.OpenForms["frm_ThucDon"].Activate();
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_HoaDon"] == null)
            {
                frm_HoaDon hd = new frm_HoaDon();
                hd.MdiParent = this;
                hd.Show();
            }
            else Application.OpenForms["frm_HoaDon"].Activate();
        }
    }
}
