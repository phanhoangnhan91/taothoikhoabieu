using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Threading;

namespace TaoTKB
{
    public partial class main : Form
    {
        public int demlanchay = 1;
        Entity ent = new Entity();
        public main()
        {
            InitializeComponent();
        }
        public void loadlailist()
        {
            listView1.Items.Clear();

            OleDbDataReader _reader = ent.LayThongTin("SELECT * FROM monhoc ORDER BY mamh,nhom");
            while (_reader.Read())
            {
                ListViewItem lvi = listView1.Items.Add(_reader[0].ToString());
                lvi.SubItems.Add(_reader[1].ToString());
                lvi.SubItems.Add(_reader[2].ToString());
                lvi.SubItems.Add(_reader[3].ToString());
                lvi.SubItems.Add(_reader[4].ToString());
            }
        }
        public Boolean laygiatrixulynhanh()
        {
            return checkXuLynhanh.Checked;
        }

        //public void loadlailist2()
        //{
        //    listView2.Items.Clear();

        //    OleDbDataReader _reader = ent.LayThongTin("select * from dsmonhoc");
        //    int i = 1;
        //    while (_reader.Read())
        //    {
        //        ListViewItem lvi = listView2.Items.Add((i++).ToString());
        //          lvi.SubItems.Add(_reader[0].ToString());
                
        //    }
        //}
        private void btThem_Click(object sender, EventArgs e)
        {
           // Form1 fm1 = new Form1(this.Nguoidung);

          //  string ngay = String.Format("{0:MM/dd/yy}", dateNgay.Value);


            if (ent.ThucThiCauTruyVan("Insert into monhoc values(" + Convert.ToInt32(txtMamh.Text) + "," + Convert.ToInt32(txtNhom.Text) + "," + Convert.ToInt32(txtThu.Text) +  
                "," + Convert.ToInt32(txtTietbd.Text)+"," + Convert.ToInt32(txtSotiet.Text) + ")"))
            //
            //load lai form
            {
                Thread.Sleep(500);
                loadlailist();

                //    MessageBox.Show("Thanh Cong Roi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadlailist();
            //loadlailist2();
            lbcho.Hide();
          //  picturecho.Hide();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
          //  txtMamh.Text = "delete from cong viec where mamh=" + txtMamh.Text + "and nhom =" + txtNhom.Text;
            
            if (ent.ThucThiCauTruyVan("delete from monhoc where mamh="+txtMamh.Text +" and nhom ="+ txtNhom.Text))
            {
                //txtMamh.Text = "delete from cong viec where mamh=" + txtMamh.Text + "and nhom =" + txtNhom.Text;

                // EventArgs ev;
                Thread.Sleep(500);// 500 milisecon
                loadlailist();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtMamh.Text = listView1.FocusedItem.SubItems[0].Text;
            txtNhom.Text = listView1.FocusedItem.SubItems[1].Text;
            txtThu.Text = listView1.FocusedItem.SubItems[2].Text;
            txtTietbd.Text = listView1.FocusedItem.SubItems[3].Text;
            txtSotiet.Text = listView1.FocusedItem.SubItems[4].Text;
            
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
             //string ngay = String.Format("{0:MM/dd/yy}", dateNgay.Value);
            
             //  txtCongviec.Text = "update congviec set('" + ngay + "',N'" + txtCongviec.Text + "')where stt=" + sttDangdcchon ;
            if (ent.ThucThiCauTruyVan("update monhoc set thu='" + txtThu.Text + "',tietbd='" + txtTietbd.Text +"',sotiet='" + txtSotiet.Text +"'where mamh=" + txtMamh.Text +" and nhom="+txtNhom.Text))
            {
                // MessageBox.Show("cập nhật thành công!");
                //    Form1 fm = new Form1(this.Nguoidung);

                Thread.Sleep(500);// 1000 milisecon
                loadlailist();
            }
        }

        private void btTaotkb_Click(object sender, EventArgs e)
        {
            
            lbcho.Show();
            //picturecho.Show();
            int [,] a= new int [15,7];
            int[,] b= new int[15, 7];
            tkb fm1 = new tkb(a,b,laygiatrixulynhanh(),demlanchay);
            fm1.Show();

            lbcho.Hide();
            demlanchay++;
            //chuyen xu li cho tkb roi chuyen qua random tkb

          //  picturecho.Hide();
        }

       

      

        //private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txttenmh.Text = listView2.FocusedItem.SubItems[1].Text;
           
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            tacgia fm3 = new tacgia();
            fm3.Show();
        }

        private void btlamtuoi_Click(object sender, EventArgs e)
        {
            loadlailist();
            //loadlailist2();
        }
    }
}
