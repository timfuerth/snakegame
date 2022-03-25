using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakegame
{
    public class Benutzer
    {
        public string username { get; private set; }
        public string vorname { get; private set; }
        public string nachname { get; private set; }
        public string passwort { get; private set; }
        public int BenutzerID { get; private set; }
        public int Rekord, aktuellePunktezahl;

        public Benutzer(string user, string vorn, string nachn, string pwd, int BenutzerID, int rekord)
        {
            username = user;
            vorname = vorn;
            nachname = nachn;
            passwort = pwd;
            this.BenutzerID = BenutzerID;
            Rekord = rekord;
        }

        public int punkteZuruecksetzen()
        {
            aktuellePunktezahl = 0;
            return aktuellePunktezahl;
        }

        public int spielt()
        {
            
            aktuellePunktezahl++;
            return aktuellePunktezahl;
        }

        public int rekordAktualisieren()
        {
            if (aktuellePunktezahl > Rekord)
            {
                Rekord = aktuellePunktezahl;
            }
            return Rekord;
        }
            
        
    }
}
