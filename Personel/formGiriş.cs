using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel
{
    public partial class formGiriş : Form
    {
        public formGiriş()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FIRAT-PC\\SQLEXPRESS;Initial Catalog=TBL_CANAVAR;Integrated Security=True");
        private void formGiriş_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Table_furk where KullaniciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullanıcı.Text);
            komut.Parameters.AddWithValue("@p2",txtŞifre.Text);
            SqlDataReader drt = komut.ExecuteReader();
            if (drt.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
            baglanti.Close();
        }
    }
}
