using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Hepipet
{
    class OrdersAdministrator : Objednavka
    {  
        //public long IdZakaznik { get; set; }
        //public long IdObjednavka { get; set; }

        public string IdProdukt { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Adresa { get; set; }
        public string Nazev { get; set; }
        public long Cena { get; set; }

        public OrdersAdministrator(long idZakaznik, long idObjednavka, string idProdukt, string jmeno, string prijmeni, string adresa, string nazev, string stav, long cena) : base(idZakaznik, idObjednavka, stav)
        {
            IdZakaznik = idZakaznik;
            IdObjednavka = idObjednavka;
            IdProdukt = idProdukt;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Adresa = adresa;
            Nazev = nazev;
            Stav = stav;
            Cena = cena;
        }

        public override string ToString()
        {
            return $"ID objednávky: {IdObjednavka}, Stav objednávky: {Stav}, Zákazník: {Jmeno} {Prijmeni}, adresa: {Adresa}, Produkty: {IdProdukt}, Celková cena: {Cena} KČ";
        }
    }
}
