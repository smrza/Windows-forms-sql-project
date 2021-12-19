using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Hepipet
{
    class Zakaznik
    {

        public const string TableName = "ZAKAZNIK";
        public const string IDString = "idZakaznik";
        public const string UsernameString = "username";
        public const string JmenoString = "jmeno";
        public const string PrijmeniString = "prijmeni";
        public const string AdresaString = "adresa";
        public const string HesloString = "heslo";


        public long Id { get; set; }
        public string Username { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Adresa { get; set; }
        public string Heslo { get; set; }

        public Zakaznik(long id, string username, string jmeno, string prijmeni, string adresa, string heslo)
        {
            Id = id;
            Username = username;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Adresa = adresa;
            Heslo = heslo;
        }

        /*
        public override string ToString()
        {
            return $"Id: {Id}, Username: {Username}, Jméno: {Jmeno}, Příjmení: {Prijmeni}, Adresa: {Adresa}";
        }
        */
    }
}
