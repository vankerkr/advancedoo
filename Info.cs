using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartofTriviaGame
{
    class Info
    {
        public void DisplayInfo(string assignment)
        {
            const string AST = "************************************************************************";

            Console.WriteLine(AST);
            Console.WriteLine();
            Console.WriteLine("Name:\t\tRyan Vankerkvoorde");
            Console.WriteLine("Course:\t\tAdvance OO Programming");
            Console.WriteLine("Instructor:\tMr. Cribb");
            Console.WriteLine("Assignment:\t" + assignment);
            Console.WriteLine("Date:\t\t" + DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine(AST);
        }
    }
}
