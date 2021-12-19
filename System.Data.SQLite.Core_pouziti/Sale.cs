using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Hepipet
{
    abstract class Sale
    {
        //public double Cena { get; set; }

        public static string VratRocniObdobi()
        {
            string date = DateTime.Now.ToString("MM");
            if (date == "03" || date == "04" || date == "05")
            {
                return "jaro";
            }
            else if(date == "06" || date == "07" || date == "08")
            {
                return "léto";
            }
            else if(date == "09" || date == "10" || date == "11")
            {
                return "podzim";
            }
            else return "zima";
        }

        // jaro = 1
        // léto = 2
        // podzim = 3
        // zima = 4

        public enum Obdobi
        {
            jaro = 1, leto, podzim, zima
        }

        public static int VratRocniObdobiProSlevu()
        {
            Obdobi obdobi;
            string date = DateTime.Now.ToString("MM");
            if (date == "03" || date == "04" || date == "05")
            {
                obdobi = Obdobi.jaro;
                int obdobiNumber = (int)obdobi;
                return obdobiNumber;
            }
            else if (date == "06" || date == "07" || date == "08")
            {
                obdobi = Obdobi.leto;
                int obdobiNumber = (int)obdobi;
                return obdobiNumber;
            }
            else if (date == "09" || date == "10" || date == "11")
            {
                obdobi = Obdobi.podzim;
                int obdobiNumber = (int)obdobi;
                return obdobiNumber;
            }
            else
            {
                obdobi = Obdobi.zima;
                int obdobiNumber = (int)obdobi;
                return obdobiNumber;
            }
        }

        /*
        public abstract double VratCelkovouCenu10(double Cena);
        public abstract double VratCelkovouCenu20(double Cena);
        public abstract double VratCelkovouCenu30(double Cena);
        public abstract double VratCelkovouCenu40(double Cena);
        */
        public abstract double VratCenu(int Count, double Cena);
    }

    class SpringSale : Sale
    {
        public override double VratCenu(int Count, double Cena)
        {
            if (Count >= 3 && Count < 8)
            {
                Cena *= 0.8;
            }
            else if (Count >= 8 && Count < 12)
            {
                Cena *= 0.7;
            }
            else if (Count >= 12)
            {
                Cena *= 0.6;
            }

            return Cena;
        }
    }

    class SummerSale : Sale
    {
        public override double VratCenu(int Count, double Cena)
        {
            if (Count >= 5 && Count < 10)
            {
                Cena *= 0.9;
            }
            else if (Count >= 10)
            {
                Cena *= 0.8;
            }

            return Cena;
        }
    }

    class AutumnSale : Sale
    {
        public override double VratCenu(int Count, double Cena)
        {
            if (Count == 0)
            {
                Cena *= 0.95;
            }
            else if (Count == 1)
            {
                Cena *= 0.85;
            }
            else if (Count == 2)
            {
                Cena *= 0.75;
            }
            else if (Count == 3)
            {
                Cena *= 0.65;
            }
            else if (Count == 4)
            {
                Cena *= 0.85;
            }

            return Cena;
        }
    }

    class WinterSale : Sale
    {
        public override double VratCenu(int Count, double Cena)
        {
            if (Count == 0)
            {
                Cena *= 0.8;
            }

            return Cena;
        }
    }
}

/* unused and unfinished functionality below, maybe come back to it
public void Sleva(Sale sale)
{
    int season = Sale.VratRocniObdobiProSlevu();

    if (season == 1)
    {
        sale = new SpringSale();
    }
    else if (season == 2)
    {
        sale = new SummerSale();
    }
    else if (season == 3)
    {
        sale = new AutumnSale();
    }
    else if (season == 4)
    {
        sale = new WinterSale();
    }
}
unused and unfinished functionality above, maybe come back to it */
