using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDung_QuanLyMatKhau
{
    public partial class formChangePassword : Form
    {
        private formUngDung Handled_frm1;
        public formChangePassword(formUngDung formUngDung)
        {
            InitializeComponent();
            Handled_frm1 = formUngDung;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            Handled_frm1.DisplayData();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Id;
            string sqlSearch = "SELECT * FROM TaiKhoan WHERE MatKhau=@oldpass";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TaiKhoan;User ID=sa;Password=123456;MultipleActiveResultSets=true");
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            cmd.Parameters.AddWithValue("@oldpass",txtOldPassword.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                if (txtNewPassword.Text == txtRepeat.Text)
                {

                    string sqlUpdate = "UPDATE TaiKhoan SET MatKhau=@newpass WHERE MatKhau=@oldpass";
                    SqlCommand cmd2 = new SqlCommand(sqlUpdate, con);
                    cmd2.Parameters.AddWithValue("@newpass", txtNewPassword.Text);
                    cmd2.Parameters.AddWithValue("@oldpass",txtOldPassword.Text);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Đổi thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hãy nhập lại ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Đổi không thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            ClearData();
            //form.DisplayData();
            

        }
        private void ClearData()
        {
            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtRepeat.Text = "";
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
