using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace System.Data.SQLite.Hepipet
{
    class Databaze
    {

        private readonly string databazeFileName;
        private readonly string connectionString;
        private ILogger logger;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///databaze
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Databaze(string databazeFileName, ILogger logger)
        {
            this.databazeFileName = databazeFileName;
            connectionString = $"Data Source={databazeFileName};Version=3;";
            this.logger = logger;
        }


        public bool JeDatabazeVytvorena()
        {
            if (System.IO.File.Exists(databazeFileName))
            {
                return true;
            }
            return false;
        }


        public void VytvorDatabazi()
        {
            if (JeDatabazeVytvorena())
            {
                return;
            }

            SQLiteConnection.CreateFile(databazeFileName);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"CREATE TABLE IF NOT EXISTS {Produkt.TableName} ({Produkt.IDString} integer primary key, {Produkt.NazevString} varchar(20) not null, {Produkt.KategorieString} varchar(20) not null, {Produkt.CenaString} int not null, {Produkt.PopisString} varchar(500) not null)";
                string commandText2 = $"CREATE TABLE IF NOT EXISTS {Zakaznik.TableName} ({Zakaznik.IDString} integer primary key, {Zakaznik.UsernameString} varchar(20) not null unique, {Zakaznik.JmenoString} varchar(20) not null, {Zakaznik.PrijmeniString} varchar(20) not null, {Zakaznik.AdresaString} varchar(50) not null, {Zakaznik.HesloString} varchar(30) not null)";
                string commandText3 = $"CREATE TABLE IF NOT EXISTS {Objednavka.TableName} ({Objednavka.IDString} integer primary key, {Objednavka.IDZakaznikString} integer, {Objednavka.StavString} varchar(20) not null, FOREIGN KEY({Objednavka.IDZakaznikString}) REFERENCES {Zakaznik.TableName}({Zakaznik.IDString}))";
                string commandText4 = $"CREATE TABLE IF NOT EXISTS {Kosik.TableName} ({Kosik.IDProduktString} integer, {Kosik.IDObjednavkaString} integer, FOREIGN KEY({Kosik.IDProduktString}) REFERENCES {Produkt.TableName}({Produkt.IDString}), FOREIGN KEY({Kosik.IDObjednavkaString}) REFERENCES {Objednavka.TableName}({Objednavka.IDString}))";
                string commandText5 = $"CREATE TABLE IF NOT EXISTS OBJEDNAVKADETAIL ({Objednavka.IDString} integer, cenasale float(53), datum varchar(40), saletype varchar(6) , FOREIGN KEY({Objednavka.IDString}) REFERENCES {Objednavka.TableName}({Objednavka.IDString}))";
                SQLiteCommand command = new SQLiteCommand(commandText, connection);
                SQLiteCommand command2 = new SQLiteCommand(commandText2, connection);
                SQLiteCommand command3 = new SQLiteCommand(commandText3, connection);
                SQLiteCommand command4 = new SQLiteCommand(commandText4, connection);
                SQLiteCommand command5 = new SQLiteCommand(commandText5, connection);
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command4.ExecuteNonQuery();
                command5.ExecuteNonQuery();

                connection.Close();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///zakaznik
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////               
        public void VlozZakaznika(string username, string jmeno, string prijmeni, string adresa, string heslo)
        {
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"INSERT INTO {Zakaznik.TableName} ({Zakaznik.UsernameString}, {Zakaznik.JmenoString}, {Zakaznik.PrijmeniString}, {Zakaznik.AdresaString}, {Zakaznik.HesloString}) values(@{Zakaznik.UsernameString}, @{Zakaznik.JmenoString}, @{Zakaznik.PrijmeniString}, @{Zakaznik.AdresaString}, @{Zakaznik.HesloString})";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Zakaznik.UsernameString}", username);
                    command.Parameters.AddWithValue($"@{Zakaznik.JmenoString}", jmeno);
                    command.Parameters.AddWithValue($"@{Zakaznik.PrijmeniString}", prijmeni);
                    command.Parameters.AddWithValue($"@{Zakaznik.AdresaString}", adresa);
                    command.Parameters.AddWithValue($"@{Zakaznik.HesloString}", heslo);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public Zakaznik VratZakaznika(string Username, string Password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"SELECT {Zakaznik.IDString}, {Zakaznik.UsernameString},{Zakaznik.JmenoString}, {Zakaznik.PrijmeniString},{Zakaznik.AdresaString}, {Zakaznik.HesloString} FROM {Zakaznik.TableName} WHERE {Zakaznik.UsernameString}=@{Zakaznik.UsernameString} AND heslo = @{Zakaznik.HesloString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Zakaznik.UsernameString}", Username);
                    command.Parameters.AddWithValue($"@{Zakaznik.HesloString}", Password);
                    command.ExecuteNonQuery();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = (long)reader[Zakaznik.IDString];
                            string username = (string)reader[Zakaznik.UsernameString];
                            string jmeno = (string)reader[Zakaznik.JmenoString];
                            string prijmeni = (string)reader[Zakaznik.PrijmeniString];
                            string adresa = (string)reader[Zakaznik.AdresaString];
                            string heslo = (string)reader[Zakaznik.HesloString];

                            Zakaznik zakaznik = new Zakaznik(id, username, jmeno, prijmeni, adresa, heslo);
                            return zakaznik;
                        }
                    }
                }
                connection.Close();
            }
            return null;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///produkty
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void VlozProdukt(string nazev, string kategorie, int cena, string popis)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"INSERT INTO {Produkt.TableName} ({Produkt.NazevString}, {Produkt.KategorieString}, {Produkt.CenaString}, {Produkt.PopisString}) values(@{Produkt.NazevString}, @{Produkt.KategorieString}, @{Produkt.CenaString}, @{Produkt.PopisString})";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Produkt.NazevString}", nazev);
                    command.Parameters.AddWithValue($"@{Produkt.KategorieString}", kategorie);
                    command.Parameters.AddWithValue($"@{Produkt.CenaString}", cena);
                    command.Parameters.AddWithValue($"@{Produkt.PopisString}", popis);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }


        public void EditProdukt(long id, string nazev, string kategorie, int cena, string popis)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"UPDATE {Produkt.TableName} SET {Produkt.NazevString} = @{Produkt.NazevString}, {Produkt.KategorieString} = @{Produkt.KategorieString}, {Produkt.CenaString} = @{Produkt.CenaString}, {Produkt.PopisString} = @{Produkt.PopisString} WHERE {Produkt.IDString} = @{Produkt.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Produkt.IDString}", id);
                    command.Parameters.AddWithValue($"@{Produkt.NazevString}", nazev);
                    command.Parameters.AddWithValue($"@{Produkt.KategorieString}", kategorie);
                    command.Parameters.AddWithValue($"@{Produkt.CenaString}", cena);
                    command.Parameters.AddWithValue($"@{Produkt.PopisString}", popis);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }


        public void DeleteProdukt(long id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"DELETE FROM {Produkt.TableName} WHERE {Produkt.IDString} = @{Produkt.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Produkt.IDString}", id);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }


        public List<Produkt> VratVsechnyProdukty()
        {
            List<Produkt> produkty = new List<Produkt>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT * FROM {Produkt.TableName}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = (long)reader[Produkt.IDString];
                            string nazev = (string)reader[Produkt.NazevString];
                            string kategorie = (string)reader[Produkt.KategorieString];
                            int cena = (int)reader[Produkt.CenaString];
                            string popis = (string)reader[Produkt.PopisString];

                            Produkt produkt = new Produkt(id, nazev, kategorie, cena, popis);
                            produkty.Add(produkt);
                        }
                    }
                }

                connection.Close();
            }

            return produkty;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///objednavky
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Objednavka VratObjednavku(string IdZakaznik)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"SELECT * FROM {Objednavka.TableName} WHERE {Objednavka.IDZakaznikString} = @{Objednavka.IDZakaznikString} ORDER BY {Objednavka.IDString} DESC LIMIT 1";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Objednavka.IDZakaznikString}", IdZakaznik);
                    command.ExecuteNonQuery();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = (long)reader[Objednavka.IDString];
                            long idZakaznika = (long)reader[Objednavka.IDZakaznikString];
                            string stav = (string)reader[Objednavka.StavString];

                            Objednavka objednavka = new Objednavka(id, idZakaznika, stav);
                            return objednavka;
                        }
                    }
                }
                connection.Close();
            }
            return null;
        }


        public void Objednej(long idProdukt, long idObjednavka)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"INSERT INTO {Kosik.TableName} ({Kosik.IDProduktString}, {Kosik.IDObjednavkaString}) values(@{Kosik.IDProduktString}, @{Objednavka.IDString})";
               
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Kosik.IDProduktString}", idProdukt);
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", idObjednavka);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void ZapisDetailObjednavky(long idObjednavka, double cena, string date, string saletype)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"INSERT INTO OBJEDNAVKADETAIL ({Objednavka.IDString}, cenasale, datum, saletype) values(@{Objednavka.IDString}, @price, '{date}', '{saletype}')";

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", idObjednavka);
                    command.Parameters.AddWithValue("@price", cena);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public double VratCenuPoSleve(long idObjednavka)
        {
            double sale = 0.0;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT cenasale FROM OBJEDNAVKADETAIL WHERE {Objednavka.IDString} = @{Objednavka.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", idObjednavka);
                    command.ExecuteNonQuery();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sale = (double)reader["cenasale"];
                        }
                    }
                }
                connection.Close();
            }
            return sale;
        }

        public string VratDatumObjednavky(long idObjednavka)
        {
            string datum = null;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT datum FROM OBJEDNAVKADETAIL WHERE {Objednavka.IDString} = @{Objednavka.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", idObjednavka);
                    command.ExecuteNonQuery();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datum = (string)reader["datum"];
                        }
                    }
                }
                connection.Close();
            }
            return datum;
        }

        public string VratSaleTypeObjednavky(long idObjednavka)
        {
            string saletype = null;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT saletype FROM OBJEDNAVKADETAIL WHERE {Objednavka.IDString} = @{Objednavka.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", idObjednavka);
                    command.ExecuteNonQuery();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            saletype = (string)reader["saletype"];
                        }
                    }
                }
                connection.Close();
            }
            return saletype;
        }

        public void ZalozObjednavku(string idZakaznik)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string commandText = $"INSERT INTO {Objednavka.TableName} ({Objednavka.IDZakaznikString}, {Objednavka.StavString}) values(@{Zakaznik.IDString}, @{Objednavka.StavString})";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Zakaznik.IDString}", idZakaznik);
                    command.Parameters.AddWithValue($"@{Objednavka.StavString}", "vytvořena");

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            if (logger != null)
            {
                logger.Log(LogLevel.Vytvoření, $"Byla vytvořena objednávka");
            }
        }

        public List<OrdersAdministrator> VratVsechnyObjednavky()
        {
            List<OrdersAdministrator> orders = new List<OrdersAdministrator>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT ZAKAZNIK.idZakaznik, ZAKAZNIK.jmeno, ZAKAZNIK.prijmeni, ZAKAZNIK.adresa, OBJEDNAVKA.idObjednavka, group_concat(PRODUKT.idProdukt) AS Produkty, group_concat(PRODUKT.nazev) AS Nazvy, SUM(PRODUKT.cena) as Ceny, OBJEDNAVKA.stav FROM ZAKAZNIK JOIN OBJEDNAVKA on OBJEDNAVKA.idZakaznik = ZAKAZNIK.idZakaznik JOIN KOSIK on KOSIK.idObjednavka = OBJEDNAVKA.idObjednavka join PRODUKT on PRODUKT.idProdukt = KOSIK.idPRODUKT GROUP BY ZAKAZNIK.idZakaznik, OBJEDNAVKA.idObjednavka";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long idZakaznik = (long)reader[Zakaznik.IDString];
                            long idObjednavka = (long)reader[Objednavka.IDString];
                            string idProdukt = (string)reader["Produkty"];
                            string jmeno = (string)reader[Zakaznik.JmenoString];
                            string prijmeni = (string)reader[Zakaznik.PrijmeniString];
                            string adresa = (string)reader[Zakaznik.AdresaString];
                            string nazev = (string)reader["Nazvy"];
                            string stav = (string)reader[Objednavka.StavString];
                            long cena = (long)reader["Ceny"];
                            
                            OrdersAdministrator order = new OrdersAdministrator(idZakaznik, idObjednavka, idProdukt, jmeno, prijmeni, adresa, nazev, stav, cena);
                            orders.Add(order);
                        }
                    }
                }

                connection.Close();
            }

            return orders;
        }

        public List<OrdersAdministratorDetail> VratVsechnyObjednavkyDetail(long idZ, long idO)
        {
            List<OrdersAdministratorDetail> orders = new List<OrdersAdministratorDetail>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT * FROM ZAKAZNIK JOIN OBJEDNAVKA on OBJEDNAVKA.idZakaznik = ZAKAZNIK.idZakaznik JOIN KOSIK on KOSIK.idObjednavka = OBJEDNAVKA.idObjednavka join PRODUKT on PRODUKT.idProdukt = KOSIK.idPRODUKT WHERE ZAKAZNIK.idZakaznik = @{Zakaznik.IDString} AND OBJEDNAVKA.idObjednavka = @{Objednavka.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Zakaznik.IDString}", idZ);
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", idO);
                    command.ExecuteNonQuery();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long idZakaznik = (long)reader[Zakaznik.IDString];
                            long idObjednavka = (long)reader[Objednavka.IDString];
                            long idProdukt = (long)reader[Produkt.IDString];
                            string jmeno = (string)reader[Zakaznik.JmenoString];
                            string prijmeni = (string)reader[Zakaznik.PrijmeniString];
                            string adresa = (string)reader[Zakaznik.AdresaString];
                            string nazev = (string)reader[Produkt.NazevString];
                            string stav = (string)reader[Objednavka.StavString];
                            int cena = (int)reader[Produkt.CenaString];

                            OrdersAdministratorDetail order = new OrdersAdministratorDetail(idZakaznik, idObjednavka, idProdukt.ToString(), jmeno, prijmeni, adresa, nazev, stav, cena);
                            orders.Add(order);
                        }
                    }
                }

                connection.Close();
            }

            return orders;
        }

        public List<OrdersZakaznikDetail> VratVsechnyObjednavkyZakaznikDetail(string username, long idO)
        {
            List<OrdersZakaznikDetail> orders = new List<OrdersZakaznikDetail>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT * FROM ZAKAZNIK JOIN OBJEDNAVKA on OBJEDNAVKA.idZakaznik = ZAKAZNIK.idZakaznik JOIN KOSIK on KOSIK.idObjednavka = OBJEDNAVKA.idObjednavka join PRODUKT on PRODUKT.idProdukt = KOSIK.idPRODUKT WHERE ZAKAZNIK.{Zakaznik.UsernameString} = @{Zakaznik.UsernameString} AND OBJEDNAVKA.idObjednavka = @{Objednavka.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Zakaznik.UsernameString}", username);
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", idO);
                    command.ExecuteNonQuery();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long idZakaznik = (long)reader[Zakaznik.IDString];
                            long idObjednavka = (long)reader[Objednavka.IDString];
                            long idProdukt = (long)reader[Produkt.IDString];
                            string jmeno = (string)reader[Zakaznik.JmenoString];
                            string prijmeni = (string)reader[Zakaznik.PrijmeniString];
                            string adresa = (string)reader[Zakaznik.AdresaString];
                            string nazev = (string)reader[Produkt.NazevString];
                            string stav = (string)reader[Objednavka.StavString];
                            int cena = (int)reader[Produkt.CenaString];

                            OrdersZakaznikDetail order = new OrdersZakaznikDetail(idZakaznik, idObjednavka, idProdukt.ToString(), jmeno, prijmeni, adresa, nazev, stav, cena);
                            orders.Add(order);
                        }
                    }
                }

                connection.Close();
            }

            return orders;
        }

        public List<OrdersZakaznik> VratVsechnyObjednavkyZakaznik(string username)
        {
            List<OrdersZakaznik> orders = new List<OrdersZakaznik>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT ZAKAZNIK.idZakaznik, ZAKAZNIK.jmeno, ZAKAZNIK.prijmeni, ZAKAZNIK.adresa, OBJEDNAVKA.idObjednavka, group_concat(PRODUKT.idProdukt) AS Produkty, group_concat(PRODUKT.nazev) AS Nazvy, SUM(PRODUKT.cena) as Ceny, OBJEDNAVKA.stav FROM ZAKAZNIK JOIN OBJEDNAVKA on OBJEDNAVKA.idZakaznik = ZAKAZNIK.idZakaznik JOIN KOSIK on KOSIK.idObjednavka = OBJEDNAVKA.idObjednavka join PRODUKT on PRODUKT.idProdukt = KOSIK.idPRODUKT WHERE ZAKAZNIK.{Zakaznik.UsernameString} = @{Zakaznik.UsernameString} GROUP BY ZAKAZNIK.idZakaznik, OBJEDNAVKA.idObjednavka";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Zakaznik.UsernameString}", username);
                    command.ExecuteNonQuery();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long idZakaznik = (long)reader[Zakaznik.IDString];
                            long idObjednavka = (long)reader[Objednavka.IDString];
                            string idProdukt = (string)reader["Produkty"];
                            string jmeno = (string)reader[Zakaznik.JmenoString];
                            string prijmeni = (string)reader[Zakaznik.PrijmeniString];
                            string adresa = (string)reader[Zakaznik.AdresaString];
                            string nazev = (string)reader["Nazvy"];
                            string stav = (string)reader[Objednavka.StavString];
                            long cena = (long)reader["Ceny"];

                            OrdersZakaznik order = new OrdersZakaznik(idZakaznik, idObjednavka, idProdukt, jmeno, prijmeni, adresa, nazev, stav, cena);
                            orders.Add(order);
                        }
                    }
                }

                connection.Close();
            }

            return orders;
        }

        public List<OrdersZakaznik> VratPocetObjednavekZakaznika(long id)
        {
            List<OrdersZakaznik> orders = new List<OrdersZakaznik>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT ZAKAZNIK.idZakaznik, ZAKAZNIK.jmeno, ZAKAZNIK.prijmeni, ZAKAZNIK.adresa, OBJEDNAVKA.idObjednavka, group_concat(PRODUKT.idProdukt) AS Produkty, group_concat(PRODUKT.nazev) AS Nazvy, SUM(PRODUKT.cena) as Ceny, OBJEDNAVKA.stav FROM ZAKAZNIK JOIN OBJEDNAVKA on OBJEDNAVKA.idZakaznik = ZAKAZNIK.idZakaznik JOIN KOSIK on KOSIK.idObjednavka = OBJEDNAVKA.idObjednavka join PRODUKT on PRODUKT.idProdukt = KOSIK.idPRODUKT WHERE ZAKAZNIK.{Zakaznik.IDString} = @{Zakaznik.IDString} GROUP BY ZAKAZNIK.idZakaznik, OBJEDNAVKA.idObjednavka";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Zakaznik.IDString}", id);
                    command.ExecuteNonQuery();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long idZakaznik = (long)reader[Zakaznik.IDString];
                            long idObjednavka = (long)reader[Objednavka.IDString];
                            string idProdukt = (string)reader["Produkty"];
                            string jmeno = (string)reader[Zakaznik.JmenoString];
                            string prijmeni = (string)reader[Zakaznik.PrijmeniString];
                            string adresa = (string)reader[Zakaznik.AdresaString];
                            string nazev = (string)reader["Nazvy"];
                            string stav = (string)reader[Objednavka.StavString];
                            long cena = (long)reader["Ceny"];

                            OrdersZakaznik order = new OrdersZakaznik(idZakaznik, idObjednavka, idProdukt, jmeno, prijmeni, adresa, nazev, stav, cena);
                            orders.Add(order);
                        }
                    }
                }

                connection.Close();
            }

            return orders;
        }

        public void DeleteObjednavku(long id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"DELETE FROM {Objednavka.TableName} WHERE {Objednavka.IDString} = @{Objednavka.IDString}; DELETE FROM {Kosik.TableName} WHERE {Objednavka.IDString} = @{Objednavka.IDString}; DELETE FROM OBJEDNAVKADETAIL WHERE {Objednavka.IDString} = @{Objednavka.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", id);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            if (logger != null)
            {
                logger.Log(LogLevel.Zrušení, $"Byla zrušena objednávka s ID: {id}");
            }
        }

        public void ZamitnoutObjednavku(long id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"UPDATE {Objednavka.TableName} SET {Objednavka.StavString} = 'zamítnuta' WHERE {Objednavka.IDString} = @{Objednavka.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", id);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void PotvrditObjednavku(long id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"UPDATE {Objednavka.TableName} SET {Objednavka.StavString} = 'potvrzena' WHERE {Objednavka.IDString} = @{Objednavka.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", id);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            if (logger != null)
            {
                logger.Log(LogLevel.Potvrzení, $"Byla potvrzena objednávka s ID: {id}");
            }
        }

        public void OdeslatObjednavku(long id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"UPDATE {Objednavka.TableName} SET {Objednavka.StavString} = 'odeslána' WHERE {Objednavka.IDString} = @{Objednavka.IDString}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Objednavka.IDString}", id);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////
