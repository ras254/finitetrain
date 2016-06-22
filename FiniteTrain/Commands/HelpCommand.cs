using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteTrain.Commands
{
    public class HelpCommand : ICommand
    {
        public bool Execute(Train train)
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("\tchange");
            Console.WriteLine("\tcheck N");
            Console.WriteLine("\texit");
            Console.WriteLine("\thelp");
            Console.WriteLine("\tmove +/-N");
            Console.WriteLine("\treset");
            Console.WriteLine("\tstate");
            Console.WriteLine();

            return true;
        }
    }
}
