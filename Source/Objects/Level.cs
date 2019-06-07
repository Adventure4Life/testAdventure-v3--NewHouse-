using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class Level
    {
        //Public Variable
        public static Area[,] GameWorld { get; set; } = new Area[3, 3];
        
        public static void InitiliseLevel()
        {
            DataReader ReadData = new DataReader();

            // Player Start
            GameWorld[Player.PosX, Player.PosY] = ReadData.ImportAreaData("(1,1)_testroom_startroom");

            /*
            // Populate Map
            GameWorld[0, 0] = ReadData.ImportAreaData("(0,0)_testroom");
            GameWorld[0, 1] = ReadData.ImportAreaData("(0,1)_testroom");
            GameWorld[0, 2] = ReadData.ImportAreaData("(0,2)_testroom");

            GameWorld[1, 0] = ReadData.ImportAreaData("(1,0)_testroom");
            
            GameWorld[1, 2] = ReadData.ImportAreaData("(1,2)_testroom");

            GameWorld[2, 0] = ReadData.ImportAreaData("(2,0)_testroom");
            GameWorld[2, 1] = ReadData.ImportAreaData("(2,1)_testroom");
            GameWorld[2, 2] = ReadData.ImportAreaData("(2,2)_testroom");
            */
        }
    }
}

/*
╔═════════════╗ ╔═════════════╗ ╔═════════════╗
║ (0,0)       ║ ║ (0,1)       ║ ║ (0,2)       ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
╚═════════════╝ ╚═════════════╝ ╚═════════════╝
╔═════════════╗ ╔═════════════╗ ╔═════════════╗
║ (1,0)       ║ ║ (1,1)       ║ ║ (1,2)       ║
║             ║ ║             ║ ║             ║
║             ║ ║ Player      ║ ║             ║
║             ║ ║ Start       ║ ║             ║
║             ║ ║             ║ ║             ║
╚═════════════╝ ╚═════════════╝ ╚═════════════╝
╔═════════════╗ ╔═════════════╗ ╔═════════════╗
║ (2,0)       ║ ║ (2,1)       ║ ║ (2,2)       ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
╚═════════════╝ ╚═════════════╝ ╚═════════════╝
*/
