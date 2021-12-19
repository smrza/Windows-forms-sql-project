namespace System.Data.SQLite.Hepipet
{
    partial class EditorProduktu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorProduktu));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNazev = new System.Windows.Forms.Label();
            this.labelKategorie = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.labelPopis = new System.Windows.Forms.Label();
            this.textBoxNazev = new System.Windows.Forms.TextBox();
            this.textBoxKategorie = new System.Windows.Forms.TextBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBoxPopis = new System.Windows.Forms.TextBox();
            this.errorProviderNazev = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKategorie = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCena = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPopis = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNazev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPopis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOK.Location = new System.Drawing.Point(124, 5);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 11;
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
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Storno";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.buttonStorno_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 215);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 45);
            this.panel1.TabIndex = 2;
            // 
            // labelNazev
            // 
            this.labelNazev.AutoSize = true;
            this.labelNazev.Location = new System.Drawing.Point(20, 14);
            this.labelNazev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNazev.Name = "labelNazev";
            this.labelNazev.Size = new System.Drawing.Size(53, 20);
            this.labelNazev.TabIndex = 3;
            this.labelNazev.Text = "Název";
            // 
            // labelKategorie
            // 
            this.labelKategorie.AutoSize = true;
            this.labelKategorie.Location = new System.Drawing.Point(20, 66);
            this.labelKategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKategorie.Name = "labelKategorie";
            this.labelKategorie.Size = new System.Drawing.Size(77, 20);
            this.labelKategorie.TabIndex = 4;
            this.labelKategorie.Text = "Kategorie";
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(20, 122);
            this.labelCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(47, 20);
            this.labelCena.TabIndex = 5;
            this.labelCena.Text = "Cena";
            // 
            // labelPopis
            // 
            this.labelPopis.AutoSize = true;
            this.labelPopis.Location = new System.Drawing.Point(18, 172);
            this.labelPopis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPopis.Name = "labelPopis";
            this.labelPopis.Size = new System.Drawing.Size(48, 20);
            this.labelPopis.TabIndex = 6;
            this.labelPopis.Text = "Popis";
            // 
            // textBoxNazev
            // 
            this.textBoxNazev.Location = new System.Drawing.Point(111, 9);
            this.textBoxNazev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNazev.Name = "textBoxNazev";
            this.textBoxNazev.Size = new System.Drawing.Size(372, 26);
            this.textBoxNazev.TabIndex = 7;
            this.textBoxNazev.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNazev_Validating);
            // 
            // textBoxKategorie
            // 
            this.textBoxKategorie.Location = new System.Drawing.Point(111, 62);
            this.textBoxKategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKategorie.Name = "textBoxKategorie";
            this.textBoxKategorie.Size = new System.Drawing.Size(372, 26);
            this.textBoxKategorie.TabIndex = 8;
            this.textBoxKategorie.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKategorie_Validating);
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(111, 117);
            this.textBoxCena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(372, 26);
            this.textBoxCena.TabIndex = 9;
            this.textBoxCena.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCena_Validating);
            // 
            // textBoxPopis
            // 
            this.textBoxPopis.Location = new System.Drawing.Point(111, 168);
            this.textBoxPopis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPopis.Name = "textBoxPopis";
            this.textBoxPopis.Size = new System.Drawing.Size(372, 26);
            this.textBoxPopis.TabIndex = 10;
            this.textBoxPopis.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPopis_Validating);
            // 
            // errorProviderNazev
            // 
            this.errorProviderNazev.ContainerControl = this;
            this.errorProviderNazev.DataMember = "";
            // 
            // errorProviderKategorie
            // 
            this.errorProviderKategorie.ContainerControl = this;
            // 
            // errorProviderCena
            // 
            this.errorProviderCena.ContainerControl = this;
            // 
            // errorProviderPopis
            // 
            this.errorProviderPopis.ContainerControl = this;
            // 
            // EditorProduktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::System.Data.SQLite.Hepipet.Properties.Resources.addforms;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(524, 260);
            this.Controls.Add(this.textBoxPopis);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.textBoxKategorie);
            this.Controls.Add(this.textBoxNazev);
            this.Controls.Add(this.labelPopis);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.labelKategorie);
            this.Controls.Add(this.labelNazev);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(546, 316);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 316);
            this.Name = "EditorProduktu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editace Produktu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNazev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPopis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Button btnOK;
        private Windows.Forms.Button btnCancel;
        private Windows.Forms.Panel panel1;
        private Windows.Forms.Label labelNazev;
        private Windows.Forms.Label labelKategorie;
        private Windows.Forms.Label labelCena;
        private Windows.Forms.Label labelPopis;
        private Windows.Forms.TextBox textBoxNazev;
        private Windows.Forms.TextBox textBoxKategorie;
        private Windows.Forms.TextBox textBoxCena;
        private Windows.Forms.TextBox textBoxPopis;
        private Windows.Forms.ErrorProvider errorProviderNazev;
        private Windows.Forms.ErrorProvider errorProviderKategorie;
        private Windows.Forms.ErrorProvider errorProviderCena;
        private Windows.Forms.ErrorProvider errorProviderPopis;
    }
}