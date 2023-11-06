using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Yellow", 4);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("White", 7, 8);
        shapes.Add(s2);

        Circle s3 = new Circle("Black", 3);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}