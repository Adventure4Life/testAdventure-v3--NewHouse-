using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    public class DirectionIsOpen
    {
        public Direction North { get; } = new Direction();
        public Direction South { get; } = new Direction();
        public Direction East { get; } = new Direction();
        public Direction West { get; } = new Direction();

        private List<Exit> exitList { get; } = new List<Exit>();

        private const string north = "north";
        private const string south = "south";
        private const string east = "east";
        private const string west = "west";

        public DirectionIsOpen(string direction)
        {
            exitList = Player.GetCurrentArea().ExitList();

            switch (direction)
            {
                case north:
                    return;
            }

                    
            
        }
    }
}

/*
    foreach (Exit exit in exitList)
            {
                //North
                if (exit.direction == north)
                    North.Exit_Exists = true;
                if (exit.direction == north && exit.open == true)
                    North.Exit_Open = true;
                //South
                if (exit.direction == south)
                    North.Exit_Exists = true;
                if (exit.direction == south && exit.open == true)
                    North.Exit_Open = true;
                //East
                if (exit.direction == east)
                    North.Exit_Exists = true;
                if (exit.direction == east && exit.open == true)
                    North.Exit_Open = true;
                //West
                if (exit.direction == west)
                    North.Exit_Exists = true;
                if (exit.direction == west && exit.open == true)
                    North.Exit_Open = true;
            }
    
    private string Exit_Open { get; } = "false";
        //public string ExitExists_Closed { get; } = "false";
        private string ExitExists { get; } = "false";
        private List<Exit> exitList { get; } = new List<Exit>();

        public Dictionary<string, string> ValidExits {get;} = new Dictionary<string,string>();


        public DirectionIsOpen()
        {
            exitList = Player.GetCurrentArea().ExitList();
            foreach (Exit exit in exitList)
            {
                if (exit.direction == Direction.North && exit.open == true)
                { ValidExits[exit.direction] = "Exit_Open"; }
                else if (exit.direction == Direction.North && exit.open == false)
                { ValidExits[exit.direction] = "Exit_Closed"; }
            }
            }

        }
*/
