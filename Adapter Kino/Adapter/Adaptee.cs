using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_kino
{
    class Adaptee
    {
        public string GetRequest()
        {
            return "\n******\nPotwierdzenie rezerwacji.\n******\n";
        }
    }
}
