using System.Collections;

namespace IteratorPattern
{
    internal abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current
        {
            get
            {
                return Current();
            }
        }

        public abstract int Key();

        public abstract object Current();

        public abstract bool MoveNext();

        public abstract void Reset();
    }
}
