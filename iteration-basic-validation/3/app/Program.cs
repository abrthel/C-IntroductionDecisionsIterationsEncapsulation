using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      int[] divisors = new int[] { 3, 5};
      string[] words = new string[] { "Fizz", "Buzz", "FizzBuzz" };

      for(int i=1; i < 100+1; i++)
      {
        string result = FizzBuzz(i, divisors, words);
        Console.WriteLine(result);
      }

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static string FizzBuzz(int count, int[] divisors, string[] words)
    {
      int divA = divisors[0];
      int divB = divisors[1];

      string wordA = words[0];
      string wordB = words[1];
      string wordC = words[2];

      if((count % divA == 0) && (count % divB == 0))
      {
        return wordC;
      }

      if(count % divA == 0)
      {
        return wordA;
      }

      if(count % divB == 0)
      {
        return wordB;
      }

      return count.ToString();
    }
  }
}
