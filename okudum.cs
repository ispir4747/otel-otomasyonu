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
    public partial class okudum : Form
    {
        public okudum()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                button1.Enabled = true;
                
            }
            else
            {
                button1.Enabled = false;
                button1.BackColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
