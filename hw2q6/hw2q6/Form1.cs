using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Poly
        {
            public double Result = 0;

            public void FunCalc(double X, double a, double b, double c)
            {
                Result = a * X * X + b * X + c;
            }
            public void FunCalc(double X, double a, double b, double c, double d)
            {
                Result = a * X * X * X + b * X * X + c * X + d;
            }
            public void FunCalc(double X, double a, double b, double c, double d, double e)
            {
                Result = a * X * X * X * X + b * X * X * X + c * X * X + d * X + e;
            }
        }
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            double X=0, a=0, b=0, c=0, d=0, e1=0;
            double.TryParse(textBox_1.Text, out X);
            double.TryParse(textBox_2.Text, out a);
            double.TryParse(textBox_3.Text, out b);
            double.TryParse(textBox_4.Text, out c);
            double.TryParse(textBox_5.Text, out d);
            double.TryParse(textBox_6.Text, out e1);
            Poly Poly1 = new Poly();
            if (X > 0 && a > 0 && b > 0 && c > 0 && d > 0 && e1 > 0)
            {
                Poly1.FunCalc(X, a, b, c, d, e1);
            }
            else if (X > 0 && a > 0 && b > 0 && c > 0 && d > 0)
            {
                Poly1.FunCalc(X, a, b, c, d);
            }
            else if (X > 0 && a > 0 && b > 0 && c > 0)
            {
                Poly1.FunCalc(X, a, b, c);
            }
            else 
            {
                MessageBox.Show("Error, Not enough input parameters or Wrong value assignment");
            }
            textBox_Result.Text = Poly1.Result.ToString();
        }
    }
}
