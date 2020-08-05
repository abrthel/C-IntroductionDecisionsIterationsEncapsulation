using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate()
    {
      string result = App.Program.Calculate();

      // Make sure the result is 5 characters long
      Assert.AreEqual(result.Length, 5);

      // Ensure the result matches its uppercased version
      Assert.AreEqual(result, result.ToUpper());

      // TODO: Test that result only contains alphanumeric characters.
    }
  }
}
