using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class ProcessCommands
    {
        private static string rawInput;
        private static string[] cleanedInputTokens;
        private static string[] stemmedInputTokens;
        private Dictionary<string, string> activeCommands;
        //private Dictionary<string, string> activeNouns;

        public ProcessCommands()
        {
            rawInput = UserInput.GetRawInput();
            cleanedInputTokens = UserInput.GetCleanedInputTokens().Clone() as string[];
            stemmedInputTokens = UserInput.GetStemmedInputTokens().Clone() as string[];
            //activeCommands = new Dictionary<string, string>(CommandDictonary.GetCommandList());
        }

        public void ProcessInputData()
        {
            if (stemmedInputTokens.Length == 1)
            {
                SingleWordActivations(stemmedInputTokens[0]);
            }
        }

        private void SingleWordActivations(string cmd)
        {
            if (activeCommands.ContainsKey(cmd))
            {
                //Console.WriteLine(word + " : " + activeCommands[word]);
                SingleCommands ProcessSingleCommand = new SingleCommands(activeCommands[cmd]);
            }
        }
    }
}

/*
            Console.WriteLine(rawInput);
            Console.WriteLine("");
            foreach  (string w in cleanedInputTokens)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine("");
            foreach (string w in stemmedInputTokens)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine("");
            foreach (KeyValuePair<string, string> item in activeCommands)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
*/