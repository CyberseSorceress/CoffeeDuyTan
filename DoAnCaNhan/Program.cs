﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCaNhan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_DangNhap());
            //Application.Run(new frm_Main());
            //Application.Run(new frm_NhanVien());
            //Application.Run(new frm_ThucDon());
            //Application.Run(new frm_HoaDon());
        }
    }
}
