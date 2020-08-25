using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp05
{
    class Circle: Shape
    {
        public int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public override double Perimeter()
        {
            return 2*Math.PI*radius*radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"Circle: [Perimeter: {Perimeter()}, Area: {Area()}]";
        }
    }
}
