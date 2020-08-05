using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate()
    {
      string sideAInput = "10";
      string sideBInput = "5";
      double expected = 11.18;

      double result = App.Program.Calculate(sideAInput, sideBInput);

      Assert.AreEqual(expected, result);
    }
  }
}
