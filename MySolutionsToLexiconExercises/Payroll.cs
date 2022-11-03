using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_1_PersonalRegister
{
    class Payroll
    {
        // private eftersom denna lista endast tillhör denna klass
        // Declare a list called payroll of type Employee
        private List<Employee> payroll;

        // instantiera en ny lista varje gång ett nytt Payroll objekt skapas (av typen Employee)
        public Payroll()
        {
            payroll = new List<Employee>();
        }

        // Lägg till ny anställd i payroll listan
        internal void AddEmployee(string name, int salary)
        {
            payroll.Add(new Employee(name, salary));     // inline temporary variable
                                                         //Employee emp = new Employee(name, salary);
                                                         //payroll.Add(emp);
        }

        internal Employee[] GetEmployees()
        {
            return payroll.ToArray();
        }
    }
}
