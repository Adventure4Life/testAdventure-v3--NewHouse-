using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class CommandDictonary
    {
        public static Dictionary<string,string> actionsSingle { get; set; } = new Dictionary<string, string>();
        public static Dictionary<string, string> actionsConstant { get; set; } = new Dictionary<string, string>();

        public static void InitialiseDefautls()
        {
            DataReader readData = new DataReader();
            actionsSingle = readData.ImportCommands_Singles();
            actionsConstant = readData.ImportCommands_Constants();
        }
    }
}

//Cmd_Constant = new Dictionary<string, string>();

//string type = "singleCommands";
//ReadData.ImportCommandData(type, "d_North", Cmd_Constant);
//

/*private static Dictionary<string, string> CmdList_Defaults { get; set; }
    private static Dictionary<string, string> CmdList { get; set; }

    static CommandDictonary()
    {
        CmdList_Defaults = new Dictionary<string, string>();
        string type = "verbs";
        ReadData.ImportCommandData(type, "look", CmdList_Defaults);
        ReadData.ImportCommandData(type, "get", CmdList_Defaults);
        InitialiseDefautls();
    }

    public static void InitialiseDefautls()
    {
        CmdList = new Dictionary<string, string>(CmdList_Defaults);
    }

    public static Dictionary<string, string> GetCommandList()
    { return CmdList; }
}
}
*/
