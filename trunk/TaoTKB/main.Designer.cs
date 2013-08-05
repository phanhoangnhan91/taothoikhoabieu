namespace TaoTKB
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.txtNhom = new System.Windows.Forms.TextBox();
            this.txtMamh = new System.Windows.Forms.TextBox();
            this.txtTietbd = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btTaotkb = new System.Windows.Forms.Button();
            this.txtSotiet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbcho = new System.Windows.Forms.Label();
            this.btlamtuoi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.checkXuLynhanh = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã MH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thứ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiết bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiết";
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(162, 22);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(70, 20);
            this.txtThu.TabIndex = 2;
            this.txtThu.Text = "2";
            // 
            // txtNhom
            // 
            this.txtNhom.Location = new System.Drawing.Point(86, 22);
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Size = new System.Drawing.Size(70, 20);
            this.txtNhom.TabIndex = 1;
            this.txtNhom.Text = "1";
            // 
            // txtMamh
            // 
            this.txtMamh.Location = new System.Drawing.Point(12, 22);
            this.txtMamh.Name = "txtMamh";
            this.txtMamh.Size = new System.Drawing.Size(70, 20);
            this.txtMamh.TabIndex = 0;
            this.txtMamh.Text = "1";
            // 
            // txtTietbd
            // 
            this.txtTietbd.Location = new System.Drawing.Point(238, 22);
            this.txtTietbd.Name = "txtTietbd";
            this.txtTietbd.Size = new System.Drawing.Size(70, 20);
            this.txtTietbd.TabIndex = 3;
            this.txtTietbd.Text = "1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(582, 480);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã MH";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nhóm";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thứ";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tiết bắt đầu";
            this.columnHeader4.Width = 132;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số tiết";
            this.columnHeader5.Width = 79;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(238, 51);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(407, 51);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(319, 50);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btTaotkb
            // 
            this.btTaotkb.Location = new System.Drawing.Point(488, 51);
            this.btTaotkb.Name = "btTaotkb";
            this.btTaotkb.Size = new System.Drawing.Size(75, 23);
            this.btTaotkb.TabIndex = 10;
            this.btTaotkb.Text = "Tạo TKB";
            this.btTaotkb.UseVisualStyleBackColor = true;
            this.btTaotkb.Click += new System.EventHandler(this.btTaotkb_Click);
            // 
            // txtSotiet
            // 
            this.txtSotiet.Location = new System.Drawing.Point(320, 22);
            this.txtSotiet.Name = "txtSotiet";
            this.txtSotiet.Size = new System.Drawing.Size(70, 20);
            this.txtSotiet.TabIndex = 4;
            this.txtSotiet.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(0, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "* Ghi chú : các ô trên đều phải nhập số";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = global::TaoTKB.Properties.Resources.index;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(407, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 35);
            this.button1.TabIndex = 13;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbcho
            // 
            this.lbcho.AutoSize = true;
            this.lbcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcho.ForeColor = System.Drawing.Color.Red;
            this.lbcho.Location = new System.Drawing.Point(329, 76);
            this.lbcho.Name = "lbcho";
            this.lbcho.Size = new System.Drawing.Size(249, 25);
            this.lbcho.TabIndex = 14;
            this.lbcho.Text = "Vui lòng chờ khoảng 1 phút";
            // 
            // btlamtuoi
            // 
            this.btlamtuoi.Location = new System.Drawing.Point(238, 75);
            this.btlamtuoi.Name = "btlamtuoi";
            this.btlamtuoi.Size = new System.Drawing.Size(75, 23);
            this.btlamtuoi.TabIndex = 15;
            this.btlamtuoi.Text = "Làm tươi";
            this.btlamtuoi.UseVisualStyleBackColor = true;
            this.btlamtuoi.Click += new System.EventHandler(this.btlamtuoi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(9, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Chủ nhật vui lòng nhập thứ: 1";
            // 
            // checkXuLynhanh
            // 
            this.checkXuLynhanh.AutoSize = true;
            this.checkXuLynhanh.Location = new System.Drawing.Point(481, 25);
            this.checkXuLynhanh.Name = "checkXuLynhanh";
            this.checkXuLynhanh.Size = new System.Drawing.Size(82, 17);
            this.checkXuLynhanh.TabIndex = 16;
            this.checkXuLynhanh.Text = "Xử lý nhanh";
            this.checkXuLynhanh.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 595);
            this.Controls.Add(this.checkXuLynhanh);
            this.Controls.Add(this.btlamtuoi);
            this.Controls.Add(this.lbcho);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btTaotkb);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtMamh);
            this.Controls.Add(this.txtSotiet);
            this.Controls.Add(this.txtTietbd);
            this.Controls.Add(this.txtNhom);
            this.Controls.Add(this.txtThu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tác giả Phan Hoàng Nhân";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThu;
        private System.Windows.Forms.TextBox txtNhom;
        private System.Windows.Forms.TextBox txtMamh;
        private System.Windows.Forms.TextBox txtTietbd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTaotkb;
        private System.Windows.Forms.TextBox txtSotiet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbcho;
        private System.Windows.Forms.Button btlamtuoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkXuLynhanh;

    }
}