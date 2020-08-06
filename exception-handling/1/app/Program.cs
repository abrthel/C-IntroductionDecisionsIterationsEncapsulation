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
        try
        {
          Console.Write("Enter a number between 1 and 10: ");
          // Should really solve this with int.TryParse()
          number = int.Parse(Console.ReadLine());

          if(number < 1 || number > 10)
          {
            throw new ArgumentException("Number is outside of range 1-10.");
          }
        }
        catch(Exception ex)
        {
          // I get this is a learning exercise but throwing an exception just to catch
          // immediately hurts me deep in my soul :P
          Console.WriteLine(String.Format("Given number is invalid. {0}", ex.Message));
        }

      }

      Console.WriteLine(String.Format("\nCongrats! You entered {0}", number));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }
  }
}
