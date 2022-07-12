using System;

namespace Circle
{
    class Circle
    {
        //attributes
        private double radius; //private is an access modifier, you can't read it or write it in another assembly (it's default in a class)

        //new constructor with parameter passage
        public Circle(double radius)
        {
            SetRadius(radius);
        }

        //methods

        public void SetRadius(double radius)
        {
            if (radius > 0)
                this.radius = radius; //this. is a pointer, this.radius refers to the attribute, not the parameter
        }

        public double GetRadius()
        {
            return radius;
        }
        public double Diameter()
        {
            return 2 * radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public string PrintCircleData()
        {
            return "The circle's diameter is: " + Diameter() +
            "\nThe circle's circumference is: " + Circumference() +
            "\nThe circle's area is: " + Area();
        }

    }
}
