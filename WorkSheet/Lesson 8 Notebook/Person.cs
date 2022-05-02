using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lesson_8_Notebook
{
    public class Person
    {
        public Person()
        {

        }
        private string lastName;
        private string street;
        private int numberFlat;
        private int numberHouse;
        private int mobPhone;
        private int homePhone;
        /// <summary>
        /// Создание нового контакта
        /// </summary>
        /// <param name="LastName"></param>
        /// <param name="Street"></param>
        /// <param name="NumberHouse"></param>
        /// <param name="NumberFlat"></param>
        /// <param name="MobPhone"></param>
        /// <param name="HomePhone"></param>
        public Person(string LastName, string Street, int NumberHouse, int NumberFlat, int MobPhone, int  HomePhone)
        {
            this.lastName = LastName;
            this.street = Street;
            this.numberHouse = NumberHouse;
            this.numberFlat = NumberFlat;
            this.mobPhone = MobPhone;
            this.homePhone = HomePhone;
        }
      
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public string Street { get { return this.street; } set { this.street = value;} }
        public int NumberHouse { get { return this.numberHouse; } set { this.numberHouse = value; } }
        public int NumberFlat { get { return this.numberFlat; } set { this.numberFlat = value; } }
        public int MobPhone { get { return this.mobPhone; } set { this.mobPhone = value; } }
        public int HomePhone { get { return this.homePhone; } set { this.homePhone = value; } }

    }
}
