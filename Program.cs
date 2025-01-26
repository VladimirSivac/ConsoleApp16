using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    /// <summary>
    /// Вывести на экран прямоугольник вида □, обрамленный символами (например, 16 на 16) и пустой внутри.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Главный метод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           Func(16, 16);
        }
        /// <summary>
        /// Дополнительный метод для вывода прямоугольника
        /// </summary>
        /// <param name="width">Ширина прямоугольника</param>
        /// <param name="height">Высота прямоугольника</param>
        static void Func(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}