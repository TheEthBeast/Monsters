using System;
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
                Console.WriteLine("Enter a number:");
                c = Convert.ToInt32(Console.ReadLine());
            } while (c < 50);

            int d = 0;
            do
            {
                Console.WriteLine("Enter another number:");
                d = Convert.ToInt32(Console.ReadLine());
            } while (d * d < 50);

            int e = 0;
            do
            {
                Console.WriteLine("Enter a number:");
                e = Convert.ToInt32(Console.ReadLine());
            } while (e < 1 || e > 10);

            int f = 0;
            do
            {
                Console.WriteLine("Enter another number:");
                f = Convert.ToInt32(Console.ReadLine());
            } while (f <= 10 && f >= 5);

            int guess = 0;
            Random rand = new Random();
            int new1 = rand.Next(1, 1000);

            Console.WriteLine("Enter a Number");
            guess = Convert.ToInt32(Console.ReadLine());

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

            Console.ReadLine();
        }
    }
}
