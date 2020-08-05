using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      Console.Write("Enter a four digit number: ");
      string userInput = Console.ReadLine();
      int result = Calculate(userInput);

      Console.WriteLine(String.Format("\nThe sum of the digits are: {0}", result));


      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static int Calculate(string input)
    {
      int value = int.Parse(input.Trim());
      int sum = 0;

      while(value > 0)
      {
        // Extract the number from the ones place by shifting it
        // it a decimal and pulling it from the mod calc.
        // Add the result to the current sum.
        sum += value % 10;

        // Pop off the current ones place by dividing the current
        // value by 10 causing the original ones place to be lost
        // since int's can't hold decimals.
        value /= 10;
      }
      return sum;
    }
  }
}
