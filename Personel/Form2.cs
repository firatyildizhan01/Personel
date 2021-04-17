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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FIRAT-PC\\SQLEXPRESS;Initial Catalog=TBL_CANAVAR;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Table_1_real", baglanti);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                lblToplamPersonel.Text = dr[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Table_1_real where perDurum=1",baglanti);
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                lblEvli.Text = dr2[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(*) From Table_1_real where perDurum=0", baglanti);
            SqlDataReader dr3 = komut4.ExecuteReader();
            while (dr3.Read())
            {
                lblBekar.Text = dr3[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Count(distinct(perSehir)) From Table_1_real", baglanti);
            SqlDataReader dr4 = komut5.ExecuteReader();
            while (dr4.Read())
            {
                lblŞehir.Text = dr4[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Sum(PerMaas) From Table_1_real", baglanti);
            SqlDataReader dr5 = komut6.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamMaaş.Text = dr5[0].ToString();
            }

            baglanti.Close();




        }
    }
}
