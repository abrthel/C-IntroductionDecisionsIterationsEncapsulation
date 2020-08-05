using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      Console.Write("Input 3 comma seperated numbers (eg: 1,5,3): ");
      string userInput = Console.ReadLine();
      int[] result = Calculate(userInput);

      Console.WriteLine(String.Format("\nHighest value is '{0}' and the lowest value is '{1}'", result[1], result[0]));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static int[] Calculate(string input)
    {
      string[] splitNumbersRaw = input.Split(',');

      // Assign default values to make the all-mighty compiler happy.
      int max = 0;
      int min = 0;

      for(int i=0; i < splitNumbersRaw.Length; i++)
      {
        int currNum = int.Parse(splitNumbersRaw[i].Trim());

        // First iteration, assign values to min/max
        if(i == 0)
        {
          max = currNum;
          min = currNum;
        }

        if(currNum > max) { max = currNum; }
        if(currNum < min) { min = currNum; }
      }

      return new int[] {min, max};
    }
  }
}
