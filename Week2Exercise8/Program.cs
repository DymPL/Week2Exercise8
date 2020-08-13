using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;

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
            //Exe7();
            //Exe8();
            //Exe9();
            Exe10();
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

                for (j = 1; j <= 2* i -1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (i = 1; i <=n-1; i++)
            {
                for (k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }

                for (j = n-1; j >= 2*i-n+1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
        static public void Exe8()
        {
            Console.WriteLine("Podaj słowo: ");
            string text = Console.ReadLine();
            string reverse = "";

            for (int i = text.Length -1; i>=0  ; i--)
            {
               reverse = string.Concat(reverse, text[i]);
            }
               Console.WriteLine(reverse);
        }
        static public void Exe9()
        {
            Console.WriteLine("Podaj liczbę dziesiątną: ");
            int number = int.Parse(Console.ReadLine());
            int i = 0;
            int[] binary = new int[32];

            while(number != 0)
            {
                binary[i++] = number % 2;
                number = number / 2;
            }
            Console.WriteLine("Liczba binarna to: ");
            for (int j = i-1; j>=0; j--)
            {
                Console.Write(binary[j]);
            } 
        }
        static public void Exe10()
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            int second = int.Parse(Console.ReadLine());

            int i = first;

            while (i % second !=0)
            {
                i += first;
            }
            Console.WriteLine($"NWW: {i}");

        }
    }
}
