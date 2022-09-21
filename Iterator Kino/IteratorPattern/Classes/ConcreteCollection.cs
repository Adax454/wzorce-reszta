using System;
using System.Collections.Generic;

namespace IteratorPattern.Classes
{
    class ConcreteCollection : AbstractCollection
    {
        private List<Seanse> listEmployees = new List<Seanse>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return listEmployees.Count; }
        }

        public void AddSeanse(Seanse seanse)
        {
            listEmployees.Add(seanse);
        }

        public Seanse GetSeanse(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}
