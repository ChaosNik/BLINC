using System;
using System.Windows.Forms;

namespace BLINC
{
    public partial class Add : Form
    {
        private Database db;
        private Javni_prevoz parent;
        public Add(Database db, Javni_prevoz parent)
        {
            this.db = db;
            this.parent = parent;
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
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
                //db.Korisnik.Local.Add(account);
                db.Korisnik.Local.Insert(0, account);
                db.SaveChanges();
                parent.Visible = true;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            Close();
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
