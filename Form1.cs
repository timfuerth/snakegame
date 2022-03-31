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
        
        //Player2:
        bool player2 = false;
        bool online  = false;
        string direction2;
        SnakeHead sh2;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1 Größe:
            this.MinimumSize = new Size(800, 800); 
            this.MaximumSize = new Size(800, 800);
            
            
            // Form - Position
            int x = Screen.PrimaryScreen.Bounds.Width - this.Width;
            int y = Screen.PrimaryScreen.Bounds.Height - this.Height;

            this.Location = new Point(x / 2, y / 2);

            //Design der Pictureboxen:
            this.BackgroundImage = Image.FromFile("images/wiese.png");
            pBclose.BackgroundImage = Image.FromFile("images/error-icon2.png");
            pBminus.BackgroundImage = Image.FromFile("images/minus.png");
            pBrestart.BackgroundImage = Image.FromFile("images/restart.png");
            pBschlangenkopf.BringToFront();
            pBschlangenkopf2.BringToFront();
            pBrestart.BringToFront();
            pbFruit.SendToBack();
            pbFruit.BackgroundImage = Image.FromFile("images/melone.png");
            pbPU.BackgroundImage = Image.FromFile("images/fast.png");
            pbPU.SendToBack();

            //Offline spielen (Rekord wird nicht gespeichert):
            if(angemeldet == false)
            {
                Spieler1 = new Benutzer("nicht angemeldet", "nicht angemeldet", "nicht angemeldet", "nicht angemeldet", -1, 0);
            }
            
            //Hier wird zu der Methode "start()" gesprungen:
            start();
        }


        private void HighscoreSpeichern() //Highscore wird in der Datenbank gespeichert
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

        private void FruitKollission(SnakeHead sh)
        {
            //Neue Picturebox wird erstellt und der Schlange hinzugefügt:
            sh.SchlangenTeilHinzufügen(NeuesSchlangenteil());

            tbAktuellerSpielstand.Text = Spieler1.spielt().ToString(); //aktuelle Puktezahl wird während dem Spiel aktualisiert
            tbRekord.Text = Spieler1.rekordAktualisieren().ToString(); //Rekord wird während dem Spiel aktualisiert, wenn die aktuelle Punktezahl größer wird.

            //Wenn das vorige PowerUp nicht mehr aktiv ist:
            if (timerPU.Enabled == false)
            {
                int ran = rand.Next(0, 2);
                if (ran == 0)
                {
                    sh.PowerUpErstellen(pbPU);
                    pbPU.Show();
                }
            }
        }
        private void PUKollission(SnakeHead sh)
        {
            //Schneller Modus:
            if (pbPU.Tag.ToString() == "fast")
                timerSnake.Interval = 90;
            //Langsamer Modus:
            else if (pbPU.Tag.ToString() == "slow")
                timerSnake.Interval = 250;
            timerPU.Start(); //Timer dauert 5 Sec.
            pbPU.Hide(); //PowerUp Picturebox verschwindet.
        }

        private void timerSnake_Tick(object sender, EventArgs e)
        {
            //Fruit check:
            if (pbFruit.Location != sh.FruitKollission(pbFruit).Location)//Wenn die Frucht die Location geändert hat, also von der Schlange gefressen worden ist.
            {
                FruitKollission(sh);
                
            }
            else if (player2)
                if (pbFruit.Location != sh2.FruitKollission(pbFruit).Location)
                {
                    FruitKollission(sh2);
                }
            //PowerUp check
            if (pbPU.Visible == true)
            {
                if (pbPU.Location != sh.PowerUpKollission(pbPU).Location)//Änderung der Location
                {
                    PUKollission(sh);
                }
                else if (player2)
                    if (pbPU.Location != sh2.PowerUpKollission(pbPU).Location)
                    {
                        PUKollission(sh2);
                    }
            }


            bool p2Angestossen  = false;
            if (player2)
                if (!sh2.bewegen(direction2))
                    p2Angestossen = true;
            //Schlange ist angestoßen:
            if (!sh.bewegen(direction) || p2Angestossen)
            {
                timerSnake.Stop();
                panelRestart.Show();
                pBschlangenkopf.Hide();
                if (player2)
                    pBschlangenkopf2.Hide();
                pbFruit.Hide();
                pbPU.Hide();

                //Highscore speichern, wenn Benutzer angemeldet ist, sonst nicht:
                int neuerHighscore = Convert.ToInt32(tbAktuellerSpielstand.Text);
                if (neuerHighscore > aktuellerHighscore && angemeldet == true)
                {
                    HighscoreSpeichern();
                }
            }
                
            
        }
        private void pBclose_Click(object sender, EventArgs e)
        {
            //Projekt ist schließbar über eigenen Button:
            this.Close();
        }
        private void pBminus_Click(object sender, EventArgs e)
        {
            //Projekt ist über eigenen Button minimierbar:
            this.WindowState = FormWindowState.Minimized;
        }

        private void pBrestart_Click(object sender, EventArgs e) //Wenn man stirbt und den Restart Button klickt.
        {
            //Die Bilder vom vorherigen Schlangenkörper werden entfernt:
            
            
            
            //Startbildschirm erscheint wieder:
            panelRestart.Hide();
            pBschlangenkopf.Show();
            if (player2)
                pBschlangenkopf2.Show();
            pbFruit.Show();
            pbPU.Show();

            //Hüpft zur Methode "start"
            start();
        }

        private void start()
        {
            foreach (SnakeHead sh in SnakeHead.snakeHeads)
            {
                foreach (Schlange body in sh.schlangenListe)
                {
                    this.Controls.Remove(body.bild);
                }
            }
            pBschlangenkopf.Location = new Point(0, 300);
            if(player2)
                pBschlangenkopf2.Location = new Point(750, 300);
            SnakeHead.snakeHeads.Clear();
            //Schlangenkopf wird erstellt:
            sh = new SnakeHead(pBschlangenkopf);
            if (player2)
            {
                sh2 = new SnakeHead(pBschlangenkopf2);
                pBschlangenkopf2.Show();
            }
                
            
            //Richtung wird auf null gesetzt, dass die Schlange stehen bleibt:
            direction = "";
            direction2 = "";

            //Wird für die Abfrage, ob der Highscore gespeichert wird oder nicht, benötigt:
            aktuellerHighscore = Convert.ToInt32(tbRekord.Text);

            //Punkte werden auf 0 zurückgesetzt:
            tbAktuellerSpielstand.Text = Spieler1.punkteZuruecksetzen().ToString();
            //Rekord wird nach dem Login oder der Registrierung gleich aktualisiert:
            tbRekord.Text = Spieler1.rekordAktualisieren().ToString();

            //Timer startet:
            timerSnake.Start();
            pbPU.Hide();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //Hier wird zur anderen Form gehüpft, wo man sich anmelden bzw. registrieren kann.
            Hide();
            LoginForm loginform = new LoginForm();
            loginform.Closed += (s, args) => Close();
            loginform.Show();
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //WASD oder Pfeil nach oben, unten, rechts und links sorgen dafür, dass sich der  Schlangenkopf in eine andere Richtung bewegt und auch das Bild aktualisiert wird. Mit 5 Millisekunden 
        {
            #region Player1
            if (keyData == Keys.A)
            {
                if (direction != "o")
                {
                    direction = "w";
                    pBschlangenkopf.Image = Image.FromFile("images/Snakehead_links.png");
                    Thread.Sleep(5);
                }
                
            }
            else if (keyData == Keys.W)
            {
                if (direction != "s")
                {
                    direction = "n";
                    pBschlangenkopf.Image = Image.FromFile("images/Snakehead.png");
                    Thread.Sleep(5);
                }
                

            }
            else if (keyData == Keys.D)
            {
                if (direction != "w")
                {
                    direction = "o";
                    pBschlangenkopf.Image = Image.FromFile("images/Snakehead_rechts.png");
                    Thread.Sleep(5);
                }
                

            }
            else if (keyData == Keys.S)
            {
                if (direction != "n")
                {
                    direction = "s";
                    pBschlangenkopf.Image = Image.FromFile("images/Snakehead_unten.png");
                    Thread.Sleep(5);

                }
                
            }
            #endregion
            #region Player2
            if (!online)
            {
                if (player2)
                {
                    if (keyData == Keys.Left)
                    {
                        if (direction2 != "o")
                        {
                            direction2 = "w";
                            pBschlangenkopf2.Image = Image.FromFile("images/Snakehead_links.png");
                            Thread.Sleep(5);
                        }

                    }
                    else if (keyData == Keys.Up)
                    {
                        if (direction2 != "s")
                        {
                            direction2 = "n";
                            pBschlangenkopf2.Image = Image.FromFile("images/Snakehead.png");
                            Thread.Sleep(5);
                        }


                    }
                    else if (keyData == Keys.Right)
                    {
                        if (direction2 != "w")
                        {
                            direction2 = "o";
                            pBschlangenkopf2.Image = Image.FromFile("images/Snakehead_rechts.png");
                            Thread.Sleep(5);
                        }


                    }
                    else if (keyData == Keys.Down)
                    {
                        if (direction2 != "n")
                        {
                            direction2 = "s";
                            pBschlangenkopf2.Image = Image.FromFile("images/Snakehead_unten.png");
                            Thread.Sleep(5);

                        }

                    }
                }
               
            }
            #endregion





            return base.ProcessCmdKey(ref msg, keyData);
        }

        public PictureBox NeuesSchlangenteil()
        {
            //Picturebox für neuen Schlangenkörper wird erstellt:
            PictureBox Schlange = new PictureBox();
            Schlange.Parent = this;
            Schlange.Size = new Size(50, 50);

            Schlange.BackColor = Color.Blue;
            Schlange.BorderStyle = BorderStyle.FixedSingle;
            Schlange.BackgroundImageLayout = ImageLayout.Stretch;
            Schlange.Location = new Point(50, 50);
            this.Controls.Add(Schlange);
            return Schlange;
        }

        #region Form kann mithilfe vom Panel bewegt werden
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
                timerSnake.Interval = 250;
                timerPU.Tag = "5";
                timerPU.Stop();
            }
        }

        #endregion

        private void btPlayer2_Click(object sender, EventArgs e)
        {
            if (!player2)
            {
                direction = "";
                online = false;
                player2 = true;
                start();
            }
            else
            {
                player2 = false;
                start();
            }
                
        }
    }
}
