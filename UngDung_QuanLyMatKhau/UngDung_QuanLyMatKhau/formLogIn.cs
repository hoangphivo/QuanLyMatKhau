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
        #region move form
        bool ismousedown = false;
        Point mousedownPosition = new Point();
        private void frm_LogIn_MouseDown(object sender ,MouseEventArgs e)
        {
            ismousedown = true;
            mousedownPosition.X = e.X;
            mousedownPosition.Y = e.Y;
        }
        private void frm_LogIn_MouseUp(object sender, MouseEventArgs e)
        {
            ismousedown = false;
            Cursor cur = Cursors.Arrow;
            this.Cursor = cur;
        }
        private void frm_LogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if(ismousedown == true)
            {
                Point newPoint = new Point();
                newPoint.X = this.Location.X + (e.X - mousedownPosition.X);
                newPoint.Y = this.Location.Y + (e.Y - mousedownPosition.Y);
                this.Location = newPoint;
            }
        }
        #endregion
    }
}
