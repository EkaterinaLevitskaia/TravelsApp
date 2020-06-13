using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace TravelsApp
{
    public partial class Form1 : Form
    {
        private const string RussiaText = "Путешествие по России";
        private const string AbroadText = "Зарубежное путешествие";
        public string travel;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            travel = (string)comboBox1.SelectedItem;
            switch (travel)
            {
                case RussiaText:
                    if (checkBox1.Checked == false)
                    {
                        Russia r = new Russia(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                        textBox4.Text = Convert.ToString(r.Calculation());
                    }
                    else
                    {
                        Russia r = new Russia(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                        textBox4.Text = Convert.ToString(r.Calculation() + 250);
                    }
                    break;

                case AbroadText:
                    if (checkBox1.Checked == false)
                    {
                        Abroad a = new Abroad(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                        textBox4.Text = Convert.ToString(a.Calculation());
                    }
                    else
                    {
                        Abroad a = new Abroad(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                        textBox4.Text = Convert.ToString(a.Calculation() + 250);
                    }
                    break;
            }
          
        }
    }
}
