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

            float sum = a + a2;
            Console.WriteLine($"The sum of {a} and {a2} is {sum}");
        }
    }
}
