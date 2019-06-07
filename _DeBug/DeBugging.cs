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
            UserInput.AnyKeyContinue();
        }

        public static void TestSomething()
        {
            Console.WriteLine(Player.PosX+", "+ Player.PosY);
            // Test AREA Data
            Console.WriteLine(Level.GameWorld[Player.PosX, Player.PosY].Name());
            Console.WriteLine(Level.GameWorld[Player.PosX, Player.PosY].LookDescription());
            foreach (string line in Level.GameWorld[Player.PosX, Player.PosY].Cinamatic())
            {
                Console.WriteLine(line);
            }
            // Test Items in Area
            Console.WriteLine(" <Items> : " + Level.GameWorld[Player.PosX, Player.PosY].ItemList().Count);
            foreach (Items item in Level.GameWorld[Player.PosX, Player.PosY].ItemList())
            {
                Console.WriteLine("   " + item.name);
                Console.WriteLine("     " + item.description_Default);
                Console.WriteLine("     " + item.PickedupAllowed);
                Console.WriteLine("     " + item.getItem_Failed);
            }
            // Test Exits in Area
            Console.WriteLine(" <Exits> : " + Level.GameWorld[Player.PosX, Player.PosY].ExitList().Count);
            foreach (Exit exit in Level.GameWorld[Player.PosX, Player.PosY].ExitList())
            {
                Console.WriteLine("   " + exit.name);
                Console.WriteLine("     " + exit.open);
                Console.WriteLine("     " + exit.look_at_exit);
                Console.WriteLine("     " + exit.move_Through_exit);
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
