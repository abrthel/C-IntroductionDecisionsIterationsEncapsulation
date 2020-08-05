using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate_Raises_Input_To_Power_Of_Three()
    {
      string input = "1234";
      int expected = 10;

      int result = App.Program.Calculate(input);

      Assert.AreEqual(expected, result);
    }
  }
}
