using System;

namespace Loopar
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv A:");

      string s = "";

      while (s != "A" && s != "B" && s != "C")
      {
        s = Console.ReadLine();

        if (s != "A" && s != "B" && s != "C")
        {
          Console.WriteLine("NO U STUPID! ONLY A B OR C ALLOWED");
        }

      }

      Console.WriteLine("WELL DONE!");


      Console.ReadLine();

    }
  }
}
