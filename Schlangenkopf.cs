using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakegame
{
    internal class Schlangenkopf:Objekte
    {
        public Schlangenkopf(PictureBox bild, int x, int y):base(bild, x, y)
        {

        }

        public void bewegen(string direction)
        {
            if (direction == "n")
                y += 50;
            else if (direction == "s")
                y -= 50;
            else if (direction == "w")
                x -= 50;
            else if (direction == "o")
                x += 50;
        }
    }
}
