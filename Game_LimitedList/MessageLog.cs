using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_LimitedList
{
    public class MessageLog<T> : LimitedList<T>
    {
        public MessageLog(int capacity) : base(capacity) { }

        public override bool Add(T item)
        {
            // om listan är full ta bort item i index 0 annars lägg till item
            if(IsFull)
            {
                list.RemoveAt(0);
            }
            return base.Add(item);
        }

    }
}
