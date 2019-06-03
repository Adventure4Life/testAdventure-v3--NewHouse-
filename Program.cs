using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine.Initilise();
            /*Engine.StartScreen();

            while (GameState.GameHasNotEnded())
            {
                Engine.PlayGame();
                DeBugging.TestSomething();
            }*/

            // Debugging
            DeBugging.TestSomething();
            DeBugging.Exit();
        }
    }
}
