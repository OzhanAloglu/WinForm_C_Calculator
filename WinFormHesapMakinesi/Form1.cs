using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ekranTemizle = false;
        private char islem;
        private double ilkSayi;


        private void btn_1_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                lbl_snc.Text = "";
                ekranTemizle = false;
            }

            if (lbl_snc.Text == "0")

            {
                lbl_snc.Text = "";
            }
            lbl_snc.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                lbl_snc.Text = "";
                ekranTemizle = false;
            }

            if (lbl_snc.Text == "0")
            {
                lbl_snc.Text = "";
            }
            lbl_snc.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                lbl_snc.Text = "";
                ekranTemizle = false;
            }

            if (lbl_snc.Text == "0")
            {
                lbl_snc.Text = "";
            }
            lbl_snc.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                lbl_snc.Text = "";
                ekranTemizle = false;
            }

            if (lbl_snc.Text == "0")
            {
                lbl_snc.Text = "";
            }
            lbl_snc.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                lbl_snc.Text = "";
                ekranTemizle = false;
            }

            if (lbl_snc.Text == "0")
            {
                lbl_snc.Text = "";
            }
            lbl_snc.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                lbl_snc.Text = "";
                ekranTemizle = false;
            }

            if (lbl_snc.Text == "0")
            {
                lbl_snc.Text = "";
            }
            lbl_snc.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                lbl_snc.Text = "";
                ekranTemizle = false;
            }

            if (lbl_snc.Text == "0")
            {
                lbl_snc.Text = "";
            }
            lbl_snc.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                lbl_snc.Text = "";
                ekranTemizle = false;
            }

            if (lbl_snc.Text == "0")
            {
                lbl_snc.Text = "";
            }
            lbl_snc.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (ekranTemizle == true)
            {
                lbl_snc.Text = "";
                ekranTemizle = false;
            }

            if (lbl_snc.Text == "0")
            {
                lbl_snc.Text = "";
            }
            lbl_snc.Text += "9";
        }

        private void btn_sfır_Click(object sender, EventArgs e)
        {
            lbl_snc.Text += "0";
            if (ekranTemizle==true)
            {
                lbl_snc.Text = "0";
                ekranTemizle = false;
            }
            
            
        }

        private void btn_artı_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekranTemizle = true;
            ilkSayi = Convert.ToInt16(lbl_snc.Text);

        }

        private void btn_eksi_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekranTemizle = true;
            ilkSayi = Convert.ToInt16(lbl_snc.Text);
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekranTemizle = true;
            ilkSayi = Convert.ToInt16(lbl_snc.Text);

        }

        private void btn_episode_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekranTemizle = true;
            ilkSayi = Convert.ToInt16(lbl_snc.Text);

        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(lbl_snc.Text);

            double sonuc = 0;


            switch (islem)
            {

                case '+':
                    sonuc = ilkSayi + ikinciSayi;
                    break;

                case '-':
                    sonuc = ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = ilkSayi / ikinciSayi;
                    break;

            }

            lbl_snc.Text = Convert.ToString(sonuc);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_snc.Text = "0";
        }
    }
}
