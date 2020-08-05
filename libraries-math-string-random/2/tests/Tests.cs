using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate()
    {
      string input = "2, 1, 4";
      int[] expected = new int[] {1, 4};

      int[] result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }
  }
}
