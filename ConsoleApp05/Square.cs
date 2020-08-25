using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp05
{
    class Square: Shape
    {
        public int X;
        
        public Square(int a)
        {
            X = a;
        }

        public override double Perimeter()
        {
            return X*X;
        }

        public override double Area()
        {
            return (X+X)*2;
        }

        public override string ToString()
        {
            return $"Square: [Perimeter: {Perimeter()}, Area: {Area()}]";
        }
    }
}
