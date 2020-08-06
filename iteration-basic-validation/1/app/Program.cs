using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      int number = 0;
      while( number < 1 || number > 10)
      {
        Console.Write("Enter a number between 1 and 10: ");
        number = int.Parse(Console.ReadLine());
      }

      Console.WriteLine(String.Format("\nCongrats! You entered {0}", number));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }
  }
}
