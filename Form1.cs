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
            this.BackgroundImage = Image.FromFile("images/wiese.png");

        }

        private void DatenbankAuslesen()
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            con.ConnectionString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = mitarbeiterDB;";
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from mitarbeiter";

            con.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //listBox2.Items.Add(reader["Vorname"] + " " + reader[2]);
            }

            reader.Close();
            con.Close();
        }
    }
}
