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
            this.pBschlangenkopf = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBminus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBclose = new System.Windows.Forms.PictureBox();
            this.timerSnake = new System.Windows.Forms.Timer(this.components);
            this.pBrestart = new System.Windows.Forms.PictureBox();
            this.lbRestart = new System.Windows.Forms.Label();
            this.panelRestart = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pBschlangenkopf)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBrestart)).BeginInit();
            this.panelRestart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBschlangenkopf
            // 
            this.pBschlangenkopf.Location = new System.Drawing.Point(0, 50);
            this.pBschlangenkopf.Margin = new System.Windows.Forms.Padding(2);
            this.pBschlangenkopf.Name = "pBschlangenkopf";
            this.pBschlangenkopf.Size = new System.Drawing.Size(50, 50);
            this.pBschlangenkopf.TabIndex = 0;
            this.pBschlangenkopf.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pBminus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pBclose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "snakegame";
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
            this.timerSnake.Interval = 200;
            this.timerSnake.Tick += new System.EventHandler(this.timerSnake_Tick);
            // 
            // pBrestart
            // 
            this.pBrestart.BackColor = System.Drawing.Color.Transparent;
            this.pBrestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBrestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBrestart.Location = new System.Drawing.Point(171, 77);
            this.pBrestart.Name = "pBrestart";
            this.pBrestart.Size = new System.Drawing.Size(444, 447);
            this.pBrestart.TabIndex = 3;
            this.pBrestart.TabStop = false;
            this.pBrestart.Click += new System.EventHandler(this.pBrestart_Click);
            // 
            // lbRestart
            // 
            this.lbRestart.AutoSize = true;
            this.lbRestart.BackColor = System.Drawing.Color.Transparent;
            this.lbRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRestart.Location = new System.Drawing.Point(357, 39);
            this.lbRestart.Name = "lbRestart";
            this.lbRestart.Size = new System.Drawing.Size(81, 25);
            this.lbRestart.TabIndex = 4;
            this.lbRestart.Text = "Restart";
            // 
            // panelRestart
            // 
            this.panelRestart.BackColor = System.Drawing.Color.Transparent;
            this.panelRestart.Controls.Add(this.lbRestart);
            this.panelRestart.Controls.Add(this.pBrestart);
            this.panelRestart.Location = new System.Drawing.Point(0, 85);
            this.panelRestart.Name = "panelRestart";
            this.panelRestart.Size = new System.Drawing.Size(800, 718);
            this.panelRestart.TabIndex = 5;
            this.panelRestart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.panelRestart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBschlangenkopf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pBschlangenkopf)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBrestart)).EndInit();
            this.panelRestart.ResumeLayout(false);
            this.panelRestart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBschlangenkopf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerSnake;
        private System.Windows.Forms.PictureBox pBminus;
        private System.Windows.Forms.PictureBox pBrestart;
        private System.Windows.Forms.Label lbRestart;
        private System.Windows.Forms.Panel panelRestart;
    }
}

