using System;
using System.Windows.Forms;

namespace Maszyna_vendingowa
{
    public partial class pzMaszynaVendingowa : Form
    {
        string[] pzKupionePrzedmioty = new string[4];
        double pzKwotaDlaPłatnościKartą;
        float pzDostępnaKwota;
        float pzDzielnikWaluty;
        int pzIlośćMonetONominale05;
        int pzIlośćMonetONominale1;
        int pzIlośćMonetONominale2;
        int pzIlośćMonetONominale5;
        int pzIlośćCocaCola;
        int pzIlośćPepsi;
        int pzIlośćMirinda;
        int pzIlośćSprite;
        public pzMaszynaVendingowa()
        {
            InitializeComponent();
        }
        private void pzcmbWaluta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pzcmbWaluta.SelectedIndex != -1)
            {
                if (pzcmbWaluta.SelectedIndex == 0)
                {
                    pzDzielnikWaluty = 1;
                }
                else if (pzcmbWaluta.SelectedIndex == 1)
                {
                    pzDzielnikWaluty = 3.5F;
                    pzDzielnikWaluty = 3.5F;
                }
                else if (pzcmbWaluta.SelectedIndex == 2)
                    pzDzielnikWaluty = 4.5F;
                pzbtnCocaCola.Text += "\n(" + Math.Round((1.8F / pzDzielnikWaluty), 2) + " " + pzcmbWaluta.SelectedItem.ToString() + ")";
                pzbtnPepsi.Text += "\n(" + Math.Round((1.6F / pzDzielnikWaluty), 2) + " " + pzcmbWaluta.SelectedItem.ToString() + ")";
                pzbtnMirinda.Text += "\n(" + Math.Round((2 / pzDzielnikWaluty), 2) + " " + pzcmbWaluta.SelectedItem.ToString() + ")";
                pzbtnSprite.Text += "\n(" + Math.Round((2.2F / pzDzielnikWaluty), 2) + " " + pzcmbWaluta.SelectedItem.ToString() + ")";
                pzWalutaDoZapłaty.Text = pzcmbWaluta.SelectedItem.ToString();
                pzlblWalutaWrzuconych.Text = pzcmbWaluta.SelectedItem.ToString();
                pzcmbRodzajPłatności.Enabled = true;
                pzcmbWaluta.Enabled = false;
                pzbtnAnuluj.Enabled = true;
            }
        }
        private void pzcmbRodzajPłatności_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random pzLosowaKwota = new Random();
            if (pzcmbRodzajPłatności.SelectedIndex == 0)
            {
                pzKwotaDlaPłatnościKartą = pzLosowaKwota.Next(50, 100);
                pzlblDostępnaKwota.Text = "Kwota dostępna dla płatności kartą: " + Math.Round(pzKwotaDlaPłatnościKartą, 2) + " " + pzcmbWaluta.SelectedItem.ToString();
                pzbtnZapłaćKartą.Enabled = true;
            }
            else if (pzcmbRodzajPłatności.SelectedIndex == 1)
            {
                pzIlośćMonetONominale05 = pzLosowaKwota.Next(2, 10);
                pzIlośćMonetONominale1 = pzLosowaKwota.Next(2, 10);
                pzIlośćMonetONominale2 = pzLosowaKwota.Next(2, 10);
                pzIlośćMonetONominale5 = pzLosowaKwota.Next(2, 10);
                pzDostępnaKwota = (float)(pzIlośćMonetONominale05 * 0.5 + pzIlośćMonetONominale1 + pzIlośćMonetONominale2 * 2 + pzIlośćMonetONominale5 * 5);
                pzlblDostępnaKwota.Text = "Kwota dostępna to: " + pzDostępnaKwota + " " + pzcmbWaluta.SelectedItem.ToString() + ", w tym:";
                pzlblIlośćMonetONominale05.Text = pzIlośćMonetONominale05 + " monet o wartości 0.5 " + pzcmbWaluta.SelectedItem.ToString();
                pzlblIlośćMonetONominale1.Text = pzIlośćMonetONominale1 + " monet o wartości 1 " + pzcmbWaluta.SelectedItem.ToString();
                pzlblIlośćMonetONominale2.Text = pzIlośćMonetONominale2 + " monet o wartości 2 " + pzcmbWaluta.SelectedItem.ToString();
                pzlblIlośćMonetONominale5.Text = pzIlośćMonetONominale5 + " monet o wartości 5 " + pzcmbWaluta.SelectedItem.ToString();
                pzbtnMoneta05.Enabled = true;
                pzbtnMoneta1.Enabled = true;
                pzbtnMoneta2.Enabled = true;
                pzbtnMoneta5.Enabled = true;
                pzbtnZapłaćMonetami.Enabled = true;
            }
            pzbtnCocaCola.Enabled = true;
            pzbtnPepsi.Enabled = true;
            pzbtnMirinda.Enabled = true;
            pzbtnSprite.Enabled = true;
            pzcmbRodzajPłatności.Enabled = false;
        }
        private void pzObliczanieIlościWrzuconychMonet(int pzIlośćMonetODanymNominale, float pzNominał, Label pzlblIlośćMonetODanymNominale, Button pzButtonDoWyłączenia)
        {
            pzBłąd.Dispose();
            float.TryParse(pztxtWrzuconeMonety.Text, out float pzWrzuconeMonety);
            float.TryParse(pztxtDoZapłaty.Text, out float pzDoZapłaty);
            if (pztxtDoZapłaty.Text == "")
            {
                pzBłąd.SetError(pztxtWrzuconeMonety, "Proszę wybrać przedmiot!");
                return;
            }
            if (pzDoZapłaty < pzWrzuconeMonety)
            {
                pzBłąd.SetError(pztxtWrzuconeMonety, "Wrzuciłeś już wystarczającą ilość monet.");
                return;
            }
            if (pzNominał == 0.5)
                pzIlośćMonetONominale05--;
            else if (pzNominał == 1)
                pzIlośćMonetONominale1--;
            else if (pzNominał == 2)
                pzIlośćMonetONominale2--;
            else if (pzNominał == 5)
                pzIlośćMonetONominale5--;
            pzIlośćMonetODanymNominale--;
            pztxtWrzuconeMonety.Text = (pzWrzuconeMonety + pzNominał).ToString();
            pzDostępnaKwota = (float)(pzIlośćMonetONominale05 * 0.5 + pzIlośćMonetONominale1 + pzIlośćMonetONominale2 * 2 + pzIlośćMonetONominale5 * 5);
            pzlblDostępnaKwota.Text = "Kwota dostępna to: " + pzDostępnaKwota + " " + pzcmbWaluta.SelectedItem.ToString() +  ", w tym:";
            pzlblIlośćMonetODanymNominale.Text = pzIlośćMonetODanymNominale.ToString() + " monet o wartości " + pzNominał + " " + pzcmbWaluta.SelectedItem.ToString();
            if (pzIlośćMonetODanymNominale == 0)
            {
                pzButtonDoWyłączenia.Enabled = false;
                return;
            }
        }
        private void pzKoszyk()
        {
            string pzZawartośćKoszyka = "";
            float.TryParse(pztxtWrzuconeMonety.Text, out float pzWrzuconeMonety);
            float.TryParse(pztxtDoZapłaty.Text, out float pzDoZapłaty);
            if (pzcmbRodzajPłatności.SelectedIndex == 1)
            {
                double pzReszta;
                for (int i = 0; i <= 3; i++)
                {
                    if (pzKupionePrzedmioty[i] != null)
                        pzZawartośćKoszyka = pzZawartośćKoszyka + pzKupionePrzedmioty[i] + "\n";
                }
                if (pzWrzuconeMonety < pzDoZapłaty)
                {
                    pzBłąd.SetError(pztxtWrzuconeMonety, "Nie wrzuciłeś wystarczającej ilości monet.");
                    return;
                }
                if (pzWrzuconeMonety > pzDoZapłaty)
                {
                    pzReszta = Math.Round(pzWrzuconeMonety - pzDoZapłaty, 2);
                    pzZawartośćKoszyka = pzZawartośćKoszyka + "\n Reszta: " + pzReszta + " " + pzcmbWaluta.SelectedItem.ToString();
                }
                if (pzZawartośćKoszyka != "")
                    pzZawartośćKoszyka = pzZawartośćKoszyka + "\n Życzymy miłego dnia!";
            }
            else if (pzcmbRodzajPłatności.SelectedIndex == 0)
            {
                if (pzDoZapłaty > pzKwotaDlaPłatnościKartą)
                {
                    pzBłąd.SetError(pzbtnZapłaćKartą, "Nie posiadasz wystarczającej ilości pieniędzy na karcie.");
                    return;
                }
                for (int i = 0; i <= 3; i++)
                {
                    if (pzKupionePrzedmioty[i] != null)
                        pzZawartośćKoszyka = pzZawartośćKoszyka + pzKupionePrzedmioty[i] + "\n";
                }
                if (pzZawartośćKoszyka != "")
                    pzZawartośćKoszyka = pzZawartośćKoszyka + "\n Życzymy miłego dnia!";
            }
            if (pzZawartośćKoszyka == "")
            {
                MessageBox.Show("Nie wybrano żadnego przedmiotu, pieniądze nie zostały pobrane.", "Twoje przedmioty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(pzZawartośćKoszyka, "Twoje przedmioty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pzReset();
        }
        private void pzDodaniePrzedmiotu(float pzCenaPrzedmiotu, int pzIlośćDanegoPrzedmiotu, int pzIndexWTablicy)
        {
            float.TryParse(pztxtDoZapłaty.Text, out float pzDoZapłaty);
            pztxtDoZapłaty.Text = (Math.Round(pzDoZapłaty + (pzCenaPrzedmiotu / pzDzielnikWaluty), 2)).ToString();
            if (pzIndexWTablicy == 0)
            {
                pzIlośćCocaCola++;
                pzKupionePrzedmioty[pzIndexWTablicy] = "Coca-Cola (" + (pzIlośćDanegoPrzedmiotu + 1) + ")";
            }
            else if (pzIndexWTablicy == 1)
            {
                pzIlośćPepsi++;
                pzKupionePrzedmioty[pzIndexWTablicy] = "Pepsi (" + (pzIlośćDanegoPrzedmiotu + 1) + ")";
            }
            else if (pzIndexWTablicy == 2)
            {
                pzIlośćMirinda++;
                pzKupionePrzedmioty[pzIndexWTablicy] = "Mirinda (" + (pzIlośćDanegoPrzedmiotu + 1) + ")";
            }
            else if (pzIndexWTablicy == 3)
            {
                pzIlośćSprite++;
                pzKupionePrzedmioty[pzIndexWTablicy] = "Sprite (" + (pzIlośćDanegoPrzedmiotu + 1) + ")";
            }
        }
       
        private void pzReset()
        {
            Array.Clear(pzKupionePrzedmioty, 0, pzKupionePrzedmioty.Length);
            pzBłąd.Dispose();
            pzcmbRodzajPłatności.SelectedIndex = -1;
            pzcmbWaluta.SelectedIndex = -1;
            pzIlośćCocaCola = 0;
            pzIlośćPepsi = 0;
            pzIlośćMirinda = 0;
            pzIlośćSprite = 0;
            pzlblIlośćMonetONominale05.Text = "";
            pzlblIlośćMonetONominale1.Text = "";
            pzlblIlośćMonetONominale2.Text = "";
            pzlblIlośćMonetONominale5.Text = "";
            pztxtWrzuconeMonety.Text = "";
            pzlblDostępnaKwota.Text = "";
            pztxtDoZapłaty.Text = "";
            pzbtnCocaCola.Text = "";
            pzbtnPepsi.Text = "";
            pzbtnMirinda.Text = "";
            pzbtnSprite.Text = "";
            pzcmbRodzajPłatności.Enabled = false;
            pzbtnZapłaćMonetami.Enabled = false;
            pzbtnZapłaćKartą.Enabled = false;
            pzcmbWaluta.Enabled = true;
            pzbtnMoneta05.Enabled = false;
            pzbtnMoneta1.Enabled = false;
            pzbtnMoneta2.Enabled = false;
            pzbtnMoneta5.Enabled = false;
            pzbtnCocaCola.Enabled = false;
            pzbtnPepsi.Enabled = false;
            pzbtnMirinda.Enabled = false;
            pzbtnSprite.Enabled = false;
            pzbtnAnuluj.Enabled = false;
        }
        private void pzbtnMoneta05_Click(object sender, EventArgs e)
        {
            pzObliczanieIlościWrzuconychMonet(pzIlośćMonetONominale05, 0.5F, pzlblIlośćMonetONominale05, pzbtnMoneta05);
        }
        private void pzbtnMoneta1_Click(object sender, EventArgs e)
        {
            pzObliczanieIlościWrzuconychMonet(pzIlośćMonetONominale1, 1, pzlblIlośćMonetONominale1, pzbtnMoneta1);
        }
        private void pzbtnMoneta2_Click(object sender, EventArgs e)
        {
            pzObliczanieIlościWrzuconychMonet(pzIlośćMonetONominale2, 2, pzlblIlośćMonetONominale2, pzbtnMoneta2);
        }
        private void pzbtnMoneta5_Click(object sender, EventArgs e)
        {
            pzObliczanieIlościWrzuconychMonet(pzIlośćMonetONominale5, 5, pzlblIlośćMonetONominale5, pzbtnMoneta5);
        }
        private void pzbtnCocaCola_Click(object sender, EventArgs e)
        {
            pzDodaniePrzedmiotu(1.8F, pzIlośćCocaCola, 0);
        }
        private void pzbtnPepsi_Click(object sender, EventArgs e)
        {
            pzDodaniePrzedmiotu(1.6F, pzIlośćPepsi, 1);
        }
        private void pzbtnMirinda_Click(object sender, EventArgs e)
        {
            pzDodaniePrzedmiotu(2, pzIlośćMirinda, 2);
        }
        private void pzbtnSprite_Click(object sender, EventArgs e)
        {
            pzDodaniePrzedmiotu(2.2F, pzIlośćSprite, 3);
        }
        private void pzbtnZapłaćMonetami_Click(object sender, EventArgs e)
        {
            pzKoszyk();
        }
        private void pzbtnAnuluj_Click(object sender, EventArgs e)
        {
            pzReset();
        }
        private void pzbtnZapłaćKartą_Click(object sender, EventArgs e)
        {
            pzKoszyk();
        }

        private void pzMaszynaVendingowa_Load(object sender, EventArgs e)
        {

        }
    }
}
