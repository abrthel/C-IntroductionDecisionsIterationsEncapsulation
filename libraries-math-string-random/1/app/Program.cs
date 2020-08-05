using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      Console.Write("Input a string: ");
      string userInput = Console.ReadLine();
      string result = Calculate(userInput);

      Console.WriteLine(String.Format("\n{0}", result));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static string Calculate(string input)
    {
      return input.Trim().ToUpper();
    }
  }
}
