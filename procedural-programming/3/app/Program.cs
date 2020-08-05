using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      Console.Write("How old are you? ");
      string userInput = Console.ReadLine();
      int result = Calculate(userInput);

      Console.WriteLine(String.Format("\nYou were born in: {0}", result));


      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static int Calculate(string input)
    {
      int age = int.Parse(input.Trim());
      return DateTime.Now.Year - age;
    }
  }
}
