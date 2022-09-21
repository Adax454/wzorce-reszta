using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_kino
{

    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetZapytanie(double cena, int liczba_osob)
        {
            return $"{this._adaptee.GetRequest()}Jest wystarczająca ilość miejsc na seans dla: " + liczba_osob + " osób. \nKwota do zapłacenia: " + cena +" zł." ;
        }
    }
}
