using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace UngDung_QuanLyMatKhau
{
    public partial class frm_LogIn : Form
    {
        public frm_LogIn()
        {
            InitializeComponent();
            
        }
        TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
        private void button2_Click(object sender, EventArgs e)
        {
            if (taikhoanbus.KTDangNhap(txtUsername.Text,txtPassword.Text) == true)
            {
                this.Hide();
                formUngDung frm = new formUngDung();
                frm.Show();
            }
            else
            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
