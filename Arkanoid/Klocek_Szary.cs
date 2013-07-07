using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arkanoid
{
    class Klocek_Szary:Klocki
    {
        private int k = 1;
        private int Num_hit =3;
        public override int num_hits
        {
            get { return Num_hit; }
            set { Num_hit = value; }
        }
        SolidBrush brush = new SolidBrush(Color.Gray);
        
        
        public Klocek_Szary(int x , int y)

        {
            klocek = new Rectangle(x, y, width, height);
            
        }
        public override void drawKlocek(Graphics paper)
        {

            paper.FillRectangle(brush, klocek);
            paper.DrawRectangle(pen, klocek);
        }
    }
}
