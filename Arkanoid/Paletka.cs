using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arkanoid
{
    class Paletka
    {
        public Rectangle[] paletka;
        public Rectangle[] Cien;
        private SolidBrush brush, brush_kulka;
        private int x, y, width, height;
        public int vecx = 0;
        public Paletka()
        {
            paletka = new Rectangle[6];
            Cien = new Rectangle[8];
            brush = new SolidBrush(Color.Black);
            brush_kulka = new SolidBrush(Color.Green);

            x = 200;
            y = 200;
            width = 10;
            height = 10;

Cien[0] = new Rectangle(x+10, y - 10, width, height);
            Cien[7] = new Rectangle(x -60 , y - 10, width, height);
            for (int i = 0; i < paletka.Length; i++)
            {
                paletka[i] = new Rectangle(x, y, width, height);
                Cien[i+1] = new Rectangle(x, y-10, width, height);
                x -= 10;
            }
           
            

        }
        public void drawPaletka(Graphics paper)
        {
            foreach (Rectangle rec in paletka)
            {
                paper.FillRectangle(brush, rec);
                
            }
            
        }
        public void Ruch()
        {
            for (int i = 0; i < paletka.Length; i++)
            {
                paletka[i].X += vecx;
                

            } for (int i = 0; i < Cien.Length; i++)
            {
                
                Cien[i].X += vecx;

            }
            
            vecx = 0;
        }
        
        
    }
}
