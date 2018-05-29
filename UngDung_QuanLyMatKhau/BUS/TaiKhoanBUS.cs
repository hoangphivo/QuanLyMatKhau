using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class TaiKhoanBUS
    {
        QL_TaiKhoanDataContext TaiKhoans = new QL_TaiKhoanDataContext();
        public bool KTDangNhap(string Username,string Password)
        {
            int taikhoan = (from tk in TaiKhoans.TaiKhoans
                            where tk.TaiKhoan1 == Username && tk.MatKhau == Password
                            select tk).Count();
            if (taikhoan == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
