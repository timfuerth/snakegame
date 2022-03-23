﻿using System;
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
        static public List<Schlange> schlangenListe = new List<Schlange>();
        public Random rand = new Random();
        int defaultsize = 50;
        int x = 400;
        int y = 400;
        string[] fruitnames = { "honigmelone", "kiwi", "orange", "apfel", "melone", "avocado", "zitrone", "erdbeere", "kokosnuss" };

        public SnakeHead(PictureBox bild) : base(bild)
        {
            
        }

        public bool bewegen(string direction)
        {
            int oldX = bild.Left;
            int oldY = bild.Top;

            if (direction == "n")
                y -= defaultsize;
            else if (direction == "s")
                y += defaultsize;
            else if (direction == "w")
                x -= defaultsize;
            else if (direction == "o")
                x += defaultsize;

            if (x<0 || x>=800 || y < 50 || y >= 800)
                return false;

            bild.Location = new Point(x, y);
            if(schlangenListe.Count > 0)
            {
                
                for (int i = schlangenListe.Count; i > 1; i--)
                {
                    schlangenListe[i-1].bild.Location = schlangenListe[i - 2].bild.Location;
                }
                schlangenListe[0].bild.Location = new Point(oldX, oldY);
            }
            return true;
        }

        public PictureBox Kollission(PictureBox fruit)
        {
            int xFruit = rand.Next(0, 16);
            int yFruit = rand.Next(1, 16);
            if(bild.Location == fruit.Location)
            {
                fruit.Location = new Point(xFruit * defaultsize, yFruit * defaultsize);
                int randomFruit = rand.Next(0, 9);
                fruit.BackgroundImage = Image.FromFile("images/" + fruitnames[randomFruit] + ".png");
            }
            return fruit;
        }
    }
}
