using System;

namespace IteratorPattern.Classes
{
    interface AbstractIterator
    {
        Seanse First();
        Seanse Next();
        bool IsCompleted { get; }
    }
}
