using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_kino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj na stronie rezerwacji internetowej kina.\nPodaj liczbę osób, dla których dokonujesz rezerwacji:");
            int liczba_osob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wybierz rodzaj biletu:\n");
            Console.WriteLine("1. Studencki -50%");
            Console.WriteLine("2. Uczniowski -30%");
            Console.WriteLine("3. Normalny");
            Console.WriteLine("4. Karta Przyjaciela Kina");
            Console.WriteLine("5. Dziecko poniżej 4 lat - za darmo");
            Console.Write("\nWybieram zniżkę numer: ");
            double cena = 0;
            int wybor = Convert.ToInt32(Console.ReadLine());
            switch (wybor)
            { 
            case 1:
                Console.WriteLine("Wybrano zniżkę studencką.");
                Console.ReadKey();
                cena = liczba_osob*25*0.5;
                break;
            case 2:
                Console.WriteLine("Wybrano zniżkę uczniowską.");
                Console.ReadKey();
                cena = liczba_osob*25*0.7;
                break;
            case 3:
                Console.WriteLine("Wybrano zniżkę normalną.");
                Console.ReadKey();
                cena = liczba_osob*25;
                break;
            case 4:
                Console.WriteLine("Jesteś posiadaczem Karty Przyjaciela Kina.");
                Console.ReadKey();
                cena = liczba_osob*25*0.25;
                break;
            case 5:
                Console.WriteLine("Dzieci poniżej 4 roku życia wchodzą za darmo.");
                Console.ReadKey();
                cena = 0;
                break;
            default: 
                Console.WriteLine("Wybrano błędną zniżkę. Spróbuj ponownie.");
                Console.ReadKey();
                break;
            }
            
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            Console.WriteLine(target.GetZapytanie(cena, liczba_osob));
            Console.ReadKey();
        }
    }
}
