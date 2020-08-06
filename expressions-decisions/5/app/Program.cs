using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      Console.Write("Input a three character month code (eg: JUL): ");
      string userInput = Console.ReadLine();
      int result = Calculate(userInput);

      Console.WriteLine(String.Format("\nThere are {0} days", result));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    // Citation
    // https://docs.microsoft.com/en-us/dotnet/api/system.datetime.daysinmonth?view=netcore-3.1
    //
    // Handy dandy little function that I totally forgot existed. Does what it says right on the tin.
    public static int Calculate(string input)
    {
      int monthCode = 0;
      int year = DateTime.Now.Year;

      string abbrevMonth = input.Trim().ToLower();
      switch(abbrevMonth)
      {
        case "jan":
         monthCode = 1;
        break;
        case "feb":
          monthCode = 2;
          // Kind of an ugly hack but it gets the job done.
          // Should pull this out and test for feb in main
          // that way we pass year to this function and its
          // possible to test it.
          Console.Write("You entered February, what year? ");
          year = int.Parse(Console.ReadLine());
        break;
        case "mar":
         monthCode = 3;
        break;
        case "apr":
         monthCode = 4;
        break;
        case "may":
         monthCode = 5;
        break;
        case "jun":
         monthCode = 6;
        break;
        case "jul":
         monthCode = 7;
        break;
        case "aug":
         monthCode = 8;
        break;
        case "sep":
         monthCode = 9;
        break;
        case "oct":
         monthCode = 10;
        break;
        case "nov":
         monthCode = 11;
        break;
        case "dec":
         monthCode = 12;
        break;
        default:
          throw new ArgumentException("Unknown Month");
      }

      return DateTime.DaysInMonth(year, monthCode);
    }
  }
}
