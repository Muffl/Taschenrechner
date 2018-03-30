using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        public Taschenrechner()
        {
            InitializeComponent();
        }

        private void Taschenrechner_Load(object sender, EventArgs e)
        {
            zahl1.Text = "";
            zahl2.Text = "";
            ergebnis.Text = "";
            zeichen.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + "1";
            }
            else
            {
                zahl2.Text = zahl2.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + "2";
            }
            else
            {
                zahl2.Text = zahl2.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + "3";
            }
            else
            {
                zahl2.Text = zahl2.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + "4";
            }
            else
            {
                zahl2.Text = zahl2.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + "5";
            }
            else
            {
                zahl2.Text = zahl2.Text + "5";
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + "6";
            }
            else
            {
                zahl2.Text = zahl2.Text + "6";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + "7";
            }
            else
            {
                zahl2.Text = zahl2.Text + "7";
            }
        }






        private void button8_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + "8";
            }
            else
            {
                zahl2.Text = zahl2.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + "9";
            }
            else
            {
                zahl2.Text = zahl2.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + "0";
            }
            else
            {
                zahl2.Text = zahl2.Text + "0";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            zeichen.Text = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            zeichen.Text = "-";
        }

        private void mal_Click(object sender, EventArgs e)
        {
            zeichen.Text = "*";
        }

        private void geteilt_Click(object sender, EventArgs e)
        {
            zeichen.Text = "/";
        }

        
        
        private void loeschen_Click(object sender, EventArgs e)
        {
            zahl1.Text = "";
            zahl2.Text = "";
            ergebnis.Text = "";
            zeichen.Text = "";
        }

        private void istGleich_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "+")
            {
                ergebnis.Text = (double.Parse(zahl1.Text) + double.Parse(zahl2.Text)).ToString();
            }

            if (zeichen.Text == "")
            {
                ergebnis.Text = (double.Parse(zahl1.Text) - double.Parse(zahl2.Text)).ToString();
            }

            if (zeichen.Text == "*")
            {
                ergebnis.Text = (double.Parse(zahl1.Text) * double.Parse(zahl2.Text)).ToString();
            }

            if (zeichen.Text == "/")
            {
                ergebnis.Text = (double.Parse(zahl1.Text) / double.Parse(zahl2.Text)).ToString();
            }

        }
       

        private void button11_Click(object sender, EventArgs e)
        {
            if (zeichen.Text == "")
            {
                zahl1.Text = zahl1.Text + ",";
            }
            else
            {
                zahl2.Text = zahl2.Text + ",";
            }
        }

        private void Taschenrechner_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
               
                   
                case Keys.D0:
                    this.button10.PerformClick();
                    break;
                case Keys.D1:
                    this.button1.PerformClick();
                    break;
                case Keys.D2:
                    this.button2.PerformClick();
                    break;
                case Keys.D3:
                    this.button3.PerformClick();
                    break;
                case Keys.D4:
                    this.button4.PerformClick();
                    break;
                case Keys.D5:
                    this.button5.PerformClick();
                    break;
                case Keys.D6:
                    this.button6.PerformClick();
                    break;
                case Keys.D7:
                    this.button7.PerformClick();
                    break;
                case Keys.D8:
                    this.button8.PerformClick();
                    break;
                case Keys.D9:
                    this.button9.PerformClick();
                    break;

                case Keys.NumPad0:
                    this.button10.PerformClick();
                    break;
                case Keys.NumPad1:
                    this.button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    this.button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    this.button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    this.button4.PerformClick();
                    break;
                case Keys.NumPad5:
                    this.button5.PerformClick();
                    break;
                case Keys.NumPad6:
                    this.button6.PerformClick();
                    break;
                case Keys.NumPad7:
                    this.button7.PerformClick();
                    break;
                case Keys.NumPad8:
                    this.button8.PerformClick();
                    break;
                case Keys.NumPad9:
                    this.button9.PerformClick();
                    break;

                case Keys.Add:
                    this.plus.PerformClick();
                    break;
                case Keys.Subtract:
                    this.minus.PerformClick();
                    break;
                case Keys.Multiply:
                    this.mal.PerformClick();
                    break;
                case Keys.Divide:
                    this.geteilt.PerformClick();
                    break;
                case Keys.Enter:
                    this.istGleich.PerformClick();
                    break;
                case Keys.Delete:
                    this.loeschen.PerformClick();
                    break;
                case Keys.Back:
                    this.loeschen.PerformClick();
                    break;






            }
        }
    }
}