using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        //square
        Square square1 = new Square(5, "blue");

        Console.WriteLine($"the area of a square is {square1.getArea()}");
        Console.WriteLine();

        //rectangle
        Rectangle rectangle1 = new Rectangle(5, 2, "yellow");
        Console.WriteLine($"The area of a rectangle is {rectangle1.getArea()}");

        Console.WriteLine();
        
        //circle
        Circle circle1 = new Circle(10,"red");
        Console.WriteLine($"The area of a cirlce is {circle1.getArea()}");


        //list
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape item in shapes)
        {
            string shapeColor = item.getColor();

            double area = item.getArea();

            Console.WriteLine($"The {shapeColor} shape has an area of {area}");
        }

    

    }
}