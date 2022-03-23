using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if(Spieler1 == null)
            {
                Spieler1 = new Benutzer("nicht angemeldet", "0", "0", "0");
            }
            
            start();
        }

        private void DatenbankAuslesen()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            con.ConnectionString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = snakedb;";
            cmd.Connection = con;

            
            //Benutzer Datenbank auslesen:
            cmd.CommandText = "SELECT * from benutzer";

            con.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                
            }

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

        private void timerSnake_Tick(object sender, EventArgs e)
        {
            if (pbFruit.Location != sh.Kollission(pbFruit).Location)
            {
                pbFruit = sh.Kollission(pbFruit);
                tbAktuellerSpielstand.Text = Spieler1.spielt().ToString();
                tbRekord.Text = Spieler1.rekordAktualisieren().ToString();
                SnakeHead.schlangenListe.Add(new Schlange(NeuesSchlangenteil()));
            }
            
            

            if (!sh.bewegen(direction))
            {
                timerSnake.Stop();
                panelRestart.Show();
                pBschlangenkopf.Hide();
                pbFruit.Hide();
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
            panelRestart.Hide();
            pBschlangenkopf.Show();
            pbFruit.Show();
            start();
        }

        private void start()
        {
            foreach (Schlange body in SnakeHead.schlangenListe)
            {
                this.Controls.Remove(body.bild);
            }
            SnakeHead.schlangenListe.Clear();
            sh = new SnakeHead(pBschlangenkopf);
            direction = "";
            tbAktuellerSpielstand.Text = Spieler1.punkteZuruecksetzen().ToString();
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
                    pBschlangenkopf.Image = Image.FromFile("images/links_head_tranparent.png");
                }
                    
            }
            if (keyData == Keys.Up || keyData == Keys.W)
            {
                if (direction != "s")
                {
                    direction = "n";
                    pBschlangenkopf.Image = Image.FromFile("images/oben_head_tranparent.png");
                }
                    

            }
            if (keyData == Keys.Right || keyData == Keys.D)
            {
                if (direction != "w")
                {
                    direction = "o";
                    pBschlangenkopf.Image = Image.FromFile("images/rechts_head_tranparent.png");
                }
                    

            }
            if (keyData == Keys.Down || keyData == Keys.S)
            {
                if (direction != "n")
                {
                    direction = "s";
                    pBschlangenkopf.Image = Image.FromFile("images/unten_head_tranparent.png");
                }
                    
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public PictureBox NeuesSchlangenteil()
        {
            PictureBox Schlange = new PictureBox();
            Schlange.Parent = this;
            Schlange.Size = new Size(50, 50);

            Schlange.BackgroundImage = Image.FromFile("images/body.png");

            Schlange.BackgroundImageLayout = ImageLayout.Stretch;
            Schlange.Location = new Point(50, 50);
            this.Controls.Add(Schlange);
            return Schlange;
        }
    }
}
