using System;

// Base class
public class Rectangle
{
    // Properties
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    // Constructor
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    // Method to calculate area
    public virtual int CalculateArea()
    {
        return Width * Height;
    }
}

// Derived class
public class Square : Rectangle
{
    // Constructor
    public Square(int side) : base(side, side)
    {
    }

    // Override the properties
    public override int Width
    {
        get { return base.Width; }
        set { base.Width = base.Height = value; }
    }

    public override int Height
    {
        get { return base.Height; }
        set { base.Width = base.Height = value; }
    }
}

// Client code
class Program
{
    static void Main()
    {
        // Using a Rectangle
        Rectangle rectangle = new Rectangle(3, 4);
        DisplayArea(rectangle);

        // Using a Square
        Rectangle square = new Square(5);
        DisplayArea(square);
    }

    // Display the area of a shape
    static void DisplayArea(Rectangle shape)
    {
        Console.WriteLine($"Area: {shape.CalculateArea()}");
    }
}