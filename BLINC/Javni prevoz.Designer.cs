namespace BLINC
{
    partial class Javni_prevoz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Javni_prevoz));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabAdminRute = new System.Windows.Forms.TabPage();
            this.pnlAdminRute = new System.Windows.Forms.Panel();
            this.btnDeleteStop = new System.Windows.Forms.Button();
            this.btnAddStop = new System.Windows.Forms.Button();
            this.btnEditStop = new System.Windows.Forms.Button();
            this.btnDeleteRoute = new System.Windows.Forms.Button();
            this.btnDole = new System.Windows.Forms.Button();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.btnGore = new System.Windows.Forms.Button();
            this.btnEditRoute = new System.Windows.Forms.Button();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlStajalista = new System.Windows.Forms.Panel();
            this.lstStajalista = new System.Windows.Forms.ListBox();
            this.pnlUnutarLinije = new System.Windows.Forms.Panel();
            this.lstUnutarLinije = new System.Windows.Forms.ListBox();
            this.comboLinijeURutama = new System.Windows.Forms.ComboBox();
            this.tabAdminKorisnici = new System.Windows.Forms.TabPage();
            this.pnlKorisnici = new System.Windows.Forms.Panel();
            this.gridKorisnici = new System.Windows.Forms.DataGridView();
            this.btnAddKorisnik = new System.Windows.Forms.Button();
            this.btnEditKorisnik = new System.Windows.Forms.Button();
            this.btnDeleteKorisnik = new System.Windows.Forms.Button();
            this.tabRute = new System.Windows.Forms.TabPage();
            this.tvRute = new System.Windows.Forms.TreeView();
            this.tabRedVoznje = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lvVremenaPolaska = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lvVremenaPovratka = new System.Windows.Forms.ListView();
            this.comboLinije = new System.Windows.Forms.ComboBox();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.pnlMapa = new System.Windows.Forms.Panel();
            this.lblDesno1 = new System.Windows.Forms.Label();
            this.lblDesno2 = new System.Windows.Forms.Label();
            this.pnlDesno = new System.Windows.Forms.ListView();
            this.pnlToggles = new System.Windows.Forms.Panel();
            this.pnlDesnoColider = new System.Windows.Forms.Panel();
            this.pnlTogglesColider = new System.Windows.Forms.Panel();
            this.mapMapa = new GMap.NET.WindowsForms.GMapControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.bLINCEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsKorisnik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmUredi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUkloni = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAdminRute.SuspendLayout();
            this.pnlAdminRute.SuspendLayout();
            this.pnlStajalista.SuspendLayout();
            this.pnlUnutarLinije.SuspendLayout();
            this.tabAdminKorisnici.SuspendLayout();
            this.pnlKorisnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKorisnici)).BeginInit();
            this.tabRute.SuspendLayout();
            this.tabRedVoznje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.pnlMapa.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bLINCEntitiesBindingSource)).BeginInit();
            this.tsKorisnik.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdminRute
            // 
            this.tabAdminRute.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabAdminRute.Controls.Add(this.pnlAdminRute);
            this.tabAdminRute.Location = new System.Drawing.Point(4, 46);
            this.tabAdminRute.Name = "tabAdminRute";
            this.tabAdminRute.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminRute.Size = new System.Drawing.Size(677, 413);
            this.tabAdminRute.TabIndex = 4;
            this.tabAdminRute.Text = "Rute";
            this.tabAdminRute.Enter += new System.EventHandler(this.tabAdminRute_Enter);
            // 
            // pnlAdminRute
            // 
            this.pnlAdminRute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdminRute.Controls.Add(this.btnDeleteStop);
            this.pnlAdminRute.Controls.Add(this.btnAddStop);
            this.pnlAdminRute.Controls.Add(this.btnEditStop);
            this.pnlAdminRute.Controls.Add(this.btnDeleteRoute);
            this.pnlAdminRute.Controls.Add(this.btnDole);
            this.pnlAdminRute.Controls.Add(this.btnAddRoute);
            this.pnlAdminRute.Controls.Add(this.btnGore);
            this.pnlAdminRute.Controls.Add(this.btnEditRoute);
            this.pnlAdminRute.Controls.Add(this.btnLijevo);
            this.pnlAdminRute.Controls.Add(this.btnDesno);
            this.pnlAdminRute.Controls.Add(this.label4);
            this.pnlAdminRute.Controls.Add(this.label3);
            this.pnlAdminRute.Controls.Add(this.pnlStajalista);
            this.pnlAdminRute.Controls.Add(this.pnlUnutarLinije);
            this.pnlAdminRute.Controls.Add(this.comboLinijeURutama);
            this.pnlAdminRute.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminRute.Name = "pnlAdminRute";
            this.pnlAdminRute.Size = new System.Drawing.Size(677, 413);
            this.pnlAdminRute.TabIndex = 0;
            // 
            // btnDeleteStop
            // 
            this.btnDeleteStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteStop.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStop.BackgroundImage")));
            this.btnDeleteStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteStop.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteStop.Location = new System.Drawing.Point(194, 332);
            this.btnDeleteStop.Name = "btnDeleteStop";
            this.btnDeleteStop.Size = new System.Drawing.Size(75, 75);
            this.btnDeleteStop.TabIndex = 22;
            this.btnDeleteStop.UseVisualStyleBackColor = false;
            this.btnDeleteStop.Click += new System.EventHandler(this.btnDeleteStop_Click);
            // 
            // btnAddStop
            // 
            this.btnAddStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddStop.BackColor = System.Drawing.Color.Lime;
            this.btnAddStop.BackgroundImage = global::BLINC.Properties.Resources.Add;
            this.btnAddStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStop.ForeColor = System.Drawing.Color.Black;
            this.btnAddStop.Location = new System.Drawing.Point(32, 332);
            this.btnAddStop.Name = "btnAddStop";
            this.btnAddStop.Size = new System.Drawing.Size(75, 75);
            this.btnAddStop.TabIndex = 20;
            this.btnAddStop.UseVisualStyleBackColor = false;
            this.btnAddStop.Click += new System.EventHandler(this.btnAddStop_Click);
            // 
            // btnEditStop
            // 
            this.btnEditStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditStop.BackColor = System.Drawing.Color.Yellow;
            this.btnEditStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditStop.BackgroundImage")));
            this.btnEditStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditStop.ForeColor = System.Drawing.Color.Black;
            this.btnEditStop.Location = new System.Drawing.Point(113, 332);
            this.btnEditStop.Name = "btnEditStop";
            this.btnEditStop.Size = new System.Drawing.Size(75, 75);
            this.btnEditStop.TabIndex = 21;
            this.btnEditStop.UseVisualStyleBackColor = false;
            this.btnEditStop.Click += new System.EventHandler(this.btnEditStop_Click);
            // 
            // btnDeleteRoute
            // 
            this.btnDeleteRoute.BackColor = System.Drawing.Color.Red;
            this.btnDeleteRoute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteRoute.BackgroundImage")));
            this.btnDeleteRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteRoute.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteRoute.Location = new System.Drawing.Point(170, 6);
            this.btnDeleteRoute.Name = "btnDeleteRoute";
            this.btnDeleteRoute.Size = new System.Drawing.Size(75, 75);
            this.btnDeleteRoute.TabIndex = 17;
            this.btnDeleteRoute.UseVisualStyleBackColor = false;
            this.btnDeleteRoute.Click += new System.EventHandler(this.btnDeleteRoute_Click);
            // 
            // btnDole
            // 
            this.btnDole.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDole.BackColor = System.Drawing.Color.Blue;
            this.btnDole.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDole.Location = new System.Drawing.Point(531, 332);
            this.btnDole.Name = "btnDole";
            this.btnDole.Size = new System.Drawing.Size(75, 75);
            this.btnDole.TabIndex = 19;
            this.btnDole.Text = "↓";
            this.btnDole.UseVisualStyleBackColor = false;
            this.btnDole.Click += new System.EventHandler(this.btnDole_Click);
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.BackColor = System.Drawing.Color.Lime;
            this.btnAddRoute.BackgroundImage = global::BLINC.Properties.Resources.Add;
            this.btnAddRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRoute.ForeColor = System.Drawing.Color.Black;
            this.btnAddRoute.Location = new System.Drawing.Point(8, 6);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(75, 75);
            this.btnAddRoute.TabIndex = 15;
            this.btnAddRoute.UseVisualStyleBackColor = false;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // btnGore
            // 
            this.btnGore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGore.BackColor = System.Drawing.Color.Blue;
            this.btnGore.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGore.Location = new System.Drawing.Point(450, 332);
            this.btnGore.Name = "btnGore";
            this.btnGore.Size = new System.Drawing.Size(75, 75);
            this.btnGore.TabIndex = 18;
            this.btnGore.Text = "↑";
            this.btnGore.UseVisualStyleBackColor = false;
            this.btnGore.Click += new System.EventHandler(this.btnGore_Click);
            // 
            // btnEditRoute
            // 
            this.btnEditRoute.BackColor = System.Drawing.Color.Yellow;
            this.btnEditRoute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditRoute.BackgroundImage")));
            this.btnEditRoute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditRoute.ForeColor = System.Drawing.Color.Black;
            this.btnEditRoute.Location = new System.Drawing.Point(89, 6);
            this.btnEditRoute.Name = "btnEditRoute";
            this.btnEditRoute.Size = new System.Drawing.Size(75, 75);
            this.btnEditRoute.TabIndex = 16;
            this.btnEditRoute.UseVisualStyleBackColor = false;
            this.btnEditRoute.Click += new System.EventHandler(this.btnEditRoute_Click);
            // 
            // btnLijevo
            // 
            this.btnLijevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLijevo.BackColor = System.Drawing.Color.Blue;
            this.btnLijevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLijevo.Location = new System.Drawing.Point(301, 252);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 75);
            this.btnLijevo.TabIndex = 14;
            this.btnLijevo.Text = "←";
            this.btnLijevo.UseVisualStyleBackColor = false;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDesno.BackColor = System.Drawing.Color.Blue;
            this.btnDesno.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDesno.Location = new System.Drawing.Point(301, 178);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 75);
            this.btnDesno.TabIndex = 13;
            this.btnDesno.Text = "→";
            this.btnDesno.UseVisualStyleBackColor = false;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(382, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stajališta unutar linije:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Preostala stajališta:";
            // 
            // pnlStajalista
            // 
            this.pnlStajalista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlStajalista.AutoScroll = true;
            this.pnlStajalista.Controls.Add(this.lstStajalista);
            this.pnlStajalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.pnlStajalista.Location = new System.Drawing.Point(0, 178);
            this.pnlStajalista.Name = "pnlStajalista";
            this.pnlStajalista.Size = new System.Drawing.Size(300, 149);
            this.pnlStajalista.TabIndex = 9;
            // 
            // lstStajalista
            // 
            this.lstStajalista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstStajalista.FormattingEnabled = true;
            this.lstStajalista.HorizontalScrollbar = true;
            this.lstStajalista.ItemHeight = 29;
            this.lstStajalista.Location = new System.Drawing.Point(0, 0);
            this.lstStajalista.Name = "lstStajalista";
            this.lstStajalista.ScrollAlwaysVisible = true;
            this.lstStajalista.Size = new System.Drawing.Size(295, 149);
            this.lstStajalista.TabIndex = 0;
            this.lstStajalista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstStajalista_MouseClick);
            this.lstStajalista.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstStajalista_MouseMove);
            // 
            // pnlUnutarLinije
            // 
            this.pnlUnutarLinije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlUnutarLinije.AutoScroll = true;
            this.pnlUnutarLinije.Controls.Add(this.lstUnutarLinije);
            this.pnlUnutarLinije.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.pnlUnutarLinije.Location = new System.Drawing.Point(377, 178);
            this.pnlUnutarLinije.Name = "pnlUnutarLinije";
            this.pnlUnutarLinije.Size = new System.Drawing.Size(300, 149);
            this.pnlUnutarLinije.TabIndex = 10;
            // 
            // lstUnutarLinije
            // 
            this.lstUnutarLinije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstUnutarLinije.FormattingEnabled = true;
            this.lstUnutarLinije.HorizontalScrollbar = true;
            this.lstUnutarLinije.ItemHeight = 29;
            this.lstUnutarLinije.Location = new System.Drawing.Point(5, 0);
            this.lstUnutarLinije.Name = "lstUnutarLinije";
            this.lstUnutarLinije.ScrollAlwaysVisible = true;
            this.lstUnutarLinije.Size = new System.Drawing.Size(295, 149);
            this.lstUnutarLinije.TabIndex = 0;
            this.lstUnutarLinije.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstUnutarLinije_MouseClick);
            this.lstUnutarLinije.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstUnutarLinije_MouseMove);
            // 
            // comboLinijeURutama
            // 
            this.comboLinijeURutama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLinijeURutama.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboLinijeURutama.DropDownHeight = 300;
            this.comboLinijeURutama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLinijeURutama.DropDownWidth = 450;
            this.comboLinijeURutama.FormattingEnabled = true;
            this.comboLinijeURutama.IntegralHeight = false;
            this.comboLinijeURutama.Location = new System.Drawing.Point(6, 87);
            this.comboLinijeURutama.MaxDropDownItems = 50;
            this.comboLinijeURutama.Name = "comboLinijeURutama";
            this.comboLinijeURutama.Size = new System.Drawing.Size(665, 45);
            this.comboLinijeURutama.TabIndex = 8;
            this.comboLinijeURutama.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboLinijeURutama_DrawItem);
            // 
            // tabAdminKorisnici
            // 
            this.tabAdminKorisnici.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabAdminKorisnici.Controls.Add(this.pnlKorisnici);
            this.tabAdminKorisnici.Controls.Add(this.btnAddKorisnik);
            this.tabAdminKorisnici.Controls.Add(this.btnEditKorisnik);
            this.tabAdminKorisnici.Controls.Add(this.btnDeleteKorisnik);
            this.tabAdminKorisnici.Location = new System.Drawing.Point(4, 46);
            this.tabAdminKorisnici.Name = "tabAdminKorisnici";
            this.tabAdminKorisnici.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminKorisnici.Size = new System.Drawing.Size(677, 413);
            this.tabAdminKorisnici.TabIndex = 3;
            this.tabAdminKorisnici.Text = "Korisnici";
            this.tabAdminKorisnici.Enter += new System.EventHandler(this.tabAdminKorisnici_Enter);
            // 
            // pnlKorisnici
            // 
            this.pnlKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKorisnici.AutoScroll = true;
            this.pnlKorisnici.Controls.Add(this.gridKorisnici);
            this.pnlKorisnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.pnlKorisnici.Location = new System.Drawing.Point(0, 87);
            this.pnlKorisnici.Name = "pnlKorisnici";
            this.pnlKorisnici.Size = new System.Drawing.Size(677, 326);
            this.pnlKorisnici.TabIndex = 19;
            // 
            // gridKorisnici
            // 
            this.gridKorisnici.AllowUserToAddRows = false;
            this.gridKorisnici.AllowUserToDeleteRows = false;
            this.gridKorisnici.AllowUserToOrderColumns = true;
            this.gridKorisnici.AllowUserToResizeColumns = false;
            this.gridKorisnici.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridKorisnici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKorisnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridKorisnici.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridKorisnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridKorisnici.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridKorisnici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridKorisnici.Location = new System.Drawing.Point(1, 0);
            this.gridKorisnici.MultiSelect = false;
            this.gridKorisnici.Name = "gridKorisnici";
            this.gridKorisnici.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridKorisnici.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridKorisnici.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridKorisnici.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridKorisnici.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridKorisnici.RowTemplate.ReadOnly = true;
            this.gridKorisnici.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKorisnici.Size = new System.Drawing.Size(677, 326);
            this.gridKorisnici.TabIndex = 14;
            this.gridKorisnici.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridKorisnici_CellMouseDoubleClick);
            this.gridKorisnici.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridKorisnici_CellMouseDown);
            this.gridKorisnici.SelectionChanged += new System.EventHandler(this.gridKorisnici_SelectionChanged);
            this.gridKorisnici.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridKorisnici_MouseDown);
            // 
            // btnAddKorisnik
            // 
            this.btnAddKorisnik.BackColor = System.Drawing.Color.Lime;
            this.btnAddKorisnik.BackgroundImage = global::BLINC.Properties.Resources.Add;
            this.btnAddKorisnik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKorisnik.ForeColor = System.Drawing.Color.Black;
            this.btnAddKorisnik.Location = new System.Drawing.Point(8, 6);
            this.btnAddKorisnik.Name = "btnAddKorisnik";
            this.btnAddKorisnik.Size = new System.Drawing.Size(75, 75);
            this.btnAddKorisnik.TabIndex = 17;
            this.btnAddKorisnik.UseVisualStyleBackColor = false;
            this.btnAddKorisnik.Click += new System.EventHandler(this.btnAddKorisnik_Click);
            // 
            // btnEditKorisnik
            // 
            this.btnEditKorisnik.BackColor = System.Drawing.Color.Yellow;
            this.btnEditKorisnik.BackgroundImage = global::BLINC.Properties.Resources.Edit;
            this.btnEditKorisnik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditKorisnik.ForeColor = System.Drawing.Color.Black;
            this.btnEditKorisnik.Location = new System.Drawing.Point(89, 6);
            this.btnEditKorisnik.Name = "btnEditKorisnik";
            this.btnEditKorisnik.Size = new System.Drawing.Size(75, 75);
            this.btnEditKorisnik.TabIndex = 16;
            this.btnEditKorisnik.UseVisualStyleBackColor = false;
            this.btnEditKorisnik.Click += new System.EventHandler(this.btnEditKorisnik_Click);
            // 
            // btnDeleteKorisnik
            // 
            this.btnDeleteKorisnik.BackColor = System.Drawing.Color.Red;
            this.btnDeleteKorisnik.BackgroundImage = global::BLINC.Properties.Resources.Delete;
            this.btnDeleteKorisnik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteKorisnik.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteKorisnik.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeleteKorisnik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleteKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteKorisnik.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteKorisnik.Location = new System.Drawing.Point(170, 6);
            this.btnDeleteKorisnik.Name = "btnDeleteKorisnik";
            this.btnDeleteKorisnik.Size = new System.Drawing.Size(75, 75);
            this.btnDeleteKorisnik.TabIndex = 15;
            this.btnDeleteKorisnik.UseVisualStyleBackColor = false;
            this.btnDeleteKorisnik.Click += new System.EventHandler(this.btnDeleteKorisnik_Click);
            // 
            // tabRute
            // 
            this.tabRute.Controls.Add(this.tvRute);
            this.tabRute.Location = new System.Drawing.Point(4, 46);
            this.tabRute.Name = "tabRute";
            this.tabRute.Padding = new System.Windows.Forms.Padding(3);
            this.tabRute.Size = new System.Drawing.Size(677, 413);
            this.tabRute.TabIndex = 2;
            this.tabRute.Text = "Rute";
            this.tabRute.UseVisualStyleBackColor = true;
            this.tabRute.Enter += new System.EventHandler(this.tabRute_Enter);
            // 
            // tvRute
            // 
            this.tvRute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvRute.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tvRute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.tvRute.Location = new System.Drawing.Point(0, 0);
            this.tvRute.Name = "tvRute";
            this.tvRute.Size = new System.Drawing.Size(677, 410);
            this.tvRute.TabIndex = 5;
            // 
            // tabRedVoznje
            // 
            this.tabRedVoznje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabRedVoznje.Controls.Add(this.splitContainer1);
            this.tabRedVoznje.Controls.Add(this.comboLinije);
            this.tabRedVoznje.Location = new System.Drawing.Point(4, 46);
            this.tabRedVoznje.Name = "tabRedVoznje";
            this.tabRedVoznje.Padding = new System.Windows.Forms.Padding(3);
            this.tabRedVoznje.Size = new System.Drawing.Size(677, 413);
            this.tabRedVoznje.TabIndex = 1;
            this.tabRedVoznje.Text = "Red vožnje";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lvVremenaPolaska);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lvVremenaPovratka);
            this.splitContainer1.Size = new System.Drawing.Size(677, 359);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(59, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vremena polaska";
            // 
            // lvVremenaPolaska
            // 
            this.lvVremenaPolaska.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVremenaPolaska.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lvVremenaPolaska.LabelWrap = false;
            this.lvVremenaPolaska.Location = new System.Drawing.Point(-1, 33);
            this.lvVremenaPolaska.Name = "lvVremenaPolaska";
            this.lvVremenaPolaska.Size = new System.Drawing.Size(338, 343);
            this.lvVremenaPolaska.TabIndex = 8;
            this.lvVremenaPolaska.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(66, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vremena povratka";
            // 
            // lvVremenaPovratka
            // 
            this.lvVremenaPovratka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVremenaPovratka.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lvVremenaPovratka.Location = new System.Drawing.Point(0, 33);
            this.lvVremenaPovratka.Name = "lvVremenaPovratka";
            this.lvVremenaPovratka.Size = new System.Drawing.Size(338, 343);
            this.lvVremenaPovratka.TabIndex = 9;
            this.lvVremenaPovratka.UseCompatibleStateImageBehavior = false;
            // 
            // comboLinije
            // 
            this.comboLinije.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboLinije.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboLinije.DropDownHeight = 300;
            this.comboLinije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLinije.DropDownWidth = 450;
            this.comboLinije.FormattingEnabled = true;
            this.comboLinije.IntegralHeight = false;
            this.comboLinije.Location = new System.Drawing.Point(3, 3);
            this.comboLinije.MaxDropDownItems = 50;
            this.comboLinije.Name = "comboLinije";
            this.comboLinije.Size = new System.Drawing.Size(671, 45);
            this.comboLinije.TabIndex = 7;
            this.comboLinije.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboLinije_DrawItem);
            // 
            // tabMap
            // 
            this.tabMap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabMap.Controls.Add(this.pnlMapa);
            this.tabMap.Location = new System.Drawing.Point(4, 46);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(677, 413);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "Mapa";
            this.tabMap.Enter += new System.EventHandler(this.tabMap_Enter);
            // 
            // pnlMapa
            // 
            this.pnlMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMapa.AutoSize = true;
            this.pnlMapa.Controls.Add(this.lblDesno1);
            this.pnlMapa.Controls.Add(this.lblDesno2);
            this.pnlMapa.Controls.Add(this.pnlDesno);
            this.pnlMapa.Controls.Add(this.pnlToggles);
            this.pnlMapa.Controls.Add(this.pnlDesnoColider);
            this.pnlMapa.Controls.Add(this.pnlTogglesColider);
            this.pnlMapa.Controls.Add(this.mapMapa);
            this.pnlMapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMapa.Location = new System.Drawing.Point(3, 3);
            this.pnlMapa.Name = "pnlMapa";
            this.pnlMapa.Size = new System.Drawing.Size(671, 410);
            this.pnlMapa.TabIndex = 5;
            // 
            // lblDesno1
            // 
            this.lblDesno1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesno1.AutoSize = true;
            this.lblDesno1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDesno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesno1.Location = new System.Drawing.Point(498, 29);
            this.lblDesno1.Name = "lblDesno1";
            this.lblDesno1.Size = new System.Drawing.Size(158, 20);
            this.lblDesno1.TabIndex = 11;
            this.lblDesno1.Text = "kroz ovo stajalište:";
            this.lblDesno1.Visible = false;
            // 
            // lblDesno2
            // 
            this.lblDesno2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesno2.AutoSize = true;
            this.lblDesno2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDesno2.Location = new System.Drawing.Point(500, 9);
            this.lblDesno2.Name = "lblDesno2";
            this.lblDesno2.Size = new System.Drawing.Size(153, 20);
            this.lblDesno2.TabIndex = 10;
            this.lblDesno2.Text = "Linije koje prolaze";
            this.lblDesno2.Visible = false;
            // 
            // pnlDesno
            // 
            this.pnlDesno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDesno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlDesno.Location = new System.Drawing.Point(486, 0);
            this.pnlDesno.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDesno.Name = "pnlDesno";
            this.pnlDesno.Size = new System.Drawing.Size(185, 408);
            this.pnlDesno.TabIndex = 3;
            this.pnlDesno.UseCompatibleStateImageBehavior = false;
            this.pnlDesno.Visible = false;
            this.pnlDesno.MouseLeave += new System.EventHandler(this.pnlDesno_MouseLeave);
            // 
            // pnlToggles
            // 
            this.pnlToggles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlToggles.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlToggles.Location = new System.Drawing.Point(0, 0);
            this.pnlToggles.Margin = new System.Windows.Forms.Padding(0);
            this.pnlToggles.Name = "pnlToggles";
            this.pnlToggles.Size = new System.Drawing.Size(70, 408);
            this.pnlToggles.TabIndex = 4;
            this.pnlToggles.Visible = false;
            this.pnlToggles.MouseLeave += new System.EventHandler(this.pnlToggles_MouseLeave);
            // 
            // pnlDesnoColider
            // 
            this.pnlDesnoColider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDesnoColider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDesnoColider.ForeColor = System.Drawing.Color.Transparent;
            this.pnlDesnoColider.Location = new System.Drawing.Point(656, 0);
            this.pnlDesnoColider.Name = "pnlDesnoColider";
            this.pnlDesnoColider.Size = new System.Drawing.Size(15, 408);
            this.pnlDesnoColider.TabIndex = 6;
            this.pnlDesnoColider.MouseEnter += new System.EventHandler(this.pnlDesnoColider_MouseEnter);
            // 
            // pnlTogglesColider
            // 
            this.pnlTogglesColider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlTogglesColider.BackColor = System.Drawing.Color.Transparent;
            this.pnlTogglesColider.ForeColor = System.Drawing.Color.Transparent;
            this.pnlTogglesColider.Location = new System.Drawing.Point(-3, -3);
            this.pnlTogglesColider.Name = "pnlTogglesColider";
            this.pnlTogglesColider.Size = new System.Drawing.Size(20, 366);
            this.pnlTogglesColider.TabIndex = 7;
            this.pnlTogglesColider.MouseEnter += new System.EventHandler(this.pnlTogglesColider_MouseEnter);
            // 
            // mapMapa
            // 
            this.mapMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapMapa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mapMapa.Bearing = 0F;
            this.mapMapa.CanDragMap = true;
            this.mapMapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapMapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapMapa.GrayScaleMode = false;
            this.mapMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapMapa.LevelsKeepInMemmory = 5;
            this.mapMapa.Location = new System.Drawing.Point(20, 0);
            this.mapMapa.Margin = new System.Windows.Forms.Padding(0);
            this.mapMapa.MarkersEnabled = true;
            this.mapMapa.MaxZoom = 20;
            this.mapMapa.MinZoom = 12;
            this.mapMapa.MouseWheelZoomEnabled = true;
            this.mapMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapMapa.Name = "mapMapa";
            this.mapMapa.NegativeMode = false;
            this.mapMapa.PolygonsEnabled = true;
            this.mapMapa.RetryLoadTile = 0;
            this.mapMapa.RoutesEnabled = true;
            this.mapMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.mapMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapMapa.ShowTileGridLines = false;
            this.mapMapa.Size = new System.Drawing.Size(636, 408);
            this.mapMapa.TabIndex = 8;
            this.mapMapa.Zoom = 0D;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabMap);
            this.tabControl1.Controls.Add(this.tabRedVoznje);
            this.tabControl1.Controls.Add(this.tabRute);
            this.tabControl1.Controls.Add(this.tabAdminRute);
            this.tabControl1.Controls.Add(this.tabAdminKorisnici);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 463);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabRedVoznje_Enter);
            // 
            // tsKorisnik
            // 
            this.tsKorisnik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUredi,
            this.tsmUkloni});
            this.tsKorisnik.Name = "tsKorisnik";
            this.tsKorisnik.Size = new System.Drawing.Size(109, 48);
            // 
            // tsmUredi
            // 
            this.tsmUredi.Image = global::BLINC.Properties.Resources.Edit;
            this.tsmUredi.Name = "tsmUredi";
            this.tsmUredi.Size = new System.Drawing.Size(108, 22);
            this.tsmUredi.Text = "Uredi";
            this.tsmUredi.Click += new System.EventHandler(this.tsmUredi_Click);
            // 
            // tsmUkloni
            // 
            this.tsmUkloni.Image = global::BLINC.Properties.Resources.Delete;
            this.tsmUkloni.Name = "tsmUkloni";
            this.tsmUkloni.Size = new System.Drawing.Size(108, 22);
            this.tsmUkloni.Text = "Ukloni";
            this.tsmUkloni.Click += new System.EventHandler(this.tsmUkloni_Click);
            // 
            // Javni_prevoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Javni_prevoz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Javni prevoz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Javni_prevoz_FormClosed);
            this.Load += new System.EventHandler(this.Javni_prevoz_Load);
            this.tabAdminRute.ResumeLayout(false);
            this.pnlAdminRute.ResumeLayout(false);
            this.pnlAdminRute.PerformLayout();
            this.pnlStajalista.ResumeLayout(false);
            this.pnlUnutarLinije.ResumeLayout(false);
            this.tabAdminKorisnici.ResumeLayout(false);
            this.pnlKorisnici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKorisnici)).EndInit();
            this.tabRute.ResumeLayout(false);
            this.tabRedVoznje.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.tabMap.PerformLayout();
            this.pnlMapa.ResumeLayout(false);
            this.pnlMapa.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bLINCEntitiesBindingSource)).EndInit();
            this.tsKorisnik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bLINCEntitiesBindingSource;
        private System.Windows.Forms.TabPage tabAdminRute;
        private System.Windows.Forms.TabPage tabAdminKorisnici;
        private System.Windows.Forms.Button btnAddKorisnik;
        private System.Windows.Forms.Button btnEditKorisnik;
        private System.Windows.Forms.Button btnDeleteKorisnik;
        private System.Windows.Forms.DataGridView gridKorisnici;
        private System.Windows.Forms.TabPage tabRute;
        private System.Windows.Forms.TreeView tvRute;
        private System.Windows.Forms.TabPage tabRedVoznje;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvVremenaPolaska;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvVremenaPovratka;
        private System.Windows.Forms.ComboBox comboLinije;
        private System.Windows.Forms.TabPage tabMap;
        private System.Windows.Forms.Panel pnlMapa;
        private System.Windows.Forms.Label lblDesno1;
        private System.Windows.Forms.Label lblDesno2;
        private System.Windows.Forms.ListView pnlDesno;
        private System.Windows.Forms.Panel pnlToggles;
        private System.Windows.Forms.Panel pnlDesnoColider;
        private System.Windows.Forms.Panel pnlTogglesColider;
        private GMap.NET.WindowsForms.GMapControl mapMapa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel pnlKorisnici;
        private System.Windows.Forms.Panel pnlAdminRute;
        private System.Windows.Forms.ComboBox comboLinijeURutama;
        private System.Windows.Forms.Panel pnlStajalista;
        private System.Windows.Forms.ListBox lstStajalista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlUnutarLinije;
        private System.Windows.Forms.ListBox lstUnutarLinije;
        private System.Windows.Forms.Button btnDole;
        private System.Windows.Forms.Button btnGore;
        private System.Windows.Forms.Button btnDeleteRoute;
        private System.Windows.Forms.Button btnEditRoute;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.Button btnDeleteStop;
        private System.Windows.Forms.Button btnAddStop;
        private System.Windows.Forms.Button btnEditStop;
        private System.Windows.Forms.ToolTip ttHelp;
        private System.Windows.Forms.ContextMenuStrip tsKorisnik;
        private System.Windows.Forms.ToolStripMenuItem tsmUredi;
        private System.Windows.Forms.ToolStripMenuItem tsmUkloni;
    }
}