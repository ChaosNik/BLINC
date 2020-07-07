using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLINC
{
    public partial class FormStajaliste : Form
    {
        private Stajaliste stop;
        private Database db;
        private Javni_prevoz parent;
        private double x, y;

        private GMapOverlay markersOverlay = new GMapOverlay("markers");
        public FormStajaliste(Stajaliste stop, Database db, Javni_prevoz parent)
        {
            InitializeComponent();
            List<String> source = new List<String>();
            foreach (var stajaliste in db.Stajaliste) source.Add(stajaliste.Naziv);
            lblNaziv.DataSource = source;
            if (stop == null)
            {
                this.db = db;
                this.parent = parent;

                lblNaziv.Text = "";
                lblX.Text = "44.7784200";
                lblY.Text = "17.1938600";

                Text = "Dodavanje stajališta";
            }
            else
            {
                this.db = db;
                this.parent = parent;
                this.stop = stop;
                lblNaziv.Enabled = false;

                lblNaziv.Text = stop.Naziv;
                x = (double)stop.X;
                y = (double)stop.Y;

                lblX.Text = x.ToString("N8", new CultureInfo("en-us"));
                lblY.Text = y.ToString("N8", new CultureInfo("en-us"));
                Text = "Izmjena stajališta";

                mapMapa.Position = new PointLatLng((double)x, (double)y);
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng((double)x, (double)y), GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                mapMapa.Overlays.Add(markersOverlay);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ("".Equals(lblNaziv.Text)||
                "".Equals(lblX.Text) ||
                "".Equals(lblY.Text))
            {
                MessageBox.Show("Prvo popunite sva polja!");
                return;
            }
            bool neMoze1 = false;
            bool neMoze2 = false;
            double xxx=0, yyy=0;
            neMoze1 = !double.TryParse(lblX.Text.Replace(",","").Replace(".",","), out xxx);
            neMoze2 = !double.TryParse(lblY.Text.Replace(",","").Replace(".",","), out yyy);
            if (xxx < -90 || xxx > 90 ||
                yyy < -180 || yyy > 180 ||
                neMoze1 || neMoze2)
            {
                MessageBox.Show("Greška pri unosu podataka!");
                return;
            }

            if (stop == null)
            {
                stop = new Stajaliste();
                stop.Naziv = lblNaziv.Text;
                stop.X = double.Parse(lblX.Text.Replace(",","").Replace(".",","));
                stop.Y = double.Parse(lblY.Text.Replace(",", "").Replace(".", ","));
                if (db.Stajaliste.Count(o => ((o.Naziv.Equals(stop.Naziv)))) != 0)
                    MessageBox.Show("To stajalište već postoji!");
                else
                {
                    db.Stajaliste.Add(stop);
                    db.SaveChanges();
                    parent.adminRouteInitiation(true);
                    parent.Visible = true;
                    Close();
                }
            }
            else
            {
                stop.Naziv = lblNaziv.Text;
                stop.X = double.Parse(lblX.Text.Replace(",", "").Replace(".", ","));
                stop.Y = double.Parse(lblY.Text.Replace(",", "").Replace(".", ","));
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
        private void FormStajaliste_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.adminRouteInitiation(true);
            parent.Visible = true;
        }

        private void FormStajaliste_Load(object sender, EventArgs e)
        {
            mapMapa.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            mapMapa.Position = new PointLatLng(44.7784200, 17.1938600);
            mapMapa.Zoom = mapMapa.MinZoom;
        }
        private void refreshMap()
        {
            double level = mapMapa.Zoom;
            mapMapa.Zoom = 1;
            mapMapa.Zoom = level;
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

        private void lblNaziv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }

        private void lblX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }

        private void lblY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(sender, e);
        }

        private void mapMapa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                x = mapMapa.FromLocalToLatLng(e.X, e.Y).Lat;
                y = mapMapa.FromLocalToLatLng(e.X, e.Y).Lng;
                if (markersOverlay.Markers.Count == 1)
                {
                    markersOverlay.Markers.Clear();
                }
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng((double)x, (double)y), GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                mapMapa.Overlays.Add(markersOverlay);
                lblX.Text = x.ToString("N8", new CultureInfo("en-us"));
                lblY.Text = y.ToString("N8", new CultureInfo("en-us"));
            }

        }
    }
}
