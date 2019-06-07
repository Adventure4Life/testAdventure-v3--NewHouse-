using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class AreaUtilities
    {
        public static void ActivateArea(Area area)
        {
            //Console.WriteLine(area.Name());
            switch (Player.AreaEntered())
            {
                case false:
                    {
                        Player.SetAreaEntered(); // Set Bool Value so app knows we have been here before
                        FrameBuffer.ClearType();
                        FrameBuffer.type = area.Cinamatic();
                        PrintBuffer.PrintType();
                        break; }
                case true:
                    { break; }
            }
        }
    }
}
