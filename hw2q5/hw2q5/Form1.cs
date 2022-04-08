using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Roots
        {
            public double a { get; set; }
            public double b { get; set; }
            public double c { get; set; }
            public double x1 { get; set; }
            public double x2 { get; set; }
            public Roots()
            {
                a = 0;
                b = 0;
                c = 0;
            }
            public Roots(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public int CalcRoots(double a, double b, double c)
            {
                int ret = 0;
                double Delta = b * b - 4 * a * c;
                if (Delta < 0)
                {
                    ret = 1;
                }
                else if (a == 0)
                {
                    ret = 2;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(Delta)) / (2 * a);
                }
                return ret;
            }
        }
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            double A, B, C;
            bool a_res, b_res, c_res;
            a_res = double.TryParse(textBox_a.Text, out A);
            b_res = double.TryParse(textBox_b.Text, out B);
            c_res = double.TryParse(textBox_c.Text, out C);

            Roots Roots1;
            int ret;
            if ((a_res == true) && (b_res == true) && (c_res == true))
            {
                Roots1 = new Roots(A, B, C);
                ret = Roots1.CalcRoots(A, B, C);

                if (ret == 0)
                {
                    textBox_X1.Text = Roots1.x1.ToString();
                    textBox_X2.Text = Roots1.x2.ToString();
                }
                else if (ret == 1)
                {
                    MessageBox.Show("Error, No real roots available for this equation");
                }
                else if (ret == 2)
                {
                    MessageBox.Show("Error, This is not a second order equation");
                }
            }
            else
            {
                MessageBox.Show("wrong inputs");
            }
        }
    }
}
