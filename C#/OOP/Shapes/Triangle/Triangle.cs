using System;

namespace Triangle
{
    class Triangle
    {
        private double s1, s2, s3; //sides

        public Triangle(double s1, double s2, double s3)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }

        public bool IsBuildable()
        {
            return (s1+s2>=s3 && s2+s3>=s1 && s1+s3>=s2);
        }

        public double Perimeter()
        {
            return s1 + s2 + s3;
        }

        public double Area()
        {
            double sp = Perimeter() / 2; //semiperimeter
            return Math.Sqrt(sp * (sp - s1) * (sp - s2) * (sp - s3));
        }

        public string Type()
        {
            if (s1 == s2 && s1 == s3)
                return "equilateral";
            else if (s1 == s2 || s1 == s3 || s2 == s3)
                return "isosceles";
            return "scalene";
        }

        public string PrintTriangleData()
        {
            return "The triangle's perimeter is: " + Perimeter() +
            "\nThe triangle's area is: " + Area() +
            "\nThe triangle's type is: " + Type();
        }
    }
}
