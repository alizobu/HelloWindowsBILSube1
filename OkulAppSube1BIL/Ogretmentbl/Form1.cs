using System;
using cl2;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ogretmen.MODEL;
using DAL;


namespace Ogretmentbl
{
    public partial class ogretmenkayit : Form
    {
        public ogretmenkayit()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                bool sonuc = obl.Ogretmenekle(new Ogretmen.MODEL.Ogretmen { Ad = ogrtmnadtext.Text.Trim(), Soyad = ogrtmnsoyadtext.Text.Trim(), TC = ogrtmntctext.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu TC'li öğretmen daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası");
                        break;
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }

        
    }
}
