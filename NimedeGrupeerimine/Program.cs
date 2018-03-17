using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimedeGrupeerimine
{
    class Program
    {
        static void Main()
        {
            string[] arrey = { "Kalle", "Malle", "Mari", "Elmar", "Juku", "Rooberts", "Bob" };

            var vastus = arrey.GroupBy(x => x.Length);

            foreach(var grupp in vastus)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nimed kus on {0} tähte", grupp.Key);
                Console.WriteLine();

                foreach(var nimi in grupp)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}", nimi);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
