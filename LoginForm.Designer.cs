namespace snakegame
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBminus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBclose = new System.Windows.Forms.PictureBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLoginUser = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLoginText = new System.Windows.Forms.Label();
            this.lbLoginText2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbRegister = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBclose)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelRegister.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(284, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "snakegame - Login/Register";
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
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(3, 10);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(167, 38);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.tbPassword);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.tbLoginUser);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Location = new System.Drawing.Point(125, 264);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(550, 158);
            this.panelLogin.TabIndex = 6;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(15, 105);
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(525, 35);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Tag = "Password";
            this.tbPassword.Text = "";
            this.tbPassword.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Passwort";
            // 
            // tbLoginUser
            // 
            this.tbLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginUser.Location = new System.Drawing.Point(15, 41);
            this.tbLoginUser.Multiline = false;
            this.tbLoginUser.Name = "tbLoginUser";
            this.tbLoginUser.Size = new System.Drawing.Size(525, 35);
            this.tbLoginUser.TabIndex = 1;
            this.tbLoginUser.Tag = "Login";
            this.tbLoginUser.Text = "";
            this.tbLoginUser.Enter += new System.EventHandler(this.textBox1_Enter);
            this.tbLoginUser.Leave += new System.EventHandler(this.tbLoginUser_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // lbLoginText
            // 
            this.lbLoginText.AutoSize = true;
            this.lbLoginText.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginText.Location = new System.Drawing.Point(340, 216);
            this.lbLoginText.Name = "lbLoginText";
            this.lbLoginText.Size = new System.Drawing.Size(155, 25);
            this.lbLoginText.TabIndex = 6;
            this.lbLoginText.Text = "ANMELDUNG";
            // 
            // lbLoginText2
            // 
            this.lbLoginText2.AutoSize = true;
            this.lbLoginText2.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginText2.Location = new System.Drawing.Point(318, 241);
            this.lbLoginText2.Name = "lbLoginText2";
            this.lbLoginText2.Size = new System.Drawing.Size(204, 20);
            this.lbLoginText2.TabIndex = 7;
            this.lbLoginText2.Text = "Bei SnakeGame anmelden.";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(345, 56);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 157);
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.BackColor = System.Drawing.Color.Transparent;
            this.lbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.Location = new System.Drawing.Point(20, 49);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(138, 16);
            this.lbRegister.TabIndex = 4;
            this.lbRegister.Text = "Neues Konto erstellen";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.Transparent;
            this.panelRegister.Controls.Add(this.richTextBox5);
            this.panelRegister.Controls.Add(this.label8);
            this.panelRegister.Controls.Add(this.richTextBox4);
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Controls.Add(this.richTextBox3);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.richTextBox1);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.richTextBox2);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Location = new System.Drawing.Point(122, 265);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(550, 299);
            this.panelRegister.TabIndex = 10;
            this.panelRegister.Visible = false;
            this.panelRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRegister_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 196);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(525, 35);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Tag = "Password";
            this.richTextBox1.Text = "";
            this.richTextBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.richTextBox1.Leave += new System.EventHandler(this.tbLoginUser_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Passwort";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(15, 22);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(525, 35);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Tag = "Login";
            this.richTextBox2.Text = "";
            this.richTextBox2.Enter += new System.EventHandler(this.textBox1_Enter);
            this.richTextBox2.Leave += new System.EventHandler(this.tbLoginUser_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Username";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(15, 255);
            this.richTextBox3.Multiline = false;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(525, 35);
            this.richTextBox3.TabIndex = 10;
            this.richTextBox3.Tag = "Password";
            this.richTextBox3.Text = "";
            this.richTextBox3.Enter += new System.EventHandler(this.textBox1_Enter);
            this.richTextBox3.Leave += new System.EventHandler(this.tbLoginUser_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Passwort wiederholen";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btLogin);
            this.panelButtons.Controls.Add(this.lbRegister);
            this.panelButtons.Location = new System.Drawing.Point(332, 425);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(173, 73);
            this.panelButtons.TabIndex = 11;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(15, 138);
            this.richTextBox4.Multiline = false;
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(525, 35);
            this.richTextBox4.TabIndex = 12;
            this.richTextBox4.Tag = "Login";
            this.richTextBox4.Text = "";
            this.richTextBox4.Enter += new System.EventHandler(this.textBox1_Enter);
            this.richTextBox4.Leave += new System.EventHandler(this.tbLoginUser_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nachname";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.Location = new System.Drawing.Point(15, 77);
            this.richTextBox5.Multiline = false;
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(525, 35);
            this.richTextBox5.TabIndex = 14;
            this.richTextBox5.Tag = "Login";
            this.richTextBox5.Text = "";
            this.richTextBox5.Enter += new System.EventHandler(this.textBox1_Enter);
            this.richTextBox5.Leave += new System.EventHandler(this.tbLoginUser_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vorname";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lbLoginText2);
            this.Controls.Add(this.lbLoginText);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Enter += new System.EventHandler(this.textBox1_Enter);
            this.Leave += new System.EventHandler(this.tbLoginUser_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBclose)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBminus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBclose;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLoginText;
        private System.Windows.Forms.RichTextBox tbLoginUser;
        private System.Windows.Forms.Label lbLoginText2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.RichTextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label7;
    }
}