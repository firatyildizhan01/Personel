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
            txtId.Text = "";
            txtMeslek.Text = "";
            txtSoyad.Text = "";
            mskMaas.Text = "";
            cmbŞehir.Text = "";
            rdoBtn1.Text = "";
            rdoBtn2.Text = "";
            txtAd.Focus();

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
            if (rdoBtn1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void rdoBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtn2.Checked == true)
            {
                label8.Text = "False";
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbŞehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                rdoBtn1.Checked = true;
            }
            if (label8.Text == "False")
            {
                rdoBtn2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Delete From Table_1_real Where perİd=@k1",baglanti);
            komut1.Parameters.AddWithValue("@k1", txtId.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silindi bir şekilde");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand update = new SqlCommand("Update Table_1_real Set perAd=@a1,perSoyad=@a2,perSehir=@a3,perMaaş=@a4,perDurum=@a5,perMeslek=@a6 Where perİd=@a7", baglanti);
            update.Parameters.AddWithValue("@a1", txtAd.Text);
            update.Parameters.AddWithValue("@a2", txtSoyad.Text);
            update.Parameters.AddWithValue("@a3", cmbŞehir.Text);
            update.Parameters.AddWithValue("@a4", mskMaas.Text);
            update.Parameters.AddWithValue("@a5", label8.Text);
            update.Parameters.AddWithValue("@a6", txtMeslek.Text);
            update.Parameters.AddWithValue("@a7", txtId.Text);
            update.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("güncelleme gerçekleşti");
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
