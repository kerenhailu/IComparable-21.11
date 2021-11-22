using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare21._11
{
    internal class Square
    {
        int width;
        int height;
       public Square(int width,int height)
        {
            this.width = width;
            this.height = height;
        }
        public int Area()
        {
            int area = this.width*this.height;
            return area;
        }
    }
}
