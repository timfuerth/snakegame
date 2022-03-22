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

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 800); 
            this.MaximumSize = new Size(800, 800);

            this.StartPosition = FormStartPosition.CenterScreen;


            this.BackgroundImage = Image.FromFile("images/wiese.png");
            pBclose.BackgroundImage = Image.FromFile("images/error-icon2.png");
            pBschlangenkopf.BackColor = Color.Red;
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
    }
}
