using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renklerinDili
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mavi")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "Mutluluğun ve Pozitifliğin rangidir. :) ";
            }
            if (comboBox1.Text == "Sarı")
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "İyimserliğin rengidir";
            if (comboBox1.Text == "Yeşil");
            label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "Bereketin Rengidir :)";
            if (comboBox1.Text == "Siyah");
            label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "Siyah rengin anlamı güç, korku, gizem, otorite, zarafet, formalite, kötülük, saldırganlık, isyan ve sofistike ile ilişkilidir.:)";
            if (comboBox1.Text == "Siyah") ;
            label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi= " + "Beyaz renk masumiyeti, saflığı ve adaleti temsil ediyor.:)";

        }









        }
    }

