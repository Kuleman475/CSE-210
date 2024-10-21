using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("red", 4);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Blue", 4, 5);
        shapes.Add(r1);

        Circle c1 = new Circle("Pink", 6);
        shapes.Add(c1);
    
        foreach(Shape s in shapes) {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The color of the shape is {color} and the area is {area}");
        }
    }
}