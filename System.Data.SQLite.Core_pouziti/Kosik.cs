using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Hepipet
{
    class Kosik
    {
        public const string TableName = "KOSIK";
        public const string IDProduktString = "idProdukt";
        public const string IDObjednavkaString = "idObjednavka";
        
        public long IdProdukt { get; set; }
        public long IdObjednavka { get; set; }
        
        
        public Kosik(long idProdukt, long idZakaznik)
        {
            IdProdukt = idProdukt;
            IdObjednavka = idZakaznik;
        }
        

        /*
        public override string ToString()
        {
            return $"Id produktu: {IdProdukt}, Id objednávky: {IdObjednavka}";
        }
        */
    }
}
