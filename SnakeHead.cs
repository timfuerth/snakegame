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

        public void bewegen(string direction)
        {
            if (direction == "n")
                y -= 50;
            else if (direction == "s")
                y += 50;
            else if (direction == "w")
                x -= 50;
            else if (direction == "o")
                x += 50;

            bild.Location = new Point(x, y);
        }
    }
}
