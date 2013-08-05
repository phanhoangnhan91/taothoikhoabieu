using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace TaoTKB
{
    public partial class tkb : Form
    {
        public int demsolanchay=1;
        public int[,] mangnhom = new int[15, 7];
        public int[,] mangmon = new int[15, 7];
        //int[,] MangMon = new int[15, 7];// luu ma mon hoc
        //int[,] mangnhom = new int[15, 7];// luu nhom

        public ListView board = new ListView();
        public void xulifileexcel()
        {

        }
        Boolean xulinhanh;

        public tkb( int[,] _mangmon,int[,] _mangnhom, Boolean _xulynhanh,int _demsolanchay)
        {
            this.mangmon = _mangnhom;
            this.mangnhom = _mangnhom;
            this.xulinhanh = _xulynhanh;
            InitializeComponent();
            this.demsolanchay = _demsolanchay;
        }
        // ham ghi 2 mang vao 
        public void ghi2mang()
        {
          

            for (int i = 1; i <= 15; i++)
            {
                string[] tenmonhoc = new string[20];
               
             //   char[] cot = new char[10] { 'Q','A', 'B', 'C', 'D', 'E', 'F','G','H','J' };

                // board.Items.Add(new ListViewItem("Tiết " + i + "     "));
                for (int j = 0; j < 7; j++)
                    if (mangmon[i - 1, j] != 0)
                    {
                        
                            board.Items[i - 1].SubItems.Add("Môn: " + mangmon[i - 1, j] + " Nhóm: " + mangnhom[i - 1, j]);
                        
                           // mySheet.Cells[i + 1, j + 2]=("Môn: " + mangmon[i - 1, j] + " Nhóm: " + mangnhom[i - 1, j]);

                    }
                    else
                        board.Items[i - 1].SubItems.Add("                   ");
               


            }
            


        }
        public void hienthitkb()
        {

            board.Bounds = new System.Drawing.Rectangle(new System.Drawing.Point(0, 0), new Size(this.Width, this.Height));

            board.View = View.Details;
            board.LabelEdit = false;
            board.AllowColumnReorder = false;
            board.GridLines = true;

            board.Columns.Add("Tiết/Thứ", -10, HorizontalAlignment.Center);
            board.Columns.Add("Chủ Nhật", -10, HorizontalAlignment.Center);
            for (int i = 2; i <= 7; i++)
            {
                board.Columns.Add("Thứ " + i, -10, HorizontalAlignment.Center);
            }

            for (int i = 1; i <= 15; i++)
            {

                board.Items.Add(new ListViewItem("Tiết " + i + "     "));
                //for(int j=0;j<7;j++)
                //board.Items[i-1].SubItems.Add(i.ToString());

            }
            ghi2mang();


            this.Controls.Add(board);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình xử lí hơi lâu xin vui lòng chờ khoảng 1 phút! Click OK để chương trình bắt đầu xử lý.");
            //Form2 frm2 = new Form2();
            //frm2.Show();
            
            randomTKB random = new randomTKB(this.xulinhanh);
            random.taothoikhoabieu(out this.mangmon, out this.mangnhom);
            
           
            // new cai form va hien thi len form
            // ham hien thi len form
            hienthitkb();
            // hoi xem co mun xuat ra file khong
           
           
         //   frm2.Close();
            
        }

        private void tkb_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tkb_ControlAdded(object sender, ControlEventArgs e)
        {
          
        }

        private void tkb_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu lại TBK vào file excel không?", "Nhắc", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                #region lam viec voi excel
                ApplicationClass xlsApp = new ApplicationClass(); 	//create an excel application 
                //object example 
                if (xlsApp == null)
                {
                    MessageBox.Show(" Máy này không cài excel, không thể xuất ra file excel!");
                    return;
                }
                // Thêm file temp xls
                Workbook workbook = xlsApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);



                // Lấy sheet 1.
                Worksheet mySheet = (Worksheet)workbook.Worksheets[1];
                mySheet.Name = "TKB" + demsolanchay.ToString();

                mySheet.Cells[1, 1] = "Tiết/Thứ";
                mySheet.Cells[1, 2] = "Chủ Nhật";
                mySheet.Cells[1, 9] = "Tác giả : Phan Hoàng Nhân";
                for (int i = 2; i <= 7; i++)
                    mySheet.Cells[1, i + 1] = "Thứ " + i;
                for (int i = 1; i <= 15; i++)
                    mySheet.Cells[i + 1, 1] = "Tiết " + i;
                for (int i = 1; i <= 15; i++)
                {
                    string[] tenmonhoc = new string[20];


                    for (int j = 0; j < 7; j++)
                        if (mangmon[i - 1, j] != 0)
                        {

                            board.Items[i - 1].SubItems.Add("Môn: " + mangmon[i - 1, j] + " Nhóm: " + mangnhom[i - 1, j]);

                            mySheet.Cells[i + 1, j + 2] = ("Môn: " + mangmon[i - 1, j] + " Nhóm: " + mangnhom[i - 1, j]);

                        }

                }
                // autofit và lưu file excel


                Range r = mySheet.get_Range("A1", "H16");
                r.Font.Bold = true;
                r.Font.Size = 11;
                r.BorderAround();
                r.Interior.Color = 173996210;
                r.Columns.AutoFit();
                char[] cot = new char[10] { 'Q', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J' };
                for (int i = 1; i < 9; i = i + 2)
                {
                    mySheet.get_Range(cot[i] + "1", cot[i] + "16").Interior.Color = 43906210;
                }
                xlsApp.Visible = true;
                // workbook.Saved = true;
                // workbook.SaveCopyAs("d:/tkb2.xlsx");

                //workbook.Close(false, false, false);
                //// xlsApp.Quit();

                //System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlsApp);
                //  System.Diagnostics.Process.Start("d:/tkb2.xlsx");


                #endregion

            }
        }
    }
}
