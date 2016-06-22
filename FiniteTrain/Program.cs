using FiniteTrain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            var train = new Train();
            ICommand cmd;

            train.Reset();
            new HelpCommand().Execute(train);

            do
            {
                cmd = CommandFactory.Create(Console.ReadLine());
            }
            while (cmd.Execute(train));

            Console.ReadLine();
        }
    }

    public static class Extensions
    {
        public static bool RandomBool(this Random rnd)
        {
            return rnd.Next(2) == 1;
        }
    }
}
