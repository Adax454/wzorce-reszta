using System;

namespace IteratorPattern.Classes
{
    interface AbstractCollection
    {
        Iterator CreateIterator();
    }
}
