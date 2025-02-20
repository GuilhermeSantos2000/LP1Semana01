using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please write an integer.");
            
            string str = Console.ReadLine();
            int a = int.Parse(str);
        }
    }
}
