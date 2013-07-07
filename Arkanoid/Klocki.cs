using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arkanoid
{
    class Klocki
    {
        private int Num_hits =1;
        public virtual int num_hits{
        get { return Num_hits;}
            set { Num_hits = value; }
        }
        
        
        
        public Rectangle klocek;
        public int x, y;
        public const int width = 30;
        public const int height =10;
        public SolidBrush brush = new SolidBrush(Color.Azure);
        public Pen pen = new Pen(Color.Black, 2);
        public void Collision(){
            Console.WriteLine(num_hits);
            if (num_hits > 0)
	{
        num_hits--;
	}
            if (num_hits == 0)
            {
                x = -100;
                y = -100;
            }

        }
        public virtual void drawKlocek(Graphics paper)
        {

            paper.FillRectangle(brush, klocek);
            paper.DrawRectangle(pen, klocek);

        }
        

    }
}
