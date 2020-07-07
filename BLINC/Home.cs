using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLINC
{
    public partial class Home : Form
    {
        Database db=new Database();
        public Home(Database db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = db.Korisnik.Find(txtKorisnickoIme.Text);
            if (korisnik!= null && txtLozinka.Text.Equals(korisnik.Lozinka.TrimEnd()))
            {
                new Javni_prevoz(db, txtLozinka.Text.Equals("admin")).Visible = true;
                Visible = false;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
                txtKorisnickoIme.Text = "Korisničko ime";
                txtLozinka.Text = "Lozinka";
            }
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnUredu_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void txtKorisnickoIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
