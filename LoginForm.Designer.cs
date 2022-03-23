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
            this.label1 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbLoginUser = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLoginText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pBminus = new System.Windows.Forms.PictureBox();
            this.pBclose = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBclose)).BeginInit();
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
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(294, 636);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(181, 38);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "LOGIN/REGISTER";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbLoginUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(125, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 189);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tbLoginUser
            // 
            this.tbLoginUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbLoginText.Location = new System.Drawing.Point(340, 236);
            this.lbLoginText.Name = "lbLoginText";
            this.lbLoginText.Size = new System.Drawing.Size(155, 25);
            this.lbLoginText.TabIndex = 6;
            this.lbLoginText.Text = "ANMELDUNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bei SnakeGame anmelden.";
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
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLoginText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBminus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBclose;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLoginText;
        private System.Windows.Forms.RichTextBox tbLoginUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.RichTextBox tbPassword;
        private System.Windows.Forms.Label label4;
    }
}