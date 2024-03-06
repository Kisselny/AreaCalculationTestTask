using AreaCalcLib.Interfaces;

namespace AreaCalcLib;

/// <summary>
/// This class works in static and non-static context.
/// Use it to create Circle objects (you need to provide
/// radius to the constructor) and access its Area property,
/// or call the CalculateArea method to get the area value statically.
/// </summary>
public class Circle : IAreaCalculation
{
    /// <summary>
    /// Cicrle's area property.
    /// </summary>
    public double Area { get; }

    /// <summary>
    /// You should provide a radius value to create the circle object.
    /// Then you'll have have access to its area property.
    /// </summary>
    /// <param name="radius">Radius value</param>
    public Circle(double radius)
    {
        Area = CalculateArea(radius);
    }
    
    /// <summary>
    /// This method calculates circle's area using its radius value.
    /// </summary>
    /// <param name="radius">Radius value</param>
    /// <returns></returns>
    public static double CalculateArea(double radius)
    {
        double circleArea = System.Math.Pow(radius, 2) * System.Math.PI;
        return circleArea;
    }
    
}