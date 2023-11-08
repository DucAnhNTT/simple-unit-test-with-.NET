using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcualtorVS2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtBox1.Text);
            b = int.Parse(txtBox2.Text);
            Calculation c = new Calculation(a, b);
            ketQua = c.Execute("+");
            txtBox3.Text = ketQua.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtBox1.Text);
            b = int.Parse(txtBox2.Text);
            Calculation c = new Calculation(a, b);
            ketQua = c.Execute("-");
            txtBox3.Text = ketQua.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtBox1.Text);
            b = int.Parse(txtBox2.Text);
            Calculation c = new Calculation(a, b);
            ketQua = c.Execute("*");
            txtBox3.Text = ketQua.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtBox1.Text);
            b = int.Parse(txtBox2.Text);
            Calculation c = new Calculation(a, b);
            ketQua = c.Execute("/");
            txtBox3.Text = ketQua.ToString();
        }
    }
}
