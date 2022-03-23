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

        public Objekte(PictureBox bild)
        {
            this.bild = bild;
            
        }
    }
}
