using System;

namespace IteratorPattern.Classes
{
    class Seanse
    {
        public int ID { get; set; }
        public string NazwaFilmu { get; set; }
        public string CzasTrwania { get; set; }
        public string DataSeansu { get; set; }

        public Seanse(int id, string nazwa_filmu, string czas_trwania, string data_seansu)
        {
            ID = id;
            NazwaFilmu = nazwa_filmu;
            CzasTrwania = czas_trwania;
            DataSeansu = data_seansu;
        }
    }
}
