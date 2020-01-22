using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Triangle
    {
        double based;
        double height;
        double sideA;
        double sideB;

        public void setBased(double based)
        {
            this.based = based;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public void setSideA(double sideA)
        {
            this.sideA = sideA;
        }
        public void setSideB(double sideB)
        {
            this.sideB = sideB;
        }
        public double area()
        {
            return this.based * this.height / 2;
        }

        public double perimeter()
        {
            return this.based + this.sideA + this.sideB;
        }
    }
}
