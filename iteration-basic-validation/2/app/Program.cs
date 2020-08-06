using System;

namespace App
{
  public class Program
  {
    static void Main()
    {
      do
      {
        Console.Write("\nHello ");
      } while (Console.ReadLine().Trim().ToLower() != "stop");
    }
  }
}
