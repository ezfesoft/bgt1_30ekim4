﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt1_30ekim4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);

            sonuc = sayi1 + sayi2;

            txtSonuc.Text = sonuc.ToString();

            txtsayi1.Clear();
            txtSayi2.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int sayi1, sayi2, sonuc;

            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);

            sonuc = sayi1 - sayi2;

            txtSonuc.Text = sonuc.ToString();

            txtsayi1.Clear();
            txtSayi2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int sayi1, sayi2, sonuc;

            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);

            sonuc = sayi1 / sayi2;

            txtSonuc.Text = sonuc.ToString();

            txtsayi1.Clear();
            txtSayi2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int sayi1, sayi2, sonuc;

            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);

            sonuc = sayi1 * sayi2;

            txtSonuc.Text = sonuc.ToString();

            txtsayi1.Clear();
            txtSayi2.Clear();
        }
    }
}
