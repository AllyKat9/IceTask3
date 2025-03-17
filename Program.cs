namespace ShapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Rectangle object
            Rectangle rectangle = new Rectangle("Rectangle 1", 10, 5);
            rectangle.Display();

            // Create a Circle object
            Circle circle = new Circle("Circle 1", 7);
            circle.Display();

            Console.ReadLine();
        }
    }
}
