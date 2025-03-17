using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public abstract class Shape
    {
        // Property for Name
        public string Name { get; set; }

        // Constructor
        public Shape(string name)
        {
            Name = name;
        }

        // Virtual method to display shape details
        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
