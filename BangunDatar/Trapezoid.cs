using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Trapezoid
    {
        public double baseA;
        public double baseB;
        public double height;
        public double side;

        public void setBaseA(double baseA)
        {
            this.baseA = baseA;
        }
        public void setBaseB(double baseB)
        {
            this.baseB = baseB;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public void setSide(double side)
        {
            this.side = side;
        }

        public double area()
        {
            return ((this.baseA + this.baseB) / 2) * this.height;
        }
        public double perimeter()
        {
            return this.baseA + this.baseB + (2 * this.side);
        }
    }
}
