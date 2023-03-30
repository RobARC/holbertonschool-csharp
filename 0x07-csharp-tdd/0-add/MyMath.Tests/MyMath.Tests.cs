using NUnit.Framework;
using MyMath;

namespace MyMath.Test;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    /// <summary>
    /// Return sum of a + b positive numbers
    /// </summary>

    public void returnSumAB([Values(1, 2, 3)] int a, [Values(4, 5, 6)] int b)
    {
        int output =  Operations.Add(a, b);
        Assert.AreEqual(output, a + b);
    }

    [Test]
    /// <summary>
    /// Return sum of a + b Negative numbers
    /// </summary>
    public void returnNegativeSumAB([Values(-1, -2, -3)] int a, [Values(-4, -5, -6)] int b)
    {
        int output =  Operations.Add(a, b);
        Assert.AreEqual(output, a + b);
    }
}