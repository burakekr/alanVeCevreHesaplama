using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daire_dikdörtgen
{
    public partial class Form1 : Form
    {
        double kısaK, uzunK, cevre, alan, yaricap;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                kısaK = Convert.ToDouble(textBox1.Text);
                uzunK = Convert.ToDouble(textBox2.Text);
                alan = kısaK * uzunK;
                cevre = (kısaK + uzunK) * 2;
                label8.Text = alan.ToString();
                label9.Text = cevre.ToString();
            }
            else if (radioButton2.Checked)
            {
                yaricap = Convert.ToDouble(textBox3.Text);
                alan = 3.14 * (yaricap * yaricap);
                cevre = 2 * 3.14 * yaricap;
                label8.Text = alan.ToString();
                label9.Text = cevre.ToString();

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                button1.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                textBox3.Text = "";
                label8.Text = "";
                label9.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = true;
                button1.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                label8.Text = "";
                label9.Text = "";
            }
        }
    }
}
