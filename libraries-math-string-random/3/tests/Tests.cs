using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate()
    {
      string input = "6";
      int expected = 2;

      int result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }
  }
}
