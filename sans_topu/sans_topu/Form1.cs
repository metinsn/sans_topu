using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sans_topu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Random rnd = new Random();
        int rastgelesayi;
        List<int> sayilar = new List<int>(6);
        int sayac = 0;
        int turSayisi = 1;




        private void timer1_Tick(object sender, EventArgs e)
        {

            if (turSayisi % 30 == 0)
            {
                timer1.Stop();
            }

            else
            {
                sayilar.Clear();
            }

            if (turSayisi == 20)
            {
                timer1.Interval = 500;
            }

            while (sayac < 6)
            {
                rastgelesayi = rnd.Next(1, 50);
                if (!sayilar.Contains(rastgelesayi))
                {
                    sayilar.Add(rastgelesayi);
                    sayac++;
                }
            }
            sayilar.Sort();

            label1.Text = sayilar[0].ToString();
            label2.Text = sayilar[1].ToString();
            label3.Text = sayilar[2].ToString();
            label4.Text = sayilar[3].ToString();
            label5.Text = sayilar[4].ToString();
            label6.Text = sayilar[5].ToString();

            sayac = 0;
            turSayisi++;
        }

    }



}


