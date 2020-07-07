using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLINC
{
    public partial class FormLinija : Form
    {
        private Linija line;
        private Database db;
        private Javni_prevoz parent;
        public FormLinija(Linija line, Database db, Javni_prevoz parent)
        {
            InitializeComponent();
            List<String> sourceBroj = new List<String>();
            List<String> sourceNaziv = new List<String>();
            foreach (var linija in db.Linija)
            {
                sourceBroj.Add(linija.Broj);
                sourceNaziv.Add(linija.Naziv);
            }
            lblBroj.DataSource = sourceBroj;
            lblNaziv.DataSource = sourceNaziv;
            if (line == null)
            {
                this.db = db;
                this.parent = parent;

                Text = "Dodavanje linije";
            }
            else
            {
                this.db = db;
                this.parent = parent;
                this.line = line;

                lblBroj.Enabled = false;

                lblBroj.Text = line.Broj;
                lblNaziv.Text = line.Naziv;
                Text = "Izmjena linije";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ("".Equals(lblNaziv.Text)||
                "".Equals(lblBroj.Text))
            {
                MessageBox.Show("Prvo popunite sva polja!");
                return;
            }
            if (line == null)
            {
                Linija line = new Linija();
                line.Broj = lblBroj.Text;
                line.Naziv = lblNaziv.Text;
                if (db.Linija.Count(o => (o.Broj.Equals(line.Broj)))!=0)
                    MessageBox.Show("Ta linija već postoji!");
                else
                {
                    db.Linija.Add(line);
                    db.SaveChanges();
                    parent.adminRouteInitiation(true);
                    parent.Visible = true;
                    Close();
                }
            }
            else
            {
                line.Broj = lblBroj.Text;
                line.Naziv = lblNaziv.Text;
                db.SaveChanges();

                parent.adminRouteInitiation(true);
                parent.Visible = true;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.adminRouteInitiation(true);
            parent.Visible = true;
            Close();
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.adminRouteInitiation(true);
            parent.Visible = true;
        }
        private void lblBroj_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) { return; }
            Point p = new Point(lblBroj.Location.X + 120, lblBroj.Location.Y + lblBroj.Height + (30 + e.Index * 10));
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                ttHelp.Show(lblBroj.Items[e.Index].ToString(), this, p);
            }
            e.DrawBackground();
            e.Graphics.DrawString(lblBroj.Items[e.Index].ToString(), e.Font, Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y));
        }
        private void lblNaziv_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) { return; }
            Point p = new Point(lblNaziv.Location.X + 120, lblNaziv.Location.Y + lblNaziv.Height + (30 + e.Index * 10));
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                ttHelp.Show(lblNaziv.Items[e.Index].ToString(), this, p);
            }
            e.DrawBackground();
            e.Graphics.DrawString(lblNaziv.Items[e.Index].ToString(), e.Font, Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y));
        }

        private void FormLinija_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.adminRouteInitiation(true);
            parent.Visible = true;
        }

        private void lblBroj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }

        private void lblNaziv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }
    }
}
