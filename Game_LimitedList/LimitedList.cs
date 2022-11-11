using System.Collections;

namespace Game_LimitedList
{
    public class LimitedList<T> : IEnumerable<T>
    {

        private readonly int Capacity;
        protected readonly List<T> list;    // With protected the list is reachable to all inheriting classes
        public LimitedList(int capacity)
        {
            this.Capacity = Math.Max(0, capacity);  // sett capacity till 0 eller capacity
            list = new List<T>(capacity);           // skapa en ny lista som anger capacity
        }

        public int Count => list.Count;
        // public bool IsFull => Capacity <= Count; Inline syntax
        public bool IsFull
        {
            get
            {
                return Capacity <= Count;
            }
        }

        public virtual bool Add(T item)
        {
            if(IsFull) return false;
            list.Add(item);
            return true;
        }

        public bool Remove(T item) => list.Remove(item);



        public T this[ int index] => list[index];
        public IEnumerator<T> GetEnumerator()
        {
            foreach(var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void ActionAll(Action<T> action)
        {
            list.ForEach(m => action?.Invoke(m));
        }

    }
}