using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteTrain.Commands
{
    public class MoveCommand : ICommand
    {
        private int _count;

        public MoveCommand(int count)
        {
            _count = count;
        }

        public bool Execute(Train train)
        {
            if (_count >= 0)
                train.Next(_count);
            else
                train.Previous(-_count);

            return new StateCommand().Execute(train);
        }
    }
}
