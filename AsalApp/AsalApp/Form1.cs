using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AsalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            long girilenSayi = Convert.ToInt64(textBox1.Text);
            long sabitSayi = 2;

            for (long i = sabitSayi; i < girilenSayi; i++)
            {
                long kontrol = 0;
                long sayac = 0;
                for(long j = 2; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        kontrol++;
                        sayac++;
                    }
                }
                if(kontrol == 0)
                    listBox1.Items.Add(i);
                label1.Text = listBox1.Items.Count.ToString();
            }
        }
    }
}