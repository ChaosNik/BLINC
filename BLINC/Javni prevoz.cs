using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BLINC
{
    public partial class Javni_prevoz : Form
    {
        private List<CheckBox> buttons = new List<CheckBox>();
        private Boolean admin = false;
        Database db;

        public Javni_prevoz(Database db, Boolean admin)
        {
            this.db = db;
            InitializeComponent();
            this.admin = admin;
            if (admin)
            {
                this.Text = "Javni prevoz - admin";
                tabControl1.TabPages.Remove(tabRute);
            }
            else
            {
                this.Text = "Javni prevoz";
                tabControl1.TabPages.Remove(tabAdminKorisnici);
                tabControl1.TabPages.Remove(tabAdminRute);
            }
            addButtons();
            mapInitiation();
        }
        private void tabRute_Enter(object sender, EventArgs e)
        {
            routeInitiation();
        }
        private void routeInitiation()
        {
            tvRute.Nodes.Clear();
            foreach (var linija in db.Linija)
            {
                List<TreeNode> nodes = new List<TreeNode>();
                foreach (var stajaliste in linija.StajalisteLinije)
                    nodes.Add(new TreeNode(stajaliste.Stajaliste1.Naziv));
                TreeNode line = new TreeNode(linija.Broj + " - " + linija.Naziv, nodes.ToArray<TreeNode>());
                tvRute.Nodes.Add(line);
            }
            tvRute.Refresh();
        }
        private void tabRedVoznje_Enter(object sender, EventArgs e)
        {
            startsInitiation();
        }
        private void startsInitiation()
        {
            List<String> linije = new List<String>();
            foreach (var linija in db.Linija)
                linije.Add(linija.Broj + " - " + linija.Naziv);
            comboLinije.DataSource = linije;
            comboLinije.SelectedIndex = 0;
            comboLinije.SelectedValueChanged += ComboLinije_SelectedValueChanged;
            vremenaInitiation();
        }
        private void tabAdminRute_Enter(object sender, EventArgs e)
        {
            adminRouteInitiation(true);
        }
        private void tabAdminKorisnici_Enter(object sender, EventArgs e)
        {
            adminKorisniciInitiation();
        }
        public void adminKorisniciInitiation()
        {
            /*List<Korisnik> users = new List<Korisnik>();
            foreach (var korisnik in db.Korisnik)
                users.Add(korisnik);
            gridKorisnici.DataSource = users;*/
            List<Tuple<String, String, String>> users = new List<Tuple<String, String, String>>();
            foreach (var korisnik in db.Korisnik)
                users.Add(new Tuple<String, String, String>(korisnik.KorisničkoIme, korisnik.Ime, korisnik.Prezime));
            gridKorisnici.DataSource = users;
            gridKorisnici.Columns[0].HeaderText = "Korisničko ime";
            gridKorisnici.Columns[1].HeaderText = "Ime";
            gridKorisnici.Columns[2].HeaderText = "Prezime";
        }
        public void adminRouteInitiation(bool first)
        {
            int oldIndex = comboLinijeURutama.SelectedIndex;
            List<String> linije = new List<String>();
            foreach (var linija in db.Linija)
                linije.Add(linija.Broj + " - " + linija.Naziv);
            comboLinijeURutama.DataSource = linije;
            if(first)comboLinijeURutama.SelectedIndex = 0;
            else comboLinijeURutama.SelectedIndex = oldIndex;
            comboLinijeURutama.SelectedValueChanged += ComboLinijeURutama_SelectedValueChanged;
            stajalistaInitiation(first);
        }

        private void ComboLinijeURutama_SelectedValueChanged(object sender, EventArgs e)
        {
            stajalistaInitiation(false);
        }
        private void stajalistaInitiation(bool first)
        {
            List<String> preostalaStajalista = new List<string>();
            List<Tuple<int, String>> linijaStajalista = new List<Tuple<int, String>>();

            var temp = comboLinijeURutama.SelectedItem.ToString().Split('-')[0].TrimEnd();
            Linija selected = db.Linija.First(o => (o.Broj.Equals(temp)));

            ListBox selectedList = lstStajalista;
            if (lstStajalista.SelectedItems.Count == 0)
                selectedList = lstUnutarLinije;
            Stajaliste stop = null;
            if (selectedList.SelectedItems.Count != 0)
            {
                var temp1 = selectedList.SelectedItem.ToString().Split('-')[1].TrimStart();
                stop = db.Stajaliste.First(o => (o.Naziv.Equals(temp1)));
            }

            foreach (var stajaliste in db.Stajaliste)
            {
                bool k = false;
                int redni_broj = 0;
                foreach (var stajalisteLinije in stajaliste.StajalisteLinije)
                {
                    if ((stajalisteLinije.Linija1 == null) || (stajalisteLinije.Stajaliste1 == null || (selected == null))) 
                    {
                        db.StajalisteLinije.Remove(stajalisteLinije);
                        continue;
                    }
                    if (stajalisteLinije.Linija1.Id == (selected.Id))
                    {
                        k = true;
                        redni_broj = (int)stajalisteLinije.Redni_broj;
                    }
                }
                if (k)
                    linijaStajalista.Add(new Tuple<int, String>(redni_broj, stajaliste.Id + " - " + stajaliste.Naziv));
                else
                    preostalaStajalista.Add(stajaliste.Id + " - " + stajaliste.Naziv);
            }
            linijaStajalista.Sort((x, y) => x.Item1.CompareTo(y.Item1));
            List<String> unutarLinijeStajalista = new List<String>();
            foreach (var x in linijaStajalista) unutarLinijeStajalista.Add(x.Item2);
            lstUnutarLinije.DataSource = unutarLinijeStajalista;
            lstStajalista.DataSource = preostalaStajalista;

            if (first)
            {
                lstStajalista.SelectedItems.Clear();
                lstUnutarLinije.SelectedItems.Clear();
                lstStajalista.SelectedIndex = 0;
            }
            else if ((stop != null) && (selectedList == lstUnutarLinije)) 
            {
                lstStajalista.SelectedItems.Clear();
                lstUnutarLinije.SelectedItems.Clear();
                lstUnutarLinije.SelectedItems.Add(stop.Id + " - " + stop.Naziv);
            }
        }
        private void ComboLinije_SelectedValueChanged(object sender, EventArgs e)
        {
            vremenaInitiation();
        }

        private void vremenaInitiation()
        {
            var temp = comboLinije.SelectedItem.ToString().Split('-')[0].TrimEnd();
            Linija linija = db.Linija.First(o => (o.Broj.Equals(temp)));
            lvVremenaPolaska.View = View.List;
            lvVremenaPovratka.View = View.List;
            lvVremenaPolaska.Items.Clear();
            lvVremenaPovratka.Items.Clear();
            foreach (var polazak in db.Polazak)
                if(polazak.Linija.Equals(linija.Id))
                {
                    if (!polazak.Povratak) lvVremenaPolaska.Items.Add(polazak.Vrijeme.ToString());
                    else lvVremenaPovratka.Items.Add(polazak.Vrijeme.ToString());
                }
        }

        private void pnlDesno_MouseLeave(object sender, EventArgs e)
        {
            pnlDesno.Hide();
            lblDesno1.Hide();
            lblDesno2.Hide();
        }

        private void pnlDesnoColider_MouseEnter(object sender, EventArgs e)
        {
            lblDesno1.Show();
            lblDesno2.Show();
            pnlDesno.Show();
        }

        private void pnlToggles_MouseLeave(object sender, EventArgs e)
        {
            pnlToggles.Hide();
        }

        private void pnlTogglesColider_MouseEnter(object sender, EventArgs e)
        {
            pnlToggles.Show();
        }

        private void tabMap_Enter(object sender, EventArgs e)
        {
            mapConstruction();
        }
        private void mapConstruction()
        {
            mapMapa.ShowCenter = false;
            //mapMapa.MapProvider = GoogleMapProvider.Instance;
            mapMapa.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            mapMapa.SetPositionByKeywords("Banja Luka, Bosnia and Herzegovina");
            mapMapa.Zoom = mapMapa.MinZoom;
        }
        private void refreshMap()
        {
            double level = mapMapa.Zoom;
            mapMapa.Zoom = 1;
            mapMapa.Zoom = level;
        }

        private void mapInitiation()
        {
            mapMapa.OnMarkerClick += gmap_OnMarkerClick;
            mapMapa.Overlays.Clear();
            routesInitiation();
            markersInitiation();
            refreshMap();
        }
        private void gmap_OnMarkerClick(GMapMarker marker, MouseEventArgs e)
        {
            Stajaliste stajaliste = null;
            pnlDesno.Items.Clear();
            foreach (var x in db.Stajaliste)
                if (x.Naziv.Equals(marker.ToolTipText)) stajaliste = x;
            pnlDesno.Items.Add("");
            pnlDesno.Items.Add("");
            pnlDesno.Items.Add("");
            pnlDesno.Items.Add("");
            foreach (var x in db.StajalisteLinije)
                if (x.Stajaliste.Equals(stajaliste.Id))
                    pnlDesno.Items.Add(x.Linija1.Broj);
            pnlDesnoColider_MouseEnter(marker, e);
        }

        private void markersInitiation()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            foreach (var stajaliste in db.Stajaliste)
            {
                GMarkerGoogle marker =
                new GMarkerGoogle
                (
                    new PointLatLng((double)stajaliste.X, (double)stajaliste.Y),
                    //GMarkerGoogleType.green
                    new Bitmap("C:/Users/nikol/Desktop/BLINC/BLINC/Resources/Icons/Bus.png")

                );
                marker.ToolTipText = stajaliste.Naziv;
                markersOverlay.Markers.Add(marker);
            }
            mapMapa.Overlays.Add(markersOverlay);
        }
        private void routesInitiation()
        {
            Random rand = new Random();
            foreach (var linija in db.Linija)
            {
                int r = rand.Next(256);
                int g = rand.Next(256);
                int b = rand.Next(256);
                if (buttons.Exists(x => (x.Text.Equals(linija.Broj) && x.Checked)))
                {
                    if (linija.StajalisteLinije.Count == 0) continue;
                    GMapOverlay routesOverlay = new GMapOverlay("Ruta" + linija.Broj);
                    Stajaliste old = linija.StajalisteLinije.First().Stajaliste1; ;
                    foreach (var stajaliste in linija.StajalisteLinije)
                    {
                        /*MapRoute route =
                            GoogleMapProvider.Instance.GetRoute
                            (
                                new PointLatLng((double)old.X, (double)old.Y),
                                new PointLatLng((double)stajaliste.Stajaliste1.X, (double)stajaliste.Stajaliste1.Y),
                                false,
                                false,
                                15
                            );
                        GMapRoute r = new GMapRoute(route.Points, "Ruta " + linija.Broj + stajaliste.Stajaliste + "-" + old.Id);
                        r.Stroke.Width = 5;
                        r.Stroke.Color = Color.SeaGreen;
                        routesOverlay.Routes.Add(r);*/

                        List<PointLatLng> points = new List<PointLatLng>();
                        points.Add(new PointLatLng((double)old.X, (double)old.Y));
                        points.Add(new PointLatLng((double)old.X, (double)old.Y));
                        points.Add(new PointLatLng((double)stajaliste.Stajaliste1.X, (double)stajaliste.Stajaliste1.Y));
                        points.Add(new PointLatLng((double)stajaliste.Stajaliste1.X, (double)stajaliste.Stajaliste1.Y));
                        GMapPolygon polygon = new GMapPolygon(points, "Ruta" + linija.Broj);
                        polygon.Fill = new SolidBrush(Color.FromArgb(r, g, b));
                        polygon.Stroke = new Pen(Color.FromArgb(r, g, b), 5);
                        routesOverlay.Polygons.Add(polygon);
                        mapMapa.Overlays.Add(routesOverlay);
                        old = stajaliste.Stajaliste1;
                    }
                }
            }
        }
        private void checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            mapInitiation();
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked.Equals(true))
                checkBox.BackColor = Color.LightBlue;
            else
                checkBox.BackColor = Color.WhiteSmoke;
        }
        private void addButtons()
        {
            int i = 0;
            foreach (var linija in db.Linija)
            { 
                CheckBox button = new CheckBox();
                button.Size = new Size(50, 50);
                button.Location = new Point(8, 8 + 61 * i);
                button.Appearance = Appearance.Button;
                button.Checked = true;
                button.Text = linija.Broj;
                button.Font = new Font(button.Font.FontFamily, 10);
                button.TextAlign = ContentAlignment.MiddleCenter;
                pnlToggles.Controls.Add(button);
                buttons.Add(button);
                button.CheckedChanged += checkBox_CheckedChanged;
                button.BackColor = Color.LightBlue;
                ++i;
            }
        }

        private void Javni_prevoz_Load(object sender, EventArgs e)
        {
        }

        private void Javni_prevoz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteKorisnik_Click(object sender, EventArgs e)
        {
            Korisnik account = db.Korisnik.Find(gridKorisnici.SelectedRows[0].Cells[0].Value.ToString());
            if ("admin".Equals(account.KorisničkoIme))
            {
                MessageBox.Show("Ne mozete mijenjati administratorski nalog!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show
            (
                "Da li ste sigurni da želite da obrišete nalog " + account.KorisničkoIme + "?",
                "Brisanje naloga!",
                MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.Yes)
            {
                db.Korisnik.Remove(account);
                db.SaveChanges();
                MessageBox.Show("Korisnički nalog " + account.KorisničkoIme + " uspješno obrisan!");
                adminKorisniciInitiation();
                return;
            }
            MessageBox.Show("Nemoguce obrisati nalog!");
        }

        private void btnEditKorisnik_Click(object sender, EventArgs e)
        {
            new FormKorisnik(db.Korisnik.Find(gridKorisnici.SelectedRows[0].Cells[0].Value.ToString()), db, this).Visible = true;
            Visible = false;
        }

        private void btnAddKorisnik_Click(object sender, EventArgs e)
        {
            new FormKorisnik(null, new Database(), this).Visible = true;
            Visible = false;
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            new FormLinija(null, new Database(), this).Visible = true;
            Visible = false;
        }

        private void btnEditRoute_Click(object sender, EventArgs e)
        {
            var temp = comboLinijeURutama.SelectedItem.ToString().Split('-')[0].TrimEnd();
            new FormLinija(db.Linija.First(o => (o.Broj.Equals(temp))), db, this).Visible = true;
            Visible = false;
        }

        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            var temp = comboLinijeURutama.SelectedItem.ToString().Split('-')[0].TrimEnd();
            Linija linija = db.Linija.First(o => (o.Broj.Equals(temp)));
            DialogResult dialogResult = MessageBox.Show
            (
                "Da li ste sigurni da želite da obrišete liniju " + linija.Broj + "?",
                "Brisanje linije!",
                MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var stajalisteLinije in linija.StajalisteLinije.ToList())
                        db.StajalisteLinije.Remove(stajalisteLinije);
                db.Linija.Remove(linija);
                db.SaveChanges();
                MessageBox.Show("Linija " + linija.Broj + " uspješno obrisana!");
                adminRouteInitiation(true);
                return;
            }
            MessageBox.Show("Nemoguce obrisati liniju!");
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            if (lstStajalista.SelectedItems.Count == 0) return;
            var temp = comboLinijeURutama.SelectedItem.ToString().Split('-')[0].TrimEnd();
            Linija linija = db.Linija.First(o => (o.Broj.Equals(temp)));
            foreach (var stajaliste in db.Stajaliste)
                if (((stajaliste.Id + " - " + stajaliste.Naziv).CompareTo((String)lstStajalista.SelectedItem)) == 0)
                {
                    StajalisteLinije item = new StajalisteLinije();
                    //item.Linija1 = linija;
                    item.Linija = linija.Id;
                    //item.Stajaliste1 = stajaliste;
                    item.Stajaliste = stajaliste.Id;
                    int count = 0;
                    foreach (var a in linija.StajalisteLinije) ++count;
                    item.Redni_broj = count;
                    db.StajalisteLinije.Add(item);
                }
            adminRouteInitiation(false);
            db.SaveChanges();
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            if (lstUnutarLinije.SelectedItems.Count == 0) return;
            var temp = comboLinijeURutama.SelectedItem.ToString().Split('-')[0].TrimEnd();
            Linija linija = db.Linija.First(o => (o.Broj.Equals(temp)));
            foreach (var stajaliste in db.Stajaliste)
                if (((stajaliste.Id + " - " + stajaliste.Naziv).CompareTo((String)lstUnutarLinije.SelectedItem)) == 0)
                {
                    StajalisteLinije stajalisteLinije = db.StajalisteLinije.First(o => ((o.Linija == linija.Id) && (o.Stajaliste == stajaliste.Id)));
                    db.StajalisteLinije.Remove(stajalisteLinije);
                }
            adminRouteInitiation(false);
            db.SaveChanges();
        }

        private void btnGore_Click(object sender, EventArgs e)
        {
            if (lstUnutarLinije.SelectedItems.Count == 0) return;
            var temp = comboLinijeURutama.SelectedItem.ToString().Split('-')[0].TrimEnd();
            Linija linija = db.Linija.First(o => (o.Broj.Equals(temp)));
            foreach (var stajaliste in db.Stajaliste)
                if (((stajaliste.Id + " - " + stajaliste.Naziv).CompareTo((String)lstUnutarLinije.SelectedItem)) == 0)
                {
                    StajalisteLinije stajalisteLinije = db.StajalisteLinije.First(o => ((o.Linija == linija.Id) && (o.Stajaliste == stajaliste.Id)));

                    int index = (int)stajalisteLinije.Redni_broj;
                    if (index == 1) return;
                    foreach(var item in linija.StajalisteLinije)
                    {
                        if(item.Redni_broj==index-1)
                        {
                            item.Redni_broj = index;
                            stajalisteLinije.Redni_broj = index - 1;
                        }
                    }
                }
            adminRouteInitiation(false);
            db.SaveChanges();
        }

        private void btnDole_Click(object sender, EventArgs e)
        {
            if (lstUnutarLinije.SelectedItems.Count == 0) return;
            var temp = comboLinijeURutama.SelectedItem.ToString().Split('-')[0].TrimEnd();
            Linija linija = db.Linija.First(o => (o.Broj.Equals(temp)));
            foreach (var stajaliste in db.Stajaliste)
                if (((stajaliste.Id + " - " + stajaliste.Naziv).CompareTo((String)lstUnutarLinije.SelectedItem)) == 0)
                {
                    StajalisteLinije stajalisteLinije = db.StajalisteLinije.First(o => ((o.Linija == linija.Id) && (o.Stajaliste == stajaliste.Id)));

                    int index = (int)stajalisteLinije.Redni_broj;
                    int max = 0;
                    foreach (var item in linija.StajalisteLinije)
                        if (item.Redni_broj > max) max = (int)item.Redni_broj;
                    if (index == max) return;
                    foreach (var item in linija.StajalisteLinije)
                    {
                        if (item.Redni_broj == index + 1)
                        {
                            item.Redni_broj = index;
                            stajalisteLinije.Redni_broj = index + 1;
                        }
                    }
                }
            adminRouteInitiation(false);
            db.SaveChanges();
        }

        private void btnAddStop_Click(object sender, EventArgs e)
        {
            new FormStajaliste(null, new Database(), this).Visible = true;
            Visible = false;
        }

        private void btnEditStop_Click(object sender, EventArgs e)
        {
            ListBox selectedList= lstStajalista;
            if (lstStajalista.SelectedItems.Count == 0) selectedList = lstUnutarLinije;
            var temp = selectedList.SelectedItem.ToString().Split('-')[1].TrimStart();
            new FormStajaliste(db.Stajaliste.First(o => (o.Naziv.Equals(temp))), db, this).Visible = true;
            Visible = false;
        }

        private void btnDeleteStop_Click(object sender, EventArgs e)
        {
            ListBox selectedList = lstStajalista;
            if (lstStajalista.SelectedItems.Count == 0) selectedList = lstUnutarLinije;
            var temp = selectedList.SelectedItem.ToString().Split('-')[1].TrimStart();
            Stajaliste stop = db.Stajaliste.First(o => (o.Naziv.Equals(temp)));
            DialogResult dialogResult = MessageBox.Show
            (
                "Da li ste sigurni da želite da obrišete stajalište " + stop.Naziv + "?",
                "Brisanje stajališta!",
                MessageBoxButtons.YesNo
            );
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var stajalisteLinije in stop.StajalisteLinije.ToList())
                    db.StajalisteLinije.Remove(stajalisteLinije);
                db.Stajaliste.Remove(stop);
                lstStajalista.SelectedItems.Clear();
                lstUnutarLinije.SelectedItems.Clear();
                db.SaveChanges();
                MessageBox.Show("Stajalište " + stop.Naziv + " uspješno obrisano!");
                adminRouteInitiation(true);
                return;
            }
            MessageBox.Show("Nemoguce obrisati Stajalište!");
        }

        private void lstStajalista_MouseClick(object sender, MouseEventArgs e)
        {
            lstUnutarLinije.SelectedItems.Clear();
        }

        private void lstUnutarLinije_MouseClick(object sender, MouseEventArgs e)
        {
            lstStajalista.SelectedItems.Clear();
        }

        private void lstStajalista_MouseMove(object sender, MouseEventArgs e)
        {
            string text = "";

            //Get the item
            int index = lstStajalista.IndexFromPoint(e.Location);
            if ((index >= 0) && (index < lstStajalista.Items.Count))
                text = lstStajalista.Items[index].ToString();

            ttHelp.SetToolTip(lstStajalista, text);
        }

        private void lstUnutarLinije_MouseMove(object sender, MouseEventArgs e)
        {
            string text = "";

            //Get the item
            int index = lstUnutarLinije.IndexFromPoint(e.Location);
            if ((index >= 0) && (index < lstUnutarLinije.Items.Count))
                text = lstUnutarLinije.Items[index].ToString();

            ttHelp.SetToolTip(lstUnutarLinije, text);
        }

        private void comboLinijeURutama_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) { return; }
            Point p = new Point(comboLinijeURutama.Location.X + 120, comboLinijeURutama.Location.Y + comboLinijeURutama.Height + (30 + e.Index * 10));
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                ttHelp.Show(comboLinijeURutama.Items[e.Index].ToString(), this, p);
            }
            e.DrawBackground();
            e.Graphics.DrawString(comboLinijeURutama.Items[e.Index].ToString(), e.Font, Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y));
        }

        private void comboLinije_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) { return; }
            Point p = new Point(comboLinije.Location.X + 120, comboLinije.Location.Y + comboLinije.Height + (30 + e.Index * 10));
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                ttHelp.Show(comboLinije.Items[e.Index].ToString(), this, p);
            }
            e.DrawBackground();
            e.Graphics.DrawString(comboLinije.Items[e.Index].ToString(), e.Font, Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y));
        }

        private void gridKorisnici_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                gridKorisnici.CurrentCell = gridKorisnici.Rows[e.RowIndex].Cells[e.ColumnIndex];
                gridKorisnici.Rows[e.RowIndex].Selected = true;
                gridKorisnici.Focus();
            }
            else
            {
                gridKorisnici.ClearSelection();
            }
        }

        private void gridKorisnici_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridView.HitTestInfo hitTest = gridKorisnici.HitTest(e.X, e.Y);

                if (hitTest.Type == DataGridViewHitTestType.None)
                {
                    gridKorisnici.ClearSelection();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void gridKorisnici_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditKorisnik_Click(sender, e);
        }

        private void gridKorisnici_SelectionChanged(object sender, EventArgs e)
        {
            tsmUkloni.Enabled = tsmUredi.Enabled = true;
        }

        private void tsmUredi_Click(object sender, EventArgs e)
        {
            btnEditKorisnik_Click(sender, e);
        }

        private void tsmUkloni_Click(object sender, EventArgs e)
        {
            btnDeleteKorisnik_Click(sender, e);
        }
    }
}
