using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_4_Stack_Heap
{
    class MyInt
    {
        public int MyValue { get; set; } = 0;
        public static int ReturnValue()
        {
            int x = new int();
            x = 3;
            int y = new int();
            y = x;
            y = 4;
            Console.WriteLine("ValueTypes are stored on the Stack");
            Console.WriteLine($"Generates 3 => {x}\n");
            return x;
        }
        public static int ReturnValue2()
        {
            MyInt x = new MyInt();
            x.MyValue = 3;
            MyInt y = new MyInt();
            y = x;
            y.MyValue = 4;
            Console.WriteLine("ReferenceTypes are stored on the Heap");
            Console.WriteLine($"Generates 4 => {x.MyValue}");
            return x.MyValue;
        }
    }
}
