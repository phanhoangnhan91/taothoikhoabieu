using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Data.OleDb;

namespace TaoTKB
{
    class randomTKB
    {
        #region bien toan cuc
        public Boolean xulinhanh;
        
        public int _solan = 0;
        public int[] soluongnhom = new int[100];
       // MonHoc[] danhsachmonhoc = new MonHoc[20];
        public int[,] MangMon = new int[15, 7];// luu ma mon hoc
        public int[,] mangnhom = new int[15, 7];// luu nhom
        public int soLuongMonHoc = 0;
        Entity et = new Entity();
        MonHoc[] MH = new MonHoc[100];
        #endregion
        public randomTKB(Boolean _xulinhanh)
        {
            this.xulinhanh = _xulinhanh;
        }
        struct MonHoc
        {
            public int mamh;
            public int nhom;
            public int thu;
            public int tietbd;
            public int sotiet;
        }
        #region ham tu viet
        Boolean kiemtratontai(int m, int n, out MonHoc monhoc) // n la mon hoc, m la nhom // true la ton tai
        {
            monhoc.mamh = 0;
            monhoc.nhom = 0;
            monhoc.sotiet = 0;
            monhoc.thu = 0;
            monhoc.tietbd = 0;
            OleDbDataReader rd3 = et.LayThongTin("select count (DISTINCT Mamh)  from monhoc");
            while (rd3.Read())
            {
                soLuongMonHoc = Convert.ToInt32(rd3[0]);
            }
            //  //Console.WriteLine("slMH:" + soLuongMonHoc);
            if (m > soLuongMonHoc)
                return false;
            else
            {
                OleDbDataReader tontai = et.LayThongTin("select * from monhoc where Mamh=" + m);
                if (tontai == null)
                    return false;
                while (tontai.Read())
                {
                    if (Convert.ToInt32(tontai[1]) == n) // neu ton tai thi gan vao mon hoc
                    {
                        monhoc.mamh = m;
                        monhoc.nhom = n;
                        monhoc.thu = Convert.ToInt32(tontai[2]);
                        monhoc.tietbd = Convert.ToInt32(tontai[3]);
                        monhoc.sotiet = Convert.ToInt32(tontai[4]);
                        return true;
                    }
                }
                return false;
            }
        }
        public void khoitaogiatriMangMon()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    MangMon[i, j] = 0;
                    mangnhom[i, j] = 0;
                }

            }
        }

        Boolean themMotmonhoc(MonHoc monhoc)
        {
            // //Console.WriteLine(monhoc.tietbd+"  "  +monhoc.thu);
            //  Console.ReadLine();
            // lay mon hoc do bo vao thoi khoa bieu
            for (int i = 0; i < monhoc.sotiet; i++)
            {
                if (MangMon[monhoc.tietbd + i - 1, monhoc.thu - 1] == 0)
                {
                    MangMon[monhoc.tietbd + i - 1, monhoc.thu - 1] = monhoc.mamh;// luu ma mh vao mang tkb
                    mangnhom[monhoc.tietbd + i - 1, monhoc.thu - 1] = monhoc.nhom;

                }
                else
                    return false;

            }

            _solan = _solan + 1;

            return true;
        }

        public void laycacgiatrithanhphan()
        {
            #region lay cac gia tri thanh phan

            int i = 0;
            int j = 0;

            OleDbDataReader reader = et.LayThongTin("select mamh, COUNT(*) from monhoc group by mamh");
            ////Console.WriteLine("cau truy van dau thuc hien dc");
            while (reader.Read())
            {
                soluongnhom[i] = Convert.ToInt32(reader[1]);
                ////Console.WriteLine( soluongnhom[i]);
                i++;
            }
            OleDbDataReader rd = et.LayThongTin("SELECT * FROM monhoc ORDER BY mamh,nhom"); // lay thong tin và sắp xếp
            while (rd.Read())
            {
                MH[j].mamh = Convert.ToInt32(rd[0]);
                MH[j].nhom = Convert.ToInt32(rd[1]);
                MH[j].thu = Convert.ToInt32(rd[2]);
                MH[j].tietbd = Convert.ToInt32(rd[3]);
                MH[j].sotiet = Convert.ToInt32(rd[4]);

                j++;
            }
            // dem so luong mon hoc

            OleDbDataReader rd3 = et.LayThongTin("select count (*) from(SELECT DISTINCT mamh FROM monhoc )");
            while (rd3.Read())
            {
                soLuongMonHoc = Convert.ToInt32(rd3[0]);
            }
            // //Console.WriteLine("slMH:"+soLuongMonHoc);

            int maxSoLuongNhom = timmax(soluongnhom);
            //     monhocNhom mhNhom= new monhocNhom[ soLuongMonHoc];// danh sach la mot chuoi cac mon hoc nhom
            #endregion

        }
        public int timmax(int[] a)
        {
            int Maximum = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (Maximum < a[i])
                    Maximum = a[i];
            }
            return Maximum;

        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void vonglapforTKB(out int[,] a, out int[,] b)
        {
            for (int q = 1; q <= soLuongMonHoc; q++)
            {
                if(xulinhanh==false)
                Thread.Sleep(1000);// cho he thong nghi 1s de ham random hoat dong tot hon
                int nhom = RandomNumber(1, soluongnhom[q - 1] + 1);
                //    //Console.WriteLine("");
                // Console.ReadLine();
                // lay mon hoc thuoc ma q, nhom nhom ra
                MonHoc monhochientai;
                monhochientai.mamh = 0;
                monhochientai.nhom = 0;
                monhochientai.thu = 0;
                monhochientai.tietbd = 0;
                monhochientai.sotiet = 0;

                
                // lay thong tin mon hoc moi
                int timvitrimautin = 0+nhom-1;// dung tim vi tri mau tin
                for (int t = 1; t < q; t++)
                    timvitrimautin = timvitrimautin + soluongnhom[t-1];
                monhochientai = MH[timvitrimautin];
                if (themMotmonhoc(monhochientai) == false) break;

            }
            //dieu kien lap lai cua vong lap for
            if (soLuongMonHoc >= 6)
            {
                if (_solan < 6)// le ra phai bang so luong mon hoc, nhung neu bang so luong mon hoc thi kho xep
                {


                    _solan = 0;
                    khoitaogiatriMangMon();
                    // Application.c();
                    vonglapforTKB(out a,out b);
                }
                else
                {
                    a = MangMon;
                    b = mangnhom;
                }
            }
            else
            {
                if (_solan != soLuongMonHoc)// le ra phai bang so luong mon hoc, nhung neu bang so luong mon hoc thi kho xep
                {


                    //Console.WriteLine("khong phat sinh dc thoi khoa bieu");// co gang doi cuoi cung cung ra
                    _solan = 0;
                    khoitaogiatriMangMon();
                    // Application.c();
                    vonglapforTKB(out a,out b);
                }
                else
                {
                    a = MangMon;
                    b = mangnhom;
                }
            }

        }

        public void taothoikhoabieu(out int[,] a, out int[,] b)
        {
            //
            laycacgiatrithanhphan();
            vonglapforTKB(out a,out b);
           
            


            a = MangMon;
            b = mangnhom;


        }
        //public void xuatmang2chieu(int[,] a)
        //{
        //    for (int i = 0; i < 15; i++)
        //    {
        //        for (int j = 0; j < 7; j++)
        //            //Console.Write(a[i, j] + "  ");
        //        //Console.WriteLine();
        //    }

        //}
        #endregion

    }
}
