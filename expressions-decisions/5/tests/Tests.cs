using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate()
    {
      string input = "aug";
      int expected = 31;

      int result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }
  }
}
