using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;


namespace TaoTKB
{
    static class Program
    {


   
        [STAThread]
        static void Main()
        {
            try
            {
                int[,] MangMon = new int[15, 7];// luu ma mon hoc
                int[,] mangnhom = new int[15, 7];// luu nhom
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new main());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          //  Console.Write("");
        }
    }
}
