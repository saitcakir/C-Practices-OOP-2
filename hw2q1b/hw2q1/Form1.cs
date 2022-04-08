using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            double R;
            double.TryParse(textBox_R.Text,out R);
            Circle Circle1 = new Circle(R,0,0);
            textBox_CircleArea.Text = Circle1.CircleArea().ToString();
            textBox_CirclePerimeter.Text = Circle1.CirclePerimeter().ToString();

        }


        public struct Circle
        {
            public double Radius { get; set; }
            public double Circle_Area { get; set; }

            public double Circle_Perimeter { get; set; }


            public Circle(double R,double a,double b)
            {
                Radius = R;
                Circle_Area = a;
                Circle_Perimeter = b;
            }
            public double CircleArea()
            {
                Circle_Area = Math.PI * Radius * Radius;
                return Circle_Area;
            }

            public double CirclePerimeter()
            {
                Circle_Perimeter = 2 * Math.PI * Radius;
                return Circle_Perimeter;
            }
        }

    }
}
