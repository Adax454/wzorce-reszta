using System;
namespace IteratorPattern.Classes
{
    class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;

        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }

        public Seanse First()
        {
            current = 0;
            return collection.GetSeanse(current);
        }

        public Seanse Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetSeanse(current);
            }
            else
            {
                return null;
            }
        }

        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
}
