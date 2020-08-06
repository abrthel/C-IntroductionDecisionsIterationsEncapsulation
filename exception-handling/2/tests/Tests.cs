using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate_addition()
    {
      string input = "1+1";
      double expected = 2;

      double result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Calculate_subtraction()
    {
      string input = "10 - 5";
      double expected = 5;

      double result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Calculate_multiplication()
    {
      string input = "9 * 9";
      double expected = 81;

      double result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Calculate_division()
    {
      string input = "81 / 9";
      double expected = 9;

      double result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Calculate_decimal()
    {
      string input = "22 / 3";
      double expected = (double)22/3; // 7.3333

      double result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }
  }
}
