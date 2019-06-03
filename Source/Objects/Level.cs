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
            GameWorld[2, 2] = ReadData.ImportAreaData("CommandTestRoom");
        }
    }
}

/*
╔═════════════╗ ╔═════════════╗ ╔═════════════╗
║ (1,1)       ║ ║ (1,2)       ║ ║ (1,3)       ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
╚═════════════╝ ╚═════════════╝ ╚═════════════╝
╔═════════════╗ ╔═════════════╗ ╔═════════════╗
║ (2,1)       ║ ║ (2,2)       ║ ║ (2,3)       ║
║             ║ ║             ║ ║             ║
║             ║ ║ Player      ║ ║             ║
║             ║ ║ Start       ║ ║             ║
║             ║ ║             ║ ║             ║
╚═════════════╝ ╚═════════════╝ ╚═════════════╝
╔═════════════╗ ╔═════════════╗ ╔═════════════╗
║ (3,1)       ║ ║ (3,2)       ║ ║ (3,3)       ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
║             ║ ║             ║ ║             ║
╚═════════════╝ ╚═════════════╝ ╚═════════════╝
*/
