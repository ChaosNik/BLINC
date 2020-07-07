namespace BLINC
{
    partial class FormStajaliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStajaliste));
            this.mapMapa = new GMap.NET.WindowsForms.GMapControl();
            this.lblY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.ComboBox();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
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
            this.mapMapa.Location = new System.Drawing.Point(9, 105);
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
            this.mapMapa.Size = new System.Drawing.Size(266, 149);
            this.mapMapa.TabIndex = 8;
            this.mapMapa.Zoom = 0D;
            this.mapMapa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mapMapa_MouseClick);
            // 
            // lblY
            // 
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblY.Location = new System.Drawing.Point(136, 76);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(136, 26);
            this.lblY.TabIndex = 14;
            this.lblY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblY_KeyDown);
            // 
            // lblX
            // 
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblX.Location = new System.Drawing.Point(136, 44);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(136, 26);
            this.lblX.TabIndex = 13;
            this.lblX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblX_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Geo. dužina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Geo. sirina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(150, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 50);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(50, 257);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 50);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNaziv.FormattingEnabled = true;
            this.lblNaziv.Location = new System.Drawing.Point(136, 12);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(136, 27);
            this.lblNaziv.TabIndex = 17;
            this.lblNaziv.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lblNaziv_DrawItem);
            this.lblNaziv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblNaziv_KeyDown);
            // 
            // FormStajaliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapMapa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStajaliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStajaliste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStajaliste_FormClosing);
            this.Load += new System.EventHandler(this.FormStajaliste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapMapa;
        private System.Windows.Forms.TextBox lblY;
        private System.Windows.Forms.TextBox lblX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox lblNaziv;
        private System.Windows.Forms.ToolTip ttHelp;
    }
}