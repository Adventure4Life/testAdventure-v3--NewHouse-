using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class ExitKeys
    {
        public string name { get; } = "--NAME:";
        public string isOpen { get; } = "--IS_OPEN:";

        public string lookAreaOpen { get; } = "--LOOK_AREA_OPEN:";
        public string lookAreaClosed { get; } = "--LOOK_AREA_CLOSED:";

        public string LookAtOpen { get; } = "--LOOK_AT_OPEN:";
        public string LookAtClosed { get; } = "--LOOK_AT_CLOSED:";

        public string Use_Open { get; } = "--USE_OPEN:";
        public string Use_CLosed { get; } = "--USE_CLOSED:";

    }

    class DataRead_Exits
    {
        ExitKeys exitKeys = new ExitKeys();
        public Exit ProcessExits(int start, int end, List<string> fileData)
        {
            Exit exit = new Exit();
            start = start + 1;
            for (int i = start; i < end; i++)
            {
                exit.name = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.name, fileData, start, end);
                exit.open = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.isOpen, fileData, start, end).Equals("true");
                exit.look_area_open = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.lookAreaOpen, fileData, start, end);
                exit.look_at_open = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.LookAtOpen, fileData, start, end);
            }
            return exit;
        }
    }
}
