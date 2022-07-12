using System;

namespace Square
{
    class Square
    {
        public double side;         //side is an attribute, public is an access modifier, you can read it or write it in another assembly
        public double Perimeter()   //perimeter is a method, no void after public so you need to return something
        {
            double p = side * 4;
            return p;
        }
        public double Area()
        {
            double a = side * side;
            return a;
        }

        public double Diagonal()
        {
            double d = side * Math.Sqrt(2);
            return d;
        }
    }
}
