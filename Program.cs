using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    /// <summary>
    /// Вывести на экран наклонную линию (\) из 8 символов.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Основной метод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Func(8);
        }
        /// <summary>
        /// Дополнительный метод для вывода наклонной линии
        /// </summary>
        /// <param name="length">длина линии</param>
        static void Func(int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#");
            }
        }
    }
}