///provisory
////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
public void EditZakaznika(long id, string jmeno, string prijmeni, string adresa)
{
    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
    {
        connection.Open();
        string commandText = $"UPDATE {Zakaznik.TableName} SET {Zakaznik.JmenoString} = @{Zakaznik.JmenoString}, {Zakaznik.PrijmeniString} = @{Zakaznik.PrijmeniString}, {Zakaznik.AdresaString} = @{Zakaznik.AdresaString} WHERE {Zakaznik.IDString} = @{Zakaznik.IDString}";
        using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
        {
            command.Parameters.AddWithValue($"@{Zakaznik.IDString}", id);
            command.Parameters.AddWithValue($"@{Zakaznik.JmenoString}", jmeno);
            command.Parameters.AddWithValue($"@{Zakaznik.PrijmeniString}", prijmeni);
            command.Parameters.AddWithValue($"@{Zakaznik.AdresaString}", adresa);
            command.ExecuteNonQuery();
        }

        connection.Close();
    }
}

public void EditHesloZakaznika(long id, string heslo)
{
    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
    {
        connection.Open();
        string commandText = $"UPDATE {Zakaznik.TableName} SET {Zakaznik.HesloString} = @{Zakaznik.HesloString} WHERE {Zakaznik.IDString} = @{Zakaznik.IDString}";
        using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
        {
            command.Parameters.AddWithValue($"@{Zakaznik.IDString}", id);
            command.Parameters.AddWithValue($"@{Zakaznik.HesloString}", heslo);
            command.ExecuteNonQuery();
        }

        connection.Close();
    }
}


public void DeleteZakaznika(long id)
{
    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
    {
        connection.Open();

        string commandText = $"DELETE FROM {Zakaznik.TableName} WHERE {Zakaznik.IDString} = @{Zakaznik.IDString}";
        using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
        {
            command.Parameters.AddWithValue($"@{Zakaznik.IDString}", id);
            command.ExecuteNonQuery();
        }

        connection.Close();
    }
}
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////