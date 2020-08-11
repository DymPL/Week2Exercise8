using System;
using System.ComponentModel.DataAnnotations;

namespace Week2Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week2Exercise8! \r\n");

            //Exe1();
            //Exe2();
            //Exe3();
            //Exe4();
            //Exe5();
            //Exe6();
            Exe7();
        }

        static public void Exe1()
        {
            bool first = true;
            int counter = 0;

            Console.WriteLine("Ile jest liczb pierwszych w przedziale 0 - 100");

            for (int i = 1; i <= 100; i++)
            {
                first = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        first = false;
                    }
                }

                if (first == true)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Wynik: {counter}");
        }

        static public void Exe2()
        {
            Console.WriteLine("Liczby parzyste z zakresu 0 – 1000");
            int counter = 0;
            int even = 0;
            do
            {
                if (even % 2 == 0)
                {
                    counter++;
                }

                ++even;
            } while (even <= 1000);

            Console.WriteLine($"Wynik: {counter}");
        }

        static public void Exe3()
        {
            int first = 0;
            int second = 1;
            int Fibonacci = 19;

            for (int i = 1; i < Fibonacci; i++)
            {
                int result = first + second;
                Console.WriteLine(result + " ");

                first = second;
                second = result;
            }

        }

        static public void Exe4()
        {
            Console.WriteLine("Podaj liczbę: ");
            int number = Int32.Parse(Console.ReadLine());

            int piramid = 0;
            int value = 0;
            while (value < number)
            {
                for (int i = 0; i < piramid; i++)
                {
                    value++;
                    Console.Write(value);
                    if (value >= number)
                        return;
                }

                Console.WriteLine();
                piramid++;
            }
        }

        static public void Exe5()
        {
            int maxNumber = 20;

            for (int i = 1; i <= maxNumber; i++)
            {
                double power = (Math.Pow(i, 3));
                Console.WriteLine($"{i} do 3 potęgi: " + power);
            }


        }

        static public void Exe6()
        {
            int maxNumber = 20;
            double sum = 0;

            for (double i = 1; i <= maxNumber; i++)
            {
                sum = sum + 1 / i;
            }

            Console.WriteLine(sum);
        }

        static public void Exe7()
        {
            int i, j, k, n;
            Console.WriteLine("Podaj długość: ");
            n = Int32.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (k=1; k<=n-i; k++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (i = 1; i <=n-1; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }

                for (j = n-1; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}
