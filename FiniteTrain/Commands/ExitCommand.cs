using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteTrain.Commands
{
    public class ExitCommand : ICommand
    {
        public bool Execute(Train train)
        {
            Console.WriteLine("Bye");
            Console.WriteLine();

            return false; // exit from do-while
        }
    }
}
