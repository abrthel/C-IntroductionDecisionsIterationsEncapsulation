using System;

namespace App
{
  public class Program
  {
    private const double NUM_POST_PER_PAINT_BUCKET = 4;

    static void Main()
    {
      Console.Write("How many fence posts do you have? ");
      string userInput = Console.ReadLine();
      int result = Calculate(userInput);

      Console.WriteLine(String.Format("\nYou will need '{0}' paint buckets", result));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static int Calculate(string input)
    {
      double fencePosts = double.Parse(input.Trim());
      return (int)Math.Ceiling(fencePosts / NUM_POST_PER_PAINT_BUCKET);
    }
  }
}
