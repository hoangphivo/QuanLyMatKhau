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
        TaiKhoanEntities2 TaiKhoans = new TaiKhoanEntities2();
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
