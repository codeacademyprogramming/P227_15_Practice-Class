using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLesson
{
    internal class Human
    {
        public Human(byte age,string name=null,string surname=null)
        {
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
        }

        public string FullName => Name + " " + Surname;

        public string Name;
        public string Surname;
        public byte Age;
    }
}
