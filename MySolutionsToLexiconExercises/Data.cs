using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_1_PersonalRegister
{
    class Data
    {
        public static void SeedData(Payroll payroll)
        {
            payroll.AddEmployee("Stefan", 20000);
            payroll.AddEmployee("Gina", 25000);
            payroll.AddEmployee("viggo", 15000);
            payroll.AddEmployee("Pelle", 10000);
        }
    }
}
