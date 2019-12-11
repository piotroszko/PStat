using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*  0
     *0 XX>XXXXXX
     *  XXXXXXXXX
     *  XoXXXoXXX
     *  XXXXXXXXX
     * 
     * 
     * 
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public enum klasa { lucznik, wojownik, mag }
    class Hero
    {
        public int zycie;
        public klasa klasaH;
        public int heroX = 0;
        public int heroY = 0;

        public Hero(int zycie, klasa klasaH, int heroX, int heroY)
        {
            this.zycie = zycie;
            this.klasaH = klasaH;
            this.heroX = heroX;
            this.heroY = heroY;
        }
    }
    class Swiat
    {
        public int x;
        public int y;
        List<Pomieszczenie> lista;

        public Swiat(int x, int y, List<Pomieszczenie> lista)
        {
            this.x = x;
            this.y = y;
            this.lista = lista;
        }
        void Ruch(Hero h, int kierunek)
        {
            if (SprawdzRuch(h,kierunek))
            {
                switch (kierunek)
                {
                    case 0:

                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    default:

                        break;
                }
            }


        }
        bool SprawdzRuch (Hero h, int kierunek) // 0- prawo 1- dol 2- lewo 3-gora
        {
            foreach (Pomieszczenie p in lista)
            {
                switch (kierunek)
                {
                    case 0:
                        
                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    default:

                        break;
                }

            }

        }
        public void Rysuj (Hero h)
        {
            for (int i=0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    bool pomieszczenie = false;
                    foreach (Pomieszczenie p in lista)
                    {
                        if (p.x == j && p.y == i)
                        {
                            Console.Write("O");
                            pomieszczenie = true;
                        } else if (h.heroX == j && h.heroY == i)
                        {
                            Console.Write("☼");
                            pomieszczenie = true;
                        }

                    }
                    if (!pomieszczenie)
                    {
                        Console.Write("X");
                    }

                }
                Console.WriteLine("");
            }
        }
    }
    class Pomieszczenie
    {
        public int x;
        public int y;
        public int inX;
        public int inY;
    }
}
