using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      Console.Write("Length of side A? ");
      string sideARaw = Console.ReadLine();
      Console.Write("Length of side B? ");
      string sideBRaw = Console.ReadLine();

      double result = Calculate(sideARaw, sideBRaw);

      Console.WriteLine(String.Format("\n{0}", result));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static double Calculate(string sideARaw, string sideBRaw)
    {
      double a = double.Parse(sideARaw.Trim());
      double b = double.Parse(sideBRaw.Trim());

      double c = Math.Sqrt(a*a + b*b);
      return Math.Round(c, 2);
    }
  }
}
