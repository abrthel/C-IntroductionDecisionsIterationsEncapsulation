using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate_Raises_Input_To_Power_Of_Three()
    {
      string input = "2";
      int expected = 8;

      int result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }
  }
}
