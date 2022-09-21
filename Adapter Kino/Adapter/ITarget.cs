using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_kino
{
    
    public interface ITarget
    {
        string GetZapytanie(double cena, int liczba_osob);
    }
}
