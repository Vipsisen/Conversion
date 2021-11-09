using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion.Classes
{
    public class fel
    {
        public static double Fel()
        {
            Console.WriteLine("Fel inmatning, tryck på valfri tangent för att göra rätt val.");
            Console.ReadKey();
            Lines.Line();
            NewConvert.ConvertAgain();
        }
    }
}
