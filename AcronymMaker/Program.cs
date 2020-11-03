using System;

namespace AcronymMaker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a multi-word term");
            string input=Console.ReadLine();
          input=input.ToUpper();
          string[] words=input.Split();
          foreach(string s in words)
          {
            Console.Write(s[0]);
          }
        }

    }
}