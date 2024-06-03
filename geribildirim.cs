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
    public partial class geribildirim : Form
    {
        public geribildirim()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=MONSTER\\SQLEXPRESS;Initial Catalog=oteloto;Integrated Security=True;");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglantı.Open();
            //select ekleme yapar
            SqlCommand komut = new SqlCommand("select * from mesaj", baglantı);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mesajid"].ToString();
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["mesajj"].ToString());


               listView1.Items.Add(ekle);
            }
            baglantı.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            admin gir=new admin();
            gir.Show();
            this.Hide();
        }

        private void geribildirim_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }
    }
}
