﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            while (a >= 2 && a <= 8)
            {
                Console.WriteLine(a);
                a = a + 1;
            }

            int b = 10;
            while (b >= 10 && b <= 20)
            {
                Console.WriteLine(b);
                b = b + 2;
            }

            int c = 0;
            do
            {
                Console.WriteLine("Enter a number greater than 50:");
                c = Convert.ToInt32(Console.ReadLine());
            } while (c < 50);

            int d = 0;
            do
            {
                Console.WriteLine("Enter another number that when squared is greater than 50:");
                d = Convert.ToInt32(Console.ReadLine());
            } while (d * d < 50);

            int e = 0;
            do
            {
                Console.WriteLine("Enter a number that is between 1 and 10:");
                e = Convert.ToInt32(Console.ReadLine());
            } while (e < 1 || e > 10);

            int f = 0;
            do
            {
                Console.WriteLine("Enter another number that is greater than 10 or less than 5:");
                f = Convert.ToInt32(Console.ReadLine());
            } while (f <= 10 && f >= 5);

            int guess = 0;
            Random rnd = new Random();
            int new1 = rnd.Next(1, 100);
            int guesses = 0;
            Console.WriteLine("Guess the number between 1 and 100:");
            guess = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (guess > new1)
                {
                    Console.WriteLine("Lower");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if (guess < new1)
                {
                    Console.WriteLine("Higher");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                guesses = guesses + 1;
            } while (guess != new1);

            if (guesses == 1)
            {
                Console.WriteLine("Well done you guessed it immediately!");
            }
            else
            {
                Console.WriteLine("Well done you guessed it in {0} guesses!", guesses);
            }
            Console.ReadLine();
        }
    }
}
