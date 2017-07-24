using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LifeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //var map = new Map(20, 20);
            //map.Live(200);
            //map.Draw();
            //Console.ReadKey();


            Console.WriteLine("Podaj X tablicy");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj Y tablicy");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj ile ma byc zywych komorek?");
            int liveCells = int.Parse(Console.ReadLine());
         
            Console.WriteLine("Podaj czas zycia komorki? (sekundy)");
            int liveTime = int.Parse(Console.ReadLine());

            Console.WriteLine("przy ilu ozywa");
            List<string> CellRessurection = new List<string>();
            CellRessurection.AddRange(Console.ReadLine().Split(','));

            Console.WriteLine("przy ilu umiera");
            List<string> CellDeath = new List<string>();
            CellDeath.AddRange(Console.ReadLine().Split(','));

            Console.WriteLine("podaj przeludnienie");
            int CellOverload = int.Parse(Console.ReadLine());



            var map = new Map(x, y);
            map.Live(liveCells);
            var lifeObject = new LifeRule(x, y, map.Tab);

            while (true)
            {
                map.Draw();
                // tutaj warunki
                lifeObject.lifeCycle(CellRessurection, CellDeath, CellOverload);
                // map.UploadMap(  ) poda� tu tabele do wrzucenia
                map.UploadMap(lifeObject.lifeArray);
                Thread.Sleep(liveTime * 1000);
            }

        }
    }
}
