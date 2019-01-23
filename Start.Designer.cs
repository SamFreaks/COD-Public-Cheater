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
            this.DisableFlash = new System.Windows.Forms.CheckBox();
            this.Bo3PBox = new System.Windows.Forms.PictureBox();
            this.Bo2PBox = new System.Windows.Forms.PictureBox();
            this.Bo1PBox = new System.Windows.Forms.PictureBox();
            this.Mw3PBox = new System.Windows.Forms.PictureBox();
            this.Mw2PBox = new System.Windows.Forms.PictureBox();
            this.Mw1PBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bo3PBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bo2PBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bo1PBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mw3PBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mw2PBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mw1PBox)).BeginInit();
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
            // DisableFlash
            // 
            this.DisableFlash.AutoSize = true;
            this.DisableFlash.Location = new System.Drawing.Point(679, 398);
            this.DisableFlash.Name = "DisableFlash";
            this.DisableFlash.Size = new System.Drawing.Size(109, 17);
            this.DisableFlash.TabIndex = 2;
            this.DisableFlash.Text = "Disable Flashing?";
            this.DisableFlash.UseVisualStyleBackColor = true;
            this.DisableFlash.CheckedChanged += new System.EventHandler(this.DisableFlash_CheckedChanged);
            // 
            // Bo3PBox
            // 
            this.Bo3PBox.Image = global::COD_Public_Cheater.Properties.Resources.call_of_duty_black_ops_iii_by_em80em_d8tdts9;
            this.Bo3PBox.Location = new System.Drawing.Point(270, 141);
            this.Bo3PBox.Name = "Bo3PBox";
            this.Bo3PBox.Size = new System.Drawing.Size(123, 123);
            this.Bo3PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bo3PBox.TabIndex = 8;
            this.Bo3PBox.TabStop = false;
            this.Bo3PBox.Click += new System.EventHandler(this.Bo3PBox_Click);
            // 
            // Bo2PBox
            // 
            this.Bo2PBox.Image = global::COD_Public_Cheater.Properties.Resources.call_of_duty_black_ops_2_icons___ico__by_backjumpone_d5pp83f;
            this.Bo2PBox.Location = new System.Drawing.Point(141, 141);
            this.Bo2PBox.Name = "Bo2PBox";
            this.Bo2PBox.Size = new System.Drawing.Size(123, 123);
            this.Bo2PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bo2PBox.TabIndex = 7;
            this.Bo2PBox.TabStop = false;
            this.Bo2PBox.Click += new System.EventHandler(this.Bo2PBox_Click);
            // 
            // Bo1PBox
            // 
            this.Bo1PBox.Image = global::COD_Public_Cheater.Properties.Resources.Call_Of_Duty_Black_Ops_256;
            this.Bo1PBox.Location = new System.Drawing.Point(12, 141);
            this.Bo1PBox.Name = "Bo1PBox";
            this.Bo1PBox.Size = new System.Drawing.Size(123, 123);
            this.Bo1PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bo1PBox.TabIndex = 6;
            this.Bo1PBox.TabStop = false;
            this.Bo1PBox.Click += new System.EventHandler(this.Bo1PBox_Click);
            // 
            // Mw3PBox
            // 
            this.Mw3PBox.Image = global::COD_Public_Cheater.Properties.Resources.CoD_Modern_Warfare_3_1_icon;
            this.Mw3PBox.Location = new System.Drawing.Point(270, 12);
            this.Mw3PBox.Name = "Mw3PBox";
            this.Mw3PBox.Size = new System.Drawing.Size(123, 123);
            this.Mw3PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mw3PBox.TabIndex = 5;
            this.Mw3PBox.TabStop = false;
            this.Mw3PBox.Click += new System.EventHandler(this.Mw3PBox_Click);
            // 
            // Mw2PBox
            // 
            this.Mw2PBox.Image = global::COD_Public_Cheater.Properties.Resources.Call_of_Duty_Modern_Warfare_2_2_icon;
            this.Mw2PBox.Location = new System.Drawing.Point(141, 12);
            this.Mw2PBox.Name = "Mw2PBox";
            this.Mw2PBox.Size = new System.Drawing.Size(123, 123);
            this.Mw2PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mw2PBox.TabIndex = 4;
            this.Mw2PBox.TabStop = false;
            this.Mw2PBox.Click += new System.EventHandler(this.Mw2PBox_Click);
            // 
            // Mw1PBox
            // 
            this.Mw1PBox.Image = global::COD_Public_Cheater.Properties.Resources.COD_MW_new_3_icon;
            this.Mw1PBox.Location = new System.Drawing.Point(12, 12);
            this.Mw1PBox.Name = "Mw1PBox";
            this.Mw1PBox.Size = new System.Drawing.Size(123, 123);
            this.Mw1PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mw1PBox.TabIndex = 3;
            this.Mw1PBox.TabStop = false;
            this.Mw1PBox.Click += new System.EventHandler(this.Mw1_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bo3PBox);
            this.Controls.Add(this.Bo2PBox);
            this.Controls.Add(this.Bo1PBox);
            this.Controls.Add(this.Mw3PBox);
            this.Controls.Add(this.Mw2PBox);
            this.Controls.Add(this.Mw1PBox);
            this.Controls.Add(this.DisableFlash);
            this.Controls.Add(this.WelcomeLinkLbl);
            this.Controls.Add(this.WelcomeLbl);
            this.Name = "Start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bo3PBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bo2PBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bo1PBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mw3PBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mw2PBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mw1PBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.LinkLabel WelcomeLinkLbl;
        private System.Windows.Forms.Timer FlashLinkLblTimer;
        private System.Windows.Forms.CheckBox DisableFlash;
        private System.Windows.Forms.PictureBox Mw1PBox;
        private System.Windows.Forms.PictureBox Mw2PBox;
        private System.Windows.Forms.PictureBox Mw3PBox;
        private System.Windows.Forms.PictureBox Bo1PBox;
        private System.Windows.Forms.PictureBox Bo2PBox;
        private System.Windows.Forms.PictureBox Bo3PBox;
    }
}

