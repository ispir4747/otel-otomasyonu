using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyonu
{
    public partial class kytmüşgirişi : Form
    {
        public kytmüşgirişi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="taha"&&textBox2.Text=="4444")
            {
                kayıtlımüş gir = new kayıtlımüş();
                gir.Show();
                this.Hide();
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Hatalı Giriş";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false; 
            label3.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
