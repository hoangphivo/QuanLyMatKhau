using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDung_QuanLyMatKhau
{
    public partial class formUngDung : Form
    {
        public formUngDung()
        {
            InitializeComponent();
            
        }

        private void formUngDung_Load(object sender, EventArgs e)
        {

        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_LogIn frm = new frm_LogIn();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region move form
        bool ismousedown = false;
        Point mousedownPosition = new Point();
        private void frm_LogIn_MouseDown(object sender, MouseEventArgs e)
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
            if (ismousedown == true)
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
