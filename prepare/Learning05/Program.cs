using System;

class Program
{
    static void Main(string[] args)
    {
        // Esto funciona bien pero en el sample hay otra manera 

        // Square s1 = new Square("Red", 3);
        // string s1Color = s1.GetColor();
        // double s1Area = s1.GetArea();
         
       
        // Rectangle r1 = new Rectangle("Blue", 4, 5);
        // string r1Color = r1.GetColor();
        // double r1Area = r1.GetArea();
 
        // Circle c1 = new Circle("Green", 6);
        // string c1Color = c1.GetColor();
        // double c1Area = c1.GetArea();
        
        // Console.Clear();
        // Console.WriteLine("Rectangle Color: " + r1Color +" - "+"Area: "+ r1Area);
        // Console.WriteLine("Square Color: " + s1Color +" - "+"Area: "+ s1Area);
        // Console.WriteLine("Circle Color: " + c1Color +" - "+"Area: "+ c1Area);

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        Console.Clear();

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine("The " + color + " shape has an area of "+ area+".");
        }

    }
}