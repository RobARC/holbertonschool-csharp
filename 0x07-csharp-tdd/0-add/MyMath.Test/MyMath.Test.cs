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
    public void returnSumAB([Values(1, 2, 3)] int a, [Values(4, 5, 6)] int b)
    {
        int output =  Operations.Add(a, b);
        Assert.AreEqual(output, a + b);
    }

      [Test]
    public void returnNegativeSumAB([Values(-1, -2, -3)] int a, [Values(-4, -5, -6)] int b)
    {
        int output =  Operations.Add(a, b);
        Assert.AreEqual(output, a + b);
    }
}