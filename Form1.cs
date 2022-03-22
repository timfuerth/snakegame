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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 800); 
            this.MaximumSize = new Size(800, 800);

            // Start - Position
            int breite = Screen.PrimaryScreen.Bounds.Width;
            int höhe = Screen.PrimaryScreen.Bounds.Height;

            int x = breite - this.Width;
            int y = höhe - this.Height;

            this.Location = new Point(x / 2, y / 2);


            this.BackgroundImage = Image.FromFile("images/wiese.png");
            pBclose.BackgroundImage = Image.FromFile("images/error-icon2.png");
            pBminus.BackgroundImage = Image.FromFile("images/minus.png");
            pBschlangenkopf.BackColor = Color.Red;

            sh = new SnakeHead(pBschlangenkopf, 0, 50);
            timerSnake.Start();
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

        private void pBclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSnake_Tick(object sender, EventArgs e)
        {
            sh.bewegen(direction);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                direction = "w";
            }
            if (e.KeyValue == 38)
            {
                direction = "n";
            }
            if (e.KeyValue == 39)
            {
                direction = "o";
            }
            if (e.KeyValue == 40)
            {
                direction = "s";
            }
        }

        private void pBminus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
