using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteTrain.Commands
{
    public class ResetCommand : ICommand
    {
        public bool Execute(Train train)
        {
            train.Reset();
            Console.WriteLine("Reseted");
            Console.WriteLine();

            return true;
        }
    }
}
