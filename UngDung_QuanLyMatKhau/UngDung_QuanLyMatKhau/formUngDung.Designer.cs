namespace UngDung_QuanLyMatKhau
{
    partial class formUngDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblChieuDaiMK = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxMKInHoa = new System.Windows.Forms.CheckBox();
            this.checkBoxMKSo = new System.Windows.Forms.CheckBox();
            this.checkBoxMKChu = new System.Windows.Forms.CheckBox();
            this.checkBoxMKKyTu = new System.Windows.Forms.CheckBox();
            this.txtChieuDaiMK = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblDangXuat = new System.Windows.Forms.Label();
            this.lblCaiDat = new System.Windows.Forms.Label();
            this.dgvDSTK = new System.Windows.Forms.DataGridView();
            this.taiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanDataSet = new UngDung_QuanLyMatKhau.TaiKhoanDataSet();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureSetting = new System.Windows.Forms.PictureBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taiKhoanTableAdapter = new UngDung_QuanLyMatKhau.TaiKhoanDataSetTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new UngDung_QuanLyMatKhau.TaiKhoanDataSetTableAdapters.TableAdapterManager();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChieuDaiMK
            // 
            this.lblChieuDaiMK.AutoSize = true;
            this.lblChieuDaiMK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChieuDaiMK.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChieuDaiMK.Location = new System.Drawing.Point(53, 68);
            this.lblChieuDaiMK.Name = "lblChieuDaiMK";
            this.lblChieuDaiMK.Size = new System.Drawing.Size(134, 19);
            this.lblChieuDaiMK.TabIndex = 2;
            this.lblChieuDaiMK.Text = "Chiều dài mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(53, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // checkBoxMKInHoa
            // 
            this.checkBoxMKInHoa.AutoSize = true;
            this.checkBoxMKInHoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMKInHoa.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxMKInHoa.Location = new System.Drawing.Point(53, 148);
            this.checkBoxMKInHoa.Name = "checkBoxMKInHoa";
            this.checkBoxMKInHoa.Size = new System.Drawing.Size(196, 23);
            this.checkBoxMKInHoa.TabIndex = 4;
            this.checkBoxMKInHoa.Text = "Mật khẩu gồm chữ In Hoa";
            this.checkBoxMKInHoa.UseVisualStyleBackColor = true;
            // 
            // checkBoxMKSo
            // 
            this.checkBoxMKSo.AutoSize = true;
            this.checkBoxMKSo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMKSo.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxMKSo.Location = new System.Drawing.Point(53, 187);
            this.checkBoxMKSo.Name = "checkBoxMKSo";
            this.checkBoxMKSo.Size = new System.Drawing.Size(140, 23);
            this.checkBoxMKSo.TabIndex = 5;
            this.checkBoxMKSo.Text = "Mật khẩu gồm số";
            this.checkBoxMKSo.UseVisualStyleBackColor = true;
            // 
            // checkBoxMKChu
            // 
            this.checkBoxMKChu.AutoSize = true;
            this.checkBoxMKChu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMKChu.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxMKChu.Location = new System.Drawing.Point(291, 148);
            this.checkBoxMKChu.Name = "checkBoxMKChu";
            this.checkBoxMKChu.Size = new System.Drawing.Size(150, 23);
            this.checkBoxMKChu.TabIndex = 6;
            this.checkBoxMKChu.Text = "Mật khẩu gồm chữ";
            this.checkBoxMKChu.UseVisualStyleBackColor = true;
            // 
            // checkBoxMKKyTu
            // 
            this.checkBoxMKKyTu.AutoSize = true;
            this.checkBoxMKKyTu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMKKyTu.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxMKKyTu.Location = new System.Drawing.Point(291, 187);
            this.checkBoxMKKyTu.Name = "checkBoxMKKyTu";
            this.checkBoxMKKyTu.Size = new System.Drawing.Size(215, 23);
            this.checkBoxMKKyTu.TabIndex = 7;
            this.checkBoxMKKyTu.Text = "Mật khẩu gồm ký tự đặc biệt";
            this.checkBoxMKKyTu.UseVisualStyleBackColor = true;
            // 
            // txtChieuDaiMK
            // 
            this.txtChieuDaiMK.Location = new System.Drawing.Point(208, 69);
            this.txtChieuDaiMK.Name = "txtChieuDaiMK";
            this.txtChieuDaiMK.Size = new System.Drawing.Size(31, 20);
            this.txtChieuDaiMK.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(454, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tạo mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(53, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(198, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 49);
            this.button3.TabIndex = 12;
            this.button3.Text = "Lưu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(350, 514);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 49);
            this.button4.TabIndex = 13;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(479, 514);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 49);
            this.button5.TabIndex = 14;
            this.button5.Text = "Sửa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.AutoSize = true;
            this.lblDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDangXuat.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangXuat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDangXuat.Location = new System.Drawing.Point(47, 9);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(112, 29);
            this.lblDangXuat.TabIndex = 15;
            this.lblDangXuat.Text = "Đăng xuất";
            // 
            // lblCaiDat
            // 
            this.lblCaiDat.AutoSize = true;
            this.lblCaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCaiDat.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaiDat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCaiDat.Location = new System.Drawing.Point(232, 9);
            this.lblCaiDat.Name = "lblCaiDat";
            this.lblCaiDat.Size = new System.Drawing.Size(84, 29);
            this.lblCaiDat.TabIndex = 16;
            this.lblCaiDat.Text = "Cài Đặt";
            // 
            // dgvDSTK
            // 
            this.dgvDSTK.AllowUserToAddRows = false;
            this.dgvDSTK.AutoGenerateColumns = false;
            this.dgvDSTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvDSTK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTK.ColumnHeadersVisible = false;
            this.dgvDSTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taiKhoanDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dgvDSTK.DataSource = this.taiKhoanBindingSource;
            this.dgvDSTK.GridColor = System.Drawing.Color.Black;
            this.dgvDSTK.Location = new System.Drawing.Point(53, 250);
            this.dgvDSTK.MultiSelect = false;
            this.dgvDSTK.Name = "dgvDSTK";
            this.dgvDSTK.ReadOnly = true;
            this.dgvDSTK.RowHeadersVisible = false;
            this.dgvDSTK.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvDSTK.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSTK.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Silver;
            this.dgvDSTK.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvDSTK.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDSTK.RowTemplate.Height = 36;
            this.dgvDSTK.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSTK.Size = new System.Drawing.Size(521, 143);
            this.dgvDSTK.TabIndex = 17;
            // 
            // taiKhoanDataGridViewTextBoxColumn
            // 
            this.taiKhoanDataGridViewTextBoxColumn.DataPropertyName = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn.HeaderText = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn.Name = "taiKhoanDataGridViewTextBoxColumn";
            this.taiKhoanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.taiKhoanDataSet;
            // 
            // taiKhoanDataSet
            // 
            this.taiKhoanDataSet.DataSetName = "TaiKhoanDataSet";
            this.taiKhoanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(53, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 31);
            this.button6.TabIndex = 18;
            this.button6.Text = "Tên tài khoản";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(222, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(167, 31);
            this.button7.TabIndex = 19;
            this.button7.Text = "Mật khẩu";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Silver;
            this.button8.Location = new System.Drawing.Point(389, 220);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(185, 31);
            this.button8.TabIndex = 20;
            this.button8.Text = "Ghi chú";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::UngDung_QuanLyMatKhau.Properties.Resources.minus_close_minimize_remove_512;
            this.pictureBox1.Location = new System.Drawing.Point(321, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureSetting
            // 
            this.pictureSetting.BackColor = System.Drawing.Color.Gray;
            this.pictureSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSetting.Image = global::UngDung_QuanLyMatKhau.Properties.Resources.settings_512;
            this.pictureSetting.Location = new System.Drawing.Point(185, 0);
            this.pictureSetting.Name = "pictureSetting";
            this.pictureSetting.Size = new System.Drawing.Size(47, 50);
            this.pictureSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSetting.TabIndex = 1;
            this.pictureSetting.TabStop = false;
            // 
            // pictureBack
            // 
            this.pictureBack.BackColor = System.Drawing.Color.Gray;
            this.pictureBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBack.Image = global::UngDung_QuanLyMatKhau.Properties.Resources.arrow_left_512;
            this.pictureBack.Location = new System.Drawing.Point(0, 0);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(47, 50);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 0;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(373, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thoát";
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UngDung_QuanLyMatKhau.TaiKhoanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(126, 417);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(175, 20);
            this.txtTaiKhoan.TabIndex = 23;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(394, 417);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(180, 20);
            this.txtMatKhau.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(48, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tài Khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(317, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mật khẩu";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(126, 465);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(448, 20);
            this.txtGhiChu.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(48, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ghi chú";
            // 
            // formUngDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(621, 595);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvDSTK);
            this.Controls.Add(this.lblCaiDat);
            this.Controls.Add(this.lblDangXuat);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtChieuDaiMK);
            this.Controls.Add(this.checkBoxMKKyTu);
            this.Controls.Add(this.checkBoxMKChu);
            this.Controls.Add(this.checkBoxMKSo);
            this.Controls.Add(this.checkBoxMKInHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblChieuDaiMK);
            this.Controls.Add(this.pictureSetting);
            this.Controls.Add(this.pictureBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUngDung";
            this.Text = "Ứng dụng quản lý mật khẩu";
            this.Load += new System.EventHandler(this.formUngDung_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_LogIn_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_LogIn_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_LogIn_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.PictureBox pictureSetting;
        private System.Windows.Forms.Label lblChieuDaiMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxMKInHoa;
        private System.Windows.Forms.CheckBox checkBoxMKSo;
        private System.Windows.Forms.CheckBox checkBoxMKChu;
        private System.Windows.Forms.CheckBox checkBoxMKKyTu;
        private System.Windows.Forms.TextBox txtChieuDaiMK;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblDangXuat;
        private System.Windows.Forms.Label lblCaiDat;
        private System.Windows.Forms.DataGridView dgvDSTK;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private TaiKhoanDataSet taiKhoanDataSet;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private TaiKhoanDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private TaiKhoanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label5;
    }
}