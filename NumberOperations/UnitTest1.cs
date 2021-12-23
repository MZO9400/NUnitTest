using NUnit.Framework;

namespace NumberOperations;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAdd() {
        Assert.AreEqual(5, new NumberOperations().Add(3, 2));
    }
    [Test]
    public void TestSubtract() {
        Assert.AreEqual(1, new NumberOperations().Subtract(3, 2));
    }
    [Test]
    public void TestMultiply() {
        Assert.AreEqual(6, new NumberOperations().Multiply(3, 2));
    }
    [Test]
    public void TestDivide() {
        Assert.AreEqual(3, new NumberOperations().Divide(9, 3));
    }
    [Test]
    public void TestIsPrime() {
        Assert.AreEqual(true, new NumberOperations().IsPrime(3));
    }
    [Test]
    public void TestIsPrime2() {
        Assert.AreEqual(false, new NumberOperations().IsPrime(4));
    }
    [Test]
    public void TestIsEven() {
        Assert.AreEqual(true, new NumberOperations().IsEven(2));
    }
    [Test]
    public void TestIsEven2() {
        Assert.AreEqual(false, new NumberOperations().IsEven(3));
    }
    [Test]
    public void TestDistance() {
        Assert.AreEqual(5, new NumberOperations().Distance(0, 0, 3, 4));
    }
}