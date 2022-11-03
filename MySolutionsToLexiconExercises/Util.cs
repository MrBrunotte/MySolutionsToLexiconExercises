using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_1_PersonalRegister
{
    using System.Diagnostics.CodeAnalysis;
    using System.Security.Cryptography;

    internal static class Util
    {
        internal static int AskForSalary(string prompt)
        {
            bool success = false;
            int answer;
            do
            {
                string input = AskForString(prompt);
                success = int.TryParse(input, out answer);
            } while (!success);

            return answer;
        }

        internal static string AskForString(string prompt)
        {
            bool success = false;
            string answer;
            do
            {
                Console.Write(prompt);
                answer = Console.ReadLine();

                if (!string.IsNullOrEmpty(answer))
                {
                    success = true;
                }
            } while (!success);

            return answer;
        }
    }
}
