using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Phone_book
{
    internal class Program
    {
        /// <summary>
        /// Добавление записи
        /// </summary>
        /// <param name="data"></param>
        static void AddRecord (Dictionary<int, string> data)
        {
            
            string Proverka;
            int NumberPhone = 0;
            string LastName;
            while (true)
            {
                Console.Write("Введите номер телефона: ");
                Proverka = Console.ReadLine();
                if (!(Proverka == " "))
        
                {
                    NumberPhone = Convert.ToInt32(Proverka);
                   
                }
                else
                {
                    Console.Write("Введите ФИО: ");
                    LastName = Console.ReadLine();
                    break;
                }
            }
                data.Add(NumberPhone, LastName);
            
        }
        /// <summary>
        /// Ввывод  в консоль владельца номера телефона
        /// </summary>
        /// <param name="data"></param>
        static void RecordSearch(Dictionary<int, string> data)
        {

            Console.Write("Введите номер телефона для поиска: ");
            int NumberPhone =int.Parse( Console.ReadLine());
            string LastName = "";
           
           
                foreach (var values in data.Values)
                {
                    if (data.TryGetValue(NumberPhone, out LastName ))
                        Console.Write($"ФИО: {values}");

                    else
                        Console.WriteLine("С таким номер пользователя нет");
                }
           
           
         }

        static void Main(string[] args)
        {
            Dictionary<int, string> PhoneBook = new Dictionary<int, string>();
            AddRecord(PhoneBook);
            RecordSearch(PhoneBook);
            Console.ReadKey();
        }
    }
}
