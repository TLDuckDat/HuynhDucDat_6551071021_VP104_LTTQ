namespace HuynhDucDat_6551071021_VP104_LTTQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtLuongCoBan = new TextBox();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(726, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.KeyDown += cacPhimTatChoGridViews;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLuongCoBan);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(35, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 156);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLuongCoBan.Location = new Point(122, 99);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(266, 29);
            txtLuongCoBan.TabIndex = 5;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenNhanVien.Location = new Point(122, 60);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(266, 29);
            txtTenNhanVien.TabIndex = 4;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNhanVien.Location = new Point(122, 25);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(266, 29);
            txtMaNhanVien.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 102);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 2;
            label3.Text = "Lương cơ bản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 65);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 28);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(483, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 156);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(6, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(266, 119);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Các chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(147, 68);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 39);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(6, 68);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(113, 39);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(147, 23);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(113, 39);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(6, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(113, 39);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Quản lý Nhân viên/ Nhân sự - VP104";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txtMaNhanVien;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLuongCoBan;
        private TextBox txtTenNhanVien;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnThem;
    }
}
