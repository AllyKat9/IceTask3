using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Circle : Shape, ICalculateArea
    {
        // Property for Radius
        public double Radius { get; set; }

        // Constructor
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        // Implementation odf CalculateArea method
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"ype: Circle, Radius: {Radius}, Area: {CalculateArea()}");
        }
    }
}
