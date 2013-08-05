using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace TaoTKB
{
    class Entity
    {

        //string connetionString = @"Server=.\SqlExpress;AttachDbFilename=D:\dkmonhoc.mdf;Database=dkmonhoc; Trusted_Connection=Yes";//;connection timeout=60000
        string connetionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dkmonhoc.accdb";
        OleDbConnection cnn;
        
        //connetionString = @"Server=.\SqlEXPRESS; Database=QLSinhVien; Integrated Security=SSPI";
        // hoặc
        

        public Boolean TaoKetNoi()
        {
            cnn = new OleDbConnection(connetionString);
            try
            {
                if (cnn.State == ConnectionState.Closed)

                    cnn.Open();
            
               // MessageBox.Show((cnn.ConnectionTimeout).ToString());
                //MessageBox.Show("Connection Open ! ");
                return true;
                //cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở csdl ! " + ex);
                return false;
            }
        }
        public Boolean ngatketnoi()
        {
            cnn = new OleDbConnection(connetionString);
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                //MessageBox.Show("Connection Open ! ");
                return true;
                //cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đóng Kết nối csdl ! " + ex);
                return false;
            }
        }
        public OleDbDataReader LayThongTin(string cautruyvan)
        {

            OleDbDataReader myReader = null;
            cnn = new OleDbConnection(connetionString);
            try
            {
                TaoKetNoi();             //  MessageBox.Show("ket noi da dc mo");
                OleDbCommand myCommand = new OleDbCommand(cautruyvan, cnn);
                myReader = myCommand.ExecuteReader();
              //  ngatketnoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lối truy vấn" + ex);
            }
            return myReader;
        }
        public Boolean ThucThiCauTruyVan(string Sql)
        {
            try
            {

                cnn = new OleDbConnection(connetionString);
                TaoKetNoi();
                OleDbCommand cautruyvan = new OleDbCommand(Sql, cnn);
                cautruyvan.ExecuteNonQuery();
               // ngatketnoi();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
