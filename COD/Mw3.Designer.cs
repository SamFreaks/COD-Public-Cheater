namespace COD_Public_Cheater.COD
{
    partial class Mw3
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
            this.StartPBox = new System.Windows.Forms.PictureBox();
            this.DisableOnTop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartPBox
            // 
            this.StartPBox.Image = global::COD_Public_Cheater.Properties.Resources.icons8_zuhause_26;
            this.StartPBox.Location = new System.Drawing.Point(12, 12);
            this.StartPBox.Name = "StartPBox";
            this.StartPBox.Size = new System.Drawing.Size(26, 26);
            this.StartPBox.TabIndex = 1;
            this.StartPBox.TabStop = false;
            this.StartPBox.Click += new System.EventHandler(this.StartPBox_Click);
            // 
            // DisableOnTop
            // 
            this.DisableOnTop.Location = new System.Drawing.Point(679, 421);
            this.DisableOnTop.Name = "DisableOnTop";
            this.DisableOnTop.Size = new System.Drawing.Size(109, 17);
            this.DisableOnTop.TabIndex = 11;
            this.DisableOnTop.Text = "Disable on Top";
            this.DisableOnTop.UseVisualStyleBackColor = true;
            this.DisableOnTop.CheckedChanged += new System.EventHandler(this.DisableOnTop_CheckedChanged);
            // 
            // Mw3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisableOnTop);
            this.Controls.Add(this.StartPBox);
            this.Name = "Mw3";
            this.Text = "Mw3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mw3_FormClosing);
            this.Load += new System.EventHandler(this.Mw3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StartPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartPBox;
        private System.Windows.Forms.CheckBox DisableOnTop;
    }
}