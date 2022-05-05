namespace prjGehalt
{
    partial class Form1
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
            this.lblListePersonen = new System.Windows.Forms.Label();
            this.livPersonen = new System.Windows.Forms.ListView();
            this.gbrStatistik = new System.Windows.Forms.GroupBox();
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.lblAlter = new System.Windows.Forms.Label();
            this.lblGehalt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlterDurchschnitt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbSortierung = new System.Windows.Forms.GroupBox();
            this.rbtName = new System.Windows.Forms.RadioButton();
            this.rbtAlter = new System.Windows.Forms.RadioButton();
            this.rbtGehalt = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtGehalt = new System.Windows.Forms.TextBox();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.rbtUnsortiert = new System.Windows.Forms.RadioButton();
            this.gbrStatistik.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grbSortierung.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListePersonen
            // 
            this.lblListePersonen.AutoSize = true;
            this.lblListePersonen.Location = new System.Drawing.Point(21, 51);
            this.lblListePersonen.Name = "lblListePersonen";
            this.lblListePersonen.Size = new System.Drawing.Size(169, 13);
            this.lblListePersonen.TabIndex = 0;
            this.lblListePersonen.Text = "Liste der eingegebenen Personen:";
            // 
            // livPersonen
            // 
            this.livPersonen.HideSelection = false;
            this.livPersonen.Location = new System.Drawing.Point(12, 67);
            this.livPersonen.Name = "livPersonen";
            this.livPersonen.Size = new System.Drawing.Size(409, 231);
            this.livPersonen.TabIndex = 1;
            this.livPersonen.UseCompatibleStateImageBehavior = false;
            // 
            // gbrStatistik
            // 
            this.gbrStatistik.Controls.Add(this.groupBox4);
            this.gbrStatistik.Controls.Add(this.groupBox3);
            this.gbrStatistik.Controls.Add(this.groupBox2);
            this.gbrStatistik.Controls.Add(this.lblGehalt);
            this.gbrStatistik.Controls.Add(this.lblAlter);
            this.gbrStatistik.Controls.Add(this.lblAnzahl);
            this.gbrStatistik.Location = new System.Drawing.Point(15, 304);
            this.gbrStatistik.Name = "gbrStatistik";
            this.gbrStatistik.Size = new System.Drawing.Size(406, 134);
            this.gbrStatistik.TabIndex = 2;
            this.gbrStatistik.TabStop = false;
            this.gbrStatistik.Text = "Statistik";
            this.gbrStatistik.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.AutoSize = true;
            this.lblAnzahl.Location = new System.Drawing.Point(47, 25);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.Size = new System.Drawing.Size(162, 13);
            this.lblAnzahl.TabIndex = 0;
            this.lblAnzahl.Text = "Anzahl der Personen in der Liste:";
            // 
            // lblAlter
            // 
            this.lblAlter.AutoSize = true;
            this.lblAlter.Location = new System.Drawing.Point(16, 56);
            this.lblAlter.Name = "lblAlter";
            this.lblAlter.Size = new System.Drawing.Size(193, 13);
            this.lblAlter.TabIndex = 1;
            this.lblAlter.Text = "Mittleres Alter der Personen in der Liste:";
            this.lblAlter.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGehalt
            // 
            this.lblGehalt.AutoSize = true;
            this.lblGehalt.Location = new System.Drawing.Point(6, 90);
            this.lblGehalt.Name = "lblGehalt";
            this.lblGehalt.Size = new System.Drawing.Size(203, 13);
            this.lblGehalt.TabIndex = 2;
            this.lblGehalt.Text = "Mittleres Gehalt der Personen in der Liste:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(220, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 19);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(220, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 19);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(220, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 19);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnHinzufügen);
            this.groupBox5.Controls.Add(this.txtGehalt);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.lblAlterDurchschnitt);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(427, 51);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(341, 138);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Personeneingabe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // lblAlterDurchschnitt
            // 
            this.lblAlterDurchschnitt.AutoSize = true;
            this.lblAlterDurchschnitt.Location = new System.Drawing.Point(6, 49);
            this.lblAlterDurchschnitt.Name = "lblAlterDurchschnitt";
            this.lblAlterDurchschnitt.Size = new System.Drawing.Size(28, 13);
            this.lblAlterDurchschnitt.TabIndex = 5;
            this.lblAlterDurchschnitt.Text = "Alter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gehalt[€]";
            // 
            // grbSortierung
            // 
            this.grbSortierung.Controls.Add(this.rbtUnsortiert);
            this.grbSortierung.Controls.Add(this.rbtGehalt);
            this.grbSortierung.Controls.Add(this.rbtAlter);
            this.grbSortierung.Controls.Add(this.rbtName);
            this.grbSortierung.Location = new System.Drawing.Point(427, 304);
            this.grbSortierung.Name = "grbSortierung";
            this.grbSortierung.Size = new System.Drawing.Size(341, 134);
            this.grbSortierung.TabIndex = 4;
            this.grbSortierung.TabStop = false;
            this.grbSortierung.Text = "Kriterium für aufsteigende Sortierung";
            // 
            // rbtName
            // 
            this.rbtName.AutoSize = true;
            this.rbtName.Location = new System.Drawing.Point(173, 23);
            this.rbtName.Name = "rbtName";
            this.rbtName.Size = new System.Drawing.Size(82, 17);
            this.rbtName.TabIndex = 5;
            this.rbtName.TabStop = true;
            this.rbtName.Text = "Nach Name";
            this.rbtName.UseVisualStyleBackColor = true;
            // 
            // rbtAlter
            // 
            this.rbtAlter.AutoSize = true;
            this.rbtAlter.Location = new System.Drawing.Point(173, 60);
            this.rbtAlter.Name = "rbtAlter";
            this.rbtAlter.Size = new System.Drawing.Size(75, 17);
            this.rbtAlter.TabIndex = 7;
            this.rbtAlter.TabStop = true;
            this.rbtAlter.Text = "Nach Alter";
            this.rbtAlter.UseVisualStyleBackColor = true;
            // 
            // rbtGehalt
            // 
            this.rbtGehalt.AutoSize = true;
            this.rbtGehalt.Location = new System.Drawing.Point(173, 96);
            this.rbtGehalt.Name = "rbtGehalt";
            this.rbtGehalt.Size = new System.Drawing.Size(85, 17);
            this.rbtGehalt.TabIndex = 8;
            this.rbtGehalt.TabStop = true;
            this.rbtGehalt.Text = "Nach Gehalt";
            this.rbtGehalt.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 20);
            this.textBox2.TabIndex = 10;
            // 
            // txtGehalt
            // 
            this.txtGehalt.Location = new System.Drawing.Point(105, 89);
            this.txtGehalt.Name = "txtGehalt";
            this.txtGehalt.Size = new System.Drawing.Size(55, 20);
            this.txtGehalt.TabIndex = 11;
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(212, 86);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(95, 23);
            this.btnHinzufügen.TabIndex = 6;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            // 
            // rbtUnsortiert
            // 
            this.rbtUnsortiert.AutoSize = true;
            this.rbtUnsortiert.Location = new System.Drawing.Point(23, 25);
            this.rbtUnsortiert.Name = "rbtUnsortiert";
            this.rbtUnsortiert.Size = new System.Drawing.Size(70, 17);
            this.rbtUnsortiert.TabIndex = 9;
            this.rbtUnsortiert.TabStop = true;
            this.rbtUnsortiert.Text = "Unsortiert";
            this.rbtUnsortiert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbSortierung);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbrStatistik);
            this.Controls.Add(this.livPersonen);
            this.Controls.Add(this.lblListePersonen);
            this.Name = "Form1";
            this.Text = "ArrayList und ListView";
            this.gbrStatistik.ResumeLayout(false);
            this.gbrStatistik.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grbSortierung.ResumeLayout(false);
            this.grbSortierung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListePersonen;
        private System.Windows.Forms.ListView livPersonen;
        private System.Windows.Forms.GroupBox gbrStatistik;
        private System.Windows.Forms.Label lblGehalt;
        private System.Windows.Forms.Label lblAlter;
        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.TextBox txtGehalt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlterDurchschnitt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbSortierung;
        private System.Windows.Forms.RadioButton rbtGehalt;
        private System.Windows.Forms.RadioButton rbtAlter;
        private System.Windows.Forms.RadioButton rbtName;
        private System.Windows.Forms.RadioButton rbtUnsortiert;
    }
}

