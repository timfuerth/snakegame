using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakegame
{
    abstract public class Objekte
    {
        public PictureBox bild;
        public int x;
        public int y;

        public Objekte(PictureBox bild, int x, int y)
        {
            this.bild = bild;
            this.x = x;
            this.y = y;
            bild.Location = new System.Drawing.Point(x, y);
        }
    }
}
