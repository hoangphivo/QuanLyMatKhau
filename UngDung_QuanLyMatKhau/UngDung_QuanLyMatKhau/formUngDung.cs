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
using System.Text.RegularExpressions;

namespace UngDung_QuanLyMatKhau
{
    public partial class formUngDung : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TaiKhoan;User ID=sa;Password=123456");
        int ID;
        public formUngDung( )
        {
            InitializeComponent();
            formChangePassword frm = new formChangePassword(this);

        }
        private void pictureSetting_Click(object sender, EventArgs e)
        {
            formChangePassword frm2 = new formChangePassword(this);
            frm2.Show();
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
        public void DisplayData()
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

        private void btnTaoMK_Click(object sender, EventArgs e)
        {
            if (checkBoxMKChu.Checked)
            {
                bool includeLowercase = true;
            }
            else
            {
                bool includeLowercase = false;
            }
            if (checkBoxMKKyTu.Checked)
            {
                bool includeSpecial = true;
            }
            else
            {
                bool includeSpecial = false;

            }
            if (checkBoxMKInHoa.Checked)
            {
                bool includeUppercase = true;
            }
            else
            {
                bool includeUppercase = false;
            }
            if (checkBoxMKSo.Checked)
            {
                bool includeNumeric = true;
            }
            else
            {
                bool includeNumeric = false;
            }



            int lengthOfPassword = 16;

            string password = PasswordGenerator.GeneratePassword(checkBoxMKChu.Checked, checkBoxMKInHoa.Checked, checkBoxMKSo.Checked, checkBoxMKKyTu.Checked, lengthOfPassword);

            while (!PasswordGenerator.PasswordIsValid(checkBoxMKChu.Checked, checkBoxMKInHoa.Checked, checkBoxMKSo.Checked, checkBoxMKKyTu.Checked, password))
            {
                password = PasswordGenerator.GeneratePassword(checkBoxMKChu.Checked, checkBoxMKInHoa.Checked, checkBoxMKSo.Checked, checkBoxMKKyTu.Checked, lengthOfPassword);
            }

            textBox2.Text = password.ToString();
        }       
        public static class PasswordGenerator
        {
            public static string GeneratePassword(bool includeLowercase, bool includeUppercase, bool includeNumeric, bool includeSpecial, int lengthOfPassword)
            {
                const int MAXIMUM_IDENTICAL_CONSECUTIVE_CHARS = 2;
                const string LOWERCASE_CHARACTERS = "abcdefghijklmnopqrstuvwxyz";
                const string UPPERCASE_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string NUMERIC_CHARACTERS = "0123456789";
                const string SPECIAL_CHARACTERS = @"!#$%&*@\";
                const string SPACE_CHARACTER = " ";
                const int PASSWORD_LENGTH_MIN = 8;
                const int PASSWORD_LENGTH_MAX = 128;

                if (lengthOfPassword < PASSWORD_LENGTH_MIN || lengthOfPassword > PASSWORD_LENGTH_MAX)
                {
                    return "Password length must be between 8 and 128.";
                }

                string characterSet = "";

                if (includeLowercase)
                {
                    characterSet += LOWERCASE_CHARACTERS;
                }

                if (includeUppercase)
                {
                    characterSet += UPPERCASE_CHARACTERS;
                }

                if (includeNumeric)
                {
                    characterSet += NUMERIC_CHARACTERS;
                }

                if (includeSpecial)
                {
                    characterSet += SPECIAL_CHARACTERS;
                }


                char[] password = new char[lengthOfPassword];
                int characterSetLength = characterSet.Length;

                System.Random random = new System.Random();
                for (int characterPosition = 0; characterPosition < lengthOfPassword; characterPosition++)
                {
                    password[characterPosition] = characterSet[random.Next(characterSetLength - 1)];

                    bool moreThanTwoIdenticalInARow =
                        characterPosition > MAXIMUM_IDENTICAL_CONSECUTIVE_CHARS
                        && password[characterPosition] == password[characterPosition - 1]
                        && password[characterPosition - 1] == password[characterPosition - 2];

                    if (moreThanTwoIdenticalInARow)
                    {
                        characterPosition--;
                    }
                }

                return string.Join(null, password);
            }
            public static bool PasswordIsValid(bool includeLowercase, bool includeUppercase, bool includeNumeric, bool includeSpecial, string password)
            {
                const string REGEX_LOWERCASE = @"[a-z]";
                const string REGEX_UPPERCASE = @"[A-Z]";
                const string REGEX_NUMERIC = @"[\d]";
                const string REGEX_SPECIAL = @"([!#$%&*@\\])+";
                const string REGEX_SPACE = @"([ ])+";

                bool lowerCaseIsValid = !includeLowercase || (includeLowercase && Regex.IsMatch(password, REGEX_LOWERCASE));
                bool upperCaseIsValid = !includeUppercase || (includeUppercase && Regex.IsMatch(password, REGEX_UPPERCASE));
                bool numericIsValid = !includeNumeric || (includeNumeric && Regex.IsMatch(password, REGEX_NUMERIC));
                bool symbolsAreValid = !includeSpecial || (includeSpecial && Regex.IsMatch(password, REGEX_SPECIAL));

                return lowerCaseIsValid && upperCaseIsValid && numericIsValid && symbolsAreValid ;
            }
        }

    }
}

