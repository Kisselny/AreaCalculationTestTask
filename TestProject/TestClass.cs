using System.Reflection.Metadata;

namespace TestProject;

[TestClass]
public class TestClass
{
    const double _pi = 3.1415926535;
    
    [TestMethod]
    public void CircleTestMethod1()
    {
        const double radius = 25;
        var circle = new AreaCalcLib.Circle(radius);
        const double expectedResult = 1963.4954084375;
        Assert.AreEqual(expectedResult, circle.Area);
    }

    [TestMethod]
    public void CircleTestMethod2()
    {
        const double radius = 25;
        var circle = new AreaCalcLib.Circle(radius);
        double expectedResult = Math.Round(_pi * radius * radius, 10);
        Assert.AreEqual(expectedResult, circle.Area);
    }

    [TestMethod]
    public void CircleTestMethod3()
    {
        const double radius = 0.385;
        var circle = new AreaCalcLib.Circle(radius);
        double expectedResult = Math.Round(0.4656625710, 11);
        Assert.AreEqual(expectedResult, circle.Area);
    }
    
    [TestMethod]
    public void CircleTestMethod4()
    {
        const double radius = 0.385;
        var circle = new AreaCalcLib.Circle(radius);
        double expectedResult = Math.Round(_pi * radius * radius, 10);
        Assert.AreEqual(expectedResult, circle.Area);
    }
    
    [TestMethod]
    public void 
}