using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    class LifeRule
    {

        public int x { get; private set; }
        public int y { get; private set; }
        public Cell[,] lifeArray { get; private set; }
        public Cell[,] lifeIteration { get; private set; }

        public LifeRule(int x, int y, Cell[,] lifeArray)
        {
            this.x = x;
            this.y = y;
            this.lifeArray = lifeArray;
            this.lifeIteration = lifeArray;
        }

        public void lifeCycle(List<string> life, List<string> die, int die2)
        {
            for(int xi=0; xi<x; xi++)
            {
                for (int yi = 0; yi < y; yi++)
                {
                    int lifeCount = CheckAll(xi, yi);                    
                    lifeCheck(lifeCount, life, die, die2, xi, yi);
                }
            }
            EndOfLifeCycle(x, y);
        }

        void lifeCheck(int lifeCount, List<string> life, List<string> die, int die2, int xi, int yi)
        {
            if (life.Contains(lifeCount.ToString()))
            {
                lifeIteration[xi, yi].CellLiveIncase();
            }
            else
            {
                if (die.Contains(lifeCount.ToString()) || lifeCount >= die2)
                {
                    lifeIteration[xi, yi].CellDeath();
                }
                else
                {
                    lifeIteration[xi, yi] = this.lifeArray[xi, yi];
                }
            }
        }

        void EndOfLifeCycle(int x, int y)
        {
            for (int xi=0; xi<x; xi++)
            {
                for (int yi = 0; yi < x; yi++)
                {
                    lifeArray[xi, yi] = lifeIteration[xi, yi];
                }
            }
        }

        int CheckAll(int xi, int yi)
        {
            int lifeCount = 0;
            try
            {
                if (lifeArray[xi - 1, yi - 1].CellLiveTime > 0) lifeCount++;
                if (lifeArray[xi, yi + 1].CellLiveTime > 0) lifeCount++;
                if (lifeArray[xi, yi - 1].CellLiveTime > 0) lifeCount++;
                if (lifeArray[xi + 1, yi - 1].CellLiveTime > 0) lifeCount++;
                if (lifeArray[xi - 1, yi].CellLiveTime > 0) lifeCount++;
                if (lifeArray[xi + 1, yi].CellLiveTime > 0) lifeCount++;
                if (lifeArray[xi - 1, yi + 1].CellLiveTime > 0) lifeCount++;
                if (lifeArray[xi + 1, yi + 1].CellLiveTime > 0) lifeCount++;
            } catch{ }
            
            return lifeCount;
        }        
    }


}
