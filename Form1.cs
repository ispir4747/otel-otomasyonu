﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                admin gir = new admin();
                gir.Show();
                this.Hide();
            }
            else
            {

                label3.Visible = true;
                label3.Text = "Hatalı Giriş !!!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Visible= false;
            label3.Visible= false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Visible= false;
            label3.Visible = false;
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kytmüşgirişi gir2=new kytmüşgirişi();
            gir2.Show();
            this.Hide ();
        }
    }
}
