using System;

namespace BangunDatar
{
    public class Square
    {
        private double sisi;

        public void setSide(double side)
        {
            this.sisi = side;
        }
        public double area()
        {
            return Math.Pow(this.sisi, 2);
        }
        public Double Perimeter()
        {
            return 4 * sisi;
        }
    }
}


