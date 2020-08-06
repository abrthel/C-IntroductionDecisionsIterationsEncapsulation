using System;
using System.Collections.Generic;

namespace App
{
  public class Program
  {
    static void Main()
    {
      bool retry = true;

      do
      {
        List<int> marks = new List<int>(20);

        for(int i=0; i < 20; i++)
        {
          Console.Write(String.Format("Enter mark {0}: ", i + 1));
          int input = int.Parse(Console.ReadLine().Trim());

          if(input == -1) {  break; }
          if(input < -1 || input > 100)
          {
            i--;
            continue;
          }
          marks.Add(input);
        }

        if(marks.Count < 1)
        {
          Console.Write("At least one mark must be entered.");
          continue;
        }

        int[] result = Calculate(marks);
        Console.WriteLine(String.Format("Min Score: {0}, Max Score: {1}, Average: {2}", result[0], result[1], result[2]));

        Console.Write("\nWould you like to try again? (yes/no): ");
        string retryInput = Console.ReadLine().Trim().ToLower();

        if(retryInput != "yes") { retry = false; }
      } while (retry);
    }

    public static int[] Calculate(IList<int> marks)
    {
      int min = -2;
      int max = 0;
      int sum = 0;

      foreach(int mark in marks)
      {
        if(min == -2) {
          min = mark;
          max = mark;
        }

        if(mark < min) { min = mark; }
        if(mark > max) { max = mark; }
        sum += mark;
      }

      int avg = sum / marks.Count;
      return new int[] { min, max, avg };
    }
  }
}
