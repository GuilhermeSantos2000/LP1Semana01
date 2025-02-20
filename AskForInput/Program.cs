using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please write an Integer.");            
            string str = Console.ReadLine();
            int a = int.Parse(str);

            Console.WriteLine("Please write a Real Number.");            
            string str2 = Console.ReadLine();
            float a2 = float.Parse(str2);
        }
    }
}
