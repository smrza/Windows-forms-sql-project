namespace System.Data.SQLite.Hepipet
{
    partial class EditorZakaznika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorZakaznika));
            this.textBoxHeslo = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxPrijmeni = new System.Windows.Forms.TextBox();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.labelHeslo = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelPrijmeni = new System.Windows.Forms.Label();
            this.labelJmeno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxHeslo2 = new System.Windows.Forms.TextBox();
            this.labelConfirmHeslo = new System.Windows.Forms.Label();
            this.errorProviderJmeno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrijmeni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHeslo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHeslo2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderJmeno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrijmeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHeslo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHeslo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxHeslo
            // 
            this.textBoxHeslo.Location = new System.Drawing.Point(118, 160);
            this.textBoxHeslo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHeslo.Name = "textBoxHeslo";
            this.textBoxHeslo.PasswordChar = '*';
            this.textBoxHeslo.Size = new System.Drawing.Size(372, 26);
            this.textBoxHeslo.TabIndex = 19;
            this.textBoxHeslo.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHeslo_Validating);
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(118, 261);
            this.textBoxAdresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(372, 26);
            this.textBoxAdresa.TabIndex = 22;
            this.textBoxAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdresa_Validating);
            // 
            // textBoxPrijmeni
            // 
            this.textBoxPrijmeni.Location = new System.Drawing.Point(118, 114);
            this.textBoxPrijmeni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrijmeni.Name = "textBoxPrijmeni";
            this.textBoxPrijmeni.Size = new System.Drawing.Size(372, 26);
            this.textBoxPrijmeni.TabIndex = 17;
            this.textBoxPrijmeni.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrijmeni_Validating);
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(118, 67);
            this.textBoxJmeno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(372, 26);
            this.textBoxJmeno.TabIndex = 16;
            this.textBoxJmeno.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxJmeno_Validating);
            // 
            // labelHeslo
            // 
            this.labelHeslo.AutoSize = true;
            this.labelHeslo.Location = new System.Drawing.Point(27, 160);
            this.labelHeslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeslo.Name = "labelHeslo";
            this.labelHeslo.Size = new System.Drawing.Size(50, 20);
            this.labelHeslo.TabIndex = 15;
            this.labelHeslo.Text = "Heslo";
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(31, 261);
            this.labelAdresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(60, 20);
            this.labelAdresa.TabIndex = 14;
            this.labelAdresa.Text = "Adresa";
            // 
            // labelPrijmeni
            // 
            this.labelPrijmeni.AutoSize = true;
            this.labelPrijmeni.Location = new System.Drawing.Point(27, 118);
            this.labelPrijmeni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrijmeni.Name = "labelPrijmeni";
            this.labelPrijmeni.Size = new System.Drawing.Size(64, 20);
            this.labelPrijmeni.TabIndex = 13;
            this.labelPrijmeni.Text = "Příjmení";
            // 
            // labelJmeno
            // 
            this.labelJmeno.AutoSize = true;
            this.labelJmeno.Location = new System.Drawing.Point(27, 72);
            this.labelJmeno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJmeno.Name = "labelJmeno";
            this.labelJmeno.Size = new System.Drawing.Size(57, 20);
            this.labelJmeno.TabIndex = 12;
            this.labelJmeno.Text = "Jméno";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 306);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 45);
            this.panel1.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOK.Location = new System.Drawing.Point(124, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Storno";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.buttonStorno_Click);
            // 
            // textBoxHeslo2
            // 
            this.textBoxHeslo2.Location = new System.Drawing.Point(118, 210);
            this.textBoxHeslo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHeslo2.Name = "textBoxHeslo2";
            this.textBoxHeslo2.PasswordChar = '*';
            this.textBoxHeslo2.Size = new System.Drawing.Size(372, 26);
            this.textBoxHeslo2.TabIndex = 21;
            this.textBoxHeslo2.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHeslo2_Validating);
            // 
            // labelConfirmHeslo
            // 
            this.labelConfirmHeslo.AutoSize = true;
            this.labelConfirmHeslo.Location = new System.Drawing.Point(29, 196);
            this.labelConfirmHeslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmHeslo.Name = "labelConfirmHeslo";
            this.labelConfirmHeslo.Size = new System.Drawing.Size(62, 40);
            this.labelConfirmHeslo.TabIndex = 20;
            this.labelConfirmHeslo.Text = "Potvrdit\r\nheslo";
            // 
            // errorProviderJmeno
            // 
            this.errorProviderJmeno.ContainerControl = this;
            // 
            // errorProviderPrijmeni
            // 
            this.errorProviderPrijmeni.ContainerControl = this;
            // 
            // errorProviderHeslo
            // 
            this.errorProviderHeslo.ContainerControl = this;
            // 
            // errorProviderHeslo2
            // 
            this.errorProviderHeslo2.ContainerControl = this;
            // 
            // errorProviderAdresa
            // 
            this.errorProviderAdresa.ContainerControl = this;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(118, 21);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(372, 26);
            this.textBoxUsername.TabIndex = 15;
            this.textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsername_Validating);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(27, 14);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(90, 40);
            this.labelUsername.TabIndex = 12;
            this.labelUsername.Text = "Uživatelské\r\njméno";
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.ContainerControl = this;
            // 
            // EditorZakaznika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::System.Data.SQLite.Hepipet.Properties.Resources.addforms;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 351);
            this.Controls.Add(this.textBoxHeslo2);
            this.Controls.Add(this.labelConfirmHeslo);
            this.Controls.Add(this.textBoxHeslo);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.textBoxPrijmeni);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.labelHeslo);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.labelPrijmeni);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelJmeno);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 407);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(551, 407);
            this.Name = "EditorZakaznika";
            this.Text = "Editace Údajů";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderJmeno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrijmeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHeslo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHeslo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.TextBox textBoxHeslo;
        private Windows.Forms.TextBox textBoxAdresa;
        private Windows.Forms.TextBox textBoxPrijmeni;
        private Windows.Forms.TextBox textBoxJmeno;
        private Windows.Forms.Label labelHeslo;
        private Windows.Forms.Label labelAdresa;
        private Windows.Forms.Label labelPrijmeni;
        private Windows.Forms.Label labelJmeno;
        private Windows.Forms.Panel panel1;
        private Windows.Forms.Button btnOK;
        private Windows.Forms.Button btnCancel;
        private Windows.Forms.TextBox textBoxHeslo2;
        private Windows.Forms.Label labelConfirmHeslo;
        private Windows.Forms.ErrorProvider errorProviderJmeno;
        private Windows.Forms.ErrorProvider errorProviderPrijmeni;
        private Windows.Forms.ErrorProvider errorProviderHeslo;
        private Windows.Forms.ErrorProvider errorProviderHeslo2;
        private Windows.Forms.ErrorProvider errorProviderAdresa;
        private Windows.Forms.TextBox textBoxUsername;
        private Windows.Forms.Label labelUsername;
        private Windows.Forms.ErrorProvider errorProviderUsername;
    }
}