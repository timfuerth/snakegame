namespace snakegame
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
            this.components = new System.ComponentModel.Container();
            this.pbSchlangenkopf = new System.Windows.Forms.PictureBox();
            this.tmTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSchlangenkopf)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSchlangenkopf
            // 
            this.pbSchlangenkopf.Location = new System.Drawing.Point(0, 0);
            this.pbSchlangenkopf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSchlangenkopf.Name = "pbSchlangenkopf";
            this.pbSchlangenkopf.Size = new System.Drawing.Size(49, 49);
            this.pbSchlangenkopf.TabIndex = 0;
            this.pbSchlangenkopf.TabStop = false;
            // 
            // tmTimer
            // 
            this.tmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 693);
            this.Controls.Add(this.pbSchlangenkopf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSchlangenkopf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSchlangenkopf;
        private System.Windows.Forms.Timer tmTimer;
    }
}

