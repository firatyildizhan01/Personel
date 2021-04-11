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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source=FIRAT-PC\SQLEXPRESS;Initial Catalog=TBL_CANAVAR;Integrated Security=True
        SqlConnection baglanti = new SqlConnection("Data Source=FIRAT-PC\\SQLEXPRESS;Initial Catalog=TBL_CANAVAR;Integrated Security=True");

        void temizle()
        {
            txtAd.Text = "";
            txtId= "";



        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBL_CANAVARDataSet.Table_1_real' table. You can move, or remove it, as needed.
            this.table_1_realTableAdapter.Fill(this.tBL_CANAVARDataSet.Table_1_real);

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.table_1_realTableAdapter.Fill(this.tBL_CANAVARDataSet.Table_1_real);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Table_1_real (perAd,perSoyad,perSehir,perMaaş,perMeslek,perDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.Add("@p1", txtAd.Text);
            komut.Parameters.Add("@p2", txtSoyad.Text);
            komut.Parameters.Add("@p3", cmbŞehir.Text);
            komut.Parameters.Add("@p4", mskMaas.Text);
            komut.Parameters.Add("@p5", txtMeslek.Text);
            komut.Parameters.Add("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt oldu");



        }

        private void rdoBtn1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";
        }

        private void rdoBtn2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }
    }
}
