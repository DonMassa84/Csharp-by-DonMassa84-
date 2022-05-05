namespace prjLogin
{
    partial class frmLogin
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
            this.btoPasswort = new System.Windows.Forms.Button();
            this.btoLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblBenutzername = new System.Windows.Forms.Label();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.lblBenutzerInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btoPasswort
            // 
            this.btoPasswort.Location = new System.Drawing.Point(461, 286);
            this.btoPasswort.Name = "btoPasswort";
            this.btoPasswort.Size = new System.Drawing.Size(96, 42);
            this.btoPasswort.TabIndex = 0;
            this.btoPasswort.Text = "Passwort";
            this.btoPasswort.UseVisualStyleBackColor = true;
            // 
            // btoLogin
            // 
            this.btoLogin.Location = new System.Drawing.Point(187, 286);
            this.btoLogin.Name = "btoLogin";
            this.btoLogin.Size = new System.Drawing.Size(87, 42);
            this.btoLogin.TabIndex = 1;
            this.btoLogin.Text = "Login";
            this.btoLogin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblBenutzername
            // 
            this.lblBenutzername.AutoSize = true;
            this.lblBenutzername.Location = new System.Drawing.Point(184, 151);
            this.lblBenutzername.Name = "lblBenutzername";
            this.lblBenutzername.Size = new System.Drawing.Size(75, 13);
            this.lblBenutzername.TabIndex = 4;
            this.lblBenutzername.Text = "Benutzername";
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(184, 195);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(50, 13);
            this.lblPasswort.TabIndex = 5;
            this.lblPasswort.Text = "Passwort";
            // 
            // lblBenutzerInfo
            // 
            this.lblBenutzerInfo.AutoSize = true;
            this.lblBenutzerInfo.Location = new System.Drawing.Point(184, 68);
            this.lblBenutzerInfo.Name = "lblBenutzerInfo";
            this.lblBenutzerInfo.Size = new System.Drawing.Size(116, 13);
            this.lblBenutzerInfo.TabIndex = 6;
            this.lblBenutzerInfo.Text = "Benutzer Informationen";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBenutzerInfo);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblBenutzername);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btoLogin);
            this.Controls.Add(this.btoPasswort);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btoPasswort;
        private System.Windows.Forms.Button btoLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblBenutzername;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Label lblBenutzerInfo;
    }
}