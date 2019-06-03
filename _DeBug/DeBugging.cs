using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class DeBugging
    {
        // - Press Any Key - Console Pause
        public static void Exit()
        {
            Console.CursorVisible = false;
            Console.WriteLine("\n*** DEBUGGING - Press Any Key to Exit - DEBUGGING ***");
            Console.ReadKey(true);
        }

        public static void TestSomething()
        {
            // Test AREA Data
            Console.WriteLine(Level.GameWorld[2, 2].Name());
            Console.WriteLine(Level.GameWorld[2, 2].LookDescription());
            foreach (string line in Level.GameWorld[2, 2].Cinamatic())
            {
                Console.WriteLine(line);
            }
            // Test Items in Area
            Console.WriteLine(" <Items> : " + Level.GameWorld[2, 2].ItemList().Count);
            foreach (Items item in Level.GameWorld[2, 2].ItemList())
            {
                Console.WriteLine("   " + item.name);
                Console.WriteLine("     " + item.description_Default);
                Console.WriteLine("     " + item.PickedupAllowed);
                Console.WriteLine("     " + item.getItem_Failed);
            }
            // Test Exits in Area
            Console.WriteLine(" <Exits> : " + Level.GameWorld[2, 2].ExitList().Count);
            foreach (Exit exit in Level.GameWorld[2, 2].ExitList())
            {
                Console.WriteLine("   " + exit.name);
                Console.WriteLine("     " + exit.open);
                Console.WriteLine("     " + exit.look_at_open);
                Console.WriteLine("     " + exit.look_area_open);
            }

            // TEST Command Import
            Console.WriteLine("<Command Imports> : " + CommandDictonary.actionsSingle.Count);
            foreach (KeyValuePair<string, string> item in CommandDictonary.actionsSingle)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            Console.WriteLine("<Constant Imports> : " + CommandDictonary.actionsConstant.Count);
            foreach (KeyValuePair<string, string> item in CommandDictonary.actionsConstant)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }

        /*public static void Test_CommandList()
        {
            Console.WriteLine(CommandDictonary.GetCommandList().Count);
            foreach (KeyValuePair<string, string> item in CommandDictonary.GetCommandList())
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }*/

        public static void Test_Tokenisation()
        {

            Console.WriteLine("\n: Raw Input : ");
            Console.WriteLine(UserInput.GetRawInput());
            Console.WriteLine("\nCleaned Tokens");

            foreach (string line in UserInput.GetCleanedInputTokens())
            {
                Console.WriteLine(line);
            }
            
            Console.WriteLine("\nStemmed Tokens");
            foreach (string line in UserInput.GetStemmedInputTokens())
            {
                Console.WriteLine(line);
            }
        }
    }
}
