using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteTrain.Commands
{
    public class StateCommand : ICommand
    {
        public bool Execute(Train train)
        {
            Console.WriteLine("Lights: " + train.Current.IsTurnedOn);
            Console.WriteLine();

            return true;
        }
    }
}
