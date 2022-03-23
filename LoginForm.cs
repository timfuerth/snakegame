﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakegame
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        bool FocusedLoginUser = false;
        bool FocusedLoginPassword = false;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 800);
            this.MaximumSize = new Size(800, 800);

            // Start - Position
            int x = Screen.PrimaryScreen.Bounds.Width - this.Width;
            int y = Screen.PrimaryScreen.Bounds.Height - this.Height;

            this.Location = new Point(x / 2, y / 2);


            this.BackgroundImage = Image.FromFile("images/wiese.png");
            pBclose.BackgroundImage = Image.FromFile("images/error-icon2.png");
            pBminus.BackgroundImage = Image.FromFile("images/minus.png");
            pbLogo.BackgroundImage = Image.FromFile("images/snake.png");
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 mainform = new Form1();
            mainform.Closed += (s, args) => Close();
            mainform.Show();
        }

        private void pBminus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pBclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (((RichTextBox)sender).Tag == "Login")
                FocusedLoginUser = true;
            else if (((RichTextBox)sender).Tag == "Password")
                FocusedLoginPassword = true;
    
            this.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (FocusedLoginUser)
            {
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(tbLoginUser.Location.X - variance+1, tbLoginUser.Location.Y - variance+1, tbLoginUser.Width + variance, tbLoginUser.Height + variance));
            }
            else if (FocusedLoginPassword)
            {
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(tbPassword.Location.X - variance + 1, tbPassword.Location.Y - variance + 1, tbPassword.Width + variance, tbPassword.Height + variance));
            }
        }

        private void tbLoginUser_Leave(object sender, EventArgs e)
        {
            if (((RichTextBox)sender).Tag == "Login")
                FocusedLoginUser = false;
            else if (((RichTextBox)sender).Tag == "Password")
                FocusedLoginPassword = false;
            this.Refresh();
        }
    }
}
