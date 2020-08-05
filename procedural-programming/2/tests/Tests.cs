using NUnit.Framework;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate_Diner_Bill_Split_Evenly_Among_Participants()
    {
      string billTotal = "42.23";
      string dinerCount = "4";

      double expected = 10.5575;

      double result = App.Program.Calculate(billTotal, dinerCount);

      Assert.AreEqual(expected, result);
    }
  }
}
