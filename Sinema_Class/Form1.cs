using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinema s = new Sinema();



        private void button1_Click_1(object sender, EventArgs e)
        {
            s.koltuk = int.Parse(texBox1.Text);
            s.sayi = s.sayi + s.koltuk;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                s.indirimBilet = true;
            }
            else
            {
                s.indirimBilet = false;
            }
            s.biletSat();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                s.indirimİptal = true;
            }
            else
            {
                s.indirimİptal = false;
            }
            s.biletİptalEt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s.boskoltukLar();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            s.bakiyeOgren();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
