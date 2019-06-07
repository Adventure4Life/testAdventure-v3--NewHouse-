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
        public string direction { get; } = "--DIRECTION:";

        public string avaliable { get; } = "--AVAILABLE:";
        public string isOpen { get; } = "--IS_OPEN:";

        public string lookAtExit { get; } = "--LOOK_AT_EXIT:";
        public string MoveThroughExit { get; } = "--Move_Through_Exit:";
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
                exit.direction = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.direction, fileData, start, end);

                exit.avaliable = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.avaliable, fileData, start, end).Equals("true");
                exit.open = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.isOpen, fileData, start, end).Equals("true");

                exit.look_at_exit = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.lookAtExit, fileData, start, end);
                exit.move_Through_exit = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.MoveThroughExit, fileData, start, end);
            }
            return exit;
        }
    }
}
