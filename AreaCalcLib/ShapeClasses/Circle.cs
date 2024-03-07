using AreaCalcLib.Interfaces;

namespace AreaCalcLib;

/// <summary>
/// This class works in static and non-static context.
/// Use it to create Circle objects (you need to provide
/// radius to the constructor) and access its Area property,
/// or call the CalculateArea method to get the area value statically.
/// It uses PI value approximated
/// to 10 digits after dot (3.1415926535).
/// </summary>
public class Circle : IAreaCalculation
{
    private const double _pi = 3.1415926535;
    
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
        double circleArea = radius * radius * _pi;
        return Math.Round(circleArea, 10);
    }
    
}