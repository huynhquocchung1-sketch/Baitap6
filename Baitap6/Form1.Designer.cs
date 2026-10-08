namespace Baitap6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTaiLai = new Button();
            dataGridView1 = new DataGridView();
            btnLocDat = new Button();
            lblTrangThai = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(164, 87);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(253, 31);
            txtHoTen.TabIndex = 0;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(591, 87);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(197, 31);
            txtDiem.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(26, 146);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 1;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(164, 146);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(305, 146);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(443, 146);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(112, 34);
            btnTaiLai.TabIndex = 1;
            btnTaiLai.Text = "Tải lại danh sách";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(776, 225);
            dataGridView1.TabIndex = 2;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(591, 146);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(197, 34);
            btnLocDat.TabIndex = 3;
            btnLocDat.Text = "Lọc SV đạt (LINQ)";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(12, 450);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(285, 25);
            lblTrangThai.TabIndex = 4;
            lblTrangThai.Text = "Hiển thị thông báo trạng thái xử lý";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(501, 87);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 5;
            label1.Text = "Điểm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 87);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 5;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(214, 18);
            label3.Name = "label3";
            label3.Size = new Size(387, 49);
            label3.TabIndex = 6;
            label3.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 515);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTrangThai);
            Controls.Add(btnLocDat);
            Controls.Add(dataGridView1);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTaiLai;
        private DataGridView dataGridView1;
        private Button btnLocDat;
        private Label lblTrangThai;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}