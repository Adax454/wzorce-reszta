using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes
{
    class Facade
    {
        RejestracjaImie imie;
        RejestracjaNazwisko nazwisko;
        RejestracjaTel numerTel;
        RejestracjaEmail email;

        public Facade()
        {
            imie = new RejestracjaImie();
            nazwisko = new RejestracjaNazwisko();
            numerTel = new RejestracjaTel();
            email = new RejestracjaEmail();
        }

        public void Create()
        {
            Console.WriteLine("\nWitamy na stronie rezerwacji seansu. \nUzupełnij swoje dane kontaktowe. \n\n");

            Console.WriteLine("Podaj imię:");
            string imie1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj nazwisko: ");
            string nazwisko1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj numer kontaktowy: ");
            string numerTel1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj adres e-mail: ");
            string email1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("*SEANS ZAREZERWOWANO*\n");

            imie.SetImie(imie1);
            nazwisko.SetNazwisko(nazwisko1);
            numerTel.SetNumerTel(numerTel1);
            email.SetEmail(email1);
                       
        }
    }
}
