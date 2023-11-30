using System;
using System.Collections.Generic;

public interface IShape
{
    double Area();
}

// Implementation of rectangle shape
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }
}

// Implementation of circle shape
public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

// class that calculates the total area of shapes without modification
public class AreaCalculator
{
    // Method that takes a list of shapes and calculates the total area
    public double CalculateTotalArea(List<IShape> shapes)
    {
        double totalArea = 0;

        foreach (var shape in shapes)
        {
            // Open for extension: You can add new shapes without modifying this class
            totalArea += shape.Area();
        }

        return totalArea;
    }
}

// Example usage
class Program
{
    static void Main()
    {
        // Creating shapes
        var rectangle = new Rectangle { Width = 5, Height = 10 };
        var circle = new Circle { Radius = 7 };

        // Adding shapes to a list
        var shapes = new List<IShape> { rectangle, circle };

        // Calculating total area without modifying the AreaCalculator class
        var areaCalculator = new AreaCalculator();
        double totalArea = areaCalculator.CalculateTotalArea(shapes);

        // Outputting the result
        Console.WriteLine($"Total area of shapes: {totalArea}");
    }
}
