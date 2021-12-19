using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Hepipet
{
    class OrdersZakaznikDetail : OrdersZakaznik
    {
        public OrdersZakaznikDetail(long idZakaznik, long idObjednavka, string idProdukt, string jmeno, string prijmeni, string adresa, string nazev, string stav, long cena) : base(idZakaznik, idObjednavka, idProdukt, jmeno, prijmeni, adresa, nazev, stav, cena)
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
            return $"Produkt: {Nazev}, Cena: {Cena} KČ";
        }
    }
}
