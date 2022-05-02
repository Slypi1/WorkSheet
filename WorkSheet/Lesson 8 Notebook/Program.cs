using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace Lesson_8_Notebook
{
    class Program
    {

        static void AddPerson(List<Person> persons, string path)
        {
            Person person = new Person();

            Console.Write("ФИО: ");
            person.LastName = Console.ReadLine();

            Console.Write("Улица: ");
            person.Street = Console.ReadLine();

            Console.Write("Номер дома: ");
            person.NumberHouse = int.Parse(Console.ReadLine());

            Console.Write("Номер квартиры: ");
            person.NumberFlat = int.Parse(Console.ReadLine());

            Console.Write("Мобильный телефон: ");
            person.MobPhone = int.Parse(Console.ReadLine());

            Console.Write("Домашний телефон: ");
            person.HomePhone = int.Parse(Console.ReadLine());
         

            persons.Add(new Person(person.LastName, person.Street, person.NumberHouse, person.NumberFlat, person.MobPhone, person.HomePhone));

           SerializationPerson(persons, path);
        }
        static void SerializationPerson(List<Person> persons, string path)
        {
            for (int i = 0; i < persons.Count; i++)
            {

                XDocument temp = new XDocument(new XElement("Person",
                                 new XAttribute("Name", persons[i].LastName),
                                 new XElement("Adress",
                                     new XElement("Street", persons[i].Street),
                                     new XElement("NumberHouse", persons[i].NumberHouse),
                                     new XElement("NumberFlat", persons[i].NumberFlat)),
                                 new XElement("Phones",
                                     new XElement("MobilePhone", persons[i].MobPhone),
                                     new XElement("HomePhone", persons[i].HomePhone))));
                temp.Save(path);

            }


        }

        static void Main(string[] args)
            {
                List<Person> person = new List<Person>();
                string Path = "notebook.xml";
                AddPerson(person, Path);    
                Console.ReadKey();
            }

        }
    
}