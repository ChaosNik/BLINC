namespace BLINC
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.btnCancel = new System.Windows.Forms.Button();
            this.brnOK = new System.Windows.Forms.Button();
            this.lblPrezime = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 50);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // brnOK
            // 
            this.brnOK.Location = new System.Drawing.Point(50, 145);
            this.brnOK.Name = "brnOK";
            this.brnOK.Size = new System.Drawing.Size(75, 50);
            this.brnOK.TabIndex = 18;
            this.brnOK.Text = "OK";
            this.brnOK.UseVisualStyleBackColor = true;
            this.brnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrezime.Location = new System.Drawing.Point(136, 108);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(136, 26);
            this.lblPrezime.TabIndex = 17;
            // 
            // lblIme
            // 
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIme.Location = new System.Drawing.Point(136, 76);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(136, 26);
            this.lblIme.TabIndex = 16;
            // 
            // lblLozinka
            // 
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLozinka.Location = new System.Drawing.Point(136, 44);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.PasswordChar = '*';
            this.lblLozinka.Size = new System.Drawing.Size(136, 26);
            this.lblLozinka.TabIndex = 15;
            this.lblLozinka.UseSystemPasswordChar = true;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKorisnickoIme.Location = new System.Drawing.Point(136, 12);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(136, 26);
            this.lblKorisnickoIme.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lozinka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Korisničko ime";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.brnOK);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button brnOK;
        private System.Windows.Forms.TextBox lblPrezime;
        private System.Windows.Forms.TextBox lblIme;
        private System.Windows.Forms.TextBox lblLozinka;
        private System.Windows.Forms.TextBox lblKorisnickoIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}