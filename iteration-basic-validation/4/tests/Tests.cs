using NUnit.Framework;
using System.Collections.Generic;

namespace tests
{
  public class Tests
  {
    [Test]
    public void Calculate()
    {
      List<int> input = new List<int> { 3, 4, 9, 10, 3, 5, 10, 56, 32, 6 };
      int expectedMin = 3;
      int expectedMax = 56;
      int expectedAvg = 13;

      int[] result = App.Program.Calculate(input);

      Assert.AreEqual(expectedMin, result[0]);
      Assert.AreEqual(expectedMax, result[1]);
      Assert.AreEqual(expectedAvg, result[2]);
    }
  }
}
