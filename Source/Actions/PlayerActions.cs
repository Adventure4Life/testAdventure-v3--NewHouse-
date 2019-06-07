using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class PlayerActions
    {

        public static void Action_MovePlayer(string direction)
        {
            Direction validMove = new Direction();
            if (validMove.ExitExists(direction))
            {
                if (validMove.Exit_IsOpen(direction))
                {
                    Console.WriteLine("Exit Is Open - " + direction);
                }
                else { Console.WriteLine("Exit Is CLOSED - " + direction); }
            }else { Console.WriteLine("NO Exit - " + direction); }
                
        }


        /*
                     DirectionIsOpen path = new DirectionIsOpen();
        if (path.North.Exit_Exists)
        {
            Console.WriteLine("DEBUG - North Exists");
            if (path.North.Exit_Open)
            {
                Console.WriteLine("DEBUG - North Exist is OPEN");
            }
            else { Console.WriteLine("DEBUG - North Exist is CLOSED"); } 
        } else { Console.WriteLine("DEBUG - NO NORTH"); }

        //List<Exit> exitList = Player.GetCurrentArea().ExitList();
        if (Direction.IsValidDirection(direction))
        {
            Console.WriteLine("DUBUG - Exit : " + direction + " = TRUE");
        }
         * List<Exit> exitList = Player.GetCurrentArea().ExitList();

        foreach (Exit exit in exitList)
        {
            if (exit.direction == direction && exit.open == true)
            { PlayerActions.MovePlayer(direction); }
            else { Console.WriteLine("NO WAY OUT"); }

            /*
            else if (exit.direction == direction && exit.open == false)
            { PlayerActions.MovePlayerFailed(direction); }
        }
    }*/

        /*    public static void MovePlayer(string direction)
        {
            switch (direction)
            {
                case Direction.North:
                    Console.WriteLine("Move North");
                    Console.WriteLine("  From : "+"("+Player.PosX+", "+Player.PosY+")");
                    Player.PosX--;
                    Console.WriteLine("  To   : " + "(" + Player.PosX + ", " + Player.PosY + ")");
                    break;
                case Direction.South:
                    Console.WriteLine("Move South");
                    Player.PosX++;
                    break;
                case Direction.East:
                    Console.WriteLine("Move East");
                    Player.PosX++;
                    break;
                case Direction.West:
                    Console.WriteLine("Move West");
                    Player.PosX--;
                    break;
            }
        }*/

        public static void MovePlayerFailed(string direction)
        {
            Console.WriteLine("DEGUG - Failed to Move");
        }
    }
}
