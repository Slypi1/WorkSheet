using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Repeat_Check
{
    internal class Program
    {
        /// <summary>
        /// Добавление нового числа
        /// </summary>
        /// <param name="data"></param>
        static void Add (HashSet<int> data)
        {
            
            int Number;
            string Proverka;
            while (true)
            {
                Console.Write("Введите число: ");
                Proverka = Console.ReadLine();
                if (!(Proverka == " "))
                {
                    Number = Convert.ToInt32(Proverka);
                    if (!(data.Contains(Number)))
                        data.Add(Number);
                    else
                        Console.WriteLine("Данное число есть в коллекции. ");
                }
                else break;
                
            }

           

        }
        static void Main(string[] args)
        {
            HashSet<int> Numbers = new HashSet<int>();
            Add(Numbers);
            Console.ReadKey();
        }
    }
}
