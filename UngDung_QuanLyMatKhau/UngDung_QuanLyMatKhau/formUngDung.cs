using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DAL;
using BUS;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UngDung_QuanLyMatKhau
{
    public partial class formUngDung : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TaiKhoan;User ID=sa;Password=123456");
        int ID;
        public formUngDung()
        {
            InitializeComponent();
            
        }
        TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();
        private void formUngDung_Load(object sender, EventArgs e)
        {
            DisplayData();

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (taikhoanbus.KTTaiKhoan(txtTaiKhoan.Text) == true){
                MessageBox.Show("Tài khoản đã tồn tại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = new SqlCommand("insert into TaiKhoan(TaiKhoan,MatKhau,Note) values(@taikhoan,@matkhau,@ghichu)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@taikhoan", txtTaiKhoan.Text);
                cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);
                cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
                con.Close();
                MessageBox.Show("Thêm thành công hãy bấm nút lưu để thay đổi", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            DisplayData();
        }
        private void DisplayData()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TaiKhoan;User ID=sa;Password=123456");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from TaiKhoan", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvDSTK.DataSource = dt;
        }
        private void ClearData()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtGhiChu.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("delete TaiKhoan where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Xóa thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayData();
            ClearData();

        }
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgvDSTK.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtTaiKhoan.Text = dgvDSTK.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMatKhau.Text = dgvDSTK.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGhiChu.Text = dgvDSTK.Rows[e.RowIndex].Cells[3].Value.ToString();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update TaiKhoan set TaiKhoan=@taikhoan,MatKhau=@matkhau,Note=@ghichu where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@taikhoan", txtTaiKhoan.Text);
            cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);
            cmd.Parameters.AddWithValue("@ghichu",txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            DisplayData();
            ClearData();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into TaiKhoan(TaiKhoan,MatKhau,Note) values(@taikhoan,@matkhau,@ghichu)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@taikhoan", txtTaiKhoan.Text);
            cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);
            cmd.Parameters.AddWithValue("@ghichu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Lưu thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayData();
            ClearData();

        }

        private void checkBoxMKInHoa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomString();
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private void txtChieuDaiMK_TextChanged(object sender, EventArgs e)
        {
            int size;
        }
    }
}
