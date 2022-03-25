﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data.MySqlClient;

namespace snakegame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string direction;
        SnakeHead sh;
        public static Benutzer Spieler1;
        public static bool angemeldet;
        int aktuellerHighscore;
        Random rand = new Random();

         

        private void EM_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void EM_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Form1 Größe:
            this.MinimumSize = new Size(800, 800); 
            this.MaximumSize = new Size(800, 800);
            
            
            // Form - Position
            int x = Screen.PrimaryScreen.Bounds.Width - this.Width;
            int y = Screen.PrimaryScreen.Bounds.Height - this.Height;

            this.Location = new Point(x / 2, y / 2);

            this.BackgroundImage = Image.FromFile("images/wiese.png");
            pBclose.BackgroundImage = Image.FromFile("images/error-icon2.png");
            pBminus.BackgroundImage = Image.FromFile("images/minus.png");
            pBrestart.BackgroundImage = Image.FromFile("images/restart.png");
            pBschlangenkopf.BringToFront();
            pBrestart.BringToFront();
            pbFruit.SendToBack();
            pbFruit.BackgroundImage = Image.FromFile("images/melone.png");
            pbPU.BackgroundImage = Image.FromFile("images/fast.png");
            pbPU.SendToBack();

            if(angemeldet == false)
            {
                Spieler1 = new Benutzer("nicht angemeldet", "nicht angemeldet", "nicht angemeldet", "nicht angemeldet", -1, 0);
            }
            
            start();
        }


        private void HighscoreSpeichern()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            con.ConnectionString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = snakedb;";
            cmd.Connection = con;

            cmd.CommandText = $"INSERT INTO highscore (Laenge, Datum, BenutzerID) VALUES ({Spieler1.Rekord},'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',{Spieler1.BenutzerID})";

            

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();

        }
        private void timerSnake_Tick(object sender, EventArgs e)
        {
            //Fruit check
            if (pbFruit.Location != sh.FruitKollission(pbFruit).Location)
            {
                tbAktuellerSpielstand.Text = Spieler1.spielt().ToString();
                tbRekord.Text = Spieler1.rekordAktualisieren().ToString();
                //Neue Picturebox wird erstellt und der Schlange hinzugefügt
                sh.SchlangenTeilHinzufügen(NeuesSchlangenteil());

                //Wenn das vorige PowerUp nicht mehr aktiv ist:
                if(timerPU.Enabled == false)
                {
                    int ran = rand.Next(0, 2);
                    if (ran == 0)
                    {
                        sh.PowerUpErstellen(pbPU);
                        pbPU.Show();
                    }
                }
                
            }
            //PowerUp check
            if (pbPU.Visible == true)
            {
                if (pbPU.Location != sh.PowerUpKollission(pbPU).Location)
                {
                    if (pbPU.Tag.ToString() == "fast")
                        timerSnake.Interval = 70;
                    else if (pbPU.Tag.ToString() == "slow")
                        timerSnake.Interval = 250;
                    timerPU.Start();
                    pbPU.Hide();
                }
            }
            


            //Schlange ist angestoßen:
            if (!sh.bewegen(direction))
            {
                timerSnake.Stop();
                panelRestart.Show();
                pBschlangenkopf.Hide();
                pbFruit.Hide();
                pbPU.Hide();
                //Highscore speichern, wenn Benutzer angemeldet ist:
                int neuerHighscore = Convert.ToInt32(tbAktuellerSpielstand.Text);
                if (neuerHighscore > aktuellerHighscore && angemeldet == true)
                {
                    HighscoreSpeichern();
                }
            }
                
            
        }
        private void pBclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pBminus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pBrestart_Click(object sender, EventArgs e)
        {
            foreach (Schlange body in sh.schlangenListe)
            {
                this.Controls.Remove(body.bild);
            }
            panelRestart.Hide();
            pBschlangenkopf.Show();
            pbFruit.Show();
            pbPU.Show();
            start();
        }

        private void start()
        {
            sh = new SnakeHead(pBschlangenkopf);

            //sh.schlangenListe.Clear();
            
            direction = "";

            aktuellerHighscore = Convert.ToInt32(tbRekord.Text);
            tbAktuellerSpielstand.Text = Spieler1.punkteZuruecksetzen().ToString();
            tbRekord.Text = Spieler1.rekordAktualisieren().ToString();
            timerSnake.Start();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginform = new LoginForm();
            loginform.Closed += (s, args) => Close();
            loginform.Show();
            
        }

       

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Left || keyData == Keys.A)
            {
                if (direction != "o")
                {
                    direction = "w";
                    pBschlangenkopf.Image = Image.FromFile("images/Snakehead_links.png");
                    Thread.Sleep(5);
                }
                
            }
            if (keyData == Keys.Up || keyData == Keys.W)
            {
                if (direction != "s")
                {
                    direction = "n";
                    pBschlangenkopf.Image = Image.FromFile("images/Snakehead.png");
                    Thread.Sleep(5);
                }
                

            }
            if (keyData == Keys.Right || keyData == Keys.D)
            {
                if (direction != "w")
                {
                    direction = "o";
                    pBschlangenkopf.Image = Image.FromFile("images/Snakehead_rechts.png");
                    Thread.Sleep(5);
                }
                

            }
            if (keyData == Keys.Down || keyData == Keys.S)
            {
                if (direction != "n")
                {
                    direction = "s";
                    pBschlangenkopf.Image = Image.FromFile("images/Snakehead_unten.png");
                    Thread.Sleep(5);

                }
                
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public PictureBox NeuesSchlangenteil()
        {
            PictureBox Schlange = new PictureBox();
            Schlange.Parent = this;
            Schlange.Size = new Size(50, 50);

            //Schlange.BackgroundImage = Image.FromFile("images/body.png");
            Schlange.BackColor = Color.Blue;
            Schlange.BorderStyle = BorderStyle.FixedSingle;
            Schlange.BackgroundImageLayout = ImageLayout.Stretch;
            Schlange.Location = new Point(50, 50);
            this.Controls.Add(Schlange);
            return Schlange;
        }

        //Form1 bewegen:
        private Point mouse_offset;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void timerPU_Tick(object sender, EventArgs e)
        {
            int timeLeft = Convert.ToInt32(timerPU.Tag);
            if (timeLeft > 1)
            {
                timeLeft--;
                timerPU.Tag = timeLeft.ToString();
            }
            else
            {
                timerSnake.Interval = 150;
                timerPU.Tag = "5";
                timerPU.Stop();
            }
        }
    }
}
