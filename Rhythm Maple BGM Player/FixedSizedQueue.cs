using System.Collections.Generic;

namespace Rhythm_Maple_BGM_Player
{
    class FixedSizedQueue<T> : Queue<T>
    {
        public FixedSizedQueue(int limit) { Limit = limit; }
        public int Limit { get; set; }

        public new void Enqueue(T item)
        {
            base.Enqueue(item);
            while (Count > Limit)
                Dequeue();
        }
    }
}
