using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace subnetiranje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }
        public int nj;
        public int i;
        public int g = 0;
        public int pom = 0;
        public int poz = 0;
        public int br;
        public int ukupno = 1;
        public int lista = 1;
        public int a;
        public int b;
        public int c;
        public int d;
        public int s;
        public int p;
        public int cc;
        public int bb;
        public int aa;
        public int prfx=32;
        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            button2.Visible = true;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            d = Convert.ToInt32(textBox4.Text);
            s = Convert.ToInt32(textBox5.Text);
            p = Convert.ToInt32(textBox6.Text);
            if (p > 0 && p <= 32)
            {
                nj = 32;
                br = 5;

            }
            else if (p > 32 && p <= 64)
            {
                nj = 64;
                br = 6;
            }
            else if (p > 64 && p <= 128)
            {
                nj = 128;
                br = 7;
            }
            else
            {
                nj = 256;
                br = 8;
            }
            label23.Text = Convert.ToString(nj);
            if (s >= 24)
            {
                int i = s - 24;
                int gg = 128;
                for (int j = i; j > 0; j--)
                {
                    if (d > gg)
                    {
                        g += gg;
                        d -= gg;
                    }
                    gg = gg / 2;
                }
                d = g;
                poz = 4;
            }
            else if (s >= 16)
            {
                i = s - 16;
                int gg = 128;
                for (int j = i; j > 0; j--)
                {
                    if (c > gg)
                    {
                        g += gg;
                        c -= gg;
                    }
                    gg = gg / 2;
                }
                c = g;
                d = 0;
                poz = 3;
            }
            else if (s >= 8)
            {
                i = s - 8;
                int gg = 128;
                for (int j = i; j > 0; j--)
                {
                    if (b > gg)
                    {
                        g += gg;
                        b -= gg;
                    }
                    gg = gg / 2;
                }
                b = g;
                c = 0;
                d = 0;
                poz = 2;
            }
            else if (s >= 0)
            {
                i = s;
                int gg = 128;
                for (int j = i; j > 0; j--)
                {
                    if (a > gg)
                    {
                        g += gg;
                        a -= gg;
                    }
                    gg = gg / 2;
                }
                a = g;
                b = 0;
                c = 0;
                d = 0;
                poz = 1;
            }
            pom = i;
            int ž = 32 - s - br;
            do
            {
                ukupno = ukupno * 2;
                ž--;
            }
            while (ž > 0);
            label9.Text = Convert.ToString(ukupno);
            label24.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d) + '/' + Convert.ToString(prfx - br);
            label17.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d) + '/' + Convert.ToString(prfx - br);
            label18.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + 1) + '/' + Convert.ToString(prfx - br);
            label19.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + 2) + '/' + Convert.ToString(prfx - br);
            label20.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + nj - 2) + '/' + Convert.ToString(prfx - br);
            label21.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + nj - 1) + '/' + Convert.ToString(prfx - br);
            label11.Text = Convert.ToString(lista);
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista = lista + 1;
            if (lista > 1)
            {
                button3.Visible = true;
            }
            if (lista >= ukupno)
            {
                button2.Visible = false;
            }
            if (poz >= 3)
            {
                d = d + nj;
                int n = 8 - pom;
                int m = 1;
                do
                {
                    m = m * 2;
                    n--;
                }
                while (n > 0);
                if (d > 255)
                {
                    d = d - 256;
                    c++;
                }
            }
            else if (poz >= 2)
            {
                d = d + nj;
                if (d > 255)
                {
                    d = d-256;
                    c++;
                }
                if (c > 255)
                {
                    c = c - 256;
                    b++;
                }
                int n = 8 - pom;
                int m = 1;
                do
                {
                    m = m * 2;
                    n--;
                } while (n > 0);
            }
            else if (poz >= 1)
            {
                d = d + nj;
                if (d > 255)
                {
                    d = d-256;
                    c++;
                }
                if (c > 255)
                {
                    c = c - 256;
                    b++;
                }
                if (b > 255)
                {
                    b = b-256;
                    a++;
                }
                int n = 8 - pom;
                int m = 1;
                do
                {
                    m = m * 2;
                    n--;
                } while (n > 0);
            }
            label24.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d) + '/' + Convert.ToString(prfx-br);
            label17.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d) + '/' + Convert.ToString(prfx - br);
            label18.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + 1) + '/' + Convert.ToString(prfx - br);
            label19.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + 2) + '/' + Convert.ToString(prfx - br);
            label20.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + nj - 2) + '/' + Convert.ToString(prfx - br);
            label21.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + nj - 1) + '/' + Convert.ToString(prfx - br);
            label11.Text = Convert.ToString(lista);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista = lista - 1;
            if (lista > 1)
            {
                button3.Visible = true;
            }
            if (lista >= ukupno)
            {
                button2.Visible = false;
            }
            if (poz >= 3)
            {
                d = d - nj;
                int n = 8 - pom;
                int m = 1;
                do
                {
                    m = m * 2;
                    n--;
                }
                while (n > 0);
                if (d < 0)
                {
                    d = d + 256;
                    c--;
                }
            }
            else if (poz >= 2)
            {
                d = d - nj;
                if (d < 0)
                {
                    d = d + 256;
                    c--;
                }
                if (c < 0)
                {
                    c = c + 256;
                    b--;
                }
                int n = 8 - pom;
                int m = 1;
                do
                {
                    m = m * 2;
                    n--;
                } while (n > 0);
            }
            else if (poz >= 1)
            {
                d = d - nj;
                if (d < 0)
                {
                    d = d + 256;
                    c--;
                }
                if (c < 0)
                {
                    c = c + 256;
                    b--;
                }
                if (b < 0)
                {
                    b = b + 256;
                    a--;
                }
                int n = 8 - pom;
                int m = 1;
                do
                {
                    m = m * 2;
                    n--;
                } while (n > 0);
            }
            label24.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d) + '/' + Convert.ToString(prfx - br);
            label17.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d) + '/' + Convert.ToString(prfx - br);
            label18.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + 1) + '/' + Convert.ToString(prfx - br);
            label19.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + 2) + '/' + Convert.ToString(prfx - br);
            label20.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + nj - 2) + '/' + Convert.ToString(prfx - br);
            label21.Text = Convert.ToString(a) + '.' + Convert.ToString(b) + '.' + Convert.ToString(c) + '.' + Convert.ToString(d + nj - 1) + '/' + Convert.ToString(prfx - br);
            label11.Text = Convert.ToString(lista);
            if (lista <= 1)
            {
                button3.Visible = false;
            }
            if (lista < ukupno)
            {
                button2.Visible = true;
            } else
            {
                button2.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            g = 0;
            pom = 0;
            poz = 0;
            ukupno = 1;
            lista = 1;
            prfx = 32;
    }
    }
}
