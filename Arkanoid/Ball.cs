using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arkanoid
{
    class Ball
    {
        public Rectangle pilka;
        public Rectangle pilka2;
        private SolidBrush brush;
        private int x, y, width, height;
        public int vecx =10;
        public int vecy= -10;
       
        public Ball()
        {
            
            brush = new SolidBrush(Color.Green);
            

            x = 100;
            y = 100;
            width = 10;
            height = 10;            
            pilka = new Rectangle(x, y, width, height);
           


        }
        public void drawPilka(Graphics paper)
        {
           
                paper.FillRectangle(brush, pilka);
            
        }
        public void Ruchpilki()
        {
            
            pilka.X += vecx;
            pilka.Y += vecy;
            Pilka2();
        }
        public void Pilka2()
        {
            pilka2 = new Rectangle(pilka.X + vecx, pilka.Y + vecy, width, height);
        }


    }
}
