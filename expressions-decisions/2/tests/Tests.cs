using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate_even()
    {
      string input = "34";
      string expected = "even";

      string result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Calculate_odd()
    {
      string input = "25";
      string expected = "odd";

      string result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }
  }
}
