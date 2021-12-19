using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Hepipet
{
    class Objednavka
    {
        public const string TableName = "OBJEDNAVKA";
        public const string IDString = "idObjednavka";
        public const string IDZakaznikString = "idZakaznik";
        public const string StavString = "stav";

        public long IdObjednavka { get; set; }
        public long IdZakaznik { get; set; }
        public string Stav { get; set; }


        public Objednavka(long id, long idZakaznik, string stav)
        {
            IdObjednavka = id;
            IdZakaznik = idZakaznik;
            Stav = stav;
        }

        /*
        public override string ToString()
        {
            return $"Id: {IdObjednavka}, Id zákazníka: {IdZakaznik}";
        }
        */
    }
}
