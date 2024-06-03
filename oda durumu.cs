using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace otel_otomasyonu
{
    public partial class oda_durumu : Form
    {
        public oda_durumu()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS;Initial Catalog=oteloto;Integrated Security=True;");

        private void oda_durumu_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from oda101", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                oda1.Text = oku["ad"].ToString() + " " + oku["soyad"].ToString();
            }
            baglantı.Close();
            if (oda1.Text != "1")
            {
                oda1.BackColor = Color.Red;
            }
            //oda 2
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from oda102", baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                oda2.Text = oku1["ad"].ToString() + " " + oku1["soyad"].ToString();
            }
            baglantı.Close();
            if (oda2.Text != "2")
            {
                oda2.BackColor = Color.Red;
            }
            //oda 3
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda103", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                oda3.Text = oku2["ad"].ToString() + " " + oku2["soyad"].ToString();
            }
            baglantı.Close();
            if (oda3.Text != "3")
            {
                oda3.BackColor = Color.Red;
            }
            //oda 4
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda104", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                oda4.Text = oku3["ad"].ToString() + " " + oku3["soyad"].ToString();
            }
            baglantı.Close();
            if (oda4.Text != "4")
            {
                oda4.BackColor = Color.Red;
            }
            //oda 5
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda105", baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                oda5.Text = oku4["ad"].ToString() + " " + oku4["soyad"].ToString();
            }
            baglantı.Close();
            if (oda5.Text != "5")
            {
                oda5.BackColor = Color.Red;
            }
            //oda 6
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select * from oda106", baglantı);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                oda6.Text = oku5["ad"].ToString() + " " + oku5["soyad"].ToString();
            }
            baglantı.Close();
            if (oda6.Text != "6")
            {
                oda6.BackColor = Color.Red;
            }
            //oda 7
            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select * from oda107", baglantı);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                oda7.Text = oku6["ad"].ToString() + " " + oku6["soyad"].ToString();
            }
            baglantı.Close();
            if (oda7.Text != "7")
            {
                oda7.BackColor = Color.Red;
            }
            //oda 8
            baglantı.Open();
            SqlCommand komut7 = new SqlCommand("select * from oda108", baglantı);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                oda8.Text = oku7["ad"].ToString() + " " + oku7["soyad"].ToString();
            }
            baglantı.Close();
            if (oda8.Text != "8")
            {
                oda8.BackColor = Color.Red;
            }
            //oda 9
            baglantı.Open();
            SqlCommand komut8 = new SqlCommand("select * from oda109", baglantı);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                oda9.Text = oku8["ad"].ToString() + " " + oku8["soyad"].ToString();
            }
            baglantı.Close();
            if (oda9.Text != "9")
            {
                oda9.BackColor = Color.Red;
            }
        }
    }
}
