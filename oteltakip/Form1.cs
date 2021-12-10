using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace oteltakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kullanici, sifre;
        private void button2_Click(object sender, EventArgs e)

        {
            SqlConnection baglanti = new SqlConnection("Data Source=WIN-5D1N64KPPAU;Initial Catalog=otelotomasyon;User ID=sa;Password=qwerT12/;");

            SqlCommand komut = new SqlCommand();
            
            baglanti.Open();

            string ekle = "INSERT INTO kullanicilar(ad,soyad,email,tc,dtarih,telno,sifre) values (@ad," +
                " @soyad, @email, @tc, @dtarih, @telno,@sifre)";

            string dogmtarih = dateTimePicker1.Value.ToString();
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@ad", textBox3.Text);
            komut.Parameters.AddWithValue("@soyad", textBox4.Text);
            komut.Parameters.AddWithValue("@email", textBox5.Text);
            komut.Parameters.AddWithValue("@tc", textBox6.Text);
            komut.Parameters.AddWithValue("@dtarih", dogmtarih);
            komut.Parameters.AddWithValue("@telno", textBox8.Text);
            komut.Parameters.AddWithValue("@sifre", textBox7.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == kullanici && textBox7.Text == sifre)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
        }
    }
}
