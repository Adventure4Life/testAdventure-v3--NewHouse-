using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class Player
    {
        // Variables : X,Y Position in Level Table (see Level)
        private static int PosX { get; set; } = 0;
        private static int PosY { get; set; } = 0;

        public static Area GetCurrentArea()
        {
            return Level.GameWorld[PosX, PosY];
        }
    }
}

/*static Player()
{
    PosX = 0;
    PosY = 0;
}*/
