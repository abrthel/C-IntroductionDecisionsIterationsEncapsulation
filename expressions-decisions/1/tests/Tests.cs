using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate_B_Is_Closer()
    {
      string aRawInput = "5";
      string bRawInput = "4";
      int answer = 2;

      string expected = "2 - User B Wins!";

      string result = App.Program.Calculate(aRawInput, bRawInput, answer);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Calculate_A_Is_Closer()
    {
      string aRawInput = "5";
      string bRawInput = "4";
      int answer = 6;

      string expected = "6 - User A Wins!";

      string result = App.Program.Calculate(aRawInput, bRawInput, answer);

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Calculate_Same_Distance()
    {
      string aRawInput = "4";
      string bRawInput = "6";
      int answer = 5;

      string expected = "Draw!";

      string result = App.Program.Calculate(aRawInput, bRawInput, answer);

      Assert.AreEqual(expected, result);
    }
  }
}
