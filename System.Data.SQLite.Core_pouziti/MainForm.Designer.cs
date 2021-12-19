namespace System.Data.SQLite.Hepipet
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialogDatabaze = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMenuItemDatabaze = new System.Windows.Forms.ToolStripMenuItem();
            this.vytvořitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.připojitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSQLite = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialogDatabaze = new System.Windows.Forms.SaveFileDialog();
            this.tabAdministrator = new System.Windows.Forms.TabControl();
            this.tabPageProdukty = new System.Windows.Forms.TabPage();
            this.listBoxProdukty = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonPridat = new System.Windows.Forms.Button();
            this.tabPageObjednavky = new System.Windows.Forms.TabPage();
            this.labelCenaPoSleveObjednavkyAdmin2 = new System.Windows.Forms.Label();
            this.labelCenaPoSleveObjednavkyAdmin = new System.Windows.Forms.Label();
            this.buttonZrusit = new System.Windows.Forms.Button();
            this.buttonOdeslat = new System.Windows.Forms.Button();
            this.buttonPotvrdit = new System.Windows.Forms.Button();
            this.buttonZamitnout = new System.Windows.Forms.Button();
            this.listBoxObjednavky = new System.Windows.Forms.ListBox();
            this.tabPageDetailObjednavky = new System.Windows.Forms.TabPage();
            this.labelSaleTypeDetailAdmin2 = new System.Windows.Forms.Label();
            this.labelDatumDetailAdmin2 = new System.Windows.Forms.Label();
            this.labelZakaznikDetailAdmin2 = new System.Windows.Forms.Label();
            this.labelAdresaDetailAdmin2 = new System.Windows.Forms.Label();
            this.labelSaleTypeDetailAdmin = new System.Windows.Forms.Label();
            this.labelStavDetailAdmin2 = new System.Windows.Forms.Label();
            this.labelCenaPoSleveDetailAdmin2 = new System.Windows.Forms.Label();
            this.labelDatumDetailAdmin = new System.Windows.Forms.Label();
            this.labelZakaznikDetailAdmin = new System.Windows.Forms.Label();
            this.labelAdresaDetailAdmin = new System.Windows.Forms.Label();
            this.labelStavDetailAdmin = new System.Windows.Forms.Label();
            this.labelCenaPoSleveDetailAdmin = new System.Windows.Forms.Label();
            this.listBoxObjednavkyDetail = new System.Windows.Forms.ListBox();
            this.labelDetailZobrazitAdmin = new System.Windows.Forms.Label();
            this.checkBoxObjednavka = new System.Windows.Forms.CheckBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabZakaznik = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelPocetProduktu = new System.Windows.Forms.Label();
            this.labelCenaPoSleveKosik2 = new System.Windows.Forms.Label();
            this.numericUpDownPocetProduktu = new System.Windows.Forms.NumericUpDown();
            this.labelCenaPoSleveKosik = new System.Windows.Forms.Label();
            this.buttonOdebratPolozkuKosik = new System.Windows.Forms.Button();
            this.buttonObjednat = new System.Windows.Forms.Button();
            this.buttonPridatDoKosiku = new System.Windows.Forms.Button();
            this.listBoxProduktyZakaznik = new System.Windows.Forms.ListBox();
            this.listBoxKosik = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelCenaPoSleveObjednavky2 = new System.Windows.Forms.Label();
            this.labelCenaPoSleveObjednavky = new System.Windows.Forms.Label();
            this.listBoxObjednavkyZakaznik = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelStavDetailZakaznik2 = new System.Windows.Forms.Label();
            this.labelStavDetailZakaznik = new System.Windows.Forms.Label();
            this.labelDatumDetailZakaznik2 = new System.Windows.Forms.Label();
            this.labelDatumDetailZakaznik = new System.Windows.Forms.Label();
            this.labelSaletypeDetailZakaznik2 = new System.Windows.Forms.Label();
            this.labelSaletypeDetailZakaznik = new System.Windows.Forms.Label();
            this.labelCenaPoSleveDetail2 = new System.Windows.Forms.Label();
            this.labelCenaPoSleveDetail = new System.Windows.Forms.Label();
            this.listBoxObjednavkyDetailZakaznik = new System.Windows.Forms.ListBox();
            this.labelDetailZobrazitZakaznik = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelVytvoritPrihlasitUzivatel = new System.Windows.Forms.Label();
            this.buttonLoginZakaznik = new System.Windows.Forms.Button();
            this.buttonLoginAdministrator = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegisterZakaznik = new System.Windows.Forms.Button();
            this.buttonPrihlasitZakaznik = new System.Windows.Forms.Button();
            this.buttonZakaznik = new System.Windows.Forms.Button();
            this.buttonAdministrator = new System.Windows.Forms.Button();
            this.labelIntro = new System.Windows.Forms.Label();
            this.labelIdLoggedUser = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelJmenoLoggedUser = new System.Windows.Forms.Label();
            this.labelPrijmeniLoggedUser = new System.Windows.Forms.Label();
            this.labelUsernameLoggedUser = new System.Windows.Forms.Label();
            this.labelUzivatel = new System.Windows.Forms.Label();
            this.labelUserString = new System.Windows.Forms.Label();
            this.labelSaleInformation = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabAdministrator.SuspendLayout();
            this.tabPageProdukty.SuspendLayout();
            this.tabPageObjednavky.SuspendLayout();
            this.tabPageDetailObjednavky.SuspendLayout();
            this.tabZakaznik.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPocetProduktu)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogDatabaze
            // 
            this.openFileDialogDatabaze.Filter = "Soubory SQLite|*.sqlite";
            // 
            // toolStripMenuItemDatabaze
            // 
            this.toolStripMenuItemDatabaze.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vytvořitToolStripMenuItem,
            this.připojitToolStripMenuItem});
            this.toolStripMenuItemDatabaze.Name = "toolStripMenuItemDatabaze";
            this.toolStripMenuItemDatabaze.Size = new System.Drawing.Size(98, 29);
            this.toolStripMenuItemDatabaze.Text = "Databáze";
            // 
            // vytvořitToolStripMenuItem
            // 
            this.vytvořitToolStripMenuItem.Name = "vytvořitToolStripMenuItem";
            this.vytvořitToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.vytvořitToolStripMenuItem.Text = "Vytvořit";
            this.vytvořitToolStripMenuItem.Click += new System.EventHandler(this.vytvořitToolStripMenuItem_Click);
            // 
            // připojitToolStripMenuItem
            // 
            this.připojitToolStripMenuItem.Name = "připojitToolStripMenuItem";
            this.připojitToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.připojitToolStripMenuItem.Text = "Připojit";
            this.připojitToolStripMenuItem.Click += new System.EventHandler(this.připojitToolStripMenuItem_Click);
            // 
            // toolStripMenuItemSQLite
            // 
            this.toolStripMenuItemSQLite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.toolStripMenuItemSQLite.Name = "toolStripMenuItemSQLite";
            this.toolStripMenuItemSQLite.Size = new System.Drawing.Size(75, 29);
            this.toolStripMenuItemSQLite.Text = "SQLite";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDatabaze,
            this.toolStripMenuItemSQLite});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1188, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveFileDialogDatabaze
            // 
            this.saveFileDialogDatabaze.Filter = "Soubory SQLite|*.sqlite";
            // 
            // tabAdministrator
            // 
            this.tabAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAdministrator.Controls.Add(this.tabPageProdukty);
            this.tabAdministrator.Controls.Add(this.tabPageObjednavky);
            this.tabAdministrator.Controls.Add(this.tabPageDetailObjednavky);
            this.tabAdministrator.Location = new System.Drawing.Point(12, 63);
            this.tabAdministrator.Name = "tabAdministrator";
            this.tabAdministrator.SelectedIndex = 0;
            this.tabAdministrator.Size = new System.Drawing.Size(1177, 623);
            this.tabAdministrator.TabIndex = 4;
            this.tabAdministrator.Visible = false;
            // 
            // tabPageProdukty
            // 
            this.tabPageProdukty.Controls.Add(this.listBoxProdukty);
            this.tabPageProdukty.Controls.Add(this.buttonDelete);
            this.tabPageProdukty.Controls.Add(this.buttonEdit);
            this.tabPageProdukty.Controls.Add(this.buttonPridat);
            this.tabPageProdukty.Location = new System.Drawing.Point(4, 29);
            this.tabPageProdukty.Name = "tabPageProdukty";
            this.tabPageProdukty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProdukty.Size = new System.Drawing.Size(1169, 590);
            this.tabPageProdukty.TabIndex = 0;
            this.tabPageProdukty.Text = "Produkty";
            this.tabPageProdukty.UseVisualStyleBackColor = true;
            // 
            // listBoxProdukty
            // 
            this.listBoxProdukty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProdukty.FormattingEnabled = true;
            this.listBoxProdukty.ItemHeight = 20;
            this.listBoxProdukty.Location = new System.Drawing.Point(127, 3);
            this.listBoxProdukty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxProdukty.Name = "listBoxProdukty";
            this.listBoxProdukty.Size = new System.Drawing.Size(1039, 584);
            this.listBoxProdukty.TabIndex = 5;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(7, 98);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 35);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Smazat";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(7, 53);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 35);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Editovat";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonPridat
            // 
            this.buttonPridat.Location = new System.Drawing.Point(7, 8);
            this.buttonPridat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPridat.Name = "buttonPridat";
            this.buttonPridat.Size = new System.Drawing.Size(112, 35);
            this.buttonPridat.TabIndex = 2;
            this.buttonPridat.Text = "Přidat";
            this.buttonPridat.UseVisualStyleBackColor = true;
            this.buttonPridat.Click += new System.EventHandler(this.buttonPridat_Click);
            // 
            // tabPageObjednavky
            // 
            this.tabPageObjednavky.Controls.Add(this.labelCenaPoSleveObjednavkyAdmin2);
            this.tabPageObjednavky.Controls.Add(this.labelCenaPoSleveObjednavkyAdmin);
            this.tabPageObjednavky.Controls.Add(this.buttonZrusit);
            this.tabPageObjednavky.Controls.Add(this.buttonOdeslat);
            this.tabPageObjednavky.Controls.Add(this.buttonPotvrdit);
            this.tabPageObjednavky.Controls.Add(this.buttonZamitnout);
            this.tabPageObjednavky.Controls.Add(this.listBoxObjednavky);
            this.tabPageObjednavky.Location = new System.Drawing.Point(4, 29);
            this.tabPageObjednavky.Name = "tabPageObjednavky";
            this.tabPageObjednavky.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObjednavky.Size = new System.Drawing.Size(1169, 590);
            this.tabPageObjednavky.TabIndex = 1;
            this.tabPageObjednavky.Text = "Objednávky";
            this.tabPageObjednavky.UseVisualStyleBackColor = true;
            // 
            // labelCenaPoSleveObjednavkyAdmin2
            // 
            this.labelCenaPoSleveObjednavkyAdmin2.AutoSize = true;
            this.labelCenaPoSleveObjednavkyAdmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCenaPoSleveObjednavkyAdmin2.Location = new System.Drawing.Point(11, 226);
            this.labelCenaPoSleveObjednavkyAdmin2.Name = "labelCenaPoSleveObjednavkyAdmin2";
            this.labelCenaPoSleveObjednavkyAdmin2.Size = new System.Drawing.Size(95, 40);
            this.labelCenaPoSleveObjednavkyAdmin2.TabIndex = 8;
            this.labelCenaPoSleveObjednavkyAdmin2.Text = "Cena po \r\nsezóní slevě";
            this.labelCenaPoSleveObjednavkyAdmin2.Visible = false;
            // 
            // labelCenaPoSleveObjednavkyAdmin
            // 
            this.labelCenaPoSleveObjednavkyAdmin.AutoSize = true;
            this.labelCenaPoSleveObjednavkyAdmin.Location = new System.Drawing.Point(11, 272);
            this.labelCenaPoSleveObjednavkyAdmin.Name = "labelCenaPoSleveObjednavkyAdmin";
            this.labelCenaPoSleveObjednavkyAdmin.Size = new System.Drawing.Size(100, 20);
            this.labelCenaPoSleveObjednavkyAdmin.TabIndex = 7;
            this.labelCenaPoSleveObjednavkyAdmin.Text = "labelPoSleve";
            this.labelCenaPoSleveObjednavkyAdmin.Visible = false;
            // 
            // buttonZrusit
            // 
            this.buttonZrusit.Location = new System.Drawing.Point(8, 143);
            this.buttonZrusit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonZrusit.Name = "buttonZrusit";
            this.buttonZrusit.Size = new System.Drawing.Size(112, 35);
            this.buttonZrusit.TabIndex = 4;
            this.buttonZrusit.Text = "Zrušit";
            this.buttonZrusit.UseVisualStyleBackColor = true;
            this.buttonZrusit.Click += new System.EventHandler(this.buttonZrusit_Click);
            // 
            // buttonOdeslat
            // 
            this.buttonOdeslat.Location = new System.Drawing.Point(8, 98);
            this.buttonOdeslat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOdeslat.Name = "buttonOdeslat";
            this.buttonOdeslat.Size = new System.Drawing.Size(112, 35);
            this.buttonOdeslat.TabIndex = 3;
            this.buttonOdeslat.Text = "Odeslat";
            this.buttonOdeslat.UseVisualStyleBackColor = true;
            this.buttonOdeslat.Click += new System.EventHandler(this.buttonOdeslat_Click);
            // 
            // buttonPotvrdit
            // 
            this.buttonPotvrdit.Location = new System.Drawing.Point(8, 53);
            this.buttonPotvrdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPotvrdit.Name = "buttonPotvrdit";
            this.buttonPotvrdit.Size = new System.Drawing.Size(112, 35);
            this.buttonPotvrdit.TabIndex = 2;
            this.buttonPotvrdit.Text = "Potvrdit";
            this.buttonPotvrdit.UseVisualStyleBackColor = true;
            this.buttonPotvrdit.Click += new System.EventHandler(this.buttonPotvrdit_Click);
            // 
            // buttonZamitnout
            // 
            this.buttonZamitnout.Location = new System.Drawing.Point(8, 8);
            this.buttonZamitnout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonZamitnout.Name = "buttonZamitnout";
            this.buttonZamitnout.Size = new System.Drawing.Size(112, 35);
            this.buttonZamitnout.TabIndex = 1;
            this.buttonZamitnout.Text = "Zamítnout";
            this.buttonZamitnout.UseVisualStyleBackColor = true;
            this.buttonZamitnout.Click += new System.EventHandler(this.buttonZamitnout_Click);
            // 
            // listBoxObjednavky
            // 
            this.listBoxObjednavky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxObjednavky.FormattingEnabled = true;
            this.listBoxObjednavky.ItemHeight = 20;
            this.listBoxObjednavky.Location = new System.Drawing.Point(128, 3);
            this.listBoxObjednavky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxObjednavky.Name = "listBoxObjednavky";
            this.listBoxObjednavky.Size = new System.Drawing.Size(1037, 584);
            this.listBoxObjednavky.TabIndex = 6;
            this.listBoxObjednavky.SelectedIndexChanged += new System.EventHandler(this.ListBoxObjednavky_Click);
            // 
            // tabPageDetailObjednavky
            // 
            this.tabPageDetailObjednavky.Controls.Add(this.labelSaleTypeDetailAdmin2);
            this.tabPageDetailObjednavky.Controls.Add(this.labelDatumDetailAdmin2);
            this.tabPageDetailObjednavky.Controls.Add(this.labelZakaznikDetailAdmin2);
            this.tabPageDetailObjednavky.Controls.Add(this.labelAdresaDetailAdmin2);
            this.tabPageDetailObjednavky.Controls.Add(this.labelSaleTypeDetailAdmin);
            this.tabPageDetailObjednavky.Controls.Add(this.labelStavDetailAdmin2);
            this.tabPageDetailObjednavky.Controls.Add(this.labelCenaPoSleveDetailAdmin2);
            this.tabPageDetailObjednavky.Controls.Add(this.labelDatumDetailAdmin);
            this.tabPageDetailObjednavky.Controls.Add(this.labelZakaznikDetailAdmin);
            this.tabPageDetailObjednavky.Controls.Add(this.labelAdresaDetailAdmin);
            this.tabPageDetailObjednavky.Controls.Add(this.labelStavDetailAdmin);
            this.tabPageDetailObjednavky.Controls.Add(this.labelCenaPoSleveDetailAdmin);
            this.tabPageDetailObjednavky.Controls.Add(this.listBoxObjednavkyDetail);
            this.tabPageDetailObjednavky.Controls.Add(this.labelDetailZobrazitAdmin);
            this.tabPageDetailObjednavky.Location = new System.Drawing.Point(4, 29);
            this.tabPageDetailObjednavky.Name = "tabPageDetailObjednavky";
            this.tabPageDetailObjednavky.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetailObjednavky.Size = new System.Drawing.Size(1169, 590);
            this.tabPageDetailObjednavky.TabIndex = 2;
            this.tabPageDetailObjednavky.Text = "Detail objednávky";
            this.tabPageDetailObjednavky.UseVisualStyleBackColor = true;
            // 
            // labelSaleTypeDetailAdmin2
            // 
            this.labelSaleTypeDetailAdmin2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSaleTypeDetailAdmin2.AutoSize = true;
            this.labelSaleTypeDetailAdmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaleTypeDetailAdmin2.Location = new System.Drawing.Point(618, 320);
            this.labelSaleTypeDetailAdmin2.Name = "labelSaleTypeDetailAdmin2";
            this.labelSaleTypeDetailAdmin2.Size = new System.Drawing.Size(86, 20);
            this.labelSaleTypeDetailAdmin2.TabIndex = 1;
            this.labelSaleTypeDetailAdmin2.Text = "Typ slevy:";
            this.labelSaleTypeDetailAdmin2.Visible = false;
            // 
            // labelDatumDetailAdmin2
            // 
            this.labelDatumDetailAdmin2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatumDetailAdmin2.AutoSize = true;
            this.labelDatumDetailAdmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumDetailAdmin2.Location = new System.Drawing.Point(618, 284);
            this.labelDatumDetailAdmin2.Name = "labelDatumDetailAdmin2";
            this.labelDatumDetailAdmin2.Size = new System.Drawing.Size(142, 20);
            this.labelDatumDetailAdmin2.TabIndex = 1;
            this.labelDatumDetailAdmin2.Text = "Datum vytvoření:";
            this.labelDatumDetailAdmin2.Visible = false;
            // 
            // labelZakaznikDetailAdmin2
            // 
            this.labelZakaznikDetailAdmin2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZakaznikDetailAdmin2.AutoSize = true;
            this.labelZakaznikDetailAdmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZakaznikDetailAdmin2.Location = new System.Drawing.Point(618, 218);
            this.labelZakaznikDetailAdmin2.Name = "labelZakaznikDetailAdmin2";
            this.labelZakaznikDetailAdmin2.Size = new System.Drawing.Size(86, 20);
            this.labelZakaznikDetailAdmin2.TabIndex = 1;
            this.labelZakaznikDetailAdmin2.Text = "Zákazník:";
            this.labelZakaznikDetailAdmin2.Visible = false;
            // 
            // labelAdresaDetailAdmin2
            // 
            this.labelAdresaDetailAdmin2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdresaDetailAdmin2.AutoSize = true;
            this.labelAdresaDetailAdmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresaDetailAdmin2.Location = new System.Drawing.Point(618, 249);
            this.labelAdresaDetailAdmin2.Name = "labelAdresaDetailAdmin2";
            this.labelAdresaDetailAdmin2.Size = new System.Drawing.Size(163, 20);
            this.labelAdresaDetailAdmin2.TabIndex = 1;
            this.labelAdresaDetailAdmin2.Text = "Doručovací adresa:";
            this.labelAdresaDetailAdmin2.Visible = false;
            // 
            // labelSaleTypeDetailAdmin
            // 
            this.labelSaleTypeDetailAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSaleTypeDetailAdmin.AutoSize = true;
            this.labelSaleTypeDetailAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaleTypeDetailAdmin.Location = new System.Drawing.Point(715, 320);
            this.labelSaleTypeDetailAdmin.Name = "labelSaleTypeDetailAdmin";
            this.labelSaleTypeDetailAdmin.Size = new System.Drawing.Size(218, 20);
            this.labelSaleTypeDetailAdmin.TabIndex = 1;
            this.labelSaleTypeDetailAdmin.Text = "labelSaleTypeDetailAdmin";
            this.labelSaleTypeDetailAdmin.Visible = false;
            // 
            // labelStavDetailAdmin2
            // 
            this.labelStavDetailAdmin2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStavDetailAdmin2.AutoSize = true;
            this.labelStavDetailAdmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStavDetailAdmin2.Location = new System.Drawing.Point(618, 390);
            this.labelStavDetailAdmin2.Name = "labelStavDetailAdmin2";
            this.labelStavDetailAdmin2.Size = new System.Drawing.Size(144, 20);
            this.labelStavDetailAdmin2.TabIndex = 1;
            this.labelStavDetailAdmin2.Text = "Stav objednávky:";
            this.labelStavDetailAdmin2.Visible = false;
            // 
            // labelCenaPoSleveDetailAdmin2
            // 
            this.labelCenaPoSleveDetailAdmin2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCenaPoSleveDetailAdmin2.AutoSize = true;
            this.labelCenaPoSleveDetailAdmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCenaPoSleveDetailAdmin2.Location = new System.Drawing.Point(618, 356);
            this.labelCenaPoSleveDetailAdmin2.Name = "labelCenaPoSleveDetailAdmin2";
            this.labelCenaPoSleveDetailAdmin2.Size = new System.Drawing.Size(184, 20);
            this.labelCenaPoSleveDetailAdmin2.TabIndex = 1;
            this.labelCenaPoSleveDetailAdmin2.Text = "Cena po sezóní slevě:";
            this.labelCenaPoSleveDetailAdmin2.Visible = false;
            // 
            // labelDatumDetailAdmin
            // 
            this.labelDatumDetailAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatumDetailAdmin.AutoSize = true;
            this.labelDatumDetailAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumDetailAdmin.Location = new System.Drawing.Point(771, 284);
            this.labelDatumDetailAdmin.Name = "labelDatumDetailAdmin";
            this.labelDatumDetailAdmin.Size = new System.Drawing.Size(197, 20);
            this.labelDatumDetailAdmin.TabIndex = 1;
            this.labelDatumDetailAdmin.Text = "labelDatumDetailAdmin";
            this.labelDatumDetailAdmin.Visible = false;
            // 
            // labelZakaznikDetailAdmin
            // 
            this.labelZakaznikDetailAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZakaznikDetailAdmin.AutoSize = true;
            this.labelZakaznikDetailAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZakaznikDetailAdmin.Location = new System.Drawing.Point(709, 218);
            this.labelZakaznikDetailAdmin.Name = "labelZakaznikDetailAdmin";
            this.labelZakaznikDetailAdmin.Size = new System.Drawing.Size(216, 20);
            this.labelZakaznikDetailAdmin.TabIndex = 1;
            this.labelZakaznikDetailAdmin.Text = "labelZakaznikDetailAdmin";
            this.labelZakaznikDetailAdmin.Visible = false;
            // 
            // labelAdresaDetailAdmin
            // 
            this.labelAdresaDetailAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdresaDetailAdmin.AutoSize = true;
            this.labelAdresaDetailAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresaDetailAdmin.Location = new System.Drawing.Point(795, 249);
            this.labelAdresaDetailAdmin.Name = "labelAdresaDetailAdmin";
            this.labelAdresaDetailAdmin.Size = new System.Drawing.Size(201, 20);
            this.labelAdresaDetailAdmin.TabIndex = 1;
            this.labelAdresaDetailAdmin.Text = "labelAdresaDetailAdmin";
            this.labelAdresaDetailAdmin.Visible = false;
            // 
            // labelStavDetailAdmin
            // 
            this.labelStavDetailAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStavDetailAdmin.AutoSize = true;
            this.labelStavDetailAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStavDetailAdmin.Location = new System.Drawing.Point(774, 390);
            this.labelStavDetailAdmin.Name = "labelStavDetailAdmin";
            this.labelStavDetailAdmin.Size = new System.Drawing.Size(180, 20);
            this.labelStavDetailAdmin.TabIndex = 1;
            this.labelStavDetailAdmin.Text = "labelStavDetailAdmin";
            this.labelStavDetailAdmin.Visible = false;
            // 
            // labelCenaPoSleveDetailAdmin
            // 
            this.labelCenaPoSleveDetailAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCenaPoSleveDetailAdmin.AutoSize = true;
            this.labelCenaPoSleveDetailAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCenaPoSleveDetailAdmin.Location = new System.Drawing.Point(815, 356);
            this.labelCenaPoSleveDetailAdmin.Name = "labelCenaPoSleveDetailAdmin";
            this.labelCenaPoSleveDetailAdmin.Size = new System.Drawing.Size(112, 20);
            this.labelCenaPoSleveDetailAdmin.TabIndex = 1;
            this.labelCenaPoSleveDetailAdmin.Text = "labelPoSleve";
            this.labelCenaPoSleveDetailAdmin.Visible = false;
            // 
            // listBoxObjednavkyDetail
            // 
            this.listBoxObjednavkyDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxObjednavkyDetail.FormattingEnabled = true;
            this.listBoxObjednavkyDetail.ItemHeight = 20;
            this.listBoxObjednavkyDetail.Location = new System.Drawing.Point(6, 5);
            this.listBoxObjednavkyDetail.Name = "listBoxObjednavkyDetail";
            this.listBoxObjednavkyDetail.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxObjednavkyDetail.Size = new System.Drawing.Size(548, 564);
            this.listBoxObjednavkyDetail.TabIndex = 0;
            this.listBoxObjednavkyDetail.Visible = false;
            // 
            // labelDetailZobrazitAdmin
            // 
            this.labelDetailZobrazitAdmin.AutoSize = true;
            this.labelDetailZobrazitAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailZobrazitAdmin.Location = new System.Drawing.Point(275, 263);
            this.labelDetailZobrazitAdmin.Name = "labelDetailZobrazitAdmin";
            this.labelDetailZobrazitAdmin.Size = new System.Drawing.Size(619, 64);
            this.labelDetailZobrazitAdmin.TabIndex = 38;
            this.labelDetailZobrazitAdmin.Text = "Pro zobrazení detailu objednávky\r\nvyberte Vámi vybranou objednávku kliknutím";
            this.labelDetailZobrazitAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxObjednavka
            // 
            this.checkBoxObjednavka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxObjednavka.AutoSize = true;
            this.checkBoxObjednavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxObjednavka.Location = new System.Drawing.Point(696, 20);
            this.checkBoxObjednavka.Name = "checkBoxObjednavka";
            this.checkBoxObjednavka.Size = new System.Drawing.Size(297, 41);
            this.checkBoxObjednavka.TabIndex = 30;
            this.checkBoxObjednavka.TabStop = false;
            this.checkBoxObjednavka.Text = "Nová Objednávka";
            this.checkBoxObjednavka.UseVisualStyleBackColor = true;
            this.checkBoxObjednavka.Visible = false;
            this.checkBoxObjednavka.CheckedChanged += new System.EventHandler(this.CheckBoxObjednavka_CheckedChanged);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(1002, -2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(96, 91);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.TabStop = false;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabZakaznik
            // 
            this.tabZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabZakaznik.Controls.Add(this.tabPage1);
            this.tabZakaznik.Controls.Add(this.tabPage2);
            this.tabZakaznik.Controls.Add(this.tabPage3);
            this.tabZakaznik.Location = new System.Drawing.Point(12, 66);
            this.tabZakaznik.Name = "tabZakaznik";
            this.tabZakaznik.SelectedIndex = 0;
            this.tabZakaznik.Size = new System.Drawing.Size(1177, 620);
            this.tabZakaznik.TabIndex = 29;
            this.tabZakaznik.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelPocetProduktu);
            this.tabPage1.Controls.Add(this.labelCenaPoSleveKosik2);
            this.tabPage1.Controls.Add(this.numericUpDownPocetProduktu);
            this.tabPage1.Controls.Add(this.labelCenaPoSleveKosik);
            this.tabPage1.Controls.Add(this.buttonOdebratPolozkuKosik);
            this.tabPage1.Controls.Add(this.buttonObjednat);
            this.tabPage1.Controls.Add(this.buttonPridatDoKosiku);
            this.tabPage1.Controls.Add(this.listBoxProduktyZakaznik);
            this.tabPage1.Controls.Add(this.listBoxKosik);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1169, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Obchod";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelPocetProduktu
            // 
            this.labelPocetProduktu.AutoSize = true;
            this.labelPocetProduktu.Location = new System.Drawing.Point(29, 62);
            this.labelPocetProduktu.Name = "labelPocetProduktu";
            this.labelPocetProduktu.Size = new System.Drawing.Size(121, 20);
            this.labelPocetProduktu.TabIndex = 37;
            this.labelPocetProduktu.Text = "Počet produktů:";
            // 
            // labelCenaPoSleveKosik2
            // 
            this.labelCenaPoSleveKosik2.AutoSize = true;
            this.labelCenaPoSleveKosik2.Location = new System.Drawing.Point(25, 402);
            this.labelCenaPoSleveKosik2.Name = "labelCenaPoSleveKosik2";
            this.labelCenaPoSleveKosik2.Size = new System.Drawing.Size(95, 40);
            this.labelCenaPoSleveKosik2.TabIndex = 36;
            this.labelCenaPoSleveKosik2.Text = "Cena po\r\nsezóní slevě";
            this.labelCenaPoSleveKosik2.Visible = false;
            // 
            // numericUpDownPocetProduktu
            // 
            this.numericUpDownPocetProduktu.Location = new System.Drawing.Point(29, 89);
            this.numericUpDownPocetProduktu.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPocetProduktu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPocetProduktu.Name = "numericUpDownPocetProduktu";
            this.numericUpDownPocetProduktu.Size = new System.Drawing.Size(112, 26);
            this.numericUpDownPocetProduktu.TabIndex = 35;
            this.numericUpDownPocetProduktu.TabStop = false;
            this.numericUpDownPocetProduktu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelCenaPoSleveKosik
            // 
            this.labelCenaPoSleveKosik.AutoSize = true;
            this.labelCenaPoSleveKosik.Location = new System.Drawing.Point(25, 454);
            this.labelCenaPoSleveKosik.Name = "labelCenaPoSleveKosik";
            this.labelCenaPoSleveKosik.Size = new System.Drawing.Size(176, 20);
            this.labelCenaPoSleveKosik.TabIndex = 34;
            this.labelCenaPoSleveKosik.Text = "labelCenaPoSleveKosik";
            this.labelCenaPoSleveKosik.Visible = false;
            // 
            // buttonOdebratPolozkuKosik
            // 
            this.buttonOdebratPolozkuKosik.Location = new System.Drawing.Point(29, 488);
            this.buttonOdebratPolozkuKosik.Name = "buttonOdebratPolozkuKosik";
            this.buttonOdebratPolozkuKosik.Size = new System.Drawing.Size(111, 63);
            this.buttonOdebratPolozkuKosik.TabIndex = 33;
            this.buttonOdebratPolozkuKosik.Text = "Odebrat z košíku";
            this.buttonOdebratPolozkuKosik.UseVisualStyleBackColor = true;
            this.buttonOdebratPolozkuKosik.Click += new System.EventHandler(this.buttonOdebratZKosiku);
            // 
            // buttonObjednat
            // 
            this.buttonObjednat.Location = new System.Drawing.Point(29, 220);
            this.buttonObjednat.Name = "buttonObjednat";
            this.buttonObjednat.Size = new System.Drawing.Size(111, 63);
            this.buttonObjednat.TabIndex = 32;
            this.buttonObjednat.Text = "Objednat";
            this.buttonObjednat.UseVisualStyleBackColor = true;
            this.buttonObjednat.Click += new System.EventHandler(this.buttonObjednat_Click);
            // 
            // buttonPridatDoKosiku
            // 
            this.buttonPridatDoKosiku.Location = new System.Drawing.Point(29, 144);
            this.buttonPridatDoKosiku.Name = "buttonPridatDoKosiku";
            this.buttonPridatDoKosiku.Size = new System.Drawing.Size(111, 63);
            this.buttonPridatDoKosiku.TabIndex = 31;
            this.buttonPridatDoKosiku.Text = "Přidat do košíku";
            this.buttonPridatDoKosiku.UseVisualStyleBackColor = true;
            this.buttonPridatDoKosiku.Click += new System.EventHandler(this.buttonPridatDoKosiku_Click);
            // 
            // listBoxProduktyZakaznik
            // 
            this.listBoxProduktyZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProduktyZakaznik.FormattingEnabled = true;
            this.listBoxProduktyZakaznik.ItemHeight = 20;
            this.listBoxProduktyZakaznik.Location = new System.Drawing.Point(169, 62);
            this.listBoxProduktyZakaznik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxProduktyZakaznik.Name = "listBoxProduktyZakaznik";
            this.listBoxProduktyZakaznik.Size = new System.Drawing.Size(975, 224);
            this.listBoxProduktyZakaznik.TabIndex = 40;
            // 
            // listBoxKosik
            // 
            this.listBoxKosik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxKosik.FormattingEnabled = true;
            this.listBoxKosik.ItemHeight = 20;
            this.listBoxKosik.Location = new System.Drawing.Point(169, 307);
            this.listBoxKosik.Name = "listBoxKosik";
            this.listBoxKosik.Size = new System.Drawing.Size(979, 244);
            this.listBoxKosik.TabIndex = 41;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelCenaPoSleveObjednavky2);
            this.tabPage2.Controls.Add(this.labelCenaPoSleveObjednavky);
            this.tabPage2.Controls.Add(this.listBoxObjednavkyZakaznik);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1169, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Objednávky";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelCenaPoSleveObjednavky2
            // 
            this.labelCenaPoSleveObjednavky2.AutoSize = true;
            this.labelCenaPoSleveObjednavky2.Location = new System.Drawing.Point(8, 560);
            this.labelCenaPoSleveObjednavky2.Name = "labelCenaPoSleveObjednavky2";
            this.labelCenaPoSleveObjednavky2.Size = new System.Drawing.Size(159, 20);
            this.labelCenaPoSleveObjednavky2.TabIndex = 37;
            this.labelCenaPoSleveObjednavky2.Text = "Cena po sezóní slevě";
            this.labelCenaPoSleveObjednavky2.Visible = false;
            // 
            // labelCenaPoSleveObjednavky
            // 
            this.labelCenaPoSleveObjednavky.AutoSize = true;
            this.labelCenaPoSleveObjednavky.Location = new System.Drawing.Point(173, 560);
            this.labelCenaPoSleveObjednavky.Name = "labelCenaPoSleveObjednavky";
            this.labelCenaPoSleveObjednavky.Size = new System.Drawing.Size(220, 20);
            this.labelCenaPoSleveObjednavky.TabIndex = 36;
            this.labelCenaPoSleveObjednavky.Text = "labelCenaPoSleveObjednavky";
            this.labelCenaPoSleveObjednavky.Visible = false;
            // 
            // listBoxObjednavkyZakaznik
            // 
            this.listBoxObjednavkyZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxObjednavkyZakaznik.FormattingEnabled = true;
            this.listBoxObjednavkyZakaznik.ItemHeight = 20;
            this.listBoxObjednavkyZakaznik.Location = new System.Drawing.Point(7, 7);
            this.listBoxObjednavkyZakaznik.Name = "listBoxObjednavkyZakaznik";
            this.listBoxObjednavkyZakaznik.Size = new System.Drawing.Size(1140, 544);
            this.listBoxObjednavkyZakaznik.TabIndex = 0;
            this.listBoxObjednavkyZakaznik.SelectedIndexChanged += new System.EventHandler(this.ListBoxObjednavkyZakaznik_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelStavDetailZakaznik2);
            this.tabPage3.Controls.Add(this.labelStavDetailZakaznik);
            this.tabPage3.Controls.Add(this.labelDatumDetailZakaznik2);
            this.tabPage3.Controls.Add(this.labelDatumDetailZakaznik);
            this.tabPage3.Controls.Add(this.labelSaletypeDetailZakaznik2);
            this.tabPage3.Controls.Add(this.labelSaletypeDetailZakaznik);
            this.tabPage3.Controls.Add(this.labelCenaPoSleveDetail2);
            this.tabPage3.Controls.Add(this.labelCenaPoSleveDetail);
            this.tabPage3.Controls.Add(this.listBoxObjednavkyDetailZakaznik);
            this.tabPage3.Controls.Add(this.labelDetailZobrazitZakaznik);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1169, 587);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Detail objednávky";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelStavDetailZakaznik2
            // 
            this.labelStavDetailZakaznik2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStavDetailZakaznik2.AutoSize = true;
            this.labelStavDetailZakaznik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStavDetailZakaznik2.Location = new System.Drawing.Point(660, 325);
            this.labelStavDetailZakaznik2.Name = "labelStavDetailZakaznik2";
            this.labelStavDetailZakaznik2.Size = new System.Drawing.Size(144, 20);
            this.labelStavDetailZakaznik2.TabIndex = 36;
            this.labelStavDetailZakaznik2.Text = "Stav objednávky:";
            this.labelStavDetailZakaznik2.Visible = false;
            // 
            // labelStavDetailZakaznik
            // 
            this.labelStavDetailZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStavDetailZakaznik.AutoSize = true;
            this.labelStavDetailZakaznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStavDetailZakaznik.Location = new System.Drawing.Point(814, 325);
            this.labelStavDetailZakaznik.Name = "labelStavDetailZakaznik";
            this.labelStavDetailZakaznik.Size = new System.Drawing.Size(202, 20);
            this.labelStavDetailZakaznik.TabIndex = 35;
            this.labelStavDetailZakaznik.Text = "labelStavDetailZakaznik";
            this.labelStavDetailZakaznik.Visible = false;
            // 
            // labelDatumDetailZakaznik2
            // 
            this.labelDatumDetailZakaznik2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatumDetailZakaznik2.AutoSize = true;
            this.labelDatumDetailZakaznik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumDetailZakaznik2.Location = new System.Drawing.Point(660, 215);
            this.labelDatumDetailZakaznik2.Name = "labelDatumDetailZakaznik2";
            this.labelDatumDetailZakaznik2.Size = new System.Drawing.Size(142, 20);
            this.labelDatumDetailZakaznik2.TabIndex = 36;
            this.labelDatumDetailZakaznik2.Text = "Datum vytvoření:";
            this.labelDatumDetailZakaznik2.Visible = false;
            // 
            // labelDatumDetailZakaznik
            // 
            this.labelDatumDetailZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatumDetailZakaznik.AutoSize = true;
            this.labelDatumDetailZakaznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumDetailZakaznik.Location = new System.Drawing.Point(815, 215);
            this.labelDatumDetailZakaznik.Name = "labelDatumDetailZakaznik";
            this.labelDatumDetailZakaznik.Size = new System.Drawing.Size(219, 20);
            this.labelDatumDetailZakaznik.TabIndex = 35;
            this.labelDatumDetailZakaznik.Text = "labelDatumDetailZakaznik";
            this.labelDatumDetailZakaznik.Visible = false;
            // 
            // labelSaletypeDetailZakaznik2
            // 
            this.labelSaletypeDetailZakaznik2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSaletypeDetailZakaznik2.AutoSize = true;
            this.labelSaletypeDetailZakaznik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaletypeDetailZakaznik2.Location = new System.Drawing.Point(660, 255);
            this.labelSaletypeDetailZakaznik2.Name = "labelSaletypeDetailZakaznik2";
            this.labelSaletypeDetailZakaznik2.Size = new System.Drawing.Size(86, 20);
            this.labelSaletypeDetailZakaznik2.TabIndex = 36;
            this.labelSaletypeDetailZakaznik2.Text = "Typ slevy:";
            this.labelSaletypeDetailZakaznik2.Visible = false;
            // 
            // labelSaletypeDetailZakaznik
            // 
            this.labelSaletypeDetailZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSaletypeDetailZakaznik.AutoSize = true;
            this.labelSaletypeDetailZakaznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaletypeDetailZakaznik.Location = new System.Drawing.Point(754, 255);
            this.labelSaletypeDetailZakaznik.Name = "labelSaletypeDetailZakaznik";
            this.labelSaletypeDetailZakaznik.Size = new System.Drawing.Size(236, 20);
            this.labelSaletypeDetailZakaznik.TabIndex = 35;
            this.labelSaletypeDetailZakaznik.Text = "labelSaletypeDetailZakaznik";
            this.labelSaletypeDetailZakaznik.Visible = false;
            // 
            // labelCenaPoSleveDetail2
            // 
            this.labelCenaPoSleveDetail2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCenaPoSleveDetail2.AutoSize = true;
            this.labelCenaPoSleveDetail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCenaPoSleveDetail2.Location = new System.Drawing.Point(660, 290);
            this.labelCenaPoSleveDetail2.Name = "labelCenaPoSleveDetail2";
            this.labelCenaPoSleveDetail2.Size = new System.Drawing.Size(184, 20);
            this.labelCenaPoSleveDetail2.TabIndex = 36;
            this.labelCenaPoSleveDetail2.Text = "Cena po sezóní slevě:";
            this.labelCenaPoSleveDetail2.Visible = false;
            // 
            // labelCenaPoSleveDetail
            // 
            this.labelCenaPoSleveDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCenaPoSleveDetail.AutoSize = true;
            this.labelCenaPoSleveDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCenaPoSleveDetail.Location = new System.Drawing.Point(858, 290);
            this.labelCenaPoSleveDetail.Name = "labelCenaPoSleveDetail";
            this.labelCenaPoSleveDetail.Size = new System.Drawing.Size(201, 20);
            this.labelCenaPoSleveDetail.TabIndex = 35;
            this.labelCenaPoSleveDetail.Text = "labelCenaPoSleveDetail";
            this.labelCenaPoSleveDetail.Visible = false;
            // 
            // listBoxObjednavkyDetailZakaznik
            // 
            this.listBoxObjednavkyDetailZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxObjednavkyDetailZakaznik.FormattingEnabled = true;
            this.listBoxObjednavkyDetailZakaznik.ItemHeight = 20;
            this.listBoxObjednavkyDetailZakaznik.Location = new System.Drawing.Point(6, 7);
            this.listBoxObjednavkyDetailZakaznik.Name = "listBoxObjednavkyDetailZakaznik";
            this.listBoxObjednavkyDetailZakaznik.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxObjednavkyDetailZakaznik.Size = new System.Drawing.Size(584, 564);
            this.listBoxObjednavkyDetailZakaznik.TabIndex = 0;
            this.listBoxObjednavkyDetailZakaznik.Visible = false;
            // 
            // labelDetailZobrazitZakaznik
            // 
            this.labelDetailZobrazitZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDetailZobrazitZakaznik.AutoSize = true;
            this.labelDetailZobrazitZakaznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailZobrazitZakaznik.Location = new System.Drawing.Point(273, 225);
            this.labelDetailZobrazitZakaznik.Name = "labelDetailZobrazitZakaznik";
            this.labelDetailZobrazitZakaznik.Size = new System.Drawing.Size(619, 64);
            this.labelDetailZobrazitZakaznik.TabIndex = 37;
            this.labelDetailZobrazitZakaznik.Text = "Pro zobrazení detailu objednávky\r\nvyberte Vámi vybranou objednávku kliknutím";
            this.labelDetailZobrazitZakaznik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(690, 333);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(161, 26);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Visible = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Location = new System.Drawing.Point(338, 333);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(161, 26);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Visible = false;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(173, 194);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(805, 46);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Prosím, zadejte uživatelské jméno a heslo";
            this.labelLogin.Visible = false;
            // 
            // labelVytvoritPrihlasitUzivatel
            // 
            this.labelVytvoritPrihlasitUzivatel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVytvoritPrihlasitUzivatel.AutoSize = true;
            this.labelVytvoritPrihlasitUzivatel.BackColor = System.Drawing.Color.Transparent;
            this.labelVytvoritPrihlasitUzivatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVytvoritPrihlasitUzivatel.Location = new System.Drawing.Point(163, 194);
            this.labelVytvoritPrihlasitUzivatel.Name = "labelVytvoritPrihlasitUzivatel";
            this.labelVytvoritPrihlasitUzivatel.Size = new System.Drawing.Size(832, 46);
            this.labelVytvoritPrihlasitUzivatel.TabIndex = 11;
            this.labelVytvoritPrihlasitUzivatel.Text = "Chcete se přihlásit nebo vytvořit nový účet?";
            this.labelVytvoritPrihlasitUzivatel.Visible = false;
            // 
            // buttonLoginZakaznik
            // 
            this.buttonLoginZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoginZakaznik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoginZakaznik.Location = new System.Drawing.Point(528, 418);
            this.buttonLoginZakaznik.Name = "buttonLoginZakaznik";
            this.buttonLoginZakaznik.Size = new System.Drawing.Size(121, 35);
            this.buttonLoginZakaznik.TabIndex = 24;
            this.buttonLoginZakaznik.Text = "Login";
            this.buttonLoginZakaznik.UseVisualStyleBackColor = false;
            this.buttonLoginZakaznik.Visible = false;
            this.buttonLoginZakaznik.Click += new System.EventHandler(this.ButtonLoginZakaznik_Click);
            // 
            // buttonLoginAdministrator
            // 
            this.buttonLoginAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoginAdministrator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoginAdministrator.Location = new System.Drawing.Point(528, 418);
            this.buttonLoginAdministrator.Name = "buttonLoginAdministrator";
            this.buttonLoginAdministrator.Size = new System.Drawing.Size(121, 35);
            this.buttonLoginAdministrator.TabIndex = 24;
            this.buttonLoginAdministrator.Text = "Login";
            this.buttonLoginAdministrator.UseVisualStyleBackColor = false;
            this.buttonLoginAdministrator.Visible = false;
            this.buttonLoginAdministrator.Click += new System.EventHandler(this.ButtonLoginAdministrator_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancel.Location = new System.Drawing.Point(528, 501);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 35);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonRegisterZakaznik
            // 
            this.buttonRegisterZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegisterZakaznik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRegisterZakaznik.Location = new System.Drawing.Point(690, 374);
            this.buttonRegisterZakaznik.Name = "buttonRegisterZakaznik";
            this.buttonRegisterZakaznik.Size = new System.Drawing.Size(161, 79);
            this.buttonRegisterZakaznik.TabIndex = 16;
            this.buttonRegisterZakaznik.Text = "Vytvořit";
            this.buttonRegisterZakaznik.UseVisualStyleBackColor = false;
            this.buttonRegisterZakaznik.Visible = false;
            this.buttonRegisterZakaznik.Click += new System.EventHandler(this.ButtonRegisterZakaznik_Click);
            // 
            // buttonPrihlasitZakaznik
            // 
            this.buttonPrihlasitZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrihlasitZakaznik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPrihlasitZakaznik.Location = new System.Drawing.Point(338, 374);
            this.buttonPrihlasitZakaznik.Name = "buttonPrihlasitZakaznik";
            this.buttonPrihlasitZakaznik.Size = new System.Drawing.Size(161, 79);
            this.buttonPrihlasitZakaznik.TabIndex = 15;
            this.buttonPrihlasitZakaznik.Text = "Přihlásit";
            this.buttonPrihlasitZakaznik.UseVisualStyleBackColor = false;
            this.buttonPrihlasitZakaznik.Visible = false;
            this.buttonPrihlasitZakaznik.Click += new System.EventHandler(this.ButtonPrihlasitZakaznik_Click);
            // 
            // buttonZakaznik
            // 
            this.buttonZakaznik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZakaznik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonZakaznik.Location = new System.Drawing.Point(690, 374);
            this.buttonZakaznik.Name = "buttonZakaznik";
            this.buttonZakaznik.Size = new System.Drawing.Size(161, 79);
            this.buttonZakaznik.TabIndex = 14;
            this.buttonZakaznik.Text = "Zákazník";
            this.buttonZakaznik.UseVisualStyleBackColor = false;
            this.buttonZakaznik.Click += new System.EventHandler(this.ButtonZakaznik_Click);
            // 
            // buttonAdministrator
            // 
            this.buttonAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdministrator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdministrator.Location = new System.Drawing.Point(338, 374);
            this.buttonAdministrator.Name = "buttonAdministrator";
            this.buttonAdministrator.Size = new System.Drawing.Size(161, 79);
            this.buttonAdministrator.TabIndex = 13;
            this.buttonAdministrator.Text = "Administrátor";
            this.buttonAdministrator.UseVisualStyleBackColor = false;
            this.buttonAdministrator.Click += new System.EventHandler(this.ButtonAdministrator_Click);
            // 
            // labelIntro
            // 
            this.labelIntro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIntro.AutoSize = true;
            this.labelIntro.BackColor = System.Drawing.Color.Transparent;
            this.labelIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntro.Location = new System.Drawing.Point(121, 157);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(940, 138);
            this.labelIntro.TabIndex = 12;
            this.labelIntro.Text = "Vítejte v aplikaci elektronického obchodu Hepipet\r\n\r\nJste administrátor nebo záka" +
    "zník?\r\n";
            this.labelIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIntro.UseMnemonic = false;
            // 
            // labelIdLoggedUser
            // 
            this.labelIdLoggedUser.AutoSize = true;
            this.labelIdLoggedUser.Location = new System.Drawing.Point(739, 9);
            this.labelIdLoggedUser.Name = "labelIdLoggedUser";
            this.labelIdLoggedUser.Size = new System.Drawing.Size(73, 20);
            this.labelIdLoggedUser.TabIndex = 22;
            this.labelIdLoggedUser.Text = "přihlášen";
            this.labelIdLoggedUser.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1093, -2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(96, 91);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Visible = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // labelJmenoLoggedUser
            // 
            this.labelJmenoLoggedUser.AutoSize = true;
            this.labelJmenoLoggedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJmenoLoggedUser.Location = new System.Drawing.Point(904, 9);
            this.labelJmenoLoggedUser.Name = "labelJmenoLoggedUser";
            this.labelJmenoLoggedUser.Size = new System.Drawing.Size(52, 20);
            this.labelJmenoLoggedUser.TabIndex = 24;
            this.labelJmenoLoggedUser.Text = "jméno";
            this.labelJmenoLoggedUser.Visible = false;
            // 
            // labelPrijmeniLoggedUser
            // 
            this.labelPrijmeniLoggedUser.AutoSize = true;
            this.labelPrijmeniLoggedUser.Location = new System.Drawing.Point(962, 9);
            this.labelPrijmeniLoggedUser.Name = "labelPrijmeniLoggedUser";
            this.labelPrijmeniLoggedUser.Size = new System.Drawing.Size(63, 20);
            this.labelPrijmeniLoggedUser.TabIndex = 25;
            this.labelPrijmeniLoggedUser.Text = "příjmení";
            this.labelPrijmeniLoggedUser.Visible = false;
            // 
            // labelUsernameLoggedUser
            // 
            this.labelUsernameLoggedUser.AutoSize = true;
            this.labelUsernameLoggedUser.Location = new System.Drawing.Point(818, 9);
            this.labelUsernameLoggedUser.Name = "labelUsernameLoggedUser";
            this.labelUsernameLoggedUser.Size = new System.Drawing.Size(80, 20);
            this.labelUsernameLoggedUser.TabIndex = 22;
            this.labelUsernameLoggedUser.Text = "username";
            this.labelUsernameLoggedUser.Visible = false;
            // 
            // labelUzivatel
            // 
            this.labelUzivatel.AutoSize = true;
            this.labelUzivatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUzivatel.Location = new System.Drawing.Point(12, 9);
            this.labelUzivatel.Name = "labelUzivatel";
            this.labelUzivatel.Size = new System.Drawing.Size(78, 20);
            this.labelUzivatel.TabIndex = 26;
            this.labelUzivatel.Text = "Uživatel:";
            this.labelUzivatel.Visible = false;
            // 
            // labelUserString
            // 
            this.labelUserString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserString.Location = new System.Drawing.Point(96, 9);
            this.labelUserString.Name = "labelUserString";
            this.labelUserString.Size = new System.Drawing.Size(588, 26);
            this.labelUserString.TabIndex = 0;
            this.labelUserString.Text = "user";
            this.labelUserString.Visible = false;
            // 
            // labelSaleInformation
            // 
            this.labelSaleInformation.AutoSize = true;
            this.labelSaleInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaleInformation.Location = new System.Drawing.Point(12, 35);
            this.labelSaleInformation.Name = "labelSaleInformation";
            this.labelSaleInformation.Size = new System.Drawing.Size(51, 20);
            this.labelSaleInformation.TabIndex = 37;
            this.labelSaleInformation.Text = "label1";
            this.labelSaleInformation.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::System.Data.SQLite.Hepipet.Properties.Resources.intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1188, 684);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelSaleInformation);
            this.Controls.Add(this.checkBoxObjednavka);
            this.Controls.Add(this.labelPrijmeniLoggedUser);
            this.Controls.Add(this.labelJmenoLoggedUser);
            this.Controls.Add(this.labelUsernameLoggedUser);
            this.Controls.Add(this.labelIdLoggedUser);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonLoginZakaznik);
            this.Controls.Add(this.labelUserString);
            this.Controls.Add(this.labelUzivatel);
            this.Controls.Add(this.labelIntro);
            this.Controls.Add(this.labelVytvoritPrihlasitUzivatel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonRegisterZakaznik);
            this.Controls.Add(this.buttonPrihlasitZakaznik);
            this.Controls.Add(this.buttonLoginAdministrator);
            this.Controls.Add(this.tabAdministrator);
            this.Controls.Add(this.buttonZakaznik);
            this.Controls.Add(this.buttonAdministrator);
            this.Controls.Add(this.tabZakaznik);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1210, 740);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1210, 740);
            this.Name = "MainForm";
            this.Text = "Hepipet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabAdministrator.ResumeLayout(false);
            this.tabPageProdukty.ResumeLayout(false);
            this.tabPageObjednavky.ResumeLayout(false);
            this.tabPageObjednavky.PerformLayout();
            this.tabPageDetailObjednavky.ResumeLayout(false);
            this.tabPageDetailObjednavky.PerformLayout();
            this.tabZakaznik.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPocetProduktu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Windows.Forms.OpenFileDialog openFileDialogDatabaze;
        private Windows.Forms.ToolStripMenuItem toolStripMenuItemDatabaze;
        private Windows.Forms.ToolStripMenuItem vytvořitToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem připojitToolStripMenuItem;
        private Windows.Forms.ToolStripMenuItem toolStripMenuItemSQLite;
        private Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private Windows.Forms.MenuStrip menuStrip1;
        private Windows.Forms.SaveFileDialog saveFileDialogDatabaze;
        private Windows.Forms.TabControl tabAdministrator;
        private Windows.Forms.TabPage tabPageProdukty;
        private Windows.Forms.ListBox listBoxProdukty;
        private Windows.Forms.Button buttonDelete;
        private Windows.Forms.Button buttonEdit;
        private Windows.Forms.Button buttonPridat;
        private Windows.Forms.TabPage tabPageObjednavky;
        private Windows.Forms.TextBox textBoxPassword;
        private Windows.Forms.TextBox textBoxUsername;
        private Windows.Forms.Label labelLogin;
        private Windows.Forms.Label labelVytvoritPrihlasitUzivatel;
        private Windows.Forms.Button buttonLoginZakaznik;
        private Windows.Forms.Button buttonLoginAdministrator;
        private Windows.Forms.Button buttonCancel;
        private Windows.Forms.Button buttonRegisterZakaznik;
        private Windows.Forms.Button buttonPrihlasitZakaznik;
        private Windows.Forms.Button buttonZakaznik;
        private Windows.Forms.Button buttonAdministrator;
        private Windows.Forms.Label labelIntro;
        private Windows.Forms.Button buttonLogout;
        private Windows.Forms.Label labelIdLoggedUser;
        private Windows.Forms.Button buttonExit;
        private Windows.Forms.Label labelJmenoLoggedUser;
        private Windows.Forms.Label labelPrijmeniLoggedUser;
        private Windows.Forms.TabControl tabZakaznik;
        private Windows.Forms.TabPage tabPage2;
        private Windows.Forms.Label labelUsernameLoggedUser;
        private Windows.Forms.ListBox listBoxObjednavkyZakaznik;
        private Windows.Forms.ListBox listBoxObjednavky;
        private Windows.Forms.Button buttonOdeslat;
        private Windows.Forms.Button buttonPotvrdit;
        private Windows.Forms.Button buttonZamitnout;
        private Windows.Forms.CheckBox checkBoxObjednavka;
        private Windows.Forms.Button buttonZrusit;
        private Windows.Forms.TabPage tabPageDetailObjednavky;
        private Windows.Forms.ListBox listBoxObjednavkyDetail;
        private Windows.Forms.TabPage tabPage3;
        private Windows.Forms.ListBox listBoxObjednavkyDetailZakaznik;
        private Windows.Forms.Label labelCenaPoSleveDetail;
        private Windows.Forms.Label labelCenaPoSleveObjednavky;
        private Windows.Forms.Label labelCenaPoSleveObjednavkyAdmin;
        private Windows.Forms.Label labelCenaPoSleveDetailAdmin;
        private Windows.Forms.TabPage tabPage1;
        private Windows.Forms.NumericUpDown numericUpDownPocetProduktu;
        private Windows.Forms.Label labelCenaPoSleveKosik;
        private Windows.Forms.Button buttonOdebratPolozkuKosik;
        private Windows.Forms.Button buttonObjednat;
        private Windows.Forms.Button buttonPridatDoKosiku;
        private Windows.Forms.ListBox listBoxProduktyZakaznik;
        private Windows.Forms.ListBox listBoxKosik;
        private Windows.Forms.Label labelUzivatel;
        private Windows.Forms.Label labelCenaPoSleveObjednavkyAdmin2;
        private Windows.Forms.Label labelCenaPoSleveDetailAdmin2;
        private Windows.Forms.Label labelCenaPoSleveObjednavky2;
        private Windows.Forms.Label labelCenaPoSleveDetail2;
        private Windows.Forms.Label labelCenaPoSleveKosik2;
        private Windows.Forms.Label labelUserString;
        private Windows.Forms.Label labelDetailZobrazitZakaznik;
        private Windows.Forms.Label labelDetailZobrazitAdmin;
        private Windows.Forms.Label labelSaleInformation;
        private Windows.Forms.Label labelSaleTypeDetailAdmin2;
        private Windows.Forms.Label labelDatumDetailAdmin2;
        private Windows.Forms.Label labelZakaznikDetailAdmin2;
        private Windows.Forms.Label labelAdresaDetailAdmin2;
        private Windows.Forms.Label labelSaleTypeDetailAdmin;
        private Windows.Forms.Label labelDatumDetailAdmin;
        private Windows.Forms.Label labelZakaznikDetailAdmin;
        private Windows.Forms.Label labelAdresaDetailAdmin;
        private Windows.Forms.Label labelStavDetailAdmin2;
        private Windows.Forms.Label labelStavDetailAdmin;
        private Windows.Forms.Label labelStavDetailZakaznik2;
        private Windows.Forms.Label labelStavDetailZakaznik;
        private Windows.Forms.Label labelDatumDetailZakaznik2;
        private Windows.Forms.Label labelDatumDetailZakaznik;
        private Windows.Forms.Label labelSaletypeDetailZakaznik2;
        private Windows.Forms.Label labelSaletypeDetailZakaznik;
        private Windows.Forms.Label labelPocetProduktu;
    }
}

