using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteTrain.Commands
{
    public class CheckCommand : ICommand
    {
        private int _count;

        public CheckCommand(int count)
        {
            _count = count;
        }

        public bool Execute(Train train)
        {
            Console.WriteLine(String.Format("Check {0}: {1}", _count, train.Count == _count));
            Console.WriteLine();

            return true;
        }
    }
}
