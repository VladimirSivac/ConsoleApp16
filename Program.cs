using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    /// <summary>
    /// Вывести на экран 4 горизонтальные строки, каждая из которых состоит из 7 символов, отделенных друг от друга пустыми строками.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Основной метод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        /// <summary>
        /// Дополнительный метод для вывода 4-х горизонтальных строк
        /// </summary>
        static void Func()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}