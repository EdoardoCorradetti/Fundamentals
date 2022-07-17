using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        public double Base { set; get; }
        public double Height { set; get; }
        public double Perimeter()
        {
            return (Base+Height)*2;
        }

        public double Area()
        {
            return Base*Height;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Base,2)+Math.Pow(Height,2));
        }

        public override string ToString()
        {
            return "The rectangle's perimeter is: " + Perimeter() +
            "\nThe rectangle's area is: " + Area() +
            "\nThe rectangle's diagonal is: " + Diagonal();
        }
    }
}
