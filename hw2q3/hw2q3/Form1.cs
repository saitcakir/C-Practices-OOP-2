using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            Circle Circle1 = new Circle(double.Parse(textBox_Radius.Text));
            
            Circle1.Circumference();
            Circle1.Area();

            textBox_Area.Text = Circle1.CircleArea.ToString();
            textBox_Circumference.Text = Circle1.CircleCircumference.ToString();
        }
        public class Circle
        {
            public double Radius { get; set; }
            public double CircleArea;
            public double CircleCircumference;
            public Circle()
            {
            }
            public Circle(double Radius)
            {
                this.Radius = Radius;
            }
            public void Area()
            {
                CircleArea = Math.PI * Radius * Radius;
            }
            public void Circumference()
            {
                CircleCircumference = 2 * Math.PI * Radius;
            }
        }
    }
}
