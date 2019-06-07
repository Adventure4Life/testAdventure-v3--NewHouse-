using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    public class Direction
    {
        private List<Exit> exitList;
        public Dictionary<string, string> validExists;

        public Direction()
        {
            exitList = new List<Exit>();
            exitList = Player.GetCurrentArea().ExitList();

            validExists = new Dictionary<string, string>();
        }

        public bool ExitExists(string direction)
        {
            foreach (Exit exit in exitList)
            {
                if (exit.direction == direction && exit.avaliable)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Exit_IsOpen(string direction)
        {
            foreach (Exit exit in exitList)
            {
                if (exit.direction == direction)
                {
                    if (exit.open)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

/*
 
            private Dictionary<string, string> TestDirection(string direction)
        {

            foreach (Exit exit in exitList)
            {
                if (exit.name == direction)
                {
                    Exit_Exists = "true";
                    validExists.Add(direction, Exit_Exists);

                    if (exit.open)
                    {
                        validExists.Add(direction, Exit_Open);
                    }
                    else if (!exit.open) { validExists.Add(direction, Exit_Closed); }
                    return validExists;
                }
            }
            return validExists;
        }
  
        public const string North = "north";
        public const string South = "south";
        public const string East = "east";
        public const string West = "west";

        public static bool IsValidDirection(string direction)
        {
            List<Exit> exitList = new List<Exit>();
            exitList = Player.GetCurrentArea().ExitList();

            switch (direction)
            {
                case North:
                    bool nTrue = false;
                    foreach (Exit exit in exitList)
                    {
                        if (exit.direction == direction)
                        { if (exit.open == true) nTrue = true; }
                    }
                    return nTrue;
                case South:
                    bool sTrue = false;
                    foreach (Exit exit in exitList)
                    {
                        if (exit.direction == direction)
                        { if (exit.open == true) sTrue = true; }
                    }
                    return sTrue;
                case West:
                    bool wTrue = false;
                    foreach (Exit exit in exitList)
                    {
                        if (exit.direction == direction)
                        { if (exit.open == true) wTrue = true; }
                    }
                    return wTrue;
                case East:
                    bool eTrue = false;
                    foreach (Exit exit in exitList)
                    {
                        if (exit.direction == direction)
                        { if (exit.open == true) eTrue = true; }
                    }
                    return eTrue;
            }
            return false;
        }
*/
/*
List<Exit> exitList = Player.GetCurrentArea().ExitList();

    foreach (Exit exit in exitList)
    {
        if (exit.direction == direction)
        { if (exit.open == true) return true; }
    }


}
}
}

/*

exit.direction == direction && exit.open == true
*/
