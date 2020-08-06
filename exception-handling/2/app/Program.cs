using System;
using System.Text.RegularExpressions;

namespace App
{
  public class Program
  {
    // Capture 1 or more digits followed by an optional '.' literal with one or more digits
    // ignore whitespace, Capture any one of *,/,+,- Ignore whitespace again then Capture 1
    // or more digits followed by an optional '.' literal with one or more digits.
    private static Regex expRegex = new Regex(@"(\d+)\W*([\+\-\*\/])\W*(\d+)", RegexOptions.Compiled);

    static void Main()
    {
      bool retry = false;
      double result = -1;
      do
      {
        retry = false;
        try
        {
          Console.Write("Input a simple math expression (eg: 5*5): ");
          string userInput = Console.ReadLine();
          result = Calculate(userInput);
        }
        catch(Exception ex)
        {
          Console.WriteLine(String.Format("Error: {0}", ex.Message));
          retry = true;
        }
      } while(retry);

      Console.WriteLine(String.Format("\nAnswer is {0}", result));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    // Citation
    // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.matchcollection?view=netcore-3.1
    // Needed help wih the Match/Capture Group API
    public static double Calculate(string input)
    {
      GroupCollection captureGroups = expRegex.Match(input).Groups;

      int a = int.Parse(captureGroups[1].Value.Trim());
      int b = int.Parse(captureGroups[3].Value.Trim());
      string op = captureGroups[2].Value.Trim();

      switch(op)
      {
        case "+":
          return (double)a + b;
        case "-":
          return (double)a - b;
        case "*":
          return (double)a * b;
        case "/":
          if(b == 0) { throw new ArgumentException("Cannot divide by 0."); }
          return (double)a / b;
        default:
         throw new ArgumentException("Invalid expression sign");
      }
    }
  }
}
