using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class CmdKeys
    {
        public string cmdName { get; set; } = "//--Single_Word_Command:";
        //public string name { get; set; } = "//--Base:";

        public string cmdSynonymList_Start { get; } = "//Synonyms-START";
        public string cmdSynonymList_End { get; } = "//Synonyms-END";

        public string cmdList_Start { get; } = "//List-START";
        public string cmdList_End { get; } = "//List-END";
    }

    class DataRead_WordLists
    {
        private DataReader ReadData = new DataReader();
        private List<string> fileData;
        private string fileName;
        CmdKeys cmdKeys;

        //Dictionary<string, string> cmdList_single_LoadList { get; set; }
        Dictionary<string, string> cmds { get; set; }
        Dictionary<string, string> cmdList_single { get; set; }
        Dictionary<string, string> cmdList_constant { get; set; }
        //Dictionary<string, string> cmdList_generated { get; set; }
        //Dictionary<string, string> objList_generated { get; set; }

        //Constructor
        public DataRead_WordLists(string name)
        {
            cmds = new Dictionary<string, string>();
            cmdList_single = new Dictionary<string, string>();
            cmdList_constant = new Dictionary<string, string>();
            //cmdList_generated = new Dictionary<string, string>();
            //cmdList_single_LoadList = new Dictionary<string, string>();
            //objList_generated = new Dictionary<string, string>();

            cmdKeys = new CmdKeys();
            fileName = name;
            fileData = ReadDataFile.Load_DataFile(FilePaths.Cmds_Single, fileName).ToList();
            #region - DEBUG - Test print some variables
            /*
            Console.WriteLine("DEBUG----------- :" + fileName);
            Console.WriteLine("DEBUG----------- :" + FilePaths.Cmds_Single);
            foreach (string line in fileData)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("DEBUG---cmdList_single_LoadList :" + cmdList_single_LoadList.Count);
            Console.WriteLine("DEBUG---cmdList_single :" + cmdList_single_LoadList.Count);
            */
            #endregion
        }

        public Dictionary<string, string> ProcessAll_ConstantCommands()
        {
            // set file stuff
            cmds = new Dictionary<string, string>();
            cmdKeys.cmdName = "//--Base:";
            fileData = ReadDataFile.Load_DataFile(FilePaths.Cmds_Constant, fileName).ToList();

            BracketCounts brackets = new BracketCounts();
            brackets = ReadDataFile.Read_BracketCount(cmdKeys.cmdList_Start, cmdKeys.cmdList_End, fileData);
            for (int i = brackets.start[0] + 1; i < brackets.end[0]; i++)
            {
                //Console.WriteLine("DEBUGGING ---- : " + fileData[i]);
                ProcessCommand(cmds, FilePaths.Cmds_Constant, fileData[i]);
            }
            return cmds;
        }


        public Dictionary<string, string> ProcessAll_SingleCommands()
        {
            cmdKeys.cmdName = "//--Single_Word_Command:";
            BracketCounts brackets = new BracketCounts();
            brackets = ReadDataFile.Read_BracketCount(cmdKeys.cmdList_Start, cmdKeys.cmdList_End, fileData);
            for (int i = brackets.start[0] + 1; i < brackets.end[0]; i++)
            {
                //Console.WriteLine("DEBUGGING ---- : " + fileData[i]);
                ProcessCommand(cmdList_single, FilePaths.Cmds_Single, fileData[i]);
            }
            return cmdList_single;
        }

        public void ProcessCommand(Dictionary<string, string> CmdList, string filePath, string fileName)
        {
            List<string> fileDataList = new List<string>(ReadDataFile.Load_DataFile(filePath, fileName));

            string value = ReadDataFile.Read_RawSingleLine(cmdKeys.cmdName, fileDataList);
            int[] brackest = ReadDataFile.FindUniqueBrackets(cmdKeys.cmdSynonymList_Start, cmdKeys.cmdSynonymList_End, fileDataList);
            List<string> keys = ReadDataFile.Read_WordLists(brackest[0], brackest[1], fileDataList);
            AddSafe(CmdList, value, value);
            foreach (string synonym in keys)
            {
                #region Test Prints
                //Console.WriteLine(value + ", " + synonym);
                //AddSafe(CmdList, TextUtils.StemWord.Stem(synonym).Value, value);
                //string StemValue = TextUtils.StemWord.Stem("looking").Value;
                #endregion
                AddSafe(CmdList, synonym, value);
            }
            #region - DEBUG - Test print some variables
            /*foreach (string line in fileDataList)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine(value);
            foreach (int brack in brackest)
            {
                Console.WriteLine(brack);
            }*/
            #endregion
        }

        public void AddSafe(Dictionary<string, string> dictionary, string key, string value)
        {
            value = TextUtils.StemWord.Stem(value).Value;
            key = TextUtils.StemWord.Stem(key).Value;
            //Console.WriteLine(value);
            if (!dictionary.ContainsKey(key))
                dictionary.Add(key, value);
        }
    }
}

/*

    string value = ReadDataFile.Read_RawSingleLine(cmdKeys.cmdName, fileDataList);
    int[] brackest = ReadDataFile.FindUniqueBrackets(cmdKeys.cmdSingleList_Start, cmdKeys.cmdSingleList_End, fileDataList);
    List<string> keys = ReadDataFile.Read_WordLists(brackest[0], brackest[1], fileDataList);

    foreach (string line in keys)
    {
        Console.WriteLine(line);
    }

    keys = TextUtils.StemWordList(keys);
    AddSafe(CmdList, value, value);
    foreach (string synonym in keys)
    {
        Console.WriteLine(value+", "+keys);
        //AddSafe(CmdList, synonym, value);
    }
}*/

/*
    private List<string> fileNameData;
    private string filePath;

    public DataRead_WordLists(string type)
    {
        filePath = type;
        fileNameData = ReadDataFile.Load_DataFile(filePath, "_ListofWords");
    }

    public Dictionary<string, string> GetList()
    {
        Dictionary<string, string> ListofCommands = new Dictionary<string, string>();
        List<string> fileNames = ReadDataFile.BetweenUniqueBrackets("//List-START", "/List-END");

        // - Load list of commands into list<string>, then use that to load command files like item files
        return ListofCommands;
    }
*/

























/*
public void AddSafe(Dictionary<string, string> dictionary, string key, string value)
{
    if (!dictionary.ContainsKey(key))
        dictionary.Add(key, value);
}

public void ProcessCommand(string fileName, Dictionary<string, string> CmdList)
{
    fileData = new List<string>(ReadDataFile.Load_DataFile(filePath, fileName));

    string value = ReadDataFile.Read_RawSingleLine("//--Base_VERB:", fileData);
    int[] brackest = ReadDataFile.FindUniqueBrackets("//Synonyms-START", "//Synonyms-END", fileData);
    List<string> keys = ReadDataFile.Read_WordLists(brackest[0], brackest[1], fileData);

    keys = TextUtils.StemWordList(keys);
    AddSafe(CmdList, value, value);
    foreach (string synonym in keys)
    {
        AddSafe(CmdList, synonym, value);
    }
}

}
}*/

/*
            switch (type)
            {
                case "verbs":
                    filePath = @"Data\commands\verbs\";
                    break;
                case "nouns":
                    filePath = @"Data\commands\nouns\";
                    break;
                case "singleCommands":
                    filePath = @"Data\commands\verbs\singleWordOnly";
                    break;
            }
*/
