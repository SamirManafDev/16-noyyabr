using System.Drawing;

namespace _16._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle { Radius = 5 };
            Rectangle rectangle = new Rectangle { x = 4, y = 5 };

            Console.WriteLine($"Circle Area: {circle.GetArea()}\nRectangle Area: {rectangle.GetArea()}");
        }

       
        
    }
}
