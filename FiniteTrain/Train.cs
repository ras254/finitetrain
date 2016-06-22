using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteTrain
{
    public class Train : List<Carriage>
    {
        private int _currentIndex = 0;

        public void Reset()
        {
            var rnd = new Random((int)DateTime.UtcNow.Ticks);
            var carCount = rnd.Next(2, 26);            

            for (int i = 0; i < carCount; i++)
            {
                Add(new Carriage() { IsTurnedOn = rnd.RandomBool() });
            }
        }

        public Carriage Current
        {
            get { return this[_currentIndex]; }
        }

        public Carriage Next(int count)
        {
            _currentIndex = (_currentIndex + count) % Count;
            return this[_currentIndex];
        }

        public Carriage Previous(int count)
        {
            _currentIndex -= count;

            while (_currentIndex < 0)
                _currentIndex += Count;

            return this[_currentIndex];
        }
    }
}
