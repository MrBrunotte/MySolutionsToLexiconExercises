using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsLinq
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        // Vi kan inte override en metod i en klass i en override klass. Employee klassens metod (instans metoden) NameToUpper() har högre prio än Extension klassens
        // metod NameToUpper() så Employee klassens metod kommer alltid köras.
        public string NameToUpper()
        {
            return Name.ToUpper();
        }
        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}
