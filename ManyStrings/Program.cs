using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string existence = "\"to be or not to be\" that is the question \u2753";
            string lyrics = "\" If you tried just a little more times, I would've made you a believer\" by Lisa \u2734";
            string quote ="\' I have a dream\' by Martin Luther King Jr. \u270B";

            Console.WriteLine(existence);
            Console.WriteLine(lyrics);
            Console.WriteLine(quote);
        }
    }
}
