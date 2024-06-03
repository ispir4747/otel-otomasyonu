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
    public partial class mesaj : Form
    {
        public mesaj()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS;Initial Catalog=oteloto;Integrated Security=True;");

       /* private void verilerigoster()
        {
           // listView1.Items.Clear();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * From mesaj", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mesajid"].ToString();
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["mesaj"].ToString());
                

               // listView1.Items.Add(ekle);
            }
            baglantı.Close();

        }*/

        private void mesaj_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into mesaj(adsoyad,mesajj)values('" + textBox1.Text + "','" + richTextBox1.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Mesaj Gönderilmiştir");
            textBox1.Clear();
            richTextBox1.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıtlımüş gir = new kayıtlımüş();
            gir.Show();
            this.Hide();

        }
    }
}
