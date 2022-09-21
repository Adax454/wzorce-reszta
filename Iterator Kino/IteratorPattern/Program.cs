using IteratorPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Program
    {
        static void Main()
        {

            ConcreteCollection collection = new ConcreteCollection();
            collection.AddSeanse(new Seanse(1, "Szybcy i wœciekli 5", "2:10:05", "26/05/2022 godzina: 12:40"));
            collection.AddSeanse(new Seanse(2, "Prze³êcz ocalonych", "2:19:32", "26/05/2022 godzina: 14:00"));
            collection.AddSeanse(new Seanse(3, "W³adca Pierœcieni – Powrót Króla", "3:21:43", "26/05/2022 godzina: 17:25"));
          



            Iterator iterator = collection.CreateIterator();
   
            Console.WriteLine("Dostêpne seanse:\n");

            for (Seanse seanse = iterator.First(); !iterator.IsCompleted; seanse = iterator.Next())
            {
                Console.WriteLine($"Data Seansu: {seanse.DataSeansu} \nNazwa Filmu: {seanse.NazwaFilmu} \nCzas Trwania: {seanse.CzasTrwania}\n");
            }
            Console.Read();
        }
    }
}
