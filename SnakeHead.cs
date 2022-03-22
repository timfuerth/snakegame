using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakegame
{
    public class SnakeHead : Objekte
    {
        public SnakeHead(PictureBox bild, int x, int y) : base(bild, x, y)
        {

        }

        public bool bewegen(string direction)
        {
            if (direction == "n")
                y -= 50;
            else if (direction == "s")
                y += 50;
            else if (direction == "w")
                x -= 50;
            else if (direction == "o")
                x += 50;

            if (x<0 || x>800 || y<50||y>800)
                return false;

            bild.Location = new Point(x, y);
            return true;
        }
    }
}
