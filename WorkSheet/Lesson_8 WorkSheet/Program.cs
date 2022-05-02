using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_WorkSheet
{

    internal class Program
    {
        /// <summary>
        /// Заполнения List рандомными числами 
        /// </summary>
        /// <param name="list"></param>
        static void FilingList (List <int> list )
        {
            Random rand = new Random ();
            for (int i = 0; i < 100; i++)
            {
                list.Add (rand.Next (100));
            }
            Print (list);

        }
        /// <summary>
        /// Вывод на консоль
        /// </summary>
        /// <param name="list"></param>
        static void Print (List <int> list )
        {
            
            
            
            for (int i = 0; i < list.Count; i++)
                Console.Write($"\t{list[i]}");

        }
        /// <summary>
        /// Удаление чисел в промежутки от 25 до 50
        /// </summary>
        /// <param name="list"></param>
        static void DelNumberInterval (List <int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    if (list[i] > 25 && list[i] < 50)
                        list.RemoveAt(i);
                    if (list[j-1] > 25 && list[j-1] < 50)
                        list.RemoveAt(j-1);
                }
                
            }
            
            Print (list);

        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Данные: ");
            FilingList(list);
            Console.WriteLine("\tПосле удаления чисел от 25 до 50: ");
            DelNumberInterval(list);

            Console.ReadKey();
        }
    }
}
