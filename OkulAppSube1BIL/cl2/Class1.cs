using Ogretmen.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DAL;

namespace cl2
{
    public class OgretmenBL
    {
        public bool Ogretmenekle(Ogretmen.MODEL.Ogretmen ogr)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@TC",ogr.TC)
                         };

            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into tblogretmen values(@Ad,@Soyad,@TC)", p) > 0;

        }
    }
}
