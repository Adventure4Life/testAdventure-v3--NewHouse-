using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class SingleCommands
    {
        private Area area;
        private List<Items> itemsInArea;
        private string cmd;

        public SingleCommands(string command)
        {
            cmd = command;
            area = Player.GetCurrentArea();
            itemsInArea = area.ItemList();
            FrameBuffer.ClearType();
            TestRecivedCommand();
        }

        private void TestRecivedCommand()
        {
            switch (cmd)
            {
                case "look":
                    Console.WriteLine("\nProcess : " + cmd);
                    LookArea(cmd);
                    break;
                case "north":
                    Console.WriteLine("\nProcess : " + cmd);
                    PlayerActions.Action_MovePlayer(cmd);
                    break;
                case "south":
                    Console.WriteLine("\nProcess : " + cmd);
                    PlayerActions.Action_MovePlayer(cmd);
                    break;
                case "east":
                    Console.WriteLine("\nProcess : " + cmd);
                    PlayerActions.Action_MovePlayer(cmd);
                    break;
                case "west":
                    Console.WriteLine("\nProcess : " + cmd);
                    PlayerActions.Action_MovePlayer(cmd);
                    break;
                case "inventory":
                    Console.WriteLine("\nProcess : " + cmd);
                    //Player.MovePlayer(cmd);
                    break;
                case "map":
                    Console.WriteLine("\nProcess : " + cmd);
                    //Player.MovePlayer(cmd);
                    break;
            }
        }

        private void LookArea(string command)
        {
            FrameBuffer.ClearType();
            FrameBuffer.AddLine_typeWrite(area.LookDescription());
            PrintType();
        }

        private void PrintType()
        {
            Console.WriteLine("");
            PrintBuffer.PrintType();
        }
    }
}
/*
   if (itemsInArea.Count != 0)
            {
                foreach (Items item in itemsInArea)
                {
                    if (item.description_Default != "")
                    {
                        FrameBuffer.AddLine_Blank();
                        FrameBuffer.AddLine_typeWrite(item.description_Default); }
                }
            }
*/