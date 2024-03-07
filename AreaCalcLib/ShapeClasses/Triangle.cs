using AreaCalcLib.Interfaces;

namespace AreaCalcLib;

/// <summary>
/// This class works in static and non-static context.
/// Use this class to create Triangle objects (you need to provide
/// all sides' lengths to the constructor) and access its Area property,
/// or call the CalculateArea method to get the area value statically.
/// The result is rounded to 5 decimal digits
/// It also has a property that indicates if the triangle
/// is right-angled.
/// </summary>
public class Triangle : IAreaCalculation
{
    /// <summary>
    /// Triangle object's area.
    /// </summary>
    public double Area { get; }
    
    /// <summary>
    /// Indicates if the triangle is right-angled.
    /// </summary>
    public bool RightAngled { get; }
    
    /// <summary>
    /// You should provide side lengths of a triangle to create the object.
    /// Then you'll have access to its area property.
    /// </summary>
    /// <param name="sideA">Triangle's first side length</param>
    /// <param name="sideB">Triangle's second side length</param>
    /// <param name="sideC">Triangle's third side length</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
        Area = CalculateArea(sideA, sideB, sideC);
        RightAngled = IsRightAngled(sideA, sideB, sideC);
    }
    
    
    private static void roundInputs(ref double sideA, ref double sideB, ref double sideC)
    {
        Math.Round(sideA, 5);
        Math.Round(sideB, 5);
        Math.Round(sideC, 5);
    }

    /// <summary>
    /// This method calculates triangle's area using its sides' lengths.
    /// The result is rounded to 5 decimal digits.
    /// </summary>
    /// <param name="sideA">Triangle's first side length</param>
    /// <param name="sideB">Triangle's second side length</param>
    /// <param name="sideC">Triangle's third side length</param>
    /// <returns></returns>
    public static double CalculateArea(double sideA, double sideB, double sideC)
    {
        roundInputs(ref sideA, ref sideB, ref sideC);
        double per = sideA + sideB + sideC; //per stands for perimeter
        double hper = per / 2; // hper stands for half the perimeter
        double area = Math.Sqrt(hper * (hper - sideA) * (hper - sideB) * (hper - sideC));
        return Math.Round(area, 5);
    }

    
    
    /// <summary>
    /// This method returns a bool that indicates if a triangle is right-angled.
    /// </summary>
    /// <param name="sideA">Triangle's first side length</param>
    /// <param name="sideB">Triangle's second side length</param>
    /// <param name="sideC">Triangle's third side length</param>
    /// <returns></returns>
    
    public static bool IsRightAngled(double sideA, double sideB, double sideC)
    {
        roundInputs(ref sideA, ref sideB, ref sideC);
        
        if (Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2)
            || Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2)
            || Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}