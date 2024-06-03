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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace otel_otomasyonu
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS;Initial Catalog=oteloto;Integrated Security=True;");
        //Data Source=MONSTER\SQLEXPRESS;Initial Catalog=oteloto;Integrated Security=True;Trust Server Certificate=True
        private void button5_Click(object sender, EventArgs e)
        {
            geribildirim gir5=new geribildirim();
            gir5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
           groupBox2.Visible= true;
            button55.Visible= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oda_durumu gir=new oda_durumu();
            gir.Show();
            

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible=true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
           

        }

        private void button27_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = true;
        }

        private void oda1_Click(object sender, EventArgs e)
        {
            label10.Text = "1";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into oda101 (ad,soyad) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
          
        }

        private void oda2_Click(object sender, EventArgs e)
        {
            label10.Text = "2";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into oda102 (ad,soyad) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }

        private void oda3_Click(object sender, EventArgs e)
        {
            label10.Text = "3";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into oda103 (ad,soyad) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }

        private void oda4_Click(object sender, EventArgs e)
        {
            label10.Text = "4";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into oda104 (ad,soyad) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }

        private void oda5_Click(object sender, EventArgs e)
        {
            label10.Text = "5";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into oda105 (ad,soyad) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }

        private void oda6_Click(object sender, EventArgs e)
        {
            label10.Text = "6";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into oda106 (ad,soyad) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }

        private void oda7_Click(object sender, EventArgs e)
        {
            label10.Text = "7";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into oda107 (ad,soyad) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }

        private void oda8_Click(object sender, EventArgs e)
        {
            label10.Text = "8";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into oda108 (ad,soyad) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }

        private void oda9_Click(object sender, EventArgs e)
        {
            label10.Text = "9";
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into oda109 (ad,soyad) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();

        }

        private void button41_Click(object sender, EventArgs e)
        {
            label10.Text = "10";

        }

        private void button40_Click(object sender, EventArgs e)
        {
            label10.Text = "11";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            label10.Text = "12";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
            groupBox2.Visible = true;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            label10.Text = "19";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            label10.Text = "20";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            label10.Text = "21";
        }

        private void button42_Click(object sender, EventArgs e)
        {
          
            groupBox2.Visible = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime ktarih=Convert.ToDateTime(dateTimePicker1.Text);
            DateTime btarih=Convert.ToDateTime(dateTimePicker2.Text);
            //TimeSpan aradaki tarih aralığını buluyor.
            TimeSpan sonuc = btarih - ktarih;
            label39.Text = sonuc.TotalDays.ToString();
            ucret=Convert.ToInt32(label39.Text)*150;
            label37.Text=ucret.ToString();

        }

        private void button54_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            //içine dahil et
            SqlCommand komut = new SqlCommand("insert into musteriekle (ad,soyad,cinsiyet,telefon,mail,tc,odano,ucret,giristarih,cikistarih) values" +
                " ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + maskedTextBox1.Text + "','" + textBox3.Text + "','" + maskedTextBox2.Text + "','" + label10.Text + "','" + label37.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','"+dateTimePicker2.Value.ToString("yyyy-MM-dd")+"')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            label10.Text=".....";
            textBox2.Clear();
            comboBox1.Text = "";
            maskedTextBox1.Clear();
            textBox3.Clear();
            maskedTextBox2.Clear();
            textBox1.Clear();
            label37.Text = ".....";
            label39.Text = ".....";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            MessageBox.Show("Kayıt Yapılmıştır");
           
        }

        private void button55_Click(object sender, EventArgs e)
        {
            groupBox1.Visible= false;
            groupBox2.Visible= false;
            button55.Visible= false;
            groupBox3.Visible= false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kayitsilme gir=new kayitsilme();
            gir.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
          /*  baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from musteriekle", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                oda1.Text = oku["ad"].ToString() + "" + oku["soyad"].ToString();
            }
            baglantı.Close();
            if (oda1.Text != "1")
            {
                oda1.BackColor = Color.Red;
            }
            //oda 2
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from musteriekle", baglantı);
            SqlDataReader oku1 = komut.ExecuteReader();

            while (oku1.Read())
            {
                oda2.Text = oku1["ad"].ToString() + "" + oku1["soyad"].ToString();
            }
            baglantı.Close();
            if (oda2.Text != "1")
            {
                oda2.BackColor = Color.Red;
            }
            //oda 3
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select * from musteriekle", baglantı);
            SqlDataReader oku2 = komut.ExecuteReader();

            while (oku2.Read())
            {
                oda3.Text = oku2["ad"].ToString() + "" + oku2["soyad"].ToString();
            }
            baglantı.Close();
            if (oda3.Text != "1")
            {
                oda3.BackColor = Color.Red;
            }
            //oda 4
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select * from musteriekle", baglantı);
            SqlDataReader oku3 = komut.ExecuteReader();

            while (oku3.Read())
            {
                oda4.Text = oku3["ad"].ToString() + "" + oku3["soyad"].ToString();
            }
            baglantı.Close();
            if (oda4.Text != "1")
            {
                oda4.BackColor = Color.Red;
            }
            //oda 5
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select * from musteriekle", baglantı);
            SqlDataReader oku4 = komut.ExecuteReader();

            while (oku4.Read())
            {
                oda5.Text = oku4["ad"].ToString() + "" + oku4["soyad"].ToString();
            }
            baglantı.Close();
            if (oda5.Text != "1")
            {
                oda5.BackColor = Color.Red;
            }
            //oda 6
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select * from musteriekle", baglantı);
            SqlDataReader oku5 = komut.ExecuteReader();

            while (oku5.Read())
            {
                oda6.Text = oku5["ad"].ToString() + "" + oku5["soyad"].ToString();
            }
            baglantı.Close();
            if (oda6.Text != "1")
            {
                oda6.BackColor = Color.Red;
            }
            //oda 7
            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select * from musteriekle", baglantı);
            SqlDataReader oku6 = komut.ExecuteReader();

            while (oku6.Read())
            {
                oda7.Text = oku6["ad"].ToString() + "" + oku6["soyad"].ToString();
            }
            baglantı.Close();
            if (oda7.Text != "1")
            {
                oda7.BackColor = Color.Red;
            }
            //oda 8
            baglantı.Open();
            SqlCommand komut7 = new SqlCommand("select * from musteriekle", baglantı);
            SqlDataReader oku7 = komut.ExecuteReader();

            while (oku7.Read())
            {
                oda8.Text = oku7["ad"].ToString() + "" + oku7["soyad"].ToString();
            }
            baglantı.Close();
            if (oda8.Text != "1")
            {
                oda8.BackColor = Color.Red;
            }
            //oda 9
            baglantı.Open();
            SqlCommand komut8 = new SqlCommand("select * from musteriekle", baglantı);
            SqlDataReader oku8 = komut.ExecuteReader();

            while (oku8.Read())
            {
                oda9.Text = oku8["ad"].ToString() + "" + oku8["soyad"].ToString();
            }
            baglantı.Close();
            if (oda9.Text != "1")
            {
                oda9.BackColor = Color.Red;
            }*/

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //suan ki saat dilimini gösteririr "saat:Dk:Saniye"
            label41.Text = DateTime.Now.ToLongTimeString();
            // tarihi gösterir "Gün sayısı:AY:Yıl:Gün ismi"
            label42.Text= DateTime.Now.ToLongDateString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void admin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //oda 1
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
                oda1.Enabled = false;
                
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
                oda2.Enabled = false;
              //  oda2.Text = "dolu";
            }
            //oda 3
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda103", baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                oda3.Text = oku2["ad"].ToString() + "" + oku2["soyad"].ToString();
            }
            baglantı.Close();
            if (oda3.Text != "3")
            {
                oda3.BackColor = Color.Red;
                oda3.Enabled = false;
            }
            //oda 4
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda104", baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                oda4.Text = oku3["ad"].ToString() + "" + oku3["soyad"].ToString();
            }
            baglantı.Close();
            if (oda4.Text != "4")
            {
                oda4.BackColor = Color.Red;
                oda4.Enabled = false;
            }
            //oda 5
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda105", baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                oda5.Text = oku4["ad"].ToString() + "" + oku4["soyad"].ToString();
            }
            baglantı.Close();
            if (oda5.Text != "5")
            {
                oda5.BackColor = Color.Red;
                oda5.Enabled = false;
            }
            //oda 6
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select * from oda106", baglantı);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                oda6.Text = oku5["ad"].ToString() + "" + oku5["soyad"].ToString();
            }
            baglantı.Close();
            if (oda6.Text != "6")
            {
                oda6.BackColor = Color.Red;
                   oda6.Enabled = false;
            }
            //oda 7
            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select * from oda107", baglantı);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                oda7.Text = oku6["ad"].ToString() + "" + oku6["soyad"].ToString();
            }
            baglantı.Close();
            if (oda7.Text != "7")
            {
                oda7.BackColor = Color.Red;
                oda7.Enabled = false;
            }
            //oda 8
            baglantı.Open();
            SqlCommand komut7 = new SqlCommand("select * from oda108", baglantı);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                oda8.Text = oku7["ad"].ToString() + "" + oku7["soyad"].ToString();
            }
            baglantı.Close();
            if (oda8.Text != "8")
            {
                oda8.BackColor = Color.Red;
                oda8.Enabled = false;
            }
            //oda 9
            baglantı.Open();
            SqlCommand komut8 = new SqlCommand("select * from oda109", baglantı);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                oda9.Text = oku8["ad"].ToString() + "" + oku8["soyad"].ToString();
            }
            baglantı.Close();
            if (oda9.Text != "9")
            {
                oda9.BackColor = Color.Red;
                    oda9.Enabled = false;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 gir1=new Form1();
            gir1.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
