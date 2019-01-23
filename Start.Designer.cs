namespace COD_Public_Cheater
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.WelcomeLinkLbl = new System.Windows.Forms.LinkLabel();
            this.FlashLinkLblTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(12, 418);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(562, 23);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "Welcome to Project COD Public Cheater by K Town Mods, available on GitHub:";
            this.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeLinkLbl
            // 
            this.WelcomeLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLinkLbl.Location = new System.Drawing.Point(580, 418);
            this.WelcomeLinkLbl.Name = "WelcomeLinkLbl";
            this.WelcomeLinkLbl.Size = new System.Drawing.Size(204, 23);
            this.WelcomeLinkLbl.TabIndex = 1;
            this.WelcomeLinkLbl.TabStop = true;
            this.WelcomeLinkLbl.Text = "Project COD Public Cheater";
            this.WelcomeLinkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WelcomeLinkLbl_LinkClicked);
            // 
            // FlashLinkLblTimer
            // 
            this.FlashLinkLblTimer.Interval = 250;
            this.FlashLinkLblTimer.Tick += new System.EventHandler(this.FlashLinkLblTimer_Tick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WelcomeLinkLbl);
            this.Controls.Add(this.WelcomeLbl);
            this.Name = "Start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.LinkLabel WelcomeLinkLbl;
        private System.Windows.Forms.Timer FlashLinkLblTimer;
    }
}

