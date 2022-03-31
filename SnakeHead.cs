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
        static public List<SnakeHead> snakeHeads = new List<SnakeHead>();
        public List<Schlange> schlangenListe = new List<Schlange>();
        public Random rand = new Random();
        int defaultsize = 50;
        int x;
        int y;
        
        string[] fruitnames = { "honigmelone", "kiwi", "orange", "apfel", "melone", "avocado", "zitrone", "erdbeere", "kokosnuss" };
        string[] PUnames = { "fast", "slow"};
        public SnakeHead(PictureBox bild) : base(bild)
        {
            x = bild.Left;
            y = bild.Top;
            snakeHeads.Add(this);
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

            if (x<0 || x>=800 || y < 50 || y >= 800 )
                return false;

            bild.Location = new Point(x, y);

            if (schlangenListe.Count > 0)
            {

                for (int i = schlangenListe.Count; i > 1; i--)
                {
                    if (bild.Bounds.IntersectsWith(schlangenListe[i - 1].bild.Bounds))
                        return false;
                    schlangenListe[i - 1].bild.Location = schlangenListe[i - 2].bild.Location;
                }

                schlangenListe[0].bild.Location = new Point(oldX, oldY);
            }
            
            if (snakeHeads.Count > 1)
            {
                foreach (SnakeHead head in snakeHeads)
                {
                    if (head != this)
                    {
                        if (head.schlangenListe.Count > 0)
                        {

                            for (int i = head.schlangenListe.Count; i > 1; i--)
                            {
                                if (bild.Bounds.IntersectsWith(head.schlangenListe[i - 1].bild.Bounds))
                                    return false;
                            }
                        }
                        if (bild.Bounds.IntersectsWith(head.bild.Bounds))
                            return false;
                    }
                    
                }
            }
            

            return true;
        }

        public PictureBox FruitKollission(PictureBox fruit)
        {
            int xFruit;
            int yFruit;
            bool besetzt = false;
            if(bild.Location == fruit.Location)
            {
                do
                {
                    xFruit = rand.Next(0, 16) * defaultsize;
                    yFruit = rand.Next(1, 16) * defaultsize;
                    besetzt = false;
                    
                    if (x != xFruit || y != yFruit)
                    {
                        if (schlangenListe.Count > 0)
                        {
                            foreach(Schlange body in schlangenListe)
                            {
                                if (body.bild.Left == xFruit && body.bild.Top == yFruit)
                                {
                                    besetzt = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        besetzt = true;
                    }
                } while (besetzt);

                fruit.Location = new Point(xFruit, yFruit);
                int randomFruit = rand.Next(0, 9);
                fruit.BackgroundImage = Image.FromFile("images/" + fruitnames[randomFruit] + ".png");
                
                
            }
            



            return fruit;
        }
        public PictureBox PowerUpErstellen(PictureBox pbPU)
        {
            int randomPU = rand.Next(0, PUnames.Length);
            pbPU.BackgroundImage = Image.FromFile("images/" + PUnames[randomPU] + ".png");
            pbPU.Tag = PUnames[randomPU];
            return pbPU;
        }

        public PictureBox PowerUpKollission(PictureBox pbPU)
        {
            int xPU;
            int yPU;
            bool besetzt = false;
            if (pbPU.Visible == true)
            {
                if (bild.Location == pbPU.Location)
                {
                    do
                    {
                        xPU = rand.Next(0, 16) * defaultsize;
                        yPU = rand.Next(1, 16) * defaultsize;
                        besetzt = false;

                        if (x != xPU || y != yPU)
                        {
                            if (schlangenListe.Count > 0)
                            {
                                foreach (Schlange body in schlangenListe)
                                {
                                    if (body.bild.Left == xPU && body.bild.Top == yPU)
                                    {
                                        besetzt = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            besetzt = true;
                        }
                    } while (besetzt);

                    pbPU.Location = new Point(xPU, yPU);
                    
                }
            }
            
            return pbPU;
        }
        
        public void SchlangenTeilHinzufügen(PictureBox schlangenTeil)
        {
            Schlange body = new Schlange(schlangenTeil);
            schlangenListe.Add(body);
        }
    }
}
