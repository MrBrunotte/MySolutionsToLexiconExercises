using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_1_PersonalRegister
{
    class Employee
    {
        // Properties
        public string Name { get; }
        public int Salary { get; }

        // constructor med prameter så att man måste skapa en ny employee med namn och lön.
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        //Vi overridear ToString metoden och vi skickar in våra properties
        public override string ToString()
        {
            return $"Name: {Name} \tSalary: {Salary}";
        }
    }
}
