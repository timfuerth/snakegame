﻿using MySql.Data.MySqlClient;
using System;
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
        RichTextBox tbActive = new RichTextBox();
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
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            con.ConnectionString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = snakedb;";
            cmd.Connection = con;


            //Benutzer Datenbank auslesen:
            cmd.CommandText = $"SELECT * from benutzer where Benutzername = '{tbLoginUser.Text}' and Passwort = '{tbPassword.Text}'";

            con.Open();
            reader = cmd.ExecuteReader();
            bool correct = false;
            while (reader.Read())
            {
                correct = true;
                MessageBox.Show(reader[1].ToString());
            }
            if (!correct)
                MessageBox.Show("Passwort oder Benutzername ist falsch!");
            reader.Close();
            con.Close();


            //Highscore Datenbank auslesen:
            cmd.CommandText = "SELECT * from highscore";

            con.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

            }

            reader.Close();
            con.Close();
        }
        private void GoBack()
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
            tbActive = (RichTextBox)sender;
            tbActive.BorderStyle = BorderStyle.None;
            tbActive.Tag = "active";

            this.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (tbActive.Tag != null)
            {
                if (tbActive.Tag.ToString() == "active")
                {
                    Pen p = new Pen(Color.Red);
                    Graphics g = e.Graphics;
                    int variance = 3;
                    g.DrawRectangle(p, new Rectangle(tbActive.Location.X - variance + 1, tbActive.Location.Y - variance + 1, tbActive.Width + variance, tbActive.Height + variance));
                }
            }
            
        }

        private void tbLoginUser_Leave(object sender, EventArgs e)
        {
            tbActive = (RichTextBox)sender;
            tbActive.BorderStyle = BorderStyle.Fixed3D;
            tbActive.Tag = "";
            this.Refresh();
        }
    }
}
