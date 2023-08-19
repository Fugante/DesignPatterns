using Ducks.Ducks;


namespace Ducks.Tests;


[TestClass]
public class DucksTests
{
    [TestMethod]
    public void TestMallardDuck()
    {
        MallardDuck duck = new();
        duck.PerformQuack();
        duck.PerformFly();
        // Assert.IsTrue(true);
    }
}