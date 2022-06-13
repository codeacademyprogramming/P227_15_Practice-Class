using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Employee:Human
    {
        public Employee(byte age) : base(age)
        {

        }

        public string Position;
        public double Salary;
    }
}
