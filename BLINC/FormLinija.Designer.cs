namespace BLINC
{
    partial class FormLinija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLinija));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.lblBroj = new System.Windows.Forms.ComboBox();
            this.lblNaziv = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 113);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 50);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(50, 113);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 50);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Broj";
            // 
            // lblBroj
            // 
            this.lblBroj.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lblBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBroj.FormattingEnabled = true;
            this.lblBroj.Location = new System.Drawing.Point(136, 12);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(136, 27);
            this.lblBroj.TabIndex = 16;
            this.lblBroj.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lblBroj_DrawItem);
            this.lblBroj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblBroj_KeyDown);
            // 
            // lblNaziv
            // 
            this.lblNaziv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNaziv.FormattingEnabled = true;
            this.lblNaziv.Location = new System.Drawing.Point(136, 44);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(136, 27);
            this.lblNaziv.TabIndex = 17;
            this.lblNaziv.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lblNaziv_DrawItem);
            this.lblNaziv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblNaziv_KeyDown);
            // 
            // FormLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLinija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLinija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLinija_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttHelp;
        private System.Windows.Forms.ComboBox lblBroj;
        private System.Windows.Forms.ComboBox lblNaziv;
    }
}