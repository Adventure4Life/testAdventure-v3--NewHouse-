using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class SingleCommands
    {
        Area area;
        List<Items> itemsInArea;

        public SingleCommands(string command)
        {
            area = Player.GetCurrentArea();
            itemsInArea = area.ItemList();
            FrameBuffer.ClearType();
            switch (command)
            {
                case "look":
                    LookArea(command);
                    break;
            }
        }

        private void LookArea(string command)
        {
            FrameBuffer.AddLine_typeWrite(area.LookDescription());

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

            PrintType();
        }

        private void PrintType()
        {
            Console.WriteLine("");
            PrintBuffer.PrintType();
        }
    }
}
