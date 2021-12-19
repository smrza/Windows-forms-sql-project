using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Data.SQLite.Hepipet
{
    public partial class EditorZakaznika : Form
    {
        public EditorZakaznika()
        {
            InitializeComponent();
        }

        public EditorZakaznika(string Username, string Jmeno, string Prijmeni, string Adresa, string Heslo, string Heslo2)
        {
            InitializeComponent();
            this.textBoxUsername.Text = Username;
            this.textBoxJmeno.Text = Jmeno;
            this.textBoxPrijmeni.Text = Prijmeni;
            this.textBoxAdresa.Text = Adresa;
            this.textBoxHeslo.Text = Heslo;
            this.textBoxHeslo2.Text = Heslo2;
        }

        public string Username { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Adresa { get; set; }
        public string Heslo { get; set; }
        public string Heslo2 { get; set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled)
                && ZkontrolujUsername()
                && ZkontrolujJmeno()
                && ZkontrolujPrijmeni()
                && ZkontrolujAdresu()
                && ZkontrolujHeslo()
                && ZkontrolujHeslo2())
            {
                this.Username = this.textBoxUsername.Text;
                this.Jmeno = this.textBoxJmeno.Text;
                this.Prijmeni = this.textBoxPrijmeni.Text;
                this.Heslo = this.textBoxHeslo.Text;
                this.Heslo2 = this.textBoxHeslo2.Text;
                this.Adresa = this.textBoxAdresa.Text;

                //nastavení vracení hodnoty DialogResult.Ok a zavření formuláře
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void buttonStorno_Click(object sender, EventArgs e)
        {
            //zavření formuláře (pozn. tlačítko je již nastaveno, aby vracelo DialogResult.Cancel)
            this.Close();
        }

        private void textBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            ZkontrolujUsername();
        }

        private bool ZkontrolujUsername()
        {
            bool OK = false;
            if (String.IsNullOrWhiteSpace(this.textBoxUsername.Text))
            {
                this.errorProviderUsername.SetError(this.textBoxUsername, "Username nesmí být prázdný!");
            }
            else
            {
                this.errorProviderUsername.SetError(this.textBoxUsername, String.Empty);
                OK = true;
            }
            return OK;
        }

        private void textBoxJmeno_Validating(object sender, CancelEventArgs e)
        {
            ZkontrolujJmeno();
        }

        private bool ZkontrolujJmeno()
        {
            bool OK = false;
            if (String.IsNullOrWhiteSpace(this.textBoxJmeno.Text))
            {
                this.errorProviderJmeno.SetError(this.textBoxJmeno, "Jméno nesmí být prázdné!");
            }
            else
            {
                this.errorProviderJmeno.SetError(this.textBoxJmeno, String.Empty);
                OK = true;
            }
            return OK;
        }



        private void textBoxPrijmeni_Validating(object sender, CancelEventArgs e)
        {
            ZkontrolujPrijmeni();
        }

        private bool ZkontrolujPrijmeni()
        {
            bool OK = false;
            if (String.IsNullOrWhiteSpace(this.textBoxPrijmeni.Text))
            {
                this.errorProviderPrijmeni.SetError(this.textBoxPrijmeni, "Příjmení nesmí být prázdné!");
            }
            else
            {
                this.errorProviderPrijmeni.SetError(this.textBoxPrijmeni, String.Empty);
                OK = true;
            }
            return OK;
        }




        private void textBoxAdresa_Validating(object sender, CancelEventArgs e)
        {
            ZkontrolujAdresu();
        }

        private bool ZkontrolujAdresu()
        {
            bool OK = false;
            if (String.IsNullOrWhiteSpace(this.textBoxAdresa.Text))
            {
                this.errorProviderAdresa.SetError(this.textBoxAdresa, "Adresa nesmí být prázdná!");
            }
            else
            {
                this.errorProviderAdresa.SetError(this.textBoxAdresa, String.Empty);
                OK = true;
            }
            return OK;
        }



        private void textBoxHeslo_Validating(object sender, CancelEventArgs e)
        {
            this.ZkontrolujHeslo();
        }

        private bool ZkontrolujHeslo()
        {
            bool OK = false;
            if (String.IsNullOrWhiteSpace(this.textBoxHeslo.Text))
            {
                this.errorProviderHeslo.SetError(this.textBoxHeslo, "Heslo nesmí být prázdné!");
            }
            else
            {
                this.errorProviderHeslo.SetError(this.textBoxHeslo, String.Empty);
                OK = true;
            }
            return OK;
        }

        private void textBoxHeslo2_Validating(object sender, CancelEventArgs e)
        {
            this.ZkontrolujHeslo2();
        }


        private bool ZkontrolujHeslo2()
        {
            bool OK = false;
            
            if (textBoxHeslo.Text != this.textBoxHeslo2.Text)
            {
                this.errorProviderHeslo2.SetError(this.textBoxHeslo2, "Hesla se musí shodovat!");
            }
            else if (String.IsNullOrWhiteSpace(this.textBoxHeslo2.Text))
            {
                this.errorProviderHeslo2.SetError(this.textBoxHeslo2, "Heslo nesmí být prázdné!");
            }
            else
            {
                this.errorProviderHeslo2.SetError(this.textBoxHeslo2, String.Empty);
                OK = true;
            }
            return OK;
        }
    }
}
