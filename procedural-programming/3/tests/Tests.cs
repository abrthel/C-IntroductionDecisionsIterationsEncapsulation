using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate()
    {
      string input = "28";
      int expected = 1992;

      int result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }
  }
}
