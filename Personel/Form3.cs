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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=FIRAT-PC\\SQLEXPRESS;Initial Catalog=TBL_CANAVAR;Integrated Security=True");
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select perSehir,Count(*) From Table_1_real Group By perSehir", baglanti);
            SqlDataReader drx = komutg1.ExecuteReader();
            while (drx.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(drx[0], drx[1]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select perMeslek,Avg(perMaaş) From Table_1_real Group by perMeslek",baglanti);
            SqlDataReader drx1 = komutg2.ExecuteReader();
            while (drx1.Read())
            {
                chart2.Series["Meslek Maaş"].Points.AddXY(drx1[0], drx1[1]);
            }
            baglanti.Close();
            
        }
    }
}
