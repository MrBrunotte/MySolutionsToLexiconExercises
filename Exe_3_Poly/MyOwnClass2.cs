﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_3_Polymorfism
{
    internal class MyOwnClass2 : UserError
    {
        public override string UEMessage()
        {
            return "Text from MyOwnClass2";
        }
    }
}
