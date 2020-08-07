using System;

namespace App
{
  public class Program
  {
    // Some notes:
    // Lots of duplication. Should extract each config prompt into a command like object
    // where we can then group validation and reuse error handling & retry logic.
    //
    // Should relocate parsing logic into the validation logic (not as a general pattern but for this
    // individual project) to reduce iterations and to keep validation code closer together.
    //
    // No custom error when not enough words/numbers have been entered. Should add it but
    // this is a toy app and in reality I wouldn't write this app like this.
    static void Main()
    {
      int[] divisors = new int[] { 3, 5, 9 };
      string[] words = new string[] { "Fizz", "Buzz", "FizzBuzz" };
      int start = 0;
      int end = 0;
      bool retry = false;

      Console.Write("Would you like to configure the program (yes/no)? ");
      if(Console.ReadLine().Trim().ToLower() == "yes")
      {

        // Get Divisors Input
        do
        {
          retry = false;
          try
          {
            Console.Write("Enter three numbers as a comma seperated list (eg: 3,4,5): ");
            string[] divisorsRawInput = Console.ReadLine().Split(',');
            for(int i=0; i < 3; i++)
            {
              divisors[i] = int.Parse(divisorsRawInput[i].Trim());
            }
            ValidateDivisors(divisors);
          }
          catch(Exception ex)
          {
            Console.WriteLine(ex.Message);
            retry = true;
          }
        } while(retry);

        // Get Words input
        do
        {
          retry = false;
          try
          {
            Console.Write("Enter three words as comma seperated list (eg: apple, orange, pear): ");
            string[] wordsRawInput = Console.ReadLine().Split(',');
            for(int i=0; i < 3; i++)
            {
              words[i] = wordsRawInput[i].Trim();
            }
            ValidateWords(words);
          }
          catch(Exception ex)
          {
            Console.WriteLine(ex.Message);
            retry = true;
          }
        } while(retry);

        // Get start/end number input
        do
        {
          retry = false;
          try
          {
            Console.Write("Enter a starting number: ");
            start = int.Parse(Console.ReadLine());

            Console.Write("Enter an ending number: ");
            end = int.Parse(Console.ReadLine());
            ValidateStartEnd(start, end);
          }
          catch(Exception ex)
          {
            Console.WriteLine(ex.Message);
            retry = true;
          }

        } while(retry);

      }

      for(int i=start; i < end+1; i++)
      {
        string result = FizzBuzz(i, divisors, words);
        Console.WriteLine(result);
      }

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    public static void ValidateStartEnd(int start, int end)
    {
      if(start > end)
      {
        throw new ArgumentException("Starting number should come before ending number.");
      }

      if(start <= 0 || end <= 0)
      {
        throw new ArgumentException("Starting or ending number must be greater than 0");
      }

      if((end-start) > 100)
      {
        throw new ArgumentException("Starting number and ending number span should not be greater than 100");
      }
    }

    public static void ValidateDivisors(int[] divisors)
    {
      for(int i=0; i<divisors.Length; i++)
      {
        if(divisors[i] < 2)
        {
          throw new ArgumentException("Divisors must be greater than 2");
        }

        for(int x=i+1; x < divisors.Length; x++)
        {
          if(divisors[i] == divisors[x])
          {
            throw new ArgumentException("Divisors must be unique.");
          }
        }
      }
    }

    public static void ValidateWords(string[] words)
    {
      for(int i=0; i < words.Length; i++)
      {
        if(String.IsNullOrWhiteSpace(words[i]))
        {
          throw new ArgumentException("Words must have at least one alphanumeric character or number.");
        }

        for(int x=i+1; x < words.Length; x++)
        {
          if(words[i] == words[x])
          {
            throw new ArgumentException("Words must be unique.");
          }
        }
      }
    }

    public static string FizzBuzz(int count, int[] divisors, string[] words)
    {
      int divA = divisors[0];
      int divB = divisors[1];
      int divC = divisors[2];

      string wordA = words[0];
      string wordB = words[1];
      string wordC = words[2];

      if(count % divA == 0)
      {
        return wordA;
      }

      if(count % divB == 0)
      {
        return wordB;
      }

      if((count % divC == 0))
      {
        return wordC;
      }

      return count.ToString();
    }
  }
}
