using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    /// <summary>
    /// Вывести числа в виде таблиц
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            A();
            B();
            C();
            D();
            Console.ReadKey();
        }
        /// <summary>
        /// Пункт а)
        /// </summary>
        static void A()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j);
                    if (j < 10)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
        /// <summary>
        /// Пункт б)
        /// </summary>
        static void B()
        {
            int value = 41;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(value);
                    if (j < 9)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write("\n");
                    }
                    value++;
                }
            }
        }
        /// <summary>
        /// Пункт в)
        /// </summary>
        static void C()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("5 ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Пункт г)
        /// </summary>
        static void D()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
            }
        }

    }
}