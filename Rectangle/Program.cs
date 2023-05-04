using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width:");
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Enter the height:");
            double height = Double.Parse(Console.ReadLine());
            Console.WriteLine("========================");

            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Your Rectangle info: \n" + rectangle.Display());
            Console.WriteLine("========================");

            Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());

        }
    }
}
