namespace System.Data.SQLite.Hepipet
{
    partial class VolbaLogovani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolbaLogovani));
            this.labelVolbaLogovani = new System.Windows.Forms.Label();
            this.buttonKonzole = new System.Windows.Forms.Button();
            this.buttonSoubor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVolbaLogovani
            // 
            this.labelVolbaLogovani.AutoSize = true;
            this.labelVolbaLogovani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolbaLogovani.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelVolbaLogovani.Location = new System.Drawing.Point(33, 51);
            this.labelVolbaLogovani.Name = "labelVolbaLogovani";
            this.labelVolbaLogovani.Size = new System.Drawing.Size(389, 20);
            this.labelVolbaLogovani.TabIndex = 0;
            this.labelVolbaLogovani.Text = "Přejete si logovat do konzole nebo do souboru?";
            // 
            // buttonKonzole
            // 
            this.buttonKonzole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonKonzole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKonzole.Location = new System.Drawing.Point(85, 109);
            this.buttonKonzole.Name = "buttonKonzole";
            this.buttonKonzole.Size = new System.Drawing.Size(119, 67);
            this.buttonKonzole.TabIndex = 1;
            this.buttonKonzole.Text = "Konzole";
            this.buttonKonzole.UseVisualStyleBackColor = false;
            this.buttonKonzole.Click += new System.EventHandler(this.ButtonKonzole_Click);
            // 
            // buttonSoubor
            // 
            this.buttonSoubor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSoubor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoubor.Location = new System.Drawing.Point(247, 109);
            this.buttonSoubor.Name = "buttonSoubor";
            this.buttonSoubor.Size = new System.Drawing.Size(119, 67);
            this.buttonSoubor.TabIndex = 2;
            this.buttonSoubor.Text = "Soubor";
            this.buttonSoubor.UseVisualStyleBackColor = false;
            this.buttonSoubor.Click += new System.EventHandler(this.ButtonSoubor_Click);
            // 
            // VolbaLogovani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(459, 229);
            this.Controls.Add(this.buttonSoubor);
            this.Controls.Add(this.buttonKonzole);
            this.Controls.Add(this.labelVolbaLogovani);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(481, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(481, 285);
            this.Name = "VolbaLogovani";
            this.Text = "Volba Logování";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Label labelVolbaLogovani;
        private Windows.Forms.Button buttonKonzole;
        private Windows.Forms.Button buttonSoubor;
    }
}