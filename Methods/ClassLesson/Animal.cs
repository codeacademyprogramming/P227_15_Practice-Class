using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLesson
{
    internal class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public Animal(string name,byte age)
        {   
            this.Name = name;
            this.Age = age;
        }

        public byte Age;
        public string Name;
    }
}
