using System;

namespace ConsoleApp05
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] s = new Shape[3];
            s[0] = new Circle(2);
            s[1] = new Square(4);
            s[2] = new Circle(5);

            Output(s);
        }

        static void Output(Shape [] s)
        {
            foreach (Shape s2 in s)
            {
                Console.WriteLine(s2);
            }
        }
    }
}
