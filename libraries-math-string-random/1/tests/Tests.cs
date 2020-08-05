using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate()
    {
      string input = "Hello Moto";
      string expected = "HELLO MOTO";

      string result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }
  }
}
