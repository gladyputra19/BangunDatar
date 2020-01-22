using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    public class circle
    {
        private double radius;

        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public double area()
        {
            return Math.Pow(this.radius, 2) * Math.PI;
        }
        public double perimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
