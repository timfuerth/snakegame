using MySql.Data.MySqlClient;
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
        string activeScreen = "Anmeldung";
        int BID;
        //LoginForm bewegen:
        private Point mouse_offset;

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
            if (panelLogin.Visible)
            {
                if (tbLoginUser.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Bitte alle Felder ausfüllen!", "SnakeGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoginAuslesen();
            }
            if (panelRegister.Visible)
            {
                if (tbRegisterUser.Text == "" || tbRegisterPasswort.Text == "" || tbRegisterPasswort2.Text == "" || tbVorname.Text == "" || tbNachname.Text == "")
                {
                    MessageBox.Show("Bitte alle Felder ausfüllen!", "SnakeGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Registrieren(tbRegisterUser.Text);
            }
        }
        
        

        private void Registrieren(string user)
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            con.ConnectionString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = snakedb;";
            cmd.Connection = con;


            //Benutzer Datenbank auslesen:
            cmd.CommandText = $"SELECT Benutzername from benutzer where benutzername = '{tbRegisterUser.Text}'";

            con.Open();
            reader = cmd.ExecuteReader();
            bool correct = false; 
            while (reader.Read())
            {
                correct = true;
                
            }
            if (correct)
            {
                MessageBox.Show("Dieser Benutzername ist bereits vergeben!", "SnakeGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            
            reader.Close();
            con.Close();
            cmd.CommandText = $"INSERT INTO `benutzer`(`Vorname`, `Nachname`, `Benutzername`, `Passwort`) VALUES ('{tbVorname.Text}','{tbNachname.Text}','{tbRegisterUser.Text}','{tbRegisterPasswort.Text}')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Erfolgreich registriert!");

            cmd.CommandText = $"SELECT BID from benutzer where Benutzername = '{tbRegisterUser.Text}'";

            con.Open();
            reader = cmd.ExecuteReader();
           
            while (reader.Read())
            {
               

                
               
                BID = Convert.ToInt32(reader[0]);
                GoBack();
                
                
            }

            reader.Close();
            con.Close();

            cmd.Connection = con;
            cmd.CommandText = $"INSERT INTO highscore (Laenge, Datum, BenutzerID) VALUES (0,'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',{BID})";

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();

            BenutzerErstellen(Convert.ToInt32(BID));

        }

        private void LoginAuslesen()
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
                MessageBox.Show("Erfolgreich angemeldet");
                
                BenutzerErstellen(Convert.ToInt32(reader[0]));
                

                GoBack();
            }
            if (!correct)
                MessageBox.Show("Passwort oder Benutzername ist falsch!");
            reader.Close();
            con.Close();

        }

        private void BenutzerErstellen(int BID)
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;

            con.ConnectionString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = snakedb;";
            cmd.Connection = con;

            cmd.CommandText = "SELECT benutzer.Benutzername, benutzer.Vorname, benutzer.Nachname, benutzer.Passwort, benutzer.BID, highscore.Laenge FROM benutzer INNER JOIN highscore ON benutzer.BID = highscore.BenutzerID Where benutzer.BID = " + BID + ";";

            con.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Form1.Spieler1 = null;
                Form1.Spieler1 = new Benutzer(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5]));

                Form1.angemeldet = true;
            }

            reader.Close();
            con.Close();


            

            /*SELECT benutzer.Benutzername, benutzer.Vorname, benutzer.Nachname, benutzer.Passwort, benutzer.BID, highscore.Laenge
            FROM benutzer
            INNER JOIN highscore
            ON benutzer.BID = highscore.BenutzerID*/
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
        #region Switch between Register/Login screen
        private void lbRegister_Click(object sender, EventArgs e)
        {
            tbActive.Tag = null;
            this.Refresh();
            if (activeScreen == "Anmeldung")
            {
                RegisterSetup();
            }
            else
                LoginSetup();
            
        }
        
        private void RegisterSetup()
        {
            activeScreen = "Registrierung";
            lbRegister.Text = "Stattdessen anmelden";

            panelLogin.Hide();
            panelRegister.Show();

            panelButtons.Top = 585;
            btLogin.Text = "REGISTRIEREN";

            lbLoginText.Text = "Registrierung";
            lbLoginText2.Text = "Registriren bei SnakeGame";
        }
        private void LoginSetup()
        {
            panelLogin.Show();
            panelRegister.Hide();

            activeScreen = "Anmeldung";
            lbRegister.Text = "Neues Konto erstellen";

            panelButtons.Top = 425;
            btLogin.Text = "LOGIN";
            lbLoginText.Text = "Registrierung";
            lbLoginText2.Text = "Registriren bei SnakeGame";
        }
        #endregion
        private void panelRegister_Paint(object sender, PaintEventArgs e)
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

        #region Bewegung des Programms
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }
        #endregion
    }
}
