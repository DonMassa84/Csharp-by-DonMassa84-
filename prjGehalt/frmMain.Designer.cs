namespace prjGehalt
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.livPersonen = new System.Windows.Forms.ListView();
            this.cohID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohAlter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohGehalt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbStatistik = new System.Windows.Forms.GroupBox();
            this.txtGehaltDurchschnitt = new System.Windows.Forms.TextBox();
            this.txtAlterDurchschnitt = new System.Windows.Forms.TextBox();
            this.txtAnzahl = new System.Windows.Forms.TextBox();
            this.lblGehaltDurchschnitt = new System.Windows.Forms.Label();
            this.lblAlterDurchschnitt = new System.Windows.Forms.Label();
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.grbEingabe = new System.Windows.Forms.GroupBox();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.txtGehalt = new System.Windows.Forms.TextBox();
            this.txtAlter = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGehalt = new System.Windows.Forms.Label();
            this.lblAlter = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grbSortierung = new System.Windows.Forms.GroupBox();
            this.rbtGehalt = new System.Windows.Forms.RadioButton();
            this.rbtAlter = new System.Windows.Forms.RadioButton();
            this.rbtName = new System.Windows.Forms.RadioButton();
            this.rbtUnsortiert = new System.Windows.Forms.RadioButton();
            this.grbStatistik.SuspendLayout();
            this.grbEingabe.SuspendLayout();
            this.grbSortierung.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste der eingegebenen Personen:";
            // 
            // livPersonen
            // 
            this.livPersonen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cohID,
            this.cohName,
            this.cohAlter,
            this.cohGehalt});
            this.livPersonen.GridLines = true;
            this.livPersonen.HideSelection = false;
            this.livPersonen.Location = new System.Drawing.Point(25, 65);
            this.livPersonen.Name = "livPersonen";
            this.livPersonen.Size = new System.Drawing.Size(563, 257);
            this.livPersonen.TabIndex = 1;
            this.livPersonen.UseCompatibleStateImageBehavior = false;
            this.livPersonen.View = System.Windows.Forms.View.Details;
            // 
            // cohID
            // 
            this.cohID.Text = "ID";
            this.cohID.Width = 40;
            // 
            // cohName
            // 
            this.cohName.Text = "Name";
            this.cohName.Width = 82;
            // 
            // cohAlter
            // 
            this.cohAlter.Text = "Alter";
            this.cohAlter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cohAlter.Width = 79;
            // 
            // cohGehalt
            // 
            this.cohGehalt.Text = "Gehalt";
            this.cohGehalt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cohGehalt.Width = 297;
            // 
            // grbStatistik
            // 
            this.grbStatistik.Controls.Add(this.txtGehaltDurchschnitt);
            this.grbStatistik.Controls.Add(this.txtAlterDurchschnitt);
            this.grbStatistik.Controls.Add(this.txtAnzahl);
            this.grbStatistik.Controls.Add(this.lblGehaltDurchschnitt);
            this.grbStatistik.Controls.Add(this.lblAlterDurchschnitt);
            this.grbStatistik.Controls.Add(this.lblAnzahl);
            this.grbStatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStatistik.Location = new System.Drawing.Point(25, 355);
            this.grbStatistik.Name = "grbStatistik";
            this.grbStatistik.Size = new System.Drawing.Size(563, 148);
            this.grbStatistik.TabIndex = 2;
            this.grbStatistik.TabStop = false;
            this.grbStatistik.Text = "Statistik";
            // 
            // txtGehaltDurchschnitt
            // 
            this.txtGehaltDurchschnitt.Enabled = false;
            this.txtGehaltDurchschnitt.Location = new System.Drawing.Point(295, 118);
            this.txtGehaltDurchschnitt.Name = "txtGehaltDurchschnitt";
            this.txtGehaltDurchschnitt.Size = new System.Drawing.Size(174, 24);
            this.txtGehaltDurchschnitt.TabIndex = 1;
            // 
            // txtAlterDurchschnitt
            // 
            this.txtAlterDurchschnitt.Enabled = false;
            this.txtAlterDurchschnitt.Location = new System.Drawing.Point(295, 81);
            this.txtAlterDurchschnitt.Name = "txtAlterDurchschnitt";
            this.txtAlterDurchschnitt.Size = new System.Drawing.Size(174, 24);
            this.txtAlterDurchschnitt.TabIndex = 1;
            // 
            // txtAnzahl
            // 
            this.txtAnzahl.Enabled = false;
            this.txtAnzahl.Location = new System.Drawing.Point(295, 48);
            this.txtAnzahl.Name = "txtAnzahl";
            this.txtAnzahl.Size = new System.Drawing.Size(174, 24);
            this.txtAnzahl.TabIndex = 1;
            // 
            // lblGehaltDurchschnitt
            // 
            this.lblGehaltDurchschnitt.AutoSize = true;
            this.lblGehaltDurchschnitt.Location = new System.Drawing.Point(6, 117);
            this.lblGehaltDurchschnitt.Name = "lblGehaltDurchschnitt";
            this.lblGehaltDurchschnitt.Size = new System.Drawing.Size(283, 18);
            this.lblGehaltDurchschnitt.TabIndex = 0;
            this.lblGehaltDurchschnitt.Text = "Mittleres Gehalt der Personen in der Liste:";
            // 
            // lblAlterDurchschnitt
            // 
            this.lblAlterDurchschnitt.AutoSize = true;
            this.lblAlterDurchschnitt.Location = new System.Drawing.Point(20, 81);
            this.lblAlterDurchschnitt.Name = "lblAlterDurchschnitt";
            this.lblAlterDurchschnitt.Size = new System.Drawing.Size(269, 18);
            this.lblAlterDurchschnitt.TabIndex = 0;
            this.lblAlterDurchschnitt.Text = "Mittleres Alter der Personen in der Liste:";
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.AutoSize = true;
            this.lblAnzahl.Location = new System.Drawing.Point(65, 48);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.Size = new System.Drawing.Size(224, 18);
            this.lblAnzahl.TabIndex = 0;
            this.lblAnzahl.Text = "Anzahl der Personen in der Liste:";
            // 
            // grbEingabe
            // 
            this.grbEingabe.Controls.Add(this.btnHinzufügen);
            this.grbEingabe.Controls.Add(this.txtGehalt);
            this.grbEingabe.Controls.Add(this.txtAlter);
            this.grbEingabe.Controls.Add(this.txtName);
            this.grbEingabe.Controls.Add(this.lblGehalt);
            this.grbEingabe.Controls.Add(this.lblAlter);
            this.grbEingabe.Controls.Add(this.lblName);
            this.grbEingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEingabe.Location = new System.Drawing.Point(641, 65);
            this.grbEingabe.Name = "grbEingabe";
            this.grbEingabe.Size = new System.Drawing.Size(354, 197);
            this.grbEingabe.TabIndex = 3;
            this.grbEingabe.TabStop = false;
            this.grbEingabe.Text = "Personeneingabe";
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(205, 134);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(143, 44);
            this.btnHinzufügen.TabIndex = 3;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // txtGehalt
            // 
            this.txtGehalt.Location = new System.Drawing.Point(110, 147);
            this.txtGehalt.Name = "txtGehalt";
            this.txtGehalt.Size = new System.Drawing.Size(62, 24);
            this.txtGehalt.TabIndex = 2;
            // 
            // txtAlter
            // 
            this.txtAlter.Location = new System.Drawing.Point(110, 96);
            this.txtAlter.Name = "txtAlter";
            this.txtAlter.Size = new System.Drawing.Size(33, 24);
            this.txtAlter.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 24);
            this.txtName.TabIndex = 0;
            // 
            // lblGehalt
            // 
            this.lblGehalt.AutoSize = true;
            this.lblGehalt.Location = new System.Drawing.Point(32, 147);
            this.lblGehalt.Name = "lblGehalt";
            this.lblGehalt.Size = new System.Drawing.Size(67, 18);
            this.lblGehalt.TabIndex = 0;
            this.lblGehalt.Text = "Gehalt[€]";
            // 
            // lblAlter
            // 
            this.lblAlter.AutoSize = true;
            this.lblAlter.Location = new System.Drawing.Point(32, 96);
            this.lblAlter.Name = "lblAlter";
            this.lblAlter.Size = new System.Drawing.Size(37, 18);
            this.lblAlter.TabIndex = 0;
            this.lblAlter.Text = "Alter";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // grbSortierung
            // 
            this.grbSortierung.Controls.Add(this.rbtGehalt);
            this.grbSortierung.Controls.Add(this.rbtAlter);
            this.grbSortierung.Controls.Add(this.rbtName);
            this.grbSortierung.Controls.Add(this.rbtUnsortiert);
            this.grbSortierung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSortierung.Location = new System.Drawing.Point(641, 355);
            this.grbSortierung.Name = "grbSortierung";
            this.grbSortierung.Size = new System.Drawing.Size(354, 148);
            this.grbSortierung.TabIndex = 4;
            this.grbSortierung.TabStop = false;
            this.grbSortierung.Text = "Kriterium für aufsteigende Sortierung";
            // 
            // rbtGehalt
            // 
            this.rbtGehalt.AutoSize = true;
            this.rbtGehalt.Location = new System.Drawing.Point(205, 120);
            this.rbtGehalt.Name = "rbtGehalt";
            this.rbtGehalt.Size = new System.Drawing.Size(105, 22);
            this.rbtGehalt.TabIndex = 3;
            this.rbtGehalt.Text = "nach Gehalt";
            this.rbtGehalt.UseVisualStyleBackColor = true;
            this.rbtGehalt.CheckedChanged += new System.EventHandler(this.rbtEinRadiobutton_CheckedChanged);
            // 
            // rbtAlter
            // 
            this.rbtAlter.AutoSize = true;
            this.rbtAlter.Location = new System.Drawing.Point(205, 83);
            this.rbtAlter.Name = "rbtAlter";
            this.rbtAlter.Size = new System.Drawing.Size(91, 22);
            this.rbtAlter.TabIndex = 2;
            this.rbtAlter.Text = "nach Alter";
            this.rbtAlter.UseVisualStyleBackColor = true;
            this.rbtAlter.CheckedChanged += new System.EventHandler(this.rbtEinRadiobutton_CheckedChanged);
            // 
            // rbtName
            // 
            this.rbtName.AutoSize = true;
            this.rbtName.Location = new System.Drawing.Point(205, 48);
            this.rbtName.Name = "rbtName";
            this.rbtName.Size = new System.Drawing.Size(99, 22);
            this.rbtName.TabIndex = 1;
            this.rbtName.Text = "nach name";
            this.rbtName.UseVisualStyleBackColor = true;
            this.rbtName.CheckedChanged += new System.EventHandler(this.rbtEinRadiobutton_CheckedChanged);
            // 
            // rbtUnsortiert
            // 
            this.rbtUnsortiert.AutoSize = true;
            this.rbtUnsortiert.Checked = true;
            this.rbtUnsortiert.Location = new System.Drawing.Point(6, 44);
            this.rbtUnsortiert.Name = "rbtUnsortiert";
            this.rbtUnsortiert.Size = new System.Drawing.Size(91, 22);
            this.rbtUnsortiert.TabIndex = 0;
            this.rbtUnsortiert.TabStop = true;
            this.rbtUnsortiert.Text = "Unsortiert";
            this.rbtUnsortiert.UseVisualStyleBackColor = true;
            this.rbtUnsortiert.CheckedChanged += new System.EventHandler(this.rbtEinRadiobutton_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 515);
            this.Controls.Add(this.grbSortierung);
            this.Controls.Add(this.grbEingabe);
            this.Controls.Add(this.grbStatistik);
            this.Controls.Add(this.livPersonen);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "ArrayList und ListView";
            this.grbStatistik.ResumeLayout(false);
            this.grbStatistik.PerformLayout();
            this.grbEingabe.ResumeLayout(false);
            this.grbEingabe.PerformLayout();
            this.grbSortierung.ResumeLayout(false);
            this.grbSortierung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView livPersonen;
        private System.Windows.Forms.GroupBox grbStatistik;
        private System.Windows.Forms.Label lblGehaltDurchschnitt;
        private System.Windows.Forms.Label lblAlterDurchschnitt;
        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.TextBox txtGehaltDurchschnitt;
        private System.Windows.Forms.TextBox txtAlterDurchschnitt;
        private System.Windows.Forms.TextBox txtAnzahl;
        private System.Windows.Forms.GroupBox grbEingabe;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.TextBox txtGehalt;
        private System.Windows.Forms.TextBox txtAlter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGehalt;
        private System.Windows.Forms.Label lblAlter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grbSortierung;
        private System.Windows.Forms.RadioButton rbtGehalt;
        private System.Windows.Forms.RadioButton rbtAlter;
        private System.Windows.Forms.RadioButton rbtName;
        private System.Windows.Forms.RadioButton rbtUnsortiert;
        private System.Windows.Forms.ColumnHeader cohID;
        private System.Windows.Forms.ColumnHeader cohName;
        private System.Windows.Forms.ColumnHeader cohAlter;
        private System.Windows.Forms.ColumnHeader cohGehalt;
    }
}

