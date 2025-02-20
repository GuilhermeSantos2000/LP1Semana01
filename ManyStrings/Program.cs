using System;
using System.Security.Cryptography;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;

            string x1 = $"{xx:f2}";
            string x2 = $"{xx:p1}";
            string i1 = $"{ii:x}";
            string i2 = $"{ii:c}";

            string existence = "\"to be or not to be\" that is the question \u2753";
            string lyrics = "\" If you tried just a little more times, I would've made you a believer\" by Lisa \u2734";
            string quote ="\'I have a dream\' by Martin Luther King Jr. \u270B";

            string name ="John";
            string surname = "Doe";
            string fullname = name + " " + surname;
            string withmiddlename = name + " Diddly " + surname;
            int age = 25;
            string namewithage = fullname + " " + 25;
            string statement = $"O sobrenome do {name} é {surname}";
            string statement2 = $"A idade do {fullname} é {age}";

            Console.WriteLine(existence);
            Console.WriteLine(lyrics);
            Console.WriteLine(quote);

            Console.WriteLine(fullname);
            Console.WriteLine(withmiddlename);
            Console.WriteLine(namewithage);
            Console.WriteLine(statement);
            Console.WriteLine(statement2);
            
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(i1);
            Console.WriteLine(i2);
        }
    }
}
