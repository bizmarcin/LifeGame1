using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    public class Cell
    {
        public int CellLiveTime { get; private set; }


        public Cell()
        {
            CellLiveTime = 0;
        }

        public void CellLiveIncase()
        {
            CellLiveTime++;
        }

        public void CellDeath()
        {
            CellLiveTime=0;
        }

        public ConsoleColor CellColor()
        {
            ConsoleColor cellColor = (ConsoleColor)CellLive.live1;

            switch (CellLiveTime)
            {
                case 0:
                    cellColor = (ConsoleColor)CellLive.live1;
                    break;
                case 1:
                    cellColor = (ConsoleColor)CellLive.live2;
                    break;
                case 2:
                    cellColor = (ConsoleColor)CellLive.live3;
                    break;
                case 3:
                    cellColor = (ConsoleColor)CellLive.live4;
                    break;
                case 4:
                    cellColor = (ConsoleColor)CellLive.live5;
                    break;
                default:
                    cellColor = (ConsoleColor)CellLive.live6;
                    break;
            }

            return cellColor;
        }

    }


    public enum CellLive
    {
        live1 = ConsoleColor.White,
        live2 = ConsoleColor.Yellow,
        live3 = ConsoleColor.Red,
        live4 = ConsoleColor.DarkRed,
        live5 = ConsoleColor.Gray,
        live6 = ConsoleColor.Blue,

    }
}