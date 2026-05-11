using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekMi;
        private double _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ensure each digit button has exactly one subscription to avoid double-appending
            var digits = new Button[] {
                rakam0Button, rakam1Button, rakam2Button, rakam3Button, rakam4Button,
                rakam5Button, rakam6Button, rakam7Button, rakam8Button, rakam9Button
            };

            foreach (var b in digits)
            {
                // remove any accidental duplicate subscriptions and attach once
                b.Click -= RakamButton_Click;
                b.Click += RakamButton_Click;
            }

            // enable form-level key handling for decimal separator
            this.KeyPreview = true;
            this.KeyPress -= Form1_KeyPress;
            this.KeyPress += Form1_KeyPress;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Accept '.' or ',' as decimal separator
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // If an operation was selected, clear screen for new number
                if (_ekranTemizlenecekMi)
                {
                    ekranLabel.Text = "";
                    _ekranTemizlenecekMi = false;
                }

                if (string.IsNullOrEmpty(ekranLabel.Text) || ekranLabel.Text == "0")
                {
                    ekranLabel.Text = "0.";
                }
                else if (!ekranLabel.Text.Contains('.'))
                {
                    ekranLabel.Text += '.';
                }

                e.Handled = true;
            }
        }


        private void RakamButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            // If an operation was selected, clear the screen for the next number
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += btn.Text;
        }

        private void toplaButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            // store first number (use label1 which is the displayed control)
            _ilkSayi = Convert.ToDouble(ekranLabel.Text);
        }
        private void islemButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            // Map displayed operator to internal char
            var opText = btn.Text;
            char op = opText.Length > 0 ? opText[0] : '\0';
            if (op == 'X' || op == 'x') op = '*';

            // If there's already a pending operation, compute intermediate result first
            if (_islem != '\0' && !_ekranTemizlenecekMi)
            {
                // perform previous operation
                double ikinci = Convert.ToDouble(ekranLabel.Text);
                double ara = Hesapla(_ilkSayi, ikinci, _islem);
                ekranLabel.Text = FormatSonuc(ara);
                _ilkSayi = ara;
            }

            _islem = op;
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(ekranLabel.Text);
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(ekranLabel.Text);
            double sonuc = 0;

            try
            {
                switch (_islem)
                {
                    case '+':
                        sonuc = _ilkSayi + ikinciSayi;
                        break;
                    case '-':
                        sonuc = _ilkSayi - ikinciSayi;
                        break;
                    case '*':
                        sonuc = _ilkSayi * ikinciSayi;
                        break;
                    case '/':
                        if (ikinciSayi == 0)
                        {
                            MessageBox.Show("0'a bölünemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        sonuc = _ilkSayi / ikinciSayi;
                        break;
                    default:
                        return; // no operation selected
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return;
            }

            // Display result and prepare for next input
            ekranLabel.Text = FormatSonuc(sonuc);
            _ekranTemizlenecekMi = true;
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
            _islem = '\0';
            _ekranTemizlenecekMi = false;
            _ilkSayi = 0;
        }

        private double Hesapla(double a, double b, char islem)
        {
            switch (islem)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b == 0 ? double.NaN : a / b;
                default: return b;
            }
        }

        private string FormatSonuc(double value)
        {
            // remove trailing .0 for integers
            if (Math.Abs(value % 1) < 1e-10)
                return ((long)Math.Round(value)).ToString();
            return value.ToString();
        }
    }
}

