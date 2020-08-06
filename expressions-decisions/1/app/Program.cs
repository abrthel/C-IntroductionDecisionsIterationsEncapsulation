using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      Console.Write("User A, guess a number: ");
      string userAInput = Console.ReadLine();

      Console.Write("User B, guess a number: ");
      string userBInput = Console.ReadLine();

      string result = Calculate(userAInput, userBInput);

      Console.WriteLine(String.Format("\n{0}", result));

      do
      {
        Console.WriteLine("\nPress the Enter Key to end this program...");
      } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    // Citation
    // https://stackoverflow.com/questions/5063269/c-sharp-random-next-never-returns-the-upper-bound
    // Random.Next apparently has a wonderful quirk where the min is inclusive but max is exclusive.
    // Almost didn't check for exclusivity (see libs question 5) - kudos to the person who wrote this
    // questions and tried to trip everyone up. Sneaky Sneaky.
    public static string Calculate(string aRaw, string bRaw, int answer=0)
    {
      int a = int.Parse(aRaw.Trim());
      int b = int.Parse(bRaw.Trim());

      if(answer == 0)
      {
        Random r = new Random();
        answer = r.Next(1, 11);
      }

      // We use Math.Abs to ignore pos/neg signs
      int aDistance = Math.Abs(a-answer);
      int bDistance = Math.Abs(b-answer);

      if(aDistance == bDistance) { return "Draw!"; }

      string winner = aDistance < bDistance ? "A" : "B";
      return String.Format("{0} - User {1} Wins!", answer, winner);
    }
  }
}
