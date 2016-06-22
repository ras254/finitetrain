using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteTrain.Commands
{
    public class ChangeCommand : ICommand
    {
        public bool Execute(Train train)
        {
            var car = train.Current;

            car.IsTurnedOn = !car.IsTurnedOn;

            return new StateCommand().Execute(train);
        }
    }
}
