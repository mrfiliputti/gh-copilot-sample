using Calculator;
namespace ToolsTest;

[TestClass]
public class SimpleCalcTests
{
    [TestMethod]
    public void TestAdd()
    {
        // Arrange
        int a = 5;
        int b = 10;

        // Act
        int result = SimpleCalc.Add(a, b);

        // Assert
        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void TestSubtract()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        int result = SimpleCalc.Subtract(a, b);

        // Assert
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void TestMultiply()
    {
        // Arrange
        int a = 5;
        int b = 10;

        // Act
        int result = SimpleCalc.Multiply(a, b);

        // Assert
        Assert.AreEqual(50, result);
    } 
}