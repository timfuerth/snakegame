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
        string direction = "s";
        Schlangenkopf sk;


        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 800); 
            this.MaximumSize = new Size(800, 800);

            this.BackgroundImage = Image.FromFile("images/wiese.png");
            pbSchlangenkopf.BackColor = Color.Red;
            sk = new Schlangenkopf(pbSchlangenkopf, 0, 50);
            tmTimer.Start();
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

        private void tmTimer_Tick(object sender, EventArgs e)
        {
            sk.bewegen(direction);
        }
    }
}
