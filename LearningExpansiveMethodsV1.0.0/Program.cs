using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExpansiveMethodsV1._0._0
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdinaryHuman steve = new OrdinaryHuman(185);
            Console.WriteLine(steve.BreakWalls(89.2)); // even if steve is OrdinaryHuman object from sealed class, we are able to expansive his methods like BreakWalls which is not included in his class. It's epic!
            Console.ReadKey();
        }
    }
}
