using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakegame
{
    abstract internal class Objekte
    {
        PictureBox Abbildung;
        int x;
        int y;

        public Objekte(PictureBox bild, int x, int y)
        {
            Abbildung = bild;
            this.x = x;
            this.y = y;
        }
    }
}
