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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRekord = new System.Windows.Forms.TextBox();
            this.pbRekord = new System.Windows.Forms.PictureBox();
            this.tbAktuellerSpielstand = new System.Windows.Forms.TextBox();
            this.pbAktuellerSpielstand = new System.Windows.Forms.PictureBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.pBminus = new System.Windows.Forms.PictureBox();
            this.pBclose = new System.Windows.Forms.PictureBox();
            this.timerSnake = new System.Windows.Forms.Timer(this.components);
            this.panelRestart = new System.Windows.Forms.Panel();
            this.pBrestart = new System.Windows.Forms.PictureBox();
            this.pbFruit = new System.Windows.Forms.PictureBox();
            this.pBschlangenkopf = new System.Windows.Forms.PictureBox();
            this.pbPU = new System.Windows.Forms.PictureBox();
            this.timerPU = new System.Windows.Forms.Timer(this.components);
            this.pBschlangenkopf2 = new System.Windows.Forms.PictureBox();
            this.btPlayer2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRekord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAktuellerSpielstand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBclose)).BeginInit();
            this.panelRestart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBrestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBschlangenkopf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBschlangenkopf2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btPlayer2);
            this.panel1.Controls.Add(this.tbRekord);
            this.panel1.Controls.Add(this.pbRekord);
            this.panel1.Controls.Add(this.tbAktuellerSpielstand);
            this.panel1.Controls.Add(this.pbAktuellerSpielstand);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.pBminus);
            this.panel1.Controls.Add(this.pBclose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // tbRekord
            // 
            this.tbRekord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbRekord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRekord.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRekord.Location = new System.Drawing.Point(200, 3);
            this.tbRekord.Multiline = true;
            this.tbRekord.Name = "tbRekord";
            this.tbRekord.ReadOnly = true;
            this.tbRekord.Size = new System.Drawing.Size(79, 44);
            this.tbRekord.TabIndex = 9;
            this.tbRekord.Text = "0";
            // 
            // pbRekord
            // 
            this.pbRekord.BackColor = System.Drawing.Color.Transparent;
            this.pbRekord.BackgroundImage = global::snakegame.Properties.Resources.pokal;
            this.pbRekord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRekord.Location = new System.Drawing.Point(144, 0);
            this.pbRekord.Name = "pbRekord";
            this.pbRekord.Size = new System.Drawing.Size(50, 50);
            this.pbRekord.TabIndex = 8;
            this.pbRekord.TabStop = false;
            // 
            // tbAktuellerSpielstand
            // 
            this.tbAktuellerSpielstand.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbAktuellerSpielstand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAktuellerSpielstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAktuellerSpielstand.Location = new System.Drawing.Point(59, 3);
            this.tbAktuellerSpielstand.Multiline = true;
            this.tbAktuellerSpielstand.Name = "tbAktuellerSpielstand";
            this.tbAktuellerSpielstand.ReadOnly = true;
            this.tbAktuellerSpielstand.Size = new System.Drawing.Size(79, 44);
            this.tbAktuellerSpielstand.TabIndex = 7;
            this.tbAktuellerSpielstand.Text = "0";
            // 
            // pbAktuellerSpielstand
            // 
            this.pbAktuellerSpielstand.BackColor = System.Drawing.Color.Transparent;
            this.pbAktuellerSpielstand.BackgroundImage = global::snakegame.Properties.Resources.melone;
            this.pbAktuellerSpielstand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAktuellerSpielstand.Location = new System.Drawing.Point(3, 0);
            this.pbAktuellerSpielstand.Name = "pbAktuellerSpielstand";
            this.pbAktuellerSpielstand.Size = new System.Drawing.Size(50, 50);
            this.pbAktuellerSpielstand.TabIndex = 6;
            this.pbAktuellerSpielstand.TabStop = false;
            // 
            // btLogin
            // 
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(470, 3);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(252, 44);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "LOGIN / REGISTRIEREN";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pBminus
            // 
            this.pBminus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBminus.Location = new System.Drawing.Point(738, 9);
            this.pBminus.Name = "pBminus";
            this.pBminus.Size = new System.Drawing.Size(25, 25);
            this.pBminus.TabIndex = 2;
            this.pBminus.TabStop = false;
            this.pBminus.Click += new System.EventHandler(this.pBminus_Click);
            // 
            // pBclose
            // 
            this.pBclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBclose.Location = new System.Drawing.Point(769, 9);
            this.pBclose.Name = "pBclose";
            this.pBclose.Size = new System.Drawing.Size(25, 25);
            this.pBclose.TabIndex = 0;
            this.pBclose.TabStop = false;
            this.pBclose.Click += new System.EventHandler(this.pBclose_Click);
            // 
            // timerSnake
            // 
            this.timerSnake.Interval = 150;
            this.timerSnake.Tick += new System.EventHandler(this.timerSnake_Tick);
            // 
            // panelRestart
            // 
            this.panelRestart.BackColor = System.Drawing.Color.Transparent;
            this.panelRestart.Controls.Add(this.pBrestart);
            this.panelRestart.Location = new System.Drawing.Point(0, 117);
            this.panelRestart.Name = "panelRestart";
            this.panelRestart.Size = new System.Drawing.Size(800, 686);
            this.panelRestart.TabIndex = 5;
            this.panelRestart.Visible = false;
            // 
            // pBrestart
            // 
            this.pBrestart.BackColor = System.Drawing.Color.Transparent;
            this.pBrestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBrestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBrestart.Location = new System.Drawing.Point(171, 77);
            this.pBrestart.Name = "pBrestart";
            this.pBrestart.Size = new System.Drawing.Size(444, 444);
            this.pBrestart.TabIndex = 3;
            this.pBrestart.TabStop = false;
            this.pBrestart.Click += new System.EventHandler(this.pBrestart_Click);
            // 
            // pbFruit
            // 
            this.pbFruit.BackColor = System.Drawing.Color.Transparent;
            this.pbFruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFruit.Location = new System.Drawing.Point(250, 300);
            this.pbFruit.Name = "pbFruit";
            this.pbFruit.Size = new System.Drawing.Size(50, 50);
            this.pbFruit.TabIndex = 5;
            this.pbFruit.TabStop = false;
            // 
            // pBschlangenkopf
            // 
            this.pBschlangenkopf.BackColor = System.Drawing.Color.Transparent;
            this.pBschlangenkopf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBschlangenkopf.ErrorImage = null;
            this.pBschlangenkopf.Image = global::snakegame.Properties.Resources.Snakehead1;
            this.pBschlangenkopf.Location = new System.Drawing.Point(400, 400);
            this.pBschlangenkopf.Margin = new System.Windows.Forms.Padding(2);
            this.pBschlangenkopf.Name = "pBschlangenkopf";
            this.pBschlangenkopf.Size = new System.Drawing.Size(50, 50);
            this.pBschlangenkopf.TabIndex = 0;
            this.pBschlangenkopf.TabStop = false;
            // 
            // pbPU
            // 
            this.pbPU.BackColor = System.Drawing.Color.Transparent;
            this.pbPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPU.Location = new System.Drawing.Point(300, 300);
            this.pbPU.Name = "pbPU";
            this.pbPU.Size = new System.Drawing.Size(50, 50);
            this.pbPU.TabIndex = 6;
            this.pbPU.TabStop = false;
            this.pbPU.Visible = false;
            // 
            // timerPU
            // 
            this.timerPU.Interval = 1000;
            this.timerPU.Tag = "5";
            this.timerPU.Tick += new System.EventHandler(this.timerPU_Tick);
            // 
            // pBschlangenkopf2
            // 
            this.pBschlangenkopf2.BackColor = System.Drawing.Color.Transparent;
            this.pBschlangenkopf2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBschlangenkopf2.ErrorImage = null;
            this.pBschlangenkopf2.Image = global::snakegame.Properties.Resources.Snakehead1;
            this.pBschlangenkopf2.Location = new System.Drawing.Point(300, 300);
            this.pBschlangenkopf2.Margin = new System.Windows.Forms.Padding(2);
            this.pBschlangenkopf2.Name = "pBschlangenkopf2";
            this.pBschlangenkopf2.Size = new System.Drawing.Size(50, 50);
            this.pBschlangenkopf2.TabIndex = 7;
            this.pBschlangenkopf2.TabStop = false;
            // 
            // btPlayer2
            // 
            this.btPlayer2.Location = new System.Drawing.Point(318, 9);
            this.btPlayer2.Name = "btPlayer2";
            this.btPlayer2.Size = new System.Drawing.Size(132, 38);
            this.btPlayer2.TabIndex = 10;
            this.btPlayer2.Text = "button1";
            this.btPlayer2.UseVisualStyleBackColor = true;
            this.btPlayer2.Click += new System.EventHandler(this.btPlayer2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.pBschlangenkopf2);
            this.Controls.Add(this.pbPU);
            this.Controls.Add(this.pbFruit);
            this.Controls.Add(this.panelRestart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBschlangenkopf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRekord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAktuellerSpielstand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBclose)).EndInit();
            this.panelRestart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBrestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBschlangenkopf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBschlangenkopf2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBschlangenkopf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBclose;
        private System.Windows.Forms.Timer timerSnake;
        private System.Windows.Forms.PictureBox pBminus;
        private System.Windows.Forms.PictureBox pBrestart;
        private System.Windows.Forms.Panel panelRestart;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.PictureBox pbFruit;
        private System.Windows.Forms.PictureBox pbAktuellerSpielstand;
        private System.Windows.Forms.TextBox tbRekord;
        private System.Windows.Forms.PictureBox pbRekord;
        private System.Windows.Forms.TextBox tbAktuellerSpielstand;
        private System.Windows.Forms.PictureBox pbPU;
        private System.Windows.Forms.Timer timerPU;
        private System.Windows.Forms.PictureBox pBschlangenkopf2;
        private System.Windows.Forms.Button btPlayer2;
    }
}

