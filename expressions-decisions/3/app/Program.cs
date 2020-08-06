using System;

namespace App
{
  public class Program
  {
    // Citation
    // https://en.wikipedia.org/wiki/Square_number
    // Had to look up what a perfect square was.
    // It's a number that when sqrt'd has no decimal places and is a positive number
    static void Main()
    {
      Console.Write("Input a number: ");
      string userInput = Console.ReadLine();
      bool result = Calculate(userInput);

      if(result)
      {
        Console.WriteLine(String.Format("\n{0} is a perfect square", userInput));
      }
      else
      {
        Console.WriteLine(String.Format("\n{0} is not a perfect square", userInput));
      }

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static bool Calculate(string input)
    {
      double number = double.Parse(input.Trim());
      if (number < 0) { return false; }

      double sqrt = Math.Sqrt(number);
      double squared = Math.Pow((int)sqrt, 2);

      return squared == number;
    }
  }
}
