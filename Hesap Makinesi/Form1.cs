using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Uzun
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _ekrantemizlenecek;
        int _ilksayi, _sonsayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek == true)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecek = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek == true)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecek = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek == true)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecek = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek == true)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecek = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "0";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek == true)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecek = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek == true)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecek = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek == true)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecek = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek == true)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecek = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek == true)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecek = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecek == true)
            {
                ekranlabel.Text = "";
                _ekrantemizlenecek = false;
            }
            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "9";
        }

        private void btncikart_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecek = true;
            _ilksayi = Convert.ToInt16(ekranlabel.Text);
            
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecek = true;
            _ilksayi = Convert.ToInt16(ekranlabel.Text);
        }

        private void btnbol_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecek = true;
            _ilksayi = Convert.ToInt16(ekranlabel.Text);
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecek = true;
            _ilksayi = Convert.ToInt16(ekranlabel.Text);
        }

        private void btnsifirla_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }

        private void btnesit_Click(object sender, EventArgs e)
        {
            _sonsayi = Convert.ToInt16(ekranlabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + _sonsayi; break;
                case '-':
                    sonuc = _ilksayi - _sonsayi; break;
                case '*':
                    sonuc = _ilksayi * _sonsayi; break;
                case '/':
                    sonuc = _ilksayi / _sonsayi; break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranlabel.Text = sonuc.ToString();
        }
    }
}
