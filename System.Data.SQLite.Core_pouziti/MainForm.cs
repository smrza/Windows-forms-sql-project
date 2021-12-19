using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace System.Data.SQLite.Hepipet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///definice
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Databaze databaze = null;
        private List<Produkt> produkty;
        private List<Produkt> kosik;
        private List<OrdersAdministrator> ordersAdministrator;
        private List<OrdersZakaznik> ordersZakaznik;
        private List<OrdersAdministratorDetail> ordersAdministratorDetail;
        private List<OrdersZakaznikDetail> ordersZakaznikDetail;
        public BindingSource bindingSource = new BindingSource();
        public BindingSource bindingSourceKosik = new BindingSource();
        public BindingSource bindingSourceOrders = new BindingSource();
        public BindingSource bindingSourceOrdersZakaznik = new BindingSource();
        public BindingSource bindingSourceOrdersDetail = new BindingSource();
        public BindingSource bindingSourceOrdersDetailZakaznik = new BindingSource();
        //ILogger logger;
        private List<OrdersZakaznik> ordersZakaznikCount;
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///logging in administrator/zakaznik
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ButtonAdministrator_Click(object sender, EventArgs e)
        {
            labelIntro.Visible = false;
            labelLogin.Visible = true;
            textBoxUsername.Visible = true;
            textBoxPassword.Visible = true;
            buttonAdministrator.Visible = false;
            buttonZakaznik.Visible = false;
            buttonCancel.Visible = true;
            buttonLoginAdministrator.Visible = true;
        }

        private void ButtonZakaznik_Click(object sender, EventArgs e)
        {
            labelIntro.Visible = false;
            labelVytvoritPrihlasitUzivatel.Visible = true;
            buttonAdministrator.Visible = false;
            buttonZakaznik.Visible = false;
            buttonPrihlasitZakaznik.Visible = true;
            buttonRegisterZakaznik.Visible = true;
            buttonCancel.Visible = true;
        }
        
        private void ButtonPrihlasitZakaznik_Click(object sender, EventArgs e)
        {
            labelIntro.Visible = false;
            labelLogin.Visible = true;
            labelVytvoritPrihlasitUzivatel.Visible = false;
            textBoxUsername.Visible = true;
            textBoxPassword.Visible = true;
            buttonAdministrator.Visible = false;
            buttonZakaznik.Visible = false;
            buttonCancel.Visible = true;
            buttonLoginZakaznik.Visible = true;
            buttonPrihlasitZakaznik.Visible = false;
            buttonRegisterZakaznik.Visible = false;
        }

        private void ButtonLoginAdministrator_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "smrza" && textBoxPassword.Text == "admin")
            {
                if (databaze == null)
                {
                    MessageBox.Show("Není připojena žádná databáze, prosím, připojte databázi", "Chyba");
                    return;
                }
                labelLogin.Visible = false;
                textBoxUsername.Visible = false;
                textBoxPassword.Visible = false;
                buttonCancel.Visible = false;
                buttonLoginAdministrator.Visible = false;
                buttonLoginZakaznik.Visible = false;
                menuStrip1.Visible = false;
                tabAdministrator.Visible = true;
                buttonLogout.Visible = true;
                buttonExit.Visible = true;
                labelUzivatel.Visible = true;
                labelUserString.Visible = true;
                labelUserString.Text = "ID: 1, Admin 1, Jan Smrža";
                listBoxProdukty.SelectedIndex = -1;
                this.listBoxObjednavky.SelectedIndex = -1;
                this.ordersAdministratorDetail = new List<OrdersAdministratorDetail>();
                labelCenaPoSleveDetailAdmin.Visible = false;
                labelCenaPoSleveDetailAdmin2.Visible = false;
                labelCenaPoSleveObjednavkyAdmin.Visible = false;
                labelCenaPoSleveObjednavkyAdmin2.Visible = false;
                labelAdresaDetailAdmin.Visible = false;
                labelAdresaDetailAdmin2.Visible = false;
                labelZakaznikDetailAdmin.Visible = false;
                labelZakaznikDetailAdmin2.Visible = false;
                labelDatumDetailAdmin.Visible = false;
                labelDatumDetailAdmin2.Visible = false;
                labelSaleTypeDetailAdmin.Visible = false;
                labelSaleTypeDetailAdmin2.Visible = false;
                labelStavDetailAdmin.Visible = false;
                labelStavDetailAdmin2.Visible = false;
                listBoxObjednavkyDetail.Visible = false;
                labelDetailZobrazitAdmin.Visible = true;
                labelSaleText();
                labelSaleInformation.Visible = true;
                tabAdministrator.SelectedTab = tabPageProdukty;
                /*
                labelIdLoggedUser.Text = "ID: 1";
                labelUsernameLoggedUser.Text = "Admin 1";
                labelJmenoLoggedUser.Text = "Jan";
                labelPrijmeniLoggedUser.Text = "Smrža";
                labelUzivatel.Visible = true;
                labelIdLoggedUser.Visible = true;
                labelJmenoLoggedUser.Visible = true;
                labelPrijmeniLoggedUser.Visible = true;
                labelUsernameLoggedUser.Visible = true;
                */
                if (checkBoxObjednavka.Checked == true)
                {
                    checkBoxObjednavka.Visible = true;
                }
            }
            else if (textBoxUsername.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Uživatelské jméno a heslo nemůže zůstat prázdné", "Chyba");
            }
            else if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Uživatelské jméno nemůže zůstat prázdné", "Chyba");
            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Heslo nemůže zůstat prázdné", "Chyba");
            }
            else MessageBox.Show("Špatně zadané přihlašovací údaje, prosím, zkuste to znovu", "Chyba");
        }


        private void ButtonLoginZakaznik_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                Zakaznik registrovany = databaze.VratZakaznika(textBoxUsername.Text, textBoxPassword.Text);
                if (registrovany != null)
                {
                    labelIdLoggedUser.Text = registrovany.Id.ToString();
                    labelJmenoLoggedUser.Text = registrovany.Jmeno;
                    labelPrijmeniLoggedUser.Text = registrovany.Prijmeni;
                    labelUsernameLoggedUser.Text = registrovany.Username;
                    labelUserString.Text = $"ID: {labelIdLoggedUser.Text}, Uživatelské jméno: {labelUsernameLoggedUser.Text}, {labelJmenoLoggedUser.Text} {labelPrijmeniLoggedUser.Text}";
                    AfterLoginZakaznik();
                }
                else
                {
                    MessageBox.Show("Při přihlášení došlo k chybě, špatně zadané přihlašovací údaje", "Chyba");
                }
            }
            else
            {
                MessageBox.Show("Prosím, připojte databázi obchodu", "Chyba");
            }
        }

        private void ButtonRegisterZakaznik_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                EditorZakaznika editorZakaznika = new EditorZakaznika();
                editorZakaznika.Text = "Registrace zákazníka";
                if (editorZakaznika.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        databaze.VlozZakaznika(editorZakaznika.Username, editorZakaznika.Jmeno, editorZakaznika.Prijmeni, editorZakaznika.Adresa, editorZakaznika.Heslo);
                        Zakaznik registrovany = databaze.VratZakaznika(editorZakaznika.Username, editorZakaznika.Heslo);
                        labelIdLoggedUser.Text = registrovany.Id.ToString();
                        labelJmenoLoggedUser.Text = registrovany.Jmeno;
                        labelPrijmeniLoggedUser.Text = registrovany.Prijmeni;
                        labelUsernameLoggedUser.Text = registrovany.Username;
                        labelUserString.Text = $"ID: {labelIdLoggedUser.Text}, Uživatelské jméno: {labelUsernameLoggedUser.Text}, {labelJmenoLoggedUser.Text} {labelPrijmeniLoggedUser.Text}";
                        MessageBox.Show("Registrace proběhla v pořádku", "Registrace");
                        AfterLoginZakaznik();
                    }
                    catch
                    {
                        MessageBox.Show("Při registraci došlo k chybě, zadal/a jste uživatelské jméno, které již existuje: ", "Chyba");
                    }
                }
            }
            else
            {
                MessageBox.Show("Prosím, připojte databázi obchodu", "Chyba");
            }
        }


        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            labelIntro.Visible = true;
            labelVytvoritPrihlasitUzivatel.Visible = false;
            labelLogin.Visible = false;
            textBoxUsername.Visible = false;
            textBoxPassword.Visible = false;
            buttonAdministrator.Visible = true;
            buttonZakaznik.Visible = true;
            buttonPrihlasitZakaznik.Visible = false;
            buttonRegisterZakaznik.Visible = false;
            buttonCancel.Visible = false;
            buttonLoginAdministrator.Visible = false;
            buttonLoginZakaznik.Visible = false;
            menuStrip1.Visible = true;
            tabAdministrator.Visible = false;
            textBoxPassword.Text = null;
            textBoxUsername.Text = null;
        }


        //metoda volaná tlačítkama zákazníka register/login pro postup do obchodu
        private void AfterLoginZakaznik()
        {
            buttonRegisterZakaznik.Visible = false;
            buttonPrihlasitZakaznik.Visible = false;
            menuStrip1.Visible = false;
            buttonCancel.Visible = false;
            labelVytvoritPrihlasitUzivatel.Visible = false;
            tabZakaznik.Visible = true;
            buttonLogout.Visible = true;
            buttonExit.Visible = true;
            labelUzivatel.Visible = true;
            labelSaleText();
            labelSaleInformation.Visible = true;
            tabZakaznik.SelectedTab = tabPage1;

            /*
            labelIdLoggedUser.Visible = true;
            labelJmenoLoggedUser.Visible = true;
            labelPrijmeniLoggedUser.Visible = true;
            labelUsernameLoggedUser.Visible = true;
            */
            labelLogin.Visible = false;
            textBoxUsername.Visible = false;
            textBoxPassword.Visible = false;
            buttonLoginZakaznik.Visible = false;
            labelUserString.Visible = true;
            try
            {
                this.ordersZakaznik = databaze.VratVsechnyObjednavkyZakaznik(labelUsernameLoggedUser.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při pokusu výběru objednávek zákazníka: " + ex.Message);
                return;
            }

            listBoxObjednavkyZakaznik.DataSource = this.ordersZakaznik;

            
            //vytvoření instance košíku pro zákazníka
            this.kosik = new List<Produkt>();
            this.ordersZakaznik = new List<OrdersZakaznik>();
            listBoxProduktyZakaznik.SelectedIndex = -1;
            this.listBoxObjednavkyZakaznik.SelectedIndex = -1;
            this.ordersZakaznikDetail = new List<OrdersZakaznikDetail>();
            labelCenaPoSleveDetail.Visible = false;
            labelCenaPoSleveDetail2.Visible = false;
            labelDatumDetailZakaznik.Visible = false;
            labelDatumDetailZakaznik2.Visible = false;
            labelSaletypeDetailZakaznik.Visible = false;
            labelSaletypeDetailZakaznik2.Visible = false;
            labelStavDetailZakaznik.Visible = false;
            labelStavDetailZakaznik2.Visible = false;
            labelCenaPoSleveObjednavky.Visible = false;
            labelCenaPoSleveObjednavky2.Visible = false;
            listBoxObjednavkyDetailZakaznik.Visible = false;
            labelDetailZobrazitZakaznik.Visible = true;

            if (season == 1)
            {
                sleva = new SpringSale();
            }
            else if (season == 2)
            {
                sleva = new SummerSale();
            }
            else if (season == 3)
            {
                sleva = new AutumnSale();
            }
            else if (season == 4)
            {
                sleva = new WinterSale();
            }
        }

        private void labelSaleText()
        {
            if (Sale.VratRocniObdobiProSlevu() == 1)
            {
                labelSaleInformation.Text = "Jarní sleva: 3 a více produktů = -20%, 8 a více produktů = -30%, 12 a více produktů = -40%";
            }
            else if (Sale.VratRocniObdobiProSlevu() == 2)
            {
                labelSaleInformation.Text = "Letní sleva: 5 a více objednávek = -10% sleva na další, 10 a více objednávek = -20% na další";
            }
            else if (Sale.VratRocniObdobiProSlevu() == 3)
            {
                labelSaleInformation.Text = "Podzimní sleva: slevněné produkty s ID 1, 2, 3, 4, 5";
            }
            else
            {
                labelSaleInformation.Text = "Zimní sleva: -20% na první objednávku nového zákazníka";
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///databaze, logger, DataSource
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void vytvořitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogDatabaze.ShowDialog() == DialogResult.OK)
            {
                VolbaLogovani volbaLogovani = new VolbaLogovani();
                volbaLogovani.ShowDialog(this);
                if (volbaLogovani.DialogResult == DialogResult.OK)
                {
                    databaze = new Databaze(saveFileDialogDatabaze.FileName, new ConsoleLogger());
                }
                else if (volbaLogovani.DialogResult == DialogResult.Yes)
                {
                    databaze = new Databaze(saveFileDialogDatabaze.FileName, new FileLogger());
                }
                else
                {
                    databaze = new Databaze(saveFileDialogDatabaze.FileName, null);
                }

                if (databaze.JeDatabazeVytvorena())
                {
                    File.Delete(saveFileDialogDatabaze.FileName);
                }

                databaze.VytvorDatabazi();

                this.produkty = new List<Produkt>();
                this.ordersAdministrator = new List<OrdersAdministrator>();
                this.PripojSeznam();

                //VolbaLoggeru();
            }
        }


        private void připojitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogDatabaze.ShowDialog() == DialogResult.OK)
            {
                VolbaLogovani volbaLogovani = new VolbaLogovani();
                volbaLogovani.ShowDialog(this);
                if (volbaLogovani.DialogResult == DialogResult.OK)
                {
                    databaze = new Databaze(openFileDialogDatabaze.FileName, new ConsoleLogger());
                }
                else if (volbaLogovani.DialogResult == DialogResult.Yes)
                {
                    databaze = new Databaze(openFileDialogDatabaze.FileName, new FileLogger());
                }
                else
                {
                    databaze = new Databaze(openFileDialogDatabaze.FileName, null);
                }

                if (!databaze.JeDatabazeVytvorena())
                {
                    databaze.VytvorDatabazi();
                }

                try
                {
                    this.produkty = databaze.VratVsechnyProdukty();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při pokusu výběru všech produktů: " + ex.Message);
                    return;
                }

                try
                {
                    this.ordersAdministrator = databaze.VratVsechnyObjednavky();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při pokusu výběru všech objednávek: " + ex.Message);
                    return;
                }

                this.PripojSeznam();
                //VolbaLoggeru();
            }
        }

        private void PripojSeznam()
        {
            //napojení na DataGridView pomocí prvku BindingSource
            //toto způsobí, že se napojený seznam automaticky změní podle toho, co provedeme v dataGridView
            if (bindingSource != null && this.produkty != null)
            {

                if (listBoxProdukty.DataSource == null)
                {
                    listBoxProdukty.Items.Clear();
                    listBoxProduktyZakaznik.Items.Clear();
                }

                bindingSource.DataSource = this.produkty;
                listBoxProdukty.DataSource = bindingSource;
                listBoxProduktyZakaznik.DataSource = bindingSource;

            }

            if (bindingSourceOrders != null && this.ordersAdministrator != null)
            {

                if (listBoxObjednavky.DataSource == null)
                {
                    listBoxObjednavky.Items.Clear();
                }

                bindingSourceOrders.DataSource = this.ordersAdministrator;
                listBoxObjednavky.DataSource = bindingSourceOrders;
            }
        }

        
        private void PripojSeznamKosik()
        {
            if (bindingSourceKosik != null && this.kosik != null)
            {
                if (listBoxKosik.DataSource == null)
                {
                    listBoxKosik.Items.Clear();
                }
            }
            bindingSourceKosik.DataSource = null;

            bindingSourceKosik.DataSource = this.kosik;
            listBoxKosik.DataSource = bindingSourceKosik;
        }

        private void PripojSeznamObjednavkyDetailAdministrator()
        {
            if (bindingSourceOrdersDetail != null && this.ordersAdministratorDetail != null)
            {

                if (listBoxObjednavkyDetail.DataSource == null)
                {
                    listBoxObjednavkyDetail.Items.Clear();
                }

                bindingSourceOrdersDetail.DataSource = this.ordersAdministratorDetail;
                listBoxObjednavkyDetail.DataSource = bindingSourceOrdersDetail;
            }
        }

        private void PripojSeznamObjednavkyDetailZakaznik()
        {
            if (bindingSourceOrdersDetailZakaznik != null && this.ordersZakaznikDetail != null)
            {

                if (listBoxObjednavkyDetailZakaznik.DataSource == null)
                {
                    listBoxObjednavkyDetailZakaznik.Items.Clear();
                }

                bindingSourceOrdersDetailZakaznik.DataSource = this.ordersZakaznikDetail;
                listBoxObjednavkyDetailZakaznik.DataSource = bindingSourceOrdersDetailZakaznik;
            }
        }

        /*
        private void VolbaLoggeru()
        {
            VolbaLogovani volbaLogovani = new VolbaLogovani();
            volbaLogovani.ShowDialog(this);
            if (volbaLogovani.DialogResult == DialogResult.OK)
            {
                try
                {
                    logger = new ConsoleLogger();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Při vytváření loggeru došlo k chybě: " + ex.Message);
                }
            }           
            else if(volbaLogovani.DialogResult == DialogResult.Yes)
            {
                try
                {
                    logger = new FileLogger();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Při vytváření loggeru došlo k chybě: " + ex.Message);
                }
            }
            
        }
        */
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///objednávky
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        double Cena = 0.0;
        double CenaSale = 0.0;
        Sale sleva; //vytvoření instance (sezóní slevy) v metodě po přihlášení uživatele "AfterLoginZakaznik"
        readonly int season = Sale.VratRocniObdobiProSlevu();

        /* test seasons */
        //readonly int season = 1;
        //readonly int season = 2;
        //readonly int season = 3;
        //readonly int season = 4;

        private void buttonPridatDoKosiku_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                int pocetProduktu = Convert.ToInt16(numericUpDownPocetProduktu.Value);

                if (this.listBoxProduktyZakaznik.SelectedIndex >= 0)
                {
                    bool workedMessageBox = false;
                    

                    for (int i = 0; i < pocetProduktu; i++)
                    {
                        Produkt doKosiku = this.produkty[this.listBoxProduktyZakaznik.SelectedIndex];
                        try
                        {
                            kosik.Add(doKosiku);                            
                            
                            this.PripojSeznamKosik();

                            if (season == 1)
                            {
                                Cena += Convert.ToDouble(doKosiku.Cena);
                                CenaSale = sleva.VratCenu(kosik.Count, Cena);
                            }
                            else if (season == 2 || season == 4)
                            {
                                ordersZakaznikCount = databaze.VratVsechnyObjednavkyZakaznik(labelUsernameLoggedUser.Text);
                                Cena += Convert.ToDouble(doKosiku.Cena);
                                CenaSale = sleva.VratCenu(ordersZakaznikCount.Count, Cena);
                            }
                            else if (season == 3)
                            {
                                Cena = sleva.VratCenu(this.listBoxProduktyZakaznik.SelectedIndex, doKosiku.Cena);
                                CenaSale += Cena;
                                Cena = 0.0;
                            }

                            labelCenaPoSleveKosik.Visible = true;
                            labelCenaPoSleveKosik2.Visible = true;
                            labelCenaPoSleveKosik.Text = CenaSale.ToString();
                            this.listBoxKosik.SelectedIndex = this.listBoxKosik.Items.Count - 1;
                            workedMessageBox = true;
                        }
                        catch (Exception ex)
                        {
                            workedMessageBox = false;
                            MessageBox.Show($"Při vkládání produktu s ID: {doKosiku.Id} do košíku došlo k chybě: " + ex.Message);
                        }
                    }
                    if (workedMessageBox == true)
                    {
                        if (numericUpDownPocetProduktu.Value >= 2)
                        {
                            MessageBox.Show($"Produkty přidány do košíku", "Hotovo");
                        }
                        else
                        {
                            MessageBox.Show($"Produkt přidán do košíku", "Hotovo");
                        }

                        numericUpDownPocetProduktu.Value = 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Není připojena žádná databáze, prosím, odhlašte se, připojte databázi a opětujte přihlášení", "Chyba");
            }
        }
        
        private void buttonOdebratZKosiku(object sender, EventArgs e)
        {
            int IndexRemove = 0;

            if (listBoxKosik.SelectedIndex >= 0)
            {
                Produkt doKosiku = this.kosik[this.listBoxKosik.SelectedIndex];
                bindingSourceKosik.RemoveAt(listBoxKosik.SelectedIndex);
                //kosik.Remove(doKosiku);

                if (season == 1)
                {
                    Cena -= doKosiku.Cena;
                    CenaSale = sleva.VratCenu(kosik.Count, Cena);
                }
                else if (season == 2 || season == 4)
                {
                    ordersZakaznikCount = databaze.VratVsechnyObjednavkyZakaznik(labelUsernameLoggedUser.Text);
                    Cena -= doKosiku.Cena;
                    CenaSale = sleva.VratCenu(ordersZakaznikCount.Count, Cena);
                }
                else if (season == 3)
                {
                    if (doKosiku.Id == 1)
                    {
                        IndexRemove = 0;
                    }
                    else if (doKosiku.Id == 2)
                    {
                        IndexRemove = 1;
                    }
                    else if (doKosiku.Id == 3)
                    {
                        IndexRemove = 2;
                    }
                    else if (doKosiku.Id == 4)
                    {
                        IndexRemove = 3;
                    }
                    else if (doKosiku.Id == 5)
                    {
                        IndexRemove = 4;
                    }
                    else IndexRemove = 5;

                    Cena = sleva.VratCenu(IndexRemove, doKosiku.Cena);
                    CenaSale -= Cena;
                    Cena = 0.0;
                    if (kosik.Count == 0)
                    {
                        CenaSale = 0;
                    }
                }

                //Math.Round(CenaSale, 3, MidpointRounding.AwayFromZero);
                labelCenaPoSleveKosik.Text = CenaSale.ToString();
                if (labelCenaPoSleveKosik.Text == "0")
                {
                    labelCenaPoSleveKosik.Visible = false;
                    labelCenaPoSleveKosik2.Visible = false;
                }
                
                this.PripojSeznamKosik();
                this.listBoxKosik.SelectedIndex = -1;
            }
        }

        private void buttonObjednat_Click(object sender, EventArgs e)
        {
            if (kosik.Count == 0)
            {
                MessageBox.Show("Máte prázdný košík", "Košík");
            }
            else
            {
                databaze.ZalozObjednavku(labelIdLoggedUser.Text);
                Objednavka objednavka = databaze.VratObjednavku(labelIdLoggedUser.Text);
                foreach (var produkt in kosik)
                {
                    databaze.Objednej(produkt.Id, objednavka.IdObjednavka);
                }
                kosik.Clear();
                DateTime time = DateTime.Now;
                string timeFormat = "yyyy-MMMM-dd HH:mm:ss";
                string slevatype = Sale.VratRocniObdobi();
                databaze.ZapisDetailObjednavky(objednavka.IdObjednavka, Convert.ToDouble(labelCenaPoSleveKosik.Text), time.ToString(timeFormat), slevatype);
                kosik = new List<Produkt>();
                this.PripojSeznamKosik();
                this.ordersAdministrator = databaze.VratVsechnyObjednavky();

                this.ordersZakaznik = databaze.VratVsechnyObjednavkyZakaznik(labelUsernameLoggedUser.Text);
                listBoxObjednavkyZakaznik.DataSource = this.ordersZakaznik;
                //this.PripojSeznamObjednavkyZakaznika();
                //bindingSourceOrdersZakaznik.DataSource = this.ordersZakaznik;
                //listBoxObjednavkyZakaznik.DataSource = bindingSourceOrdersZakaznik;
                this.PripojSeznam();
                labelCenaPoSleveKosik.Text = null;
                labelCenaPoSleveKosik.Visible = false;
                labelCenaPoSleveKosik2.Visible = false;

                //checkBoxObjednavka.Visible = true;
                //labelCenaPoSleveKosik.Text = "0";

                checkBoxObjednavka.Checked = true;
                BlinkNovaObjednavka(true);
                CenaSale = 0.0;
                Cena = 0.0;
                listBoxObjednavkyZakaznik.SelectedIndex = -1;
                labelCenaPoSleveDetail.Visible = false;
                labelCenaPoSleveDetail2.Visible = false;
                labelCenaPoSleveDetail.Text = "0";
                labelCenaPoSleveObjednavky.Text = "0";
                labelCenaPoSleveObjednavky.Visible = false;
                labelCenaPoSleveObjednavky2.Visible = false;
                listBoxObjednavkyDetailZakaznik.Visible = false;
                labelDatumDetailZakaznik.Visible = false;
                labelDatumDetailZakaznik2.Visible = false;
                labelSaletypeDetailZakaznik.Visible = false;
                labelSaletypeDetailZakaznik2.Visible = false;
                labelStavDetailZakaznik.Visible = false;
                labelStavDetailZakaznik2.Visible = false;
                //maybe edit this below
                this.ordersZakaznikDetail = new List<OrdersZakaznikDetail>();
                PripojSeznamObjednavkyDetailZakaznik();
                //maybe edit this above
                labelDetailZobrazitZakaznik.Visible = true;
                listBoxProduktyZakaznik.SelectedIndex = -1;
                MessageBox.Show("Objednávka úspěšně vytvořena");
            }
        }

        private void CheckBoxObjednavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxObjednavka.Visible == true && checkBoxObjednavka.Checked == false)
            {
                checkBoxObjednavka.Checked = false;
                checkBoxObjednavka.Visible = false;
                BlinkNovaObjednavka(false);
            }
        }

        private async void BlinkNovaObjednavka(bool blink)
        {
            while (blink == true)
            {
                await Task.Delay(500);
                checkBoxObjednavka.ForeColor = checkBoxObjednavka.ForeColor == Color.Red ? Color.Green : Color.Red;
            }
        }

        private void ListBoxObjednavky_Click(object sender, EventArgs e)
        {
            if (this.listBoxObjednavky.SelectedIndex >= 0)
            {
                this.ordersAdministrator = databaze.VratVsechnyObjednavky();
                OrdersAdministrator order = this.ordersAdministrator[this.listBoxObjednavky.SelectedIndex];
                this.ordersAdministratorDetail = new List<OrdersAdministratorDetail>();
                this.ordersAdministratorDetail = databaze.VratVsechnyObjednavkyDetail(order.IdZakaznik, order.IdObjednavka);
                //this.ordersZakaznik = databaze.VratPocetObjednavekZakaznika(order.IdZakaznik);
                labelCenaPoSleveDetailAdmin.Visible = true;
                labelCenaPoSleveDetailAdmin2.Visible = true;
                labelCenaPoSleveObjednavkyAdmin.Visible = true;
                labelCenaPoSleveObjednavkyAdmin2.Visible = true;
                labelAdresaDetailAdmin.Visible = true;
                labelAdresaDetailAdmin2.Visible = true;
                labelZakaznikDetailAdmin.Visible = true;
                labelZakaznikDetailAdmin2.Visible = true;
                labelDatumDetailAdmin.Visible = true;
                labelDatumDetailAdmin2.Visible = true;
                labelSaleTypeDetailAdmin.Visible = true;
                labelSaleTypeDetailAdmin2.Visible = true;
                labelStavDetailAdmin.Visible = true;
                labelStavDetailAdmin2.Visible = true;
                listBoxObjednavkyDetail.Visible = true;
                labelDetailZobrazitAdmin.Visible = false;

                labelCenaPoSleveDetailAdmin.Text = databaze.VratCenuPoSleve(order.IdObjednavka).ToString();
                labelCenaPoSleveObjednavkyAdmin.Text = labelCenaPoSleveDetailAdmin.Text;
                labelAdresaDetailAdmin.Text = order.Adresa.ToString();
                labelZakaznikDetailAdmin.Text = $"ID: {order.IdZakaznik}, Jméno: {order.Jmeno} {order.Prijmeni}";
                labelDatumDetailAdmin.Text = databaze.VratDatumObjednavky(order.IdObjednavka).ToString();
                labelSaleTypeDetailAdmin.Text = databaze.VratSaleTypeObjednavky(order.IdObjednavka).ToString();
                labelStavDetailAdmin.Text = order.Stav.ToString();
                PripojSeznamObjednavkyDetailAdministrator();
            }
        }

        private void ListBoxObjednavkyZakaznik_Click(object sender, EventArgs e)
        {
            if (this.listBoxObjednavkyZakaznik.SelectedIndex >= 0)
            {
                this.ordersZakaznik = databaze.VratVsechnyObjednavkyZakaznik(labelUsernameLoggedUser.Text);
                OrdersZakaznik order = this.ordersZakaznik[this.listBoxObjednavkyZakaznik.SelectedIndex];
                this.ordersZakaznikDetail = new List<OrdersZakaznikDetail>();
                this.ordersZakaznikDetail = databaze.VratVsechnyObjednavkyZakaznikDetail(labelUsernameLoggedUser.Text, order.IdObjednavka);
                labelCenaPoSleveDetail.Text = databaze.VratCenuPoSleve(order.IdObjednavka).ToString();

                labelCenaPoSleveDetail.Visible = true;
                labelCenaPoSleveDetail2.Visible = true;
                labelDatumDetailZakaznik.Visible = true;
                labelDatumDetailZakaznik2.Visible = true;
                labelSaletypeDetailZakaznik.Visible = true;
                labelSaletypeDetailZakaznik2.Visible = true;
                labelStavDetailZakaznik.Visible = true;
                labelStavDetailZakaznik2.Visible = true;
                labelCenaPoSleveObjednavky.Visible = true;
                labelCenaPoSleveObjednavky2.Visible = true;
                listBoxObjednavkyDetailZakaznik.Visible = true;
                labelDetailZobrazitZakaznik.Visible = false;

                labelDatumDetailZakaznik.Text = databaze.VratDatumObjednavky(order.IdObjednavka).ToString();
                labelSaletypeDetailZakaznik.Text = databaze.VratSaleTypeObjednavky(order.IdObjednavka).ToString();
                labelStavDetailZakaznik.Text = order.Stav.ToString();

                labelCenaPoSleveObjednavky.Text = labelCenaPoSleveDetail.Text;
                PripojSeznamObjednavkyDetailZakaznik();
            }          
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///administrátor
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonPridat_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                EditorProduktu editorProduktu = new EditorProduktu();
                if (editorProduktu.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        databaze.VlozProdukt(editorProduktu.Nazev, editorProduktu.Kategorie, editorProduktu.Cena, editorProduktu.Popis);

                        //refresh produktů v ListBoxu
                        this.produkty = databaze.VratVsechnyProdukty();
                        this.PripojSeznam();
                        listBoxProdukty.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Při vkládání produktu do databáze došlo k chybě: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Není připojena žádná databáze, prosím, odhlašte se, připojte databázi a opětujte přihlášení", "Chyba");
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                if (this.listBoxProdukty.SelectedIndex >= 0)
                {
                    Produkt editovanyProdukt = this.produkty[this.listBoxProdukty.SelectedIndex];
                    EditorProduktu editorProduktu = new EditorProduktu(editovanyProdukt.Nazev, editovanyProdukt.Kategorie, editovanyProdukt.Cena, editovanyProdukt.Popis);
                    if (editorProduktu.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                            databaze.EditProdukt(editovanyProdukt.Id, editorProduktu.Nazev, editorProduktu.Kategorie, editorProduktu.Cena, editorProduktu.Popis);

                            //refresh produktů v ListBoxu
                            this.produkty = databaze.VratVsechnyProdukty();
                            this.PripojSeznam();
                            listBoxProdukty.SelectedIndex = -1;
                            MessageBox.Show($"Produkt s ID: {editovanyProdukt.Id} úspěšně změněn", "Hotovo");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Při editaci produktu s ID: {editovanyProdukt.Id} došlo k chybě: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Není připojena žádná databáze, prosím, odhlašte se, připojte databázi a opětujte přihlášení", "Chyba");
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                if (this.listBoxProdukty.SelectedIndex >= 0)
                {
                    Produkt editovanyProdukt = this.produkty[this.listBoxProdukty.SelectedIndex];
                    if (MessageBox.Show($"Opravdu chete smazat produkt s ID: {editovanyProdukt.Id}?", "Delete produktu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            databaze.DeleteProdukt(editovanyProdukt.Id);

                            //refresh produktů v ListBoxu
                            this.produkty = databaze.VratVsechnyProdukty();
                            this.PripojSeznam();
                            listBoxProdukty.SelectedIndex = -1;
                            MessageBox.Show($"Produkt s ID: {editovanyProdukt.Id} smazán", "Hotovo");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Při mazaní produktu s ID: {editovanyProdukt.Id} došlo k chybě: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Není připojena žádná databáze, prosím, odhlašte se, připojte databázi a opětujte přihlášení", "Chyba");
            }
        }

        private void buttonZrusit_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                if (this.listBoxObjednavky.SelectedIndex >= 0)
                {
                    OrdersAdministrator ordersAdministrator = this.ordersAdministrator[this.listBoxObjednavky.SelectedIndex];
                    if (ordersAdministrator.Stav == "potvrzena")
                    {
                        MessageBox.Show("Objednávka je ve stavu 'potvrzena', buďto odbjednávku zamítněte nebo odešlete a pokračujte zrušením", "Chyba");
                    }
                    else if (MessageBox.Show($"Opravdu chete odstranit objednávku s ID: {ordersAdministrator.IdObjednavka}?", "Odstranit objednávku", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            databaze.DeleteObjednavku(ordersAdministrator.IdObjednavka);

                            //refresh produktů v ListBoxu
                            this.ordersAdministrator = databaze.VratVsechnyObjednavky();
                            this.PripojSeznam();
                            ordersAdministratorDetail.Clear();
                            bindingSourceOrdersDetail.DataSource = null;
                            labelCenaPoSleveDetail.Text = null;
                            labelCenaPoSleveDetailAdmin.Text = null;
                            labelCenaPoSleveObjednavky.Text = null;
                            labelCenaPoSleveObjednavkyAdmin.Text = null;
                            labelAdresaDetailAdmin.Text = null;                            
                            labelZakaznikDetailAdmin.Text = null;                            
                            labelDatumDetailAdmin.Text = null;                            
                            labelSaleTypeDetailAdmin.Text = null;                            
                            labelStavDetailAdmin.Text = null;                            
                            listBoxObjednavkyDetail.Text = null;
                            labelCenaPoSleveDetailAdmin.Visible = false;
                            labelCenaPoSleveDetailAdmin2.Visible = false;
                            labelCenaPoSleveObjednavkyAdmin.Visible = false;
                            labelCenaPoSleveObjednavkyAdmin2.Visible = false;
                            labelAdresaDetailAdmin.Visible = false;
                            labelAdresaDetailAdmin2.Visible = false;
                            labelZakaznikDetailAdmin.Visible = false;
                            labelZakaznikDetailAdmin2.Visible = false;
                            labelDatumDetailAdmin.Visible = false;
                            labelDatumDetailAdmin2.Visible = false;
                            labelSaleTypeDetailAdmin.Visible = false;
                            labelSaleTypeDetailAdmin2.Visible = false;
                            labelStavDetailAdmin.Visible = false;
                            labelStavDetailAdmin2.Visible = false;
                            listBoxObjednavkyDetail.Visible = false;
                            labelDetailZobrazitAdmin.Visible = true;
                            listBoxObjednavky.SelectedIndex = -1;
                            //this.PripojSeznamObjednavkyDetailAdministrator();

                            MessageBox.Show($"Objednávka s ID: {ordersAdministrator.IdObjednavka} zrušena", "Hotovo");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Při rušení objednávky s ID: {ordersAdministrator.IdObjednavka} došlo k chybě: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonZamitnout_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                if (this.listBoxObjednavky.SelectedIndex >= 0)
                {
                    OrdersAdministrator ordersAdministrator = this.ordersAdministrator[this.listBoxObjednavky.SelectedIndex];
                    if (ordersAdministrator.Stav == "zamítnuta")
                    {
                        MessageBox.Show("Objednávka byla již zamítnuta dříve", "Zamítnuta");
                    }
                    else if (MessageBox.Show($"Opravdu chete zamítnout objednávku s ID: {ordersAdministrator.IdObjednavka}?", "Zamítnout objednávku", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            databaze.ZamitnoutObjednavku(ordersAdministrator.IdObjednavka);

                            //refresh produktů v ListBoxu
                            this.ordersAdministrator = databaze.VratVsechnyObjednavky();
                            this.PripojSeznam();
                            /*
                            if (logger != null)
                            {
                                logger.Log(LogLevel.Zrušení, $"Byla zrušena objednávka s ID: {ordersAdministrator.IdObjednavka}");
                            }
                            */
                            MessageBox.Show($"Objednávka s ID: {ordersAdministrator.IdObjednavka} zamítnuta", "Hotovo");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Při zamítnutí objednávky s ID: {ordersAdministrator.IdObjednavka} došlo k chybě: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonPotvrdit_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                if (this.listBoxObjednavky.SelectedIndex >= 0)
                {
                    OrdersAdministrator ordersAdministrator = this.ordersAdministrator[this.listBoxObjednavky.SelectedIndex];
                    if (ordersAdministrator.Stav == "potvrzena")
                    {
                        MessageBox.Show("Objednávka byla již potvrzena dříve", "Potvrzena");
                    }
                    else if (MessageBox.Show($"Opravdu chete potvrdit objednávku s ID: {ordersAdministrator.IdObjednavka}?", "Potvrdit objednávku", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            databaze.PotvrditObjednavku(ordersAdministrator.IdObjednavka);

                            //refresh produktů v ListBoxu
                            this.ordersAdministrator = databaze.VratVsechnyObjednavky();
                            this.PripojSeznam();

                            MessageBox.Show($"Objednávka s ID: {ordersAdministrator.IdObjednavka} potvrzena", "Hotovo");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Při potvrzení objednávky s ID: {ordersAdministrator.IdObjednavka} došlo k chybě: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonOdeslat_Click(object sender, EventArgs e)
        {
            if (databaze != null)
            {
                if (this.listBoxObjednavky.SelectedIndex >= 0)
                {
                    OrdersAdministrator ordersAdministrator = this.ordersAdministrator[this.listBoxObjednavky.SelectedIndex];
                    if (ordersAdministrator.Stav == "odeslána")
                    {
                        MessageBox.Show("Objednávka byla již odeslána dříve", "Odeslána");
                    }
                    else if (MessageBox.Show($"Opravdu chete odeslat objednávku s ID: {ordersAdministrator.IdObjednavka}?", "Odeslat objednávku", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            databaze.OdeslatObjednavku(ordersAdministrator.IdObjednavka);

                            //refresh produktů v ListBoxu
                            this.ordersAdministrator = databaze.VratVsechnyObjednavky();
                            this.PripojSeznam();
                            MessageBox.Show($"Objednávka s ID: {ordersAdministrator.IdObjednavka} odeslána", "Hotovo");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Při odeslání objednávky s ID: {ordersAdministrator.IdObjednavka} došlo k chybě: " + ex.Message);
                        }
                    }
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///infostrip
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Pro práci s SQLite je nutné nainstalovat NuGet package (balíček NuGet) s názvem \"System.Data.SQLite.Core\"" + Environment.NewLine;
            message += "Po kliknutí pravým tlačítkem na References (Odkazy) vyberte z kontextového menu \"Manage NuGet Packages...\" (\"Spravovat balíčky NuGet...\")" + Environment.NewLine;
            message += "V okně klikněte na procházet a zadejte vyhledání \"System.Data.SQLite.Core\"." + Environment.NewLine;
            message += "Klikněte na nalezený balíček a poté na tlačítko Install (Nainstalovat)." + Environment.NewLine;
            MessageBox.Show(message);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///exit, logout
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            labelIntro.Visible = true;
            labelVytvoritPrihlasitUzivatel.Visible = false;
            labelLogin.Visible = false;
            textBoxUsername.Visible = false;
            textBoxPassword.Visible = false;
            buttonAdministrator.Visible = true;
            buttonZakaznik.Visible = true;
            buttonPrihlasitZakaznik.Visible = false;
            buttonRegisterZakaznik.Visible = false;
            buttonCancel.Visible = false;
            buttonLoginAdministrator.Visible = false;
            buttonLoginZakaznik.Visible = false;
            menuStrip1.Visible = true;
            tabAdministrator.Visible = false;
            tabZakaznik.Visible = false;
            textBoxPassword.Text = null;
            textBoxUsername.Text = null;
            labelCenaPoSleveKosik.Text = null;
            labelCenaPoSleveKosik.Visible = false;
            labelCenaPoSleveKosik2.Visible = false;
            labelDetailZobrazitZakaznik.Visible = true;
            labelDetailZobrazitAdmin.Visible = true;
            listBoxObjednavkyDetail.Visible = false;
            listBoxObjednavkyDetailZakaznik.Visible = false;
            if (kosik != null)
            {
                this.kosik.Clear();
            }
            this.PripojSeznamKosik();
            if (ordersAdministratorDetail != null)
            {
                ordersAdministratorDetail.Clear();
                bindingSourceOrdersDetail.DataSource = null;
            }
            if (ordersZakaznikDetail != null)
            {
                ordersZakaznikDetail.Clear();
                bindingSourceOrdersDetailZakaznik.DataSource = null;
            }
            buttonLogout.Visible = false;
            buttonExit.Visible = false;
            labelIdLoggedUser.Text = null;
            labelUsernameLoggedUser.Text = null;
            labelJmenoLoggedUser.Text = null;
            labelPrijmeniLoggedUser.Text = null;
            labelUzivatel.Visible = false;
            /*
            labelIdLoggedUser.Visible = false;
            labelJmenoLoggedUser.Visible = false;
            labelPrijmeniLoggedUser.Visible = false;
            labelUsernameLoggedUser.Visible = false;
            */
            this.listBoxObjednavky.SelectedIndex = -1;
            this.listBoxObjednavkyZakaznik.SelectedIndex = -1;
            labelUserString.Visible = false;
            labelCenaPoSleveDetailAdmin.Visible = false;
            labelCenaPoSleveDetailAdmin2.Visible = false;
            labelCenaPoSleveObjednavkyAdmin.Visible = false;
            labelCenaPoSleveObjednavkyAdmin2.Visible = false;
            labelAdresaDetailAdmin.Visible = false;
            labelAdresaDetailAdmin2.Visible = false;
            labelZakaznikDetailAdmin.Visible = false;
            labelZakaznikDetailAdmin2.Visible = false;
            labelDatumDetailAdmin.Visible = false;
            labelDatumDetailAdmin2.Visible = false;
            labelSaleTypeDetailAdmin.Visible = false;
            labelSaleTypeDetailAdmin2.Visible = false;
            labelStavDetailAdmin.Visible = false;
            labelStavDetailAdmin2.Visible = false;
            listBoxObjednavkyDetail.Visible = false;
            labelCenaPoSleveDetail.Visible = false;
            labelCenaPoSleveDetail2.Visible = false;
            labelDatumDetailZakaznik.Visible = false;
            labelDatumDetailZakaznik2.Visible = false;
            labelSaletypeDetailZakaznik.Visible = false;
            labelSaletypeDetailZakaznik2.Visible = false;
            labelStavDetailZakaznik.Visible = false;
            labelStavDetailZakaznik2.Visible = false;
            labelCenaPoSleveObjednavky.Visible = false;
            labelCenaPoSleveObjednavky2.Visible = false;
            CenaSale = 0.0;
            Cena = 0.0;
            labelSaleInformation.Visible = false;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}