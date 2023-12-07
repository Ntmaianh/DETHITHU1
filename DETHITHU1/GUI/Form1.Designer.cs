namespace DETHITHU1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            radbtnHetHang = new RadioButton();
            radbtnConHang = new RadioButton();
            txtGia = new TextBox();
            txtMa = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnXoa = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            dgvXeMay = new DataGridView();
            cbLoc = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXeMay).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radbtnHetHang);
            groupBox1.Controls.Add(radbtnConHang);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // radbtnHetHang
            // 
            radbtnHetHang.AutoSize = true;
            radbtnHetHang.Location = new Point(198, 157);
            radbtnHetHang.Name = "radbtnHetHang";
            radbtnHetHang.Size = new Size(77, 19);
            radbtnHetHang.TabIndex = 8;
            radbtnHetHang.TabStop = true;
            radbtnHetHang.Text = "Hết hàng ";
            radbtnHetHang.UseVisualStyleBackColor = true;
            // 
            // radbtnConHang
            // 
            radbtnConHang.AutoSize = true;
            radbtnConHang.Location = new Point(86, 157);
            radbtnConHang.Name = "radbtnConHang";
            radbtnConHang.Size = new Size(80, 19);
            radbtnConHang.TabIndex = 7;
            radbtnConHang.TabStop = true;
            radbtnConHang.Text = "Còn hàng ";
            radbtnConHang.UseVisualStyleBackColor = true;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(86, 113);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(192, 23);
            txtGia.TabIndex = 6;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(86, 74);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(192, 23);
            txtMa.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(86, 38);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(192, 23);
            txtTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 161);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 121);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Gía bán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 82);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 46);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(441, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(241, 159);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(34, 112);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(182, 32);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(34, 68);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(182, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(34, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(182, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvXeMay);
            groupBox3.Location = new Point(29, 256);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(667, 223);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // dgvXeMay
            // 
            dgvXeMay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXeMay.Location = new Point(6, 22);
            dgvXeMay.Name = "dgvXeMay";
            dgvXeMay.RowTemplate.Height = 25;
            dgvXeMay.Size = new Size(655, 182);
            dgvXeMay.TabIndex = 0;
            dgvXeMay.CellMouseClick += dgvXeMay_CellMouseClick;
            // 
            // cbLoc
            // 
            cbLoc.FormattingEnabled = true;
            cbLoc.Items.AddRange(new object[] { "1", "0" });
            cbLoc.Location = new Point(441, 202);
            cbLoc.Name = "cbLoc";
            cbLoc.Size = new Size(241, 23);
            cbLoc.TabIndex = 2;
            cbLoc.Text = "Lọc theo trạng thái";
            cbLoc.SelectedIndexChanged += cbLoc_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 491);
            Controls.Add(cbLoc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "QuanLiXeMay";
            Load += Form1_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvXeMay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbLoc;
        private DataGridView dgvXeMay;
        private Button btnClear;
        private Button btnXoa;
        private Button btnAdd;
        private RadioButton radbtnHetHang;
        private RadioButton radbtnConHang;
        private TextBox txtGia;
        private TextBox txtMa;
        private TextBox txtTen;
    }
}