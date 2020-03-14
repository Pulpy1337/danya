using System;
using System.Collections.Generic;
using System.Text;

namespace ListTemplate
{
    class MyPerson
    {
        // Поля класса
        private int age;
        private bool gender;
        private string name;

        // Свойства для доступа к полям
        public int Age { get => age; set => age = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Name { get => name; set => name = value; }

        public MyPerson()
        {
            name = "Name";
            age = 0;
            Gender = false;
        }

        public MyPerson(string name, int age, bool gender) 
        {
            this.name = name;
            this.age = age;
            this.Gender = gender;
        }


    }
}
