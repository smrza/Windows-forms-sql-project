using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Hepipet
{
    class Produkt //: Sale
    {

        public const string TableName = "PRODUKT";
        public const string IDString = "idProdukt";
        public const string NazevString = "nazev";
        public const string KategorieString = "kategorie";
        public const string CenaString = "cena";
        public const string PopisString = "popis";


        public long Id { get; set; }
        public string Nazev { get; set; }
        public string Kategorie { get; set; }
        public int Cena { get; set; }
        public string Popis { get; set; }

        public Produkt(long id, string nazev, string kategorie, int cena, string popis)
        {
            Id = id;
            Nazev = nazev;
            Kategorie = kategorie;
            Cena = cena;
            Popis = popis;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Název: {Nazev}, Kategorie: {Kategorie}, Cena: {Cena} KČ, Popis: {Popis}";
        }

        /*
        public override double VratCelkovouCenu10(double Cena)
        {
            return Cena * 0.9;
        }
        public override double VratCelkovouCenu20(double Cena)
        {
            return Cena * 0.8;
        }
        public override double VratCelkovouCenu30(double Cena)
        {
            return Cena * 0.7;
        }
        public override double VratCelkovouCenu40(double Cena)
        {
            return Cena * 0.6;
        }

        public override double VratCenu(int CountProducts, int CountOrders, int Index, double Cena)
        {
            string Season = VratRocniObdobi();
            if (Season == "jaro")
            {
                if (CountProducts >= 3 && CountProducts < 8)
                {
                    Cena = VratCelkovouCenu20(Cena);
                }
                else if (CountProducts >= 8 && CountProducts < 12)
                {
                    Cena = VratCelkovouCenu30(Cena);
                }
                else if (CountProducts >= 12)
                {
                    Cena = VratCelkovouCenu40(Cena);
                }
            }

            if (Season == "léto")
            {
                if (CountOrders >= 5 && CountOrders < 10)
                {
                    Cena = VratCelkovouCenu10(Cena);
                }
                else if (CountOrders >= 10)
                {
                    Cena = VratCelkovouCenu20(Cena);
                }
            }

            if (Season == "podzim")
            {
                if (Index == 0)
                {
                    Cena *= 0.95;
                }
                else if(Index == 1)
                {
                    Cena *= 0.85;
                }
                else if (Index == 2)
                {
                    Cena *= 0.75;
                }
                else if (Index == 3)
                {
                    Cena *= 0.65;
                }
                else if (Index == 4)
                {
                    Cena *= 0.85;
                }
            }

            if (Season == "zima")
            {
                if (CountOrders == 0)
                {
                    Cena = VratCelkovouCenu20(Cena);
                }
            }

            return Cena;
        }
        */
    }
}
