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


        public ProcessCommands()
        {
            rawInput = UserInput.GetRawInput();
            cleanedInputTokens = UserInput.GetCleanedInputTokens().Clone() as string[];
            stemmedInputTokens = UserInput.GetStemmedInputTokens().Clone() as string[];
            #region DEBUGGING PRINTOUTS of Variables.
            /*
            Console.WriteLine("ProcessCommands Constructor");
            Console.WriteLine("rawInput : " + rawInput);
            foreach (string word in cleanedInputTokens)
                Console.WriteLine("cleanedInputTokens : " + word);
            foreach (string word in stemmedInputTokens)
                Console.WriteLine("stemmedInputTokens : " + word);
            */
            //ProcessInputData(); // Moved to UserInputs.GetInput()
            //examine
            //Console.WriteLine("DEBUG 'examine': "+ CommandDictonary.actionsConstant["examine"]);
            //string Stemmed = TextUtils.StemWord.Stem("examine").Value;
            //Console.WriteLine("Stemmed Command : "+Stemmed);
            #endregion
        }

        public void ProcessInputData()
        {
            if (stemmedInputTokens.Length == 1)
            {
                //Console.WriteLine("ProcessCommands Constructor");
                //Console.WriteLine("SingleWord : "+ stemmedInputTokens[0]);
                SingleWordActivations(stemmedInputTokens[0]);
            }
        }

        private void SingleWordActivations(string cmd)
        {
            #region DEBUGGING Printouts
            /*
            foreach (KeyValuePair<string, string> item in CommandDictonary.actionsSingle)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            
            foreach (KeyValuePair<string, string> item in CommandDictonary.actionsConstant)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            */
            #endregion
            if (CommandDictonary.actionsSingle.ContainsKey(cmd))
            {
                #region DEBUGGING Printouts
                /*
                Console.WriteLine();
                Console.WriteLine("Dose the command exist in the CONSTANT command list?");
                Console.WriteLine("CMD (to send) : " + cmd);
                Console.WriteLine(cmd + " : " + CommandDictonary.actionsSingle[cmd]);
                */
                #endregion
                SingleCommands ProcessSingleCommand = new SingleCommands(CommandDictonary.actionsSingle[cmd]);
            }
        }
    }
}

/*
            //private Dictionary<string, string> activeCommands;
            //private Dictionary<string, string> activeNouns;
            //activeCommands = new Dictionary<string, string>(CommandDictonary.GetCommandList()); 
  
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
