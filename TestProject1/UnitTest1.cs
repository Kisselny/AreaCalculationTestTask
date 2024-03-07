namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CircleTestMethod1()
    {
        const double radius = 25;
        var circle = new AreaCalcLib.Circle(radius);
        const double expectedResult = 1963.49541;
        Assert.AreEqual(expectedResult, circle.Area);
    }

    [TestMethod]
    public void CircleTestMethod2()
    {
        const double _pi = 3.1415926535;
        const double radius = 25;
        var circle = new AreaCalcLib.Circle(radius);
        double expectedResult = Math.Round(_pi * radius * radius, 5);
        Assert.AreEqual(expectedResult, circle.Area);
    }

    [TestMethod]
    public void CircleTestMethod3()
    {
        const double radius = 0.385;
        var circle = new AreaCalcLib.Circle(radius);
        double expectedResult = 0.46566;
        Assert.AreEqual(expectedResult, circle.Area);
    }
    
    [TestMethod]
    public void CircleTestMethod4()
    {
        const double _pi = 3.1415926535;
        const double radius = 0.385;
        var circle = new AreaCalcLib.Circle(radius);
        double expectedResult = Math.Round(_pi * radius * radius, 5);
        Assert.AreEqual(expectedResult, circle.Area);
    }

    [TestMethod]
    public void CircleTestMethod5()
    {
        const double _pi = 3.1415926535;
        const double radius = 4245.4654897965413;
        var circle = new AreaCalcLib.Circle(radius);
        double expectedResult = Math.Round(_pi * radius * radius, 5);
        Assert.AreEqual(expectedResult, circle.Area);
    }

    [TestMethod]
    public void TriangleTestMethod1()
    {
        var triangle = new AreaCalcLib.Triangle(5, 5, 5);
        double expectedResult = 10.82532;
        Assert.AreEqual(expectedResult, triangle.Area);
    }

    [TestMethod]
    public void TriangleTestMethod2()
    {
        var triangle = new AreaCalcLib.Triangle(5, 5, 5);
        bool expectedResult = false;
        Assert.AreEqual(expectedResult, triangle.RightAngled);
    }

    [TestMethod]
    public void TriangleTestMethod3()
    {
        var triangle = new AreaCalcLib.Triangle(3, 4, 5);
        bool expectedResult = true;
        Assert.AreEqual(expectedResult, triangle.RightAngled);
    }
}