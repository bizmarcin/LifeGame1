using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    public class Map
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Cell[,] Tab { get; private set; }

        public Map(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Tab = new Cell[X, Y];
        }

        public void Live(int liveCells)
        {
            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    Tab[j, i] = new Cell();
                }

            }


            Random rnd = new Random();
            for (int i = 0; i < liveCells; i++)
            {
                Tab[rnd.Next(0, X), rnd.Next(0, Y)].CellLiveIncase();

            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    Console.BackgroundColor = Tab[j, i].CellColor();
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void UploadMap(Cell[,] tab)
        {
            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    Tab[j, i] = tab[j, i];
                }
            }
        }
    }
}










