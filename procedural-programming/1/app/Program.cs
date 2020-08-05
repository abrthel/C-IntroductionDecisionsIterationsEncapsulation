using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a number: ");
      string userInput = Console.ReadLine();
      int result = Calculate(userInput);

      Console.WriteLine(String.Format("Your number cubed is: {0}", result));


      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static int Calculate(string input)
    {
      int value = int.Parse(input.Trim());
      return value * value * value;
    }
  }
}
