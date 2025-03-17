using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Rectangle : Shape, ICalculateArea
    {
        // Properties for Length and Width
        public double Length { get; set; }
        public double Width { get; set; }

        // Constructor
        public Rectangle(string name, double length, double width) : base(name)
        {
            Length = length;
            Width = width;
        }

        // Implementation of CalculateArea method
        public double CalculateArea()
        {
            return Length * Width;
        }

        // Ovveride Display method to include area
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Type: Rectangle, Length: {Length}, Width: {Width}, Area: {CalculateArea()}");
        }
    }
}
