using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultoplePolinom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            produkt3_1.Enabled = false;
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            produkt5_1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            double a = Convert.ToDouble(koeficienti0P2.Text);
            double a1 = Convert.ToDouble(koeficienti0P2.Text);
            double a00 = a * a1;
            produkt0_0.Text = a00.ToString();


            //produkt 01
            double b = Convert.ToDouble(koeficienti0P2.Text);
            double b1 = Convert.ToDouble(koeficienti1P1.Text);
            double b01 = b * b1;
            produkt0_1.Text = b01.ToString();

            //produkt 02
            double c = Convert.ToDouble(koeficienti0P2.Text);
            double c1 = Convert.ToDouble(koeficienti2P1.Text);
            double c02 = c * c1;
            produkt0_2.Text = c02.ToString();

            //produkt 03
            double d = Convert.ToDouble(koeficienti0P2.Text);
            double d1 = Convert.ToDouble(koeficienti3P1.Text);
            double d03 = d * d1;
            produkt0_3.Text = d03.ToString();

            //produkt 04
            double f = Convert.ToDouble(koeficienti0P2.Text);
            double f1 = Convert.ToDouble(koeficienti4P1.Text);
            double f04 = f * f1;
            produkt0_4.Text = f04.ToString();

            //produkt 05
            double g = Convert.ToDouble(koeficienti0P2.Text);
            double g1 = Convert.ToDouble(koeficienti5P1.Text);
            double g05 = g * g1;
            produkt0_5.Text = g05.ToString();

            //produkt 06
            double h = Convert.ToDouble(koeficienti0P2.Text);
            double h1 = Convert.ToDouble(koeficienti6P1.Text);
            double h06 = h * h1;
            produkt0_6.Text = h06.ToString();

            //produkt 07
            double i = Convert.ToDouble(koeficienti0P2.Text);
            double i1 = Convert.ToDouble(koeficienti7P1.Text);
            double i07 = i * i1;
            produkt0_7.Text = i07.ToString();

            //----------------------------------------------------------------

            //produkt 10
            double aa = Convert.ToDouble(koeficienti1P2.Text);
            double aa1 = Convert.ToDouble(koeficienti0P1.Text);
            double aa00 = aa * aa1;
            produkt1_0.Text = aa00.ToString();

            //produkt 11
            double bb = Convert.ToDouble(koeficienti1P2.Text);
            double bb1 = Convert.ToDouble(koeficienti1P1.Text);
            double bb11 = bb * bb1;
            produkt1_1.Text = bb11.ToString();

            //produkt 12
            double cc = Convert.ToDouble(koeficienti1P2.Text);
            double cc1 = Convert.ToDouble(koeficienti2P1.Text);
            double cc12 = cc * cc1;
            produkt1_2.Text = cc12.ToString();

            //produkt 13
            double dd = Convert.ToDouble(koeficienti1P2.Text);
            double dd1 = Convert.ToDouble(koeficienti3P1.Text);
            double dd13 = dd * dd1;
            produkt1_3.Text = dd13.ToString();

            //produkt 14
            double ff = Convert.ToDouble(koeficienti1P2.Text);
            double ff1 = Convert.ToDouble(koeficienti4P1.Text);
            double ff14 = ff * ff1;
            produkt1_4.Text = ff14.ToString();

            //produkt 15
            double gg = Convert.ToDouble(koeficienti1P2.Text);
            double gg1 = Convert.ToDouble(koeficienti5P1.Text);
            double gg15 = gg * gg1;
            produkt1_5.Text = gg15.ToString();

            //produkt 16
            double hh = Convert.ToDouble(koeficienti1P2.Text);
            double hh1 = Convert.ToDouble(koeficienti6P1.Text);
            double hh16 = hh * hh1;
            produkt1_6.Text = hh16.ToString();

            //produkt 17
            double ii = Convert.ToDouble(koeficienti1P2.Text);
            double ii1 = Convert.ToDouble(koeficienti7P1.Text);
            double ii17 = ii * ii1;
            produkt1_7.Text = ii17.ToString();

            //--------------------------------------------------------

            //produkt 20
            double j = Convert.ToDouble(koeficienti2P2.Text);
            double j1 = Convert.ToDouble(koeficienti0P1.Text);
            double j20 = j * j1;
            produkt2_0.Text = j20.ToString();

            //produkt 21
            double k = Convert.ToDouble(koeficienti2P2.Text);
            double k1 = Convert.ToDouble(koeficienti1P1.Text);
            double k21 = k * k1;
            produkt2_1.Text = k21.ToString();

            //produkt 22
            double l = Convert.ToDouble(koeficienti2P2.Text);
            double l1 = Convert.ToDouble(koeficienti2P1.Text);
            double l22 = l * l1;
            produkt2_2.Text = l22.ToString();

            //produkt 23
            double m = Convert.ToDouble(koeficienti2P2.Text);
            double m1 = Convert.ToDouble(koeficienti3P1.Text);
            double m23 = m * m1;
            produkt2_3.Text = m23.ToString();

            //produkt 24
            double n = Convert.ToDouble(koeficienti2P2.Text);
            double n1 = Convert.ToDouble(koeficienti4P1.Text);
            double n24 = n * n1;
            produkt2_4.Text = n24.ToString();

            //produkt 25
            double o = Convert.ToDouble(koeficienti2P2.Text);
            double o1 = Convert.ToDouble(koeficienti5P1.Text);
            double o25 = o * o1;
            produkt2_5.Text = o25.ToString();

            //produkt 26
            double p = Convert.ToDouble(koeficienti2P2.Text);
            double p1 = Convert.ToDouble(koeficienti6P1.Text);
            double p26 = p * p1;
            produkt2_6.Text = p26.ToString();

            //produkt 27
            double q = Convert.ToDouble(koeficienti2P2.Text);
            double q1 = Convert.ToDouble(koeficienti7P1.Text);
            double q27 = q * q1;
            produkt2_7.Text = q27.ToString();

            //----------------------------------------------------------------------------------

            //produkt 30
            double ka = Convert.ToDouble(koeficienti3P2.Text);
            double ka1 = Convert.ToDouble(koeficienti0P1.Text);
            double ka30 = ka * ka1;
            produkt3_0.Text = ka30.ToString();

            //produkt 31
            double ba = Convert.ToDouble(koeficienti3P2.Text);
            double ba1 = Convert.ToDouble(koeficienti1P1.Text);
            double ba31 = ba * ba1;
            produkt3_1.Text = ba31.ToString();

            //produkt 32
            double ca = Convert.ToDouble(koeficienti3P2.Text);
            double ca1 = Convert.ToDouble(koeficienti2P1.Text);
            double ca32 = ca * ca1;
            produkt3_2.Text = ca32.ToString();

            //produkt 33
            double da = Convert.ToDouble(koeficienti3P2.Text);
            double da1 = Convert.ToDouble(koeficienti3P1.Text);
            double da33 = da * da1;
            produkt3_3.Text = da33.ToString();

            //produkt 34
            double fa = Convert.ToDouble(koeficienti3P2.Text);
            double fa1 = Convert.ToDouble(koeficienti4P1.Text);
            double fa34 = fa * fa1;
            produkt3_4.Text = fa34.ToString();

            //produkt 35
            double ga = Convert.ToDouble(koeficienti3P2.Text);
            double ga1 = Convert.ToDouble(koeficienti5P1.Text);
            double ga35 = ga * ga1;
            produkt3_5.Text = ga35.ToString();

            //produkt 36
            double ha = Convert.ToDouble(koeficienti3P2.Text);
            double ha1 = Convert.ToDouble(koeficienti6P1.Text);
            double ha36 = ha * ha1;
            produkt3_6.Text = ha36.ToString();

            //produkt 37
            double ia = Convert.ToDouble(koeficienti3P2.Text);
            double ia1 = Convert.ToDouble(koeficienti7P1.Text);
            double ia37 = ia * ia1;
            produkt3_7.Text = ia37.ToString();

            //---------------------------------------------------------------
            //produkt 40
            double ab = Convert.ToDouble(koeficienti4P2.Text);
            double ab1 = Convert.ToDouble(koeficienti0P1.Text);
            double ab40 = ab * ab1;
            produkt4_0.Text = ab40.ToString();

            //produkt 41
            double bk = Convert.ToDouble(koeficienti4P2.Text);
            double bk1 = Convert.ToDouble(koeficienti1P1.Text);
            double bk41 = bk * bk1;
            produkt4_1.Text = bk41.ToString();

            //produkt 42
            double cb = Convert.ToDouble(koeficienti4P2.Text);
            double cb1 = Convert.ToDouble(koeficienti2P1.Text);
            double cb42 = cb * cb1;
            produkt4_2.Text = cb42.ToString();

            //produkt 43
            double db = Convert.ToDouble(koeficienti4P2.Text);
            double db1 = Convert.ToDouble(koeficienti3P1.Text);
            double db43 = db * db1;
            produkt4_3.Text = db43.ToString();

            //produkt 44
            double fb = Convert.ToDouble(koeficienti4P2.Text);
            double fb1 = Convert.ToDouble(koeficienti4P1.Text);
            double fb44 = fb * fb1;
            produkt4_4.Text = fb44.ToString();

            //produkt 45
            double gb = Convert.ToDouble(koeficienti4P2.Text);
            double gb1 = Convert.ToDouble(koeficienti5P1.Text);
            double gb45 = gb * gb1;
            produkt4_5.Text = gb45.ToString();

            //produkt 46
            double hb = Convert.ToDouble(koeficienti4P2.Text);
            double hb1 = Convert.ToDouble(koeficienti6P1.Text);
            double hb46 = hb * hb1;
            produkt4_6.Text = hb46.ToString();

            //produkt 47
            double ib = Convert.ToDouble(koeficienti4P2.Text);
            double ib1 = Convert.ToDouble(koeficienti7P1.Text);
            double ib47 = ib * ib1;
            produkt4_7.Text = ib47.ToString();

            //---------------------------------------------------------

            //produkt 50
            double as2 = Convert.ToDouble(koeficienti5P2.Text);
            double as1 = Convert.ToDouble(koeficienti0P1.Text);
            double as50 = as2 * as1;
            produkt5_0.Text = as50.ToString();

            //produkt 51
            double bs = Convert.ToDouble(koeficienti5P2.Text);
            double bs1 = Convert.ToDouble(koeficienti1P1.Text);
            double bs51 = bs * bs1;
            produkt5_1.Text = bs51.ToString();

            //produkt 52
            double cs = Convert.ToDouble(koeficienti5P2.Text);
            double cs1 = Convert.ToDouble(koeficienti2P1.Text);
            double cs52 = cs * cs1;
            produkt5_2.Text = cs52.ToString();

            //produkt 53
            double ds = Convert.ToDouble(koeficienti5P2.Text);
            double ds1 = Convert.ToDouble(koeficienti3P1.Text);
            double ds53 = ds * ds1;
            produkt5_3.Text = ds53.ToString();

            //produkt 54
            double fs = Convert.ToDouble(koeficienti5P2.Text);
            double fs1 = Convert.ToDouble(koeficienti4P1.Text);
            double fs54 = fs * fs1;
            produkt5_4.Text = fs54.ToString();

            //produkt 55
            double gs = Convert.ToDouble(koeficienti5P2.Text);
            double gs1 = Convert.ToDouble(koeficienti5P1.Text);
            double gs55 = gs * gs1;
            produkt5_5.Text = gs55.ToString();

            //produkt 56
            double hs = Convert.ToDouble(koeficienti5P2.Text);
            double hs1 = Convert.ToDouble(koeficienti6P1.Text);
            double hs56 = hs * hs1;
            produkt5_6.Text = hs56.ToString();

            //produkt 57
            double si = Convert.ToDouble(koeficienti5P2.Text);
            double si1 = Convert.ToDouble(koeficienti7P1.Text);
            double si57 = si * si1;
            produkt5_7.Text = si57.ToString();
            //----------------------------------------------------------

            //produkt 60
            double ay2 = Convert.ToDouble(koeficienti6P2.Text);
            double ay1 = Convert.ToDouble(koeficienti0P1.Text);
            double ay60 = ay2 * ay1;
            produkt6_0.Text = ay60.ToString();

            //produkt 61
            double by = Convert.ToDouble(koeficienti6P2.Text);
            double by1 = Convert.ToDouble(koeficienti1P1.Text);
            double by61 = by * by1;
            produkt6_1.Text = by61.ToString();

            //produkt 62
            double cy = Convert.ToDouble(koeficienti6P2.Text);
            double cy1 = Convert.ToDouble(koeficienti2P1.Text);
            double cy62 = cy * cy1;
            produkt6_2.Text = cy62.ToString();

            //produkt 63
            double dy = Convert.ToDouble(koeficienti6P2.Text);
            double dy1 = Convert.ToDouble(koeficienti3P1.Text);
            double dy63 = dy * dy1;
            produkt6_3.Text = dy63.ToString();

            //produkt 64
            double fy = Convert.ToDouble(koeficienti6P2.Text);
            double fy1 = Convert.ToDouble(koeficienti4P1.Text);
            double fy64 = fy * fy1;
            produkt6_4.Text = fy64.ToString();

            //produkt 65
            double gy = Convert.ToDouble(koeficienti6P2.Text);
            double gy1 = Convert.ToDouble(koeficienti5P1.Text);
            double gy65 = gy * gy1;
            produkt6_5.Text = gy65.ToString();

            //produkt 66
            double hy = Convert.ToDouble(koeficienti6P2.Text);
            double hy1 = Convert.ToDouble(koeficienti6P1.Text);
            double hy66 = hy * hy1;
            produkt6_6.Text = hy66.ToString();

            //produkt 67
            double yi = Convert.ToDouble(koeficienti6P2.Text);
            double yi1 = Convert.ToDouble(koeficienti7P1.Text);
            double yi67 = yi * yi1;
            produkt6_7.Text = yi67.ToString();

            //----------------------------------------------------------



            //produkt 70
            double ar2 = Convert.ToDouble(koeficienti7P2.Text);
            double ar1 = Convert.ToDouble(koeficienti0P1.Text);
            double ar70 = ar2 * ar1;
            produkt7_0.Text = ar70.ToString();

            //produkt 71
            double br = Convert.ToDouble(koeficienti7P2.Text);
            double br1 = Convert.ToDouble(koeficienti1P1.Text);
            double br71 = by * by1;
            produkt7_1.Text = br71.ToString();

            //produkt 72
            double cr = Convert.ToDouble(koeficienti7P2.Text);
            double cr1 = Convert.ToDouble(koeficienti2P1.Text);
            double cr72 = cr * cr1;
            produkt7_2.Text = cr72.ToString();

            //produkt 73
            double dr = Convert.ToDouble(koeficienti7P2.Text);
            double dr1 = Convert.ToDouble(koeficienti3P1.Text);
            double dr73 = dr * dr1;
            produkt7_3.Text = dr73.ToString();

            //produkt 74
            double fr = Convert.ToDouble(koeficienti7P2.Text);
            double fr1 = Convert.ToDouble(koeficienti4P1.Text);
            double fr74 = fr * fr1;
            produkt7_4.Text = fr74.ToString();

            //produkt 75
            double gr = Convert.ToDouble(koeficienti7P2.Text);
            double gr1 = Convert.ToDouble(koeficienti5P1.Text);
            double gr75 = gr * gr1;
            produkt7_5.Text = gr75.ToString();

            //produkt 76
            double hr = Convert.ToDouble(koeficienti7P2.Text);
            double hr1 = Convert.ToDouble(koeficienti6P1.Text);
            double hr76 = hy * hy1;
            produkt7_6.Text = hr76.ToString();

            //produkt 77
            double yr = Convert.ToDouble(koeficienti7P2.Text);
            double yr1 = Convert.ToDouble(koeficienti7P1.Text);
            double yr77 = yr * yr1;
            produkt7_7.Text = yr77.ToString();


            //-------------------------------------SHUMA

            double x0 = Convert.ToDouble(produkt0_0.Text); 
            shuma0.Text = x0.ToString();

            double x1 = Convert.ToDouble(produkt0_1.Text);
            double xx1 = Convert.ToDouble(produkt1_0.Text);
            double rez1 = x1 + xx1;
            shuma1.Text = rez1.ToString();

            double x2 = Convert.ToDouble(produkt0_2.Text);
            double xx2 = Convert.ToDouble(produkt1_1.Text);
            double xxx2 = Convert.ToDouble(produkt2_0.Text);
            double rez2 = x2 + xx2 + xxx2;
            shuma2.Text = rez2.ToString();


            double y1 = Convert.ToDouble(produkt0_3.Text);
            double y2 = Convert.ToDouble(produkt1_2.Text);
            double y3 = Convert.ToDouble(produkt2_1.Text);
            double y4 = Convert.ToDouble(produkt3_0.Text);
            double rez3 = y1+y2+y3+y4;
            shuma3.Text = rez3.ToString();


            double z1 = Convert.ToDouble(produkt0_4.Text);
            double z2 = Convert.ToDouble(produkt1_3.Text);
            double z3 = Convert.ToDouble(produkt2_2.Text);
            double z4 = Convert.ToDouble(produkt3_1.Text);
            double z5 = Convert.ToDouble(produkt4_0.Text);
            double rez4 = z1 + z2 + z3 + z4 + z5;
            shuma4.Text = rez4.ToString();

            double zz1 = Convert.ToDouble(produkt0_5.Text);
            double zz2 = Convert.ToDouble(produkt1_4.Text);
            double zz3 = Convert.ToDouble(produkt2_3.Text);
            double zz4 = Convert.ToDouble(produkt3_2.Text);
            double zz5 = Convert.ToDouble(produkt4_1.Text);
            double zz6 = Convert.ToDouble(produkt5_0.Text);
            double rez5 = zz1 + zz2 + zz3 + zz4 + zz5+zz6;
            shuma5.Text = rez5.ToString();



            double zy1 = Convert.ToDouble(produkt0_6.Text);
            double zy2 = Convert.ToDouble(produkt1_5.Text);
            double zy3 = Convert.ToDouble(produkt2_4.Text);
            double zy4 = Convert.ToDouble(produkt3_3.Text);
            double zy5 = Convert.ToDouble(produkt4_2.Text);
            double zy6 = Convert.ToDouble(produkt5_1.Text);
            double zy7 = Convert.ToDouble(produkt6_0.Text);
            double rez6 = zy1 + zy2 + zy3 + zy4 + zy5 + zy6+zy7;
            shuma6.Text = rez6.ToString();


            double sh1 = Convert.ToDouble(produkt0_7.Text);
            double sh2 = Convert.ToDouble(produkt1_6.Text);
            double sh3 = Convert.ToDouble(produkt2_5.Text);
            double sh4 = Convert.ToDouble(produkt3_4.Text);
            double sh5 = Convert.ToDouble(produkt4_3.Text);
            double sh6 = Convert.ToDouble(produkt5_2.Text);
            double sh7 = Convert.ToDouble(produkt6_1.Text);
            double sh8 = Convert.ToDouble(produkt7_0.Text);
            double rez7 = sh1 + sh2 + sh3 + sh4 + sh5 + sh6 + sh7 +sh8;
            shuma7.Text = rez7.ToString();


            double jk2 = Convert.ToDouble(produkt1_7.Text);
            double jk3 = Convert.ToDouble(produkt2_6.Text);
            double jk4 = Convert.ToDouble(produkt3_5.Text);
            double jk5 = Convert.ToDouble(produkt4_4.Text);
            double jk6 = Convert.ToDouble(produkt5_3.Text);
            double jk7 = Convert.ToDouble(produkt6_2.Text);
            double jk8 = Convert.ToDouble(produkt7_1.Text);
            double rez8 =  jk2 + jk3 + jk4 + jk5 + jk6 + jk7 + jk8;
            shuma8.Text = rez8.ToString();


            double je3 = Convert.ToDouble(produkt2_7.Text);
            double je4 = Convert.ToDouble(produkt3_6.Text);
            double je5 = Convert.ToDouble(produkt4_5.Text);
            double je6 = Convert.ToDouble(produkt5_4.Text);
            double je7 = Convert.ToDouble(produkt6_3.Text);
            double je8 = Convert.ToDouble(produkt7_2.Text);
            double rez9 = je3 + je4 + je5 + je6 + je7 + je8;
            shuma9.Text = rez9.ToString();


            double ji4 = Convert.ToDouble(produkt3_7.Text);
            double ji5 = Convert.ToDouble(produkt4_6.Text);
            double ji6 = Convert.ToDouble(produkt5_5.Text);
            double ji7 = Convert.ToDouble(produkt6_4.Text);
            double ji8 = Convert.ToDouble(produkt7_3.Text);
            double rez10 = ji4 + ji5 + ji6 + ji7 + ji8;
            shuma10.Text = rez10.ToString();

            double jy5 = Convert.ToDouble(produkt4_7.Text);
            double jy6 = Convert.ToDouble(produkt5_6.Text);
            double jy7 = Convert.ToDouble(produkt6_5.Text);
            double jy8 = Convert.ToDouble(produkt7_4.Text);
            double rez11 = jy5 + jy6 + jy7 + jy8;
            shuma11.Text = rez11.ToString();


            double jg6 = Convert.ToDouble(produkt5_7.Text);
            double jg7 = Convert.ToDouble(produkt6_6.Text);
            double jg8 = Convert.ToDouble(produkt7_5.Text);
            double rez12 = jg6 + jg7 + jg8;
            shuma12.Text = rez12.ToString();

            double jz7 = Convert.ToDouble(produkt6_7.Text);
            double jz8 = Convert.ToDouble(produkt7_6.Text);
            double rez13 = jz7 + jz8;
            shuma13.Text = rez13.ToString();

            double jr8 = Convert.ToDouble(produkt7_7.Text);
            double rez14 =  jr8;
            shuma14.Text = rez14.ToString();
        }

        private void koeficienti0P1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti1P1_TextChanged(object sender, EventArgs e)
        {
          



        }

        private void koeficienti2P1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void koeficienti0P1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void koeficienti2P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti1P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti3P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti4P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti5P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti6P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti7P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti0P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti1P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti2P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti3P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti4P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti5P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti6P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void koeficienti7P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void produkt0_0_TextChanged(object sender, EventArgs e)
        {
            produkt0_0.Enabled = false;
        }

        private void produkt0_1_TextChanged(object sender, EventArgs e)
        {
            produkt0_1.Enabled = false;
        }

        private void produkt0_2_TextChanged(object sender, EventArgs e)
        {
            produkt0_2.Enabled = false;
        }

        private void produkt0_3_TextChanged(object sender, EventArgs e)
        {
            produkt0_3.Enabled = false;
        }

        private void produkt0_4_TextChanged(object sender, EventArgs e)
        {
            produkt0_4.Enabled = false;
        }

        private void produkt0_5_TextChanged(object sender, EventArgs e)
        {
            produkt0_5.Enabled = false;
        }

        private void produkt0_6_TextChanged(object sender, EventArgs e)
        {
            produkt0_6.Enabled = false;
        }

        private void produkt0_7_TextChanged(object sender, EventArgs e)
        {
            produkt0_7.Enabled = false;
        }

        private void produkt1_0_TextChanged(object sender, EventArgs e)
        {
            produkt1_0.Enabled = false;
        }

        private void produkt1_1_TextChanged(object sender, EventArgs e)
        {
            produkt1_1.Enabled = false;
        }

        private void produkt1_2_TextChanged(object sender, EventArgs e)
        {
            produkt1_2.Enabled = false;
        }

        private void produkt1_3_TextChanged(object sender, EventArgs e)
        {
            produkt1_3.Enabled = false;
        }

        private void produkt1_4_TextChanged(object sender, EventArgs e)
        {
            produkt1_4.Enabled = false;
        }

        private void produkt1_5_TextChanged(object sender, EventArgs e)
        {
            produkt1_5.Enabled = false;
        }

        private void produkt1_6_TextChanged(object sender, EventArgs e)
        {
            produkt1_6.Enabled = false;
        }

        private void produkt1_7_TextChanged(object sender, EventArgs e)
        {
            produkt1_7.Enabled = false;
        }

        private void produkt2_0_TextChanged(object sender, EventArgs e)
        {
            produkt2_0.Enabled = false;
        }

        private void produkt2_1_TextChanged(object sender, EventArgs e)
        {
            produkt2_1.Enabled = false;
        }

        private void produkt2_2_TextChanged(object sender, EventArgs e)
        {
            produkt2_2.Enabled = false;
        }

        private void produkt2_3_TextChanged(object sender, EventArgs e)
        {
            produkt2_3.Enabled = false;
        }

        private void produkt2_4_TextChanged(object sender, EventArgs e)
        {
            produkt2_4.Enabled = false;
        }

        private void produkt2_5_TextChanged(object sender, EventArgs e)
        {
            produkt2_5.Enabled = false;
        }

        private void produkt2_6_TextChanged(object sender, EventArgs e)
        {
            produkt2_6.Enabled = false;
        }

        private void produkt2_7_TextChanged(object sender, EventArgs e)
        {
            produkt2_7.Enabled = false;
        }

        private void produkt3_0_TextChanged(object sender, EventArgs e)
        {
            produkt3_0.Enabled = false;
        }

        private void produkt3_2_TextChanged(object sender, EventArgs e)
        {
            produkt3_2.Enabled = false;
        }

        private void produkt3_3_TextChanged(object sender, EventArgs e)
        {
            produkt3_3.Enabled = false;
        }

        private void produkt3_4_TextChanged(object sender, EventArgs e)
        {
            produkt3_4.Enabled = false;
        }

        private void produkt3_5_TextChanged(object sender, EventArgs e)
        {
            produkt3_5.Enabled = false;
        }

        private void produkt3_6_TextChanged(object sender, EventArgs e)
        {
            produkt3_6.Enabled = false;
        }

        private void produkt3_7_TextChanged(object sender, EventArgs e)
        {
            produkt3_7.Enabled = false;
        }

        private void produkt4_0_TextChanged(object sender, EventArgs e)
        {
            produkt4_0.Enabled = false;
        }

        private void produkt4_1_TextChanged(object sender, EventArgs e)
        {
            produkt4_1.Enabled = false;
        }

        private void produkt4_2_TextChanged(object sender, EventArgs e)
        {
            produkt4_2.Enabled = false;
        }

        private void produkt4_3_TextChanged(object sender, EventArgs e)
        {
            produkt4_3.Enabled = false;
        }

        private void produkt4_4_TextChanged(object sender, EventArgs e)
        {
            produkt4_4.Enabled = false;
        }

        private void produkt4_5_TextChanged(object sender, EventArgs e)
        {
            produkt4_5.Enabled = false;
        }

        private void produkt4_6_TextChanged(object sender, EventArgs e)
        {
            produkt4_6.Enabled = false;
        }

        private void produkt4_7_TextChanged(object sender, EventArgs e)
        {
            produkt4_7.Enabled = false;
        }

        private void produkt5_0_TextChanged(object sender, EventArgs e)
        {
            produkt5_0.Enabled = false;
        }

        private void produkt5_2_TextChanged(object sender, EventArgs e)
        {
            produkt5_2.Enabled = false;
        }

        private void produkt5_3_TextChanged(object sender, EventArgs e)
        {
            produkt5_3.Enabled = false;
        }

        private void produkt5_4_TextChanged(object sender, EventArgs e)
        {
            produkt5_4.Enabled = false;
        }

        private void produkt5_5_TextChanged(object sender, EventArgs e)
        {
            produkt5_5.Enabled = false;
        }

        private void produkt5_6_TextChanged(object sender, EventArgs e)
        {
            produkt5_6.Enabled = false;
        }

        private void produkt5_7_TextChanged(object sender, EventArgs e)
        {
            produkt5_7.Enabled = false;
        }

        private void produkt6_0_TextChanged(object sender, EventArgs e)
        {
            produkt6_0.Enabled = false;
        }

        private void produkt6_1_TextChanged(object sender, EventArgs e)
        {
            produkt6_1.Enabled = false;
        }

        private void produkt6_2_TextChanged(object sender, EventArgs e)
        {
            produkt6_2.Enabled = false;
        }

        private void produkt6_3_TextChanged(object sender, EventArgs e)
        {
            produkt6_3.Enabled = false;
        }

        private void produkt6_4_TextChanged(object sender, EventArgs e)
        {
            produkt6_4.Enabled = false;
        }

        private void produkt6_5_TextChanged(object sender, EventArgs e)
        {
            produkt6_5.Enabled = false;
        }

        private void produkt6_6_TextChanged(object sender, EventArgs e)
        {
            produkt6_6.Enabled = false;
        }

        private void produkt6_7_TextChanged(object sender, EventArgs e)
        {
            produkt6_7.Enabled = false;
        }

        private void produkt7_0_TextChanged(object sender, EventArgs e)
        {
            produkt7_0.Enabled = false;
        }

        private void produkt7_1_TextChanged(object sender, EventArgs e)
        {
            produkt7_1.Enabled = false;
        }

        private void produkt7_2_TextChanged(object sender, EventArgs e)
        {
            produkt7_2.Enabled = false;
        }

        private void produkt7_3_TextChanged(object sender, EventArgs e)
        {
            produkt7_3.Enabled = false;
        }

        private void produkt7_4_TextChanged(object sender, EventArgs e)
        {
            produkt7_4.Enabled = false;
        }

        private void produkt7_5_TextChanged(object sender, EventArgs e)
        {
            produkt7_5.Enabled = false;
        }

        private void produkt7_6_TextChanged(object sender, EventArgs e)
        {
            produkt7_6.Enabled = false;
        }

        private void produkt7_7_TextChanged(object sender, EventArgs e)
        {
            produkt7_7.Enabled = false;
        }

        private void shuma0_TextChanged(object sender, EventArgs e)
        {
            shuma0.Enabled = false;
        }

        private void shuma1_TextChanged(object sender, EventArgs e)
        {
            shuma1.Enabled = false;
        }

        private void shuma2_TextChanged(object sender, EventArgs e)
        {
            shuma2.Enabled = false;
        }

        private void shuma3_TextChanged(object sender, EventArgs e)
        {
            shuma3.Enabled = false;
        }

        private void shuma4_TextChanged(object sender, EventArgs e)
        {
            shuma4.Enabled = false;
        }

        private void shuma5_TextChanged(object sender, EventArgs e)
        {
            shuma5.Enabled = false;
        }

        private void shuma6_TextChanged(object sender, EventArgs e)
        {
            shuma6.Enabled = false;
        }

        private void shuma7_TextChanged(object sender, EventArgs e)
        {
            shuma7.Enabled = false;
        }

        private void shuma8_TextChanged(object sender, EventArgs e)
        {
            shuma8.Enabled = false;
        }

        private void shuma9_TextChanged(object sender, EventArgs e)
        {
            shuma9.Enabled = false;
        }

        private void shuma10_TextChanged(object sender, EventArgs e)
        {
            shuma10.Enabled = false;
        }

        private void shuma11_TextChanged(object sender, EventArgs e)
        {
            shuma11.Enabled = false;
        }

        private void shuma12_TextChanged(object sender, EventArgs e)
        {
            shuma12.Enabled = false;
        }

        private void shuma13_TextChanged(object sender, EventArgs e)
        {
            shuma13.Enabled = false;
        }

        private void shuma14_TextChanged(object sender, EventArgs e)
        {
            shuma14.Enabled = false;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            textBox17.Enabled = false;
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
           
        }

        private void ClearTextboxes()
        {
            koeficienti0P1.Clear();
            koeficienti1P1.Clear();
            koeficienti2P1.Clear();
            koeficienti3P1.Clear();
            koeficienti4P1.Clear();
            koeficienti5P1.Clear();
            koeficienti6P1.Clear();
            koeficienti7P1.Clear();
            koeficienti0P2.Clear();
            koeficienti1P2.Clear();
            koeficienti2P2.Clear();
            koeficienti3P2.Clear();
            koeficienti4P2.Clear();
            koeficienti5P2.Clear();
            koeficienti6P2.Clear();
            koeficienti7P2.Clear();

            produkt0_0.Clear();
            produkt0_1.Clear();
            produkt0_2.Clear();
            produkt0_3.Clear();
            produkt0_4.Clear();
            produkt0_5.Clear();
            produkt0_6.Clear();
            produkt0_7.Clear();

            produkt1_0.Clear();
            produkt1_1.Clear();
            produkt1_2.Clear();
            produkt1_3.Clear();
            produkt1_4.Clear();
            produkt1_5.Clear();
            produkt1_6.Clear();
            produkt1_7.Clear();

            produkt2_0.Clear();
            produkt2_1.Clear();
            produkt2_2.Clear();
            produkt2_3.Clear();
            produkt2_4.Clear();
            produkt2_5.Clear();
            produkt2_6.Clear();
            produkt2_7.Clear();

            produkt3_0.Clear();
            produkt3_1.Clear();
            produkt3_2.Clear();
            produkt3_3.Clear();
            produkt3_4.Clear();
            produkt3_5.Clear();
            produkt3_6.Clear();
            produkt3_7.Clear();


            produkt4_0.Clear();
            produkt4_1.Clear();
            produkt4_2.Clear();
            produkt4_3.Clear();
            produkt4_4.Clear();
            produkt4_5.Clear();
            produkt4_6.Clear();
            produkt4_7.Clear();

            produkt5_0.Clear();
            produkt5_1.Clear();
            produkt5_2.Clear();
            produkt5_3.Clear();
            produkt5_4.Clear();
            produkt5_5.Clear();
            produkt5_6.Clear();
            produkt5_7.Clear();

            produkt6_0.Clear();
            produkt6_1.Clear();
            produkt6_2.Clear();
            produkt6_3.Clear();
            produkt6_4.Clear();
            produkt6_5.Clear();
            produkt6_6.Clear();
            produkt6_7.Clear();


            produkt7_0.Clear();
            produkt7_1.Clear();
            produkt7_2.Clear();
            produkt7_3.Clear();
            produkt7_4.Clear();
            produkt7_5.Clear();
            produkt7_6.Clear();
            produkt7_7.Clear();

            shuma0.Clear();
            shuma1.Clear();

            shuma2.Clear();
            shuma3.Clear();

            shuma4.Clear();
            shuma5.Clear();
            shuma6.Clear();
            shuma7.Clear();

            shuma8.Clear();
            shuma9.Clear();
            shuma10.Clear();
            shuma11.Clear();
            shuma12.Clear();
            shuma13.Clear();
            shuma14.Clear();


        }

        private void label44_Click(object sender, EventArgs e)
        {

        }
    }
}
