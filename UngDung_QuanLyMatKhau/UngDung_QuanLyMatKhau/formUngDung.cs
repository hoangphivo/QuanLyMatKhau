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
    }
}
