using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate_perfect_square()
    {
      string input = "9";
      bool expected = true;

      bool result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Calculate__not_a_perfect_square()
    {
      string input = "13";
      bool expected = false;

      bool result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }
  }
}
