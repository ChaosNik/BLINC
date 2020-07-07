using System;
using System.Data.Entity.Migrations;
using System.Windows.Forms;

namespace BLINC
{
    public partial class FormKorisnik : Form
    {
        private Korisnik account;
        private Database db;
        private Javni_prevoz parent;
        public FormKorisnik(Korisnik account, Database db, Javni_prevoz parent)
        {
            if (account == null)
            {
                this.db = db;
                this.parent = parent;
                InitializeComponent();

                lblKorisnickoIme.ReadOnly = false;
                Text = "Dodavanje korisnika";
            }
            else
            {
                this.db = db;
                this.parent = parent;
                this.account = account;
                InitializeComponent();

                lblKorisnickoIme.Text = account.KorisničkoIme;
                lblLozinka.Text = account.Lozinka;
                lblIme.Text = account.Ime;
                lblPrezime.Text = account.Prezime;
                Text = "Izmjena korisnika";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ("".Equals(lblKorisnickoIme.Text) ||
                "".Equals(lblLozinka.Text) ||
                "".Equals(lblIme.Text) ||
                "".Equals(lblPrezime.Text))
            {
                MessageBox.Show("Prvo popunite sva polja!");
                return;
            }
            if (account == null)
            {
                Korisnik account = new Korisnik();
                account.KorisničkoIme = lblKorisnickoIme.Text;
                account.Lozinka = lblLozinka.Text;
                account.Ime = lblIme.Text;
                account.Prezime = lblPrezime.Text;
                if (db.Korisnik.Find(account.KorisničkoIme) != null)
                    MessageBox.Show("Taj nalog već postoji!");
                else
                {
                    db.Korisnik.Add(account);
                    db.SaveChanges();
                    parent.adminKorisniciInitiation();
                    parent.Visible = true;
                    Close();
                }
            }
            else
            {
                account.Lozinka = lblLozinka.Text;
                account.Ime = lblIme.Text;
                account.Prezime = lblPrezime.Text;
                db.SaveChanges();

                parent.adminKorisniciInitiation();
                parent.Visible = true;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.adminKorisniciInitiation();
            parent.Visible = true;
            Close();
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.adminKorisniciInitiation();
            parent.Visible = true;
        }

        private void lblKorisnickoIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }

        private void lblLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }

        private void lblIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }

        private void lblPrezime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }
    }
}
