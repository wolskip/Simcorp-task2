using NUnit.Framework;
using System;
using System.IO;

[TestFixture]
public class ProgramTests
{
    private StringWriter _output;

    [SetUp]
    public void SetUp()
    {
        _output = new StringWriter();
        Console.SetOut(_output);
    }

    [TearDown]
    public void TearDown()
    {
        _output.Dispose();
    }

    [Test]
    public void Main_InvalidInput_NotEnoughArguments()
    {
        // Arrange
        var args = new string[] { "3", "4" };

        // Act
        Program.Main(args);

        // Assert
        Assert.AreEqual("Invalid input. Please provide exactly three integer side lengths.\r\n", _output.ToString());
    }

    [Test]
    public void Main_InvalidInput_NonIntegerArguments()
    {
        // Arrange
        var args = new string[] { "3", "4", "abc" };

        // Act
        Program.Main(args);

        // Assert
        Assert.AreEqual("Invalid input. Please provide exactly three integer side lengths.\r\n", _output.ToString());
    }

    [Test]
    public void Main_NotATriangle()
    {
        // Arrange
        var args = new string[] { "1", "2", "3" };

        // Act
        Program.Main(args);

        // Assert
        Assert.AreEqual("Not a triangle\r\n", _output.ToString());
    }

    [Test]
    public void Main_EquilateralTriangle()
    {
        // Arrange
        var args = new string[] { "3", "3", "3" };

        // Act
        Program.Main(args);

        // Assert
        Assert.AreEqual("The type of triangle is: Equilateral\r\n", _output.ToString());
    }

    [Test]
    public void Main_IsoscelesTriangle()
    {
        // Arrange
        var args = new string[] { "3", "3", "4" };

        // Act
        Program.Main(args);

        // Assert
        Assert.AreEqual("The type of triangle is: Isosceles\r\n", _output.ToString());
    }

    [Test]
    public void Main_ScaleneTriangle()
    {
        // Arrange
        var args = new string[] { "3", "4", "5" };

        // Act
        Program.Main(args);

        // Assert
        Assert.AreEqual("The type of triangle is: Scalene\r\n", _output.ToString());
    }

    [Test]
    public void Main_InvalidInput_ZeroOrNegativeSides()
    {
        // Arrange
        var args = new string[] { "0", "-1", "5" };

        // Act
        Program.Main(args);

        // Assert
        Assert.AreEqual("Not a triangle\r\n", _output.ToString());
    }

    [Test]
    public void Main_ValidInput_LargeNumbers()
    {
        // Arrange
        var args = new string[] { "1000000", "1000000", "1000000" };

        // Act
        Program.Main(args);

        // Assert
        Assert.AreEqual("The type of triangle is: Equilateral\r\n", _output.ToString());
    }

    [Test]
    public void Main_ValidInput_FloatingPointNumbers()
    {
        // Arrange
        var args = new string[] { "3.5", "3.5", "3.5" };

        // Act
        Program.Main(args);

        // Assert
        Assert.AreEqual("Invalid input. Please provide exactly three integer side lengths.\r\n", _output.ToString());
    }
}
