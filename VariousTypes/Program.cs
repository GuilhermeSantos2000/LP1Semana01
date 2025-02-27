﻿using System;

namespace VariousTypes
{
    public class Program
    {
    
        private static void Main(string[] args)
        {
            Program program = new Program();

            int a = 1;
            int b = 1334;
            int c = 839;
            
            char smiley = '\u263A';
            char omega = '\u03A9';
            char heart = '\u2665';

            float d = 5.768f;
            double e = 4.3414;
            decimal f = 3.1415m;
            
            bool skyisblue = true;
            bool skyisorange = false;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            
            Console.WriteLine(smiley);
            Console.WriteLine(omega);
            Console.WriteLine(heart);

            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            
            Console.WriteLine(skyisblue);
            Console.WriteLine(skyisorange);
        }
    }
}
