using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartofTriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Info inf = new Info();
            inf.DisplayInfo("Assignment 1");

            TriviaUI theUI = new TriviaUI();
            theUI.Play();

        }
    }
}
