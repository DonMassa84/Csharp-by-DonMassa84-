namespace prjLogin
{
    partial class frmMain
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
            this.lblUnsereApplikation = new System.Windows.Forms.Label();
            this.btoAbmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnsereApplikation
            // 
            this.lblUnsereApplikation.AutoSize = true;
            this.lblUnsereApplikation.Location = new System.Drawing.Point(101, 108);
            this.lblUnsereApplikation.Name = "lblUnsereApplikation";
            this.lblUnsereApplikation.Size = new System.Drawing.Size(96, 13);
            this.lblUnsereApplikation.TabIndex = 0;
            this.lblUnsereApplikation.Text = "Unsere Applikation";
            // 
            // btoAbmelden
            // 
            this.btoAbmelden.Location = new System.Drawing.Point(283, 103);
            this.btoAbmelden.Name = "btoAbmelden";
            this.btoAbmelden.Size = new System.Drawing.Size(75, 23);
            this.btoAbmelden.TabIndex = 1;
            this.btoAbmelden.Text = "Abmelden";
            this.btoAbmelden.UseVisualStyleBackColor = true;
            this.btoAbmelden.Click += new System.EventHandler(this.btoAbmelden_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btoAbmelden);
            this.Controls.Add(this.lblUnsereApplikation);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnsereApplikation;
        private System.Windows.Forms.Button btoAbmelden;
    }
}