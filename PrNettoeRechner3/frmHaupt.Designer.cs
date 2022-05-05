namespace PrNettoeRechner3
{
    partial class frmHaupt
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
            this.lblBrutto = new System.Windows.Forms.Label();
            this.lblSteuer = new System.Windows.Forms.Label();
            this.lblNetto = new System.Windows.Forms.Label();
            this.txtSteuer = new System.Windows.Forms.TextBox();
            this.txtNetto = new System.Windows.Forms.TextBox();
            this.txtBrutto = new System.Windows.Forms.TextBox();
            this.btoBerechnen = new System.Windows.Forms.Button();
            this.btoNeueBerechnung = new System.Windows.Forms.Button();
            this.ProgrammEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrutto
            // 
            this.lblBrutto.AutoSize = true;
            this.lblBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrutto.Location = new System.Drawing.Point(65, 39);
            this.lblBrutto.Name = "lblBrutto";
            this.lblBrutto.Size = new System.Drawing.Size(58, 24);
            this.lblBrutto.TabIndex = 0;
            this.lblBrutto.Text = "Brutto";
            // 
            // lblSteuer
            // 
            this.lblSteuer.AutoSize = true;
            this.lblSteuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteuer.Location = new System.Drawing.Point(65, 83);
            this.lblSteuer.Name = "lblSteuer";
            this.lblSteuer.Size = new System.Drawing.Size(65, 24);
            this.lblSteuer.TabIndex = 0;
            this.lblSteuer.Text = "Steuer";
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetto.Location = new System.Drawing.Point(65, 132);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(54, 24);
            this.lblNetto.TabIndex = 0;
            this.lblNetto.Text = "Netto";
            // 
            // txtSteuer
            // 
            this.txtSteuer.Location = new System.Drawing.Point(152, 88);
            this.txtSteuer.Name = "txtSteuer";
            this.txtSteuer.Size = new System.Drawing.Size(100, 20);
            this.txtSteuer.TabIndex = 1;
            // 
            // txtNetto
            // 
            this.txtNetto.Enabled = false;
            this.txtNetto.Location = new System.Drawing.Point(152, 132);
            this.txtNetto.Name = "txtNetto";
            this.txtNetto.Size = new System.Drawing.Size(100, 20);
            this.txtNetto.TabIndex = 2;
            // 
            // txtBrutto
            // 
            this.txtBrutto.Location = new System.Drawing.Point(152, 39);
            this.txtBrutto.Name = "txtBrutto";
            this.txtBrutto.Size = new System.Drawing.Size(100, 20);
            this.txtBrutto.TabIndex = 0;
            // 
            // btoBerechnen
            // 
            this.btoBerechnen.Location = new System.Drawing.Point(30, 201);
            this.btoBerechnen.Name = "btoBerechnen";
            this.btoBerechnen.Size = new System.Drawing.Size(100, 48);
            this.btoBerechnen.TabIndex = 3;
            this.btoBerechnen.Text = "Berechnen";
            this.btoBerechnen.UseVisualStyleBackColor = true;
            this.btoBerechnen.Click += new System.EventHandler(this.btoBerechnen_Click);
            // 
            // btoNeueBerechnung
            // 
            this.btoNeueBerechnung.Location = new System.Drawing.Point(201, 201);
            this.btoNeueBerechnung.Name = "btoNeueBerechnung";
            this.btoNeueBerechnung.Size = new System.Drawing.Size(100, 48);
            this.btoNeueBerechnung.TabIndex = 5;
            this.btoNeueBerechnung.Text = "Neue Berechnung";
            this.btoNeueBerechnung.UseVisualStyleBackColor = true;
            this.btoNeueBerechnung.Click += new System.EventHandler(this.btoNeueBerechnung_Click);
            // 
            // ProgrammEnde
            // 
            this.ProgrammEnde.Location = new System.Drawing.Point(363, 201);
            this.ProgrammEnde.Name = "ProgrammEnde";
            this.ProgrammEnde.Size = new System.Drawing.Size(128, 48);
            this.ProgrammEnde.TabIndex = 5;
            this.ProgrammEnde.Text = "btoProgrammEnde";
            this.ProgrammEnde.UseVisualStyleBackColor = true;
            this.ProgrammEnde.Click += new System.EventHandler(this.ProgrammEnde_Click);
            // 
            // frmHaupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgrammEnde);
            this.Controls.Add(this.btoNeueBerechnung);
            this.Controls.Add(this.btoBerechnen);
            this.Controls.Add(this.txtNetto);
            this.Controls.Add(this.txtBrutto);
            this.Controls.Add(this.txtSteuer);
            this.Controls.Add(this.lblNetto);
            this.Controls.Add(this.lblSteuer);
            this.Controls.Add(this.lblBrutto);
            this.Name = "frmHaupt";
            this.Text = "3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrutto;
        private System.Windows.Forms.Label lblSteuer;
        private System.Windows.Forms.Label lblNetto;
        private System.Windows.Forms.TextBox txtSteuer;
        private System.Windows.Forms.TextBox txtNetto;
        private System.Windows.Forms.TextBox txtBrutto;
        private System.Windows.Forms.Button btoBerechnen;
        private System.Windows.Forms.Button btoNeueBerechnung;
        private System.Windows.Forms.Button ProgrammEnde;
    }
}

