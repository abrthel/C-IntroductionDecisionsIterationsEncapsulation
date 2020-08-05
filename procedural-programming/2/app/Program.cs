using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      Console.Write("Enter bill total: ");
      string rawBillTotal = Console.ReadLine();

      Console.Write("Divide amongst how many diners? ");
      string rawDinerCount = Console.ReadLine();

      double result = Calculate(rawBillTotal, rawDinerCount);

      Console.WriteLine(String.Format("Each party should pay: ${0}", result));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static double Calculate(string rawBillTotal, string rawDinerCount)
    {
      double billTotal = double.Parse(rawBillTotal.Trim());
      int dinerCount = int.Parse(rawDinerCount.Trim());

      return billTotal / (double)dinerCount;
    }
  }
}
