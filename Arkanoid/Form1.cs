using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        Graphics paper;
        Paletka paletka = new Paletka();
        Ball ball = new Ball();
        List<Klocek_czerwony> czerwone = new List<Klocek_czerwony>{};
        List<Klocek_Zolty> zolte = new List<Klocek_Zolty> { };
        List<Klocek_Szary> szare = new List<Klocek_Szary> { }; 
        List<Klocki> kon = new List<Klocki>{};
        
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++)
			{
			 for (int j = 0; j < 4; j++)
			{
                var nowy = new Klocek_czerwony(i * 30, j * 10);
                kon.Add(nowy);
                
			}
			}
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j <4; j++)
                {
                    var nowy = new Klocek_Zolty(i * 30, j * 10);
                    kon.Add(nowy);
                    
                }

            } for (int i = 6; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var nowy = new Klocek_Szary(i * 30, j * 10);
                    kon.Add(nowy);
                    
                }
            }
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            paletka.drawPaletka(paper);
            ball.drawPilka(paper);
            
            foreach (var item in kon)
            {
                
                item.drawKlocek(paper);
                
            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Klocki on = new Klocki();
            var u = false;
            foreach (var item in kon)
            {

                if (ball.pilka2.IntersectsWith(item.klocek))
                {
                    ball.vecy = -ball.vecy;
                    item.Collision();
                    Console.WriteLine(item.num_hits);
                    if (item.num_hits == 0)
                    {
                        on = item;
                        u = true;
                    }
                }
            }
            
                kon.Remove(on);

                foreach (var item in paletka.Cien)
                {
                    if (ball.pilka.IntersectsWith(item))
                    {
                        ball.vecy = -ball.vecy;
                        //ball.pilka.Y -= 10;
                        var k = paletka.Cien.ToList();
                        var m = k.IndexOf(item);
                        if (m< 4)
                        {
                            ball.vecx = 10;
                        }
                        else
                        {
                            ball.vecx = -10;
                        }
                    }
                }
                if (ball.pilka.X <= 0 || ball.pilka.X >= 290  )
                {
                    ball.vecx = -ball.vecx;
                }
                if (ball.pilka.Y <= 0 || ball.pilka.Y >= 230)
                {
                    ball.vecy = -ball.vecy;
                }
            
            

        ball.Ruchpilki();
        
        this.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                paletka.vecx = -10;
            }
            if (e.KeyData == Keys.Right)
            {
                paletka.vecx = 10;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

paletka.Ruch();
        }

    }
}
