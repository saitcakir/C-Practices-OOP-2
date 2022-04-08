using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Circle
        {
            private double Radius { get; set; }
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
        public class Cylinder : Circle
        {
            private double h;
            private double surfaceArea;

            public double Volume { get; set; }
            public double SurfaceArea { get; set; }
            public Cylinder() { }
            public Cylinder(double Radius, double Height) : base(Radius)
            {
                h = Height;
            }
            public void CylinderVolume()
            {
                Area();
                Volume = CircleArea * h;
            }
            public void CylinderSurfaceArea()
            {
                Circumference();
                Area();
                SurfaceArea = h * CircleCircumference + 2*CircleArea;
            }
        }
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox_Radius.Text, out double R);
            double.TryParse(textBox_CylinderHeight.Text, out double H);
            Cylinder cylinder1 = new Cylinder(R, H);
            cylinder1.CylinderSurfaceArea();
            cylinder1.CylinderVolume();
            textBox_Area.Text = cylinder1.SurfaceArea.ToString();
            textBox_Volume.Text = cylinder1.Volume.ToString();
        }
    }
}
