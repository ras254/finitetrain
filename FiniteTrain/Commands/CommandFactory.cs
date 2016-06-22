using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteTrain.Commands
{
    public class CommandFactory
    {
        public static ICommand Create(String cmd)
        {
            var args = cmd.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            switch (args[0].ToLowerInvariant())
            {
                case "change":
                    return new ChangeCommand();

                case "check":
                    return IntCommand(args, i => new CheckCommand(i));

                case "exit":
                    return new ExitCommand();

                case "help":
                    return new HelpCommand();

                case "move":
                    return IntCommand(args, i => new MoveCommand(i));

                case "reset":
                    return new ResetCommand();

                case "state":
                    return new StateCommand();

                default:
                    return WrongCommand();
            }
        }

        private static ICommand IntCommand(String[] args, Func<int, ICommand> intCommand)
        {
            if (args.Length < 2)
                return WrongCommand();

            int iArg;

            if (Int32.TryParse(args[1], out iArg))
                return intCommand(iArg);
            else
                return WrongCommand();
        }

        private static ICommand WrongCommand()
        {
            Console.WriteLine("Wrong command or paramters");
            Console.WriteLine();
            return new HelpCommand();
        }
    }

}
