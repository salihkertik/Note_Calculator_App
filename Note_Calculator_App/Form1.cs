using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToInt16(textBox3.Text);
            s2 = Convert.ToInt16(textBox4.Text);

            ortalama = (s1 * 0.40) + (s2 * 0.60);
            listBox1.Items.Add(ad + " " + soyad + "~~Ortalama: " + ortalama);

        }
    }
}
