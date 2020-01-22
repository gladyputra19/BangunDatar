using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    public class Rectangle
    {
        private int width;
        private int height;

        public void setWidth(int width)
        {
            this.width = width;
        }
         public void setHeight(int height)
        {
            this.height = height;
        }
        public int area()
        {
            return width * height;
        }
        public int perimeter()
        {
            return 2 * (width + height);
        }
    }

    
}
