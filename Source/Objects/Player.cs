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
        public static int PosX { get; set; }
        public static int PosY { get; set; }

        // Variables : Track if a area has been entered before or not
        private static bool[,] HasEnteredArea { get; set; } = new bool[3, 3];

        public static void Initilise()
        {
            //Console.WriteLine("DEBUGGG - Player Constructor");
            PosX = 1;
            PosY = 1;
            for (int x = 0; x < HasEnteredArea.GetLength(0); x++)
                for (int y = 0; y < HasEnteredArea.GetLength(1); y++)
                    HasEnteredArea[x, y] = false;
        }

        public static Area GetCurrentArea()
        {
            return Level.GameWorld[PosX, PosY];
        }

        public static void SetAreaEntered()
        {
            HasEnteredArea[PosX, PosY] = true;
        }

        public static bool AreaEntered()
        {
            return HasEnteredArea[PosX, PosY];
        }

    }
}

