namespace Maszyna_vendingowa
{
    partial class pzMaszynaVendingowa
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pzMaszynaVendingowa));
            this.pzlblTytuł = new System.Windows.Forms.Label();
            this.pzlblWaluta = new System.Windows.Forms.Label();
            this.pzcmbWaluta = new System.Windows.Forms.ComboBox();
            this.pzlblRodzajPłatności = new System.Windows.Forms.Label();
            this.pzcmbRodzajPłatności = new System.Windows.Forms.ComboBox();
            this.pzlblMonety = new System.Windows.Forms.Label();
            this.pzbtnMoneta05 = new System.Windows.Forms.Button();
            this.pzbtnMoneta1 = new System.Windows.Forms.Button();
            this.pzbtnMoneta2 = new System.Windows.Forms.Button();
            this.pzbtnMoneta5 = new System.Windows.Forms.Button();
            this.pzlblPrzedmioty = new System.Windows.Forms.Label();
            this.pzbtnPepsi = new System.Windows.Forms.Button();
            this.pzbtnMirinda = new System.Windows.Forms.Button();
            this.pzbtnSprite = new System.Windows.Forms.Button();
            this.pzbtnDoZapłaty = new System.Windows.Forms.Label();
            this.pztxtDoZapłaty = new System.Windows.Forms.TextBox();
            this.pzlblWrzuconeMonety = new System.Windows.Forms.Label();
            this.pztxtWrzuconeMonety = new System.Windows.Forms.TextBox();
            this.pzbtnZapłaćMonetami = new System.Windows.Forms.Button();
            this.pzlblDostępnaKwota = new System.Windows.Forms.Label();
            this.pzlblIlośćMonetONominale05 = new System.Windows.Forms.Label();
            this.pzlblIlośćMonetONominale1 = new System.Windows.Forms.Label();
            this.pzlblIlośćMonetONominale2 = new System.Windows.Forms.Label();
            this.pzbtnZapłaćKartą = new System.Windows.Forms.Button();
            this.pzlblIlośćMonetONominale5 = new System.Windows.Forms.Label();
            this.pzBłąd = new System.Windows.Forms.ErrorProvider(this.components);
            this.pzWalutaDoZapłaty = new System.Windows.Forms.Label();
            this.pzbtnAnuluj = new System.Windows.Forms.Button();
            this.pzlblWalutaWrzuconych = new System.Windows.Forms.Label();
            this.pzbtnCocaCola = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pzBłąd)).BeginInit();
            this.SuspendLayout();
            // 
            // pzlblTytuł
            // 
            resources.ApplyResources(this.pzlblTytuł, "pzlblTytuł");
            this.pzlblTytuł.Name = "pzlblTytuł";
            // 
            // pzlblWaluta
            // 
            resources.ApplyResources(this.pzlblWaluta, "pzlblWaluta");
            this.pzlblWaluta.Name = "pzlblWaluta";
            // 
            // pzcmbWaluta
            // 
            this.pzcmbWaluta.FormattingEnabled = true;
            this.pzcmbWaluta.Items.AddRange(new object[] {
            resources.GetString("pzcmbWaluta.Items"),
            resources.GetString("pzcmbWaluta.Items1"),
            resources.GetString("pzcmbWaluta.Items2")});
            resources.ApplyResources(this.pzcmbWaluta, "pzcmbWaluta");
            this.pzcmbWaluta.Name = "pzcmbWaluta";
            this.pzcmbWaluta.SelectedIndexChanged += new System.EventHandler(this.pzcmbWaluta_SelectedIndexChanged);
            // 
            // pzlblRodzajPłatności
            // 
            resources.ApplyResources(this.pzlblRodzajPłatności, "pzlblRodzajPłatności");
            this.pzlblRodzajPłatności.Name = "pzlblRodzajPłatności";
            // 
            // pzcmbRodzajPłatności
            // 
            resources.ApplyResources(this.pzcmbRodzajPłatności, "pzcmbRodzajPłatności");
            this.pzcmbRodzajPłatności.FormattingEnabled = true;
            this.pzcmbRodzajPłatności.Items.AddRange(new object[] {
            resources.GetString("pzcmbRodzajPłatności.Items"),
            resources.GetString("pzcmbRodzajPłatności.Items1")});
            this.pzcmbRodzajPłatności.Name = "pzcmbRodzajPłatności";
            this.pzcmbRodzajPłatności.SelectedIndexChanged += new System.EventHandler(this.pzcmbRodzajPłatności_SelectedIndexChanged);
            // 
            // pzlblMonety
            // 
            resources.ApplyResources(this.pzlblMonety, "pzlblMonety");
            this.pzlblMonety.Name = "pzlblMonety";
            // 
            // pzbtnMoneta05
            // 
            resources.ApplyResources(this.pzbtnMoneta05, "pzbtnMoneta05");
            this.pzbtnMoneta05.Name = "pzbtnMoneta05";
            this.pzbtnMoneta05.UseVisualStyleBackColor = true;
            this.pzbtnMoneta05.Click += new System.EventHandler(this.pzbtnMoneta05_Click);
            // 
            // pzbtnMoneta1
            // 
            resources.ApplyResources(this.pzbtnMoneta1, "pzbtnMoneta1");
            this.pzbtnMoneta1.Name = "pzbtnMoneta1";
            this.pzbtnMoneta1.UseVisualStyleBackColor = true;
            this.pzbtnMoneta1.Click += new System.EventHandler(this.pzbtnMoneta1_Click);
            // 
            // pzbtnMoneta2
            // 
            resources.ApplyResources(this.pzbtnMoneta2, "pzbtnMoneta2");
            this.pzbtnMoneta2.Name = "pzbtnMoneta2";
            this.pzbtnMoneta2.UseVisualStyleBackColor = true;
            this.pzbtnMoneta2.Click += new System.EventHandler(this.pzbtnMoneta2_Click);
            // 
            // pzbtnMoneta5
            // 
            resources.ApplyResources(this.pzbtnMoneta5, "pzbtnMoneta5");
            this.pzbtnMoneta5.Name = "pzbtnMoneta5";
            this.pzbtnMoneta5.UseVisualStyleBackColor = true;
            this.pzbtnMoneta5.Click += new System.EventHandler(this.pzbtnMoneta5_Click);
            // 
            // pzlblPrzedmioty
            // 
            resources.ApplyResources(this.pzlblPrzedmioty, "pzlblPrzedmioty");
            this.pzlblPrzedmioty.Name = "pzlblPrzedmioty";
            // 
            // pzbtnPepsi
            // 
            resources.ApplyResources(this.pzbtnPepsi, "pzbtnPepsi");
            this.pzbtnPepsi.Name = "pzbtnPepsi";
            this.pzbtnPepsi.UseVisualStyleBackColor = true;
            this.pzbtnPepsi.Click += new System.EventHandler(this.pzbtnPepsi_Click);
            // 
            // pzbtnMirinda
            // 
            resources.ApplyResources(this.pzbtnMirinda, "pzbtnMirinda");
            this.pzbtnMirinda.Name = "pzbtnMirinda";
            this.pzbtnMirinda.UseVisualStyleBackColor = true;
            this.pzbtnMirinda.Click += new System.EventHandler(this.pzbtnMirinda_Click);
            // 
            // pzbtnSprite
            // 
            resources.ApplyResources(this.pzbtnSprite, "pzbtnSprite");
            this.pzbtnSprite.Name = "pzbtnSprite";
            this.pzbtnSprite.UseVisualStyleBackColor = true;
            this.pzbtnSprite.Click += new System.EventHandler(this.pzbtnSprite_Click);
            // 
            // pzbtnDoZapłaty
            // 
            resources.ApplyResources(this.pzbtnDoZapłaty, "pzbtnDoZapłaty");
            this.pzbtnDoZapłaty.Name = "pzbtnDoZapłaty";
            // 
            // pztxtDoZapłaty
            // 
            resources.ApplyResources(this.pztxtDoZapłaty, "pztxtDoZapłaty");
            this.pztxtDoZapłaty.Name = "pztxtDoZapłaty";
            this.pztxtDoZapłaty.ReadOnly = true;
            // 
            // pzlblWrzuconeMonety
            // 
            resources.ApplyResources(this.pzlblWrzuconeMonety, "pzlblWrzuconeMonety");
            this.pzlblWrzuconeMonety.Name = "pzlblWrzuconeMonety";
            // 
            // pztxtWrzuconeMonety
            // 
            resources.ApplyResources(this.pztxtWrzuconeMonety, "pztxtWrzuconeMonety");
            this.pztxtWrzuconeMonety.Name = "pztxtWrzuconeMonety";
            this.pztxtWrzuconeMonety.ReadOnly = true;
            // 
            // pzbtnZapłaćMonetami
            // 
            resources.ApplyResources(this.pzbtnZapłaćMonetami, "pzbtnZapłaćMonetami");
            this.pzbtnZapłaćMonetami.Name = "pzbtnZapłaćMonetami";
            this.pzbtnZapłaćMonetami.UseVisualStyleBackColor = true;
            this.pzbtnZapłaćMonetami.Click += new System.EventHandler(this.pzbtnZapłaćMonetami_Click);
            // 
            // pzlblDostępnaKwota
            // 
            resources.ApplyResources(this.pzlblDostępnaKwota, "pzlblDostępnaKwota");
            this.pzlblDostępnaKwota.Name = "pzlblDostępnaKwota";
            // 
            // pzlblIlośćMonetONominale05
            // 
            resources.ApplyResources(this.pzlblIlośćMonetONominale05, "pzlblIlośćMonetONominale05");
            this.pzlblIlośćMonetONominale05.Name = "pzlblIlośćMonetONominale05";
            // 
            // pzlblIlośćMonetONominale1
            // 
            resources.ApplyResources(this.pzlblIlośćMonetONominale1, "pzlblIlośćMonetONominale1");
            this.pzlblIlośćMonetONominale1.Name = "pzlblIlośćMonetONominale1";
            // 
            // pzlblIlośćMonetONominale2
            // 
            resources.ApplyResources(this.pzlblIlośćMonetONominale2, "pzlblIlośćMonetONominale2");
            this.pzlblIlośćMonetONominale2.Name = "pzlblIlośćMonetONominale2";
            // 
            // pzbtnZapłaćKartą
            // 
            resources.ApplyResources(this.pzbtnZapłaćKartą, "pzbtnZapłaćKartą");
            this.pzbtnZapłaćKartą.Name = "pzbtnZapłaćKartą";
            this.pzbtnZapłaćKartą.UseVisualStyleBackColor = true;
            this.pzbtnZapłaćKartą.Click += new System.EventHandler(this.pzbtnZapłaćKartą_Click);
            // 
            // pzlblIlośćMonetONominale5
            // 
            resources.ApplyResources(this.pzlblIlośćMonetONominale5, "pzlblIlośćMonetONominale5");
            this.pzlblIlośćMonetONominale5.Name = "pzlblIlośćMonetONominale5";
            // 
            // pzBłąd
            // 
            this.pzBłąd.ContainerControl = this;
            // 
            // pzWalutaDoZapłaty
            // 
            resources.ApplyResources(this.pzWalutaDoZapłaty, "pzWalutaDoZapłaty");
            this.pzWalutaDoZapłaty.Name = "pzWalutaDoZapłaty";
            // 
            // pzbtnAnuluj
            // 
            resources.ApplyResources(this.pzbtnAnuluj, "pzbtnAnuluj");
            this.pzbtnAnuluj.Name = "pzbtnAnuluj";
            this.pzbtnAnuluj.UseVisualStyleBackColor = true;
            this.pzbtnAnuluj.Click += new System.EventHandler(this.pzbtnAnuluj_Click);
            // 
            // pzlblWalutaWrzuconych
            // 
            resources.ApplyResources(this.pzlblWalutaWrzuconych, "pzlblWalutaWrzuconych");
            this.pzlblWalutaWrzuconych.Name = "pzlblWalutaWrzuconych";
            // 
            // pzbtnCocaCola
            // 
            resources.ApplyResources(this.pzbtnCocaCola, "pzbtnCocaCola");
            this.pzbtnCocaCola.Name = "pzbtnCocaCola";
            this.pzbtnCocaCola.UseVisualStyleBackColor = true;
            this.pzbtnCocaCola.Click += new System.EventHandler(this.pzbtnCocaCola_Click);
            // 
            // pzMaszynaVendingowa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pzlblWalutaWrzuconych);
            this.Controls.Add(this.pzbtnAnuluj);
            this.Controls.Add(this.pzWalutaDoZapłaty);
            this.Controls.Add(this.pzlblIlośćMonetONominale5);
            this.Controls.Add(this.pzbtnZapłaćKartą);
            this.Controls.Add(this.pzlblIlośćMonetONominale2);
            this.Controls.Add(this.pzlblIlośćMonetONominale1);
            this.Controls.Add(this.pzlblIlośćMonetONominale05);
            this.Controls.Add(this.pzlblDostępnaKwota);
            this.Controls.Add(this.pzbtnZapłaćMonetami);
            this.Controls.Add(this.pztxtWrzuconeMonety);
            this.Controls.Add(this.pzlblWrzuconeMonety);
            this.Controls.Add(this.pztxtDoZapłaty);
            this.Controls.Add(this.pzbtnDoZapłaty);
            this.Controls.Add(this.pzbtnSprite);
            this.Controls.Add(this.pzbtnMirinda);
            this.Controls.Add(this.pzbtnPepsi);
            this.Controls.Add(this.pzbtnCocaCola);
            this.Controls.Add(this.pzlblPrzedmioty);
            this.Controls.Add(this.pzbtnMoneta5);
            this.Controls.Add(this.pzbtnMoneta2);
            this.Controls.Add(this.pzbtnMoneta1);
            this.Controls.Add(this.pzbtnMoneta05);
            this.Controls.Add(this.pzlblMonety);
            this.Controls.Add(this.pzcmbRodzajPłatności);
            this.Controls.Add(this.pzlblRodzajPłatności);
            this.Controls.Add(this.pzcmbWaluta);
            this.Controls.Add(this.pzlblWaluta);
            this.Controls.Add(this.pzlblTytuł);
            this.Name = "pzMaszynaVendingowa";
            this.Load += new System.EventHandler(this.pzMaszynaVendingowa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pzBłąd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pzlblTytuł;
        private System.Windows.Forms.Label pzlblWaluta;
        private System.Windows.Forms.ComboBox pzcmbWaluta;
        private System.Windows.Forms.Label pzlblRodzajPłatności;
        private System.Windows.Forms.ComboBox pzcmbRodzajPłatności;
        private System.Windows.Forms.Label pzlblMonety;
        private System.Windows.Forms.Button pzbtnMoneta05;
        private System.Windows.Forms.Button pzbtnMoneta1;
        private System.Windows.Forms.Button pzbtnMoneta2;
        private System.Windows.Forms.Button pzbtnMoneta5;
        private System.Windows.Forms.Label pzlblPrzedmioty;
        private System.Windows.Forms.Button pzbtnCocaCola;
        private System.Windows.Forms.Button pzbtnPepsi;
        private System.Windows.Forms.Button pzbtnMirinda;
        private System.Windows.Forms.Button pzbtnSprite;
        private System.Windows.Forms.Label pzbtnDoZapłaty;
        private System.Windows.Forms.TextBox pztxtDoZapłaty;
        private System.Windows.Forms.Label pzlblWrzuconeMonety;
        private System.Windows.Forms.TextBox pztxtWrzuconeMonety;
        private System.Windows.Forms.Button pzbtnZapłaćMonetami;
        private System.Windows.Forms.Label pzlblDostępnaKwota;
        private System.Windows.Forms.Label pzlblIlośćMonetONominale05;
        private System.Windows.Forms.Label pzlblIlośćMonetONominale1;
        private System.Windows.Forms.Label pzlblIlośćMonetONominale2;
        private System.Windows.Forms.Button pzbtnZapłaćKartą;
        private System.Windows.Forms.Label pzlblIlośćMonetONominale5;
        private System.Windows.Forms.ErrorProvider pzBłąd;
        private System.Windows.Forms.Label pzWalutaDoZapłaty;
        private System.Windows.Forms.Button pzbtnAnuluj;
        private System.Windows.Forms.Label pzlblWalutaWrzuconych;
    }
}

