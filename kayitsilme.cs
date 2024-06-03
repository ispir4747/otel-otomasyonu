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
using System.Data.Sql;


namespace otel_otomasyonu
{
    public partial class kayitsilme : Form
    {
        public kayitsilme()
        {
            InitializeComponent();
        }
       SqlConnection baglantı = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS;Initial Catalog=oteloto;Integrated Security=True;");
        private void temizle()
        {
            textBox4.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            maskedTextBox1.Clear();
            textBox3.Clear();
            maskedTextBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * From musteriekle", baglantı);
            SqlDataReader oku=komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
                ekle.SubItems.Add(oku["giristarih"].ToString());
                ekle.SubItems.Add(oku["cikistarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
            groupBox1.Visible = true;
            textBox1.Visible = true;
            label1 .Visible = true;
            listView1 .Visible = true;
            button5.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label1.Visible = true;
            textBox1.Visible = true;

        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0]. Text);
            textBox4.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[5].Text;
            maskedTextBox2.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  listView1.Items.Clear();
          if(textBox5.Text=="1")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from oda101 delete from musteriekle", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi Geçekleştirilmiştir");
                temizle();
            }
            if (textBox5.Text == "2")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from oda102 delete from musteriekle", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi Geçekleştirilmiştir");
                temizle();
            }
            if (textBox5.Text == "3")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from oda103 delete from musteriekle", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi Geçekleştirilmiştir");
                temizle();
            }
            if (textBox5.Text == "4")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from oda104 delete from musteriekle", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi Geçekleştirilmiştir");
                temizle();
            }
            if (textBox5.Text == "5")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from oda105 delete from musteriekle", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi Geçekleştirilmiştir");
                temizle();
            }
            if (textBox5.Text == "6")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from oda106 delete from musteriekle", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi Geçekleştirilmiştir");
                temizle();
            }
            if (textBox5.Text == "7")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from oda107 delete from musteriekle", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi Geçekleştirilmiştir");
                temizle();
            }
            if (textBox5.Text == "8")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from oda108 delete from musteriekle", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi Geçekleştirilmiştir");
                temizle();
            }
            if (textBox5.Text == "9")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("delete from oda109 delete from musteriekle", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Silme işlemi Geçekleştirilmiştir");
                temizle();
            }

            //verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update musteriekle set ad='" + textBox4.Text + "',soyad='" + textBox2.Text + "',cinsiyet='" + comboBox1.Text + "',telefon='" + maskedTextBox1.Text + "',mail='"+textBox3.Text+"',tc='"+maskedTextBox2.Text+"',odano='"+textBox5.Text+"',ucret='"+textBox6.Text+"',giristarih='" + dateTimePicker1.Value.ToString("yyyy-MM-dd")+"',cikistarih='"+ dateTimePicker2.Value.ToString("yyyy-MM-dd")+"' where id=" + id + "", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerigoster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible= false;
            listView1.Visible= false;
            button5.Visible= false;
            button2.Visible= false;
            button3.Visible= false;
            button4.Visible= false;
            label1.Visible= false;
            textBox1.Visible= false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * From musteriekle where ad like '%"+textBox1.Text+ "%'", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
                ekle.SubItems.Add(oku["giristarih"].ToString());
                ekle.SubItems.Add(oku["cikistarih"].ToString());

                listView1.Items.Add(ekle);
            }
            baglantı.Close();
        }

        private void kayitsilme_Load(object sender, EventArgs e)
        {

        }
    }
}
//SqlCommand komut = new SqlCommand("delete from musteriekle where id=(" + id + ")", baglantı);