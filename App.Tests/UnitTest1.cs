using App.Core;
using NUnit.Framework;

namespace App.Tests;

public class CalculatorTests
{
    private Calculator _calc = null;

    [SetUp]
    public void Setup()
    {
        _calc = new Calculator();
    }

    //[Test]
    //public void Test1()
    //{
    //    Assert.Pass();
    //}
    public void Sum_DeveSomar2e3_Retorna5()
    {
        // Arrange
        var a = 2;
        var b = 3;

        // Act
        var result = _calc.Sum(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [TestCase(1, 1, 2)]
    [TestCase(-2, 2, 0)]
    [TestCase(10, -3, 7)]
    public void Sum_VariosCenarios(int a, int b, int esperado)
    {
        // Arrange
        var calc = new Calculator();

        // Act
        var result = calc.Sum(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(esperado));
    }
    [TestCase(5, 5, 0)]
    [TestCase(30, 20, 10)]
    [TestCase(15, 10, 5)]
    public void Sub_VariosCenarios(int a, int b, int esperado)
    {
        var calc = new Calculator(); // A
        var result = calc.Sub(a, b); // A
        Assert.That(result, Is.EqualTo(esperado)); // A
    }
    [TestCase(5, 5, 25)]
    [TestCase(10, 5, 50)]
    [TestCase(5, 3, 15)]
    public void Mul_VariosCenarios(int a, int b, int esperado)
    {
        var calc = new Calculator(); // A
        var result = calc.Mul(a, b); // A
        Assert.That(result, Is.EqualTo(esperado)); // A
    }
    [TestCase(5, 5, 1)]
    [TestCase(10, 2, 5)]
    [TestCase(30, 3, 10)]
    public void Div_VariosCenarios(int a, int b, double esperado)
    {
        var calc = new Calculator(); // A
        var result = calc.Div(a, b); // A
        Assert.That(result, Is.EqualTo(esperado)); // A
    }
}