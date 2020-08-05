using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      string result = Calculate();

      Console.WriteLine(String.Format("\nRandom password is: {0}", result));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    // Citation
    // https://www.asciitable.com/
    // Had to lookup ASCII code range for uppercase alphanumeric characters

    // Citation
    // https://docs.microsoft.com/en-us/dotnet/api/system.convert.tochar?view=netcore-3.1#System_Convert_ToChar_System_Int64_
    // Couldn't remember how C# converted ints to chars.
    public static string Calculate()
    {
      string password = "";
      Random r = new Random();

      for(int i=0; i < 5; i++)
      {
        char letter = Convert.ToChar(r.Next(65, 90));
        password = string.Concat(password, letter);
      }

      return password;
    }
  }
}
