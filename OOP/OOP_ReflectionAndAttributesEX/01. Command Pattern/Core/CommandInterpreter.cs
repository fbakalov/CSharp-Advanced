
using CommandPattern.Core.Contracts;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] arguments = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string commandName = arguments[0];

            string[] commandArgs = arguments.Skip(1).ToArray();

            Type commandType = Assembly
                .GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{commandName}Command");

            if (commandType is null)
            {
                throw new InvalidOperationException("Command not found");
            }

            ICommand commandInstance = 
                (ICommand)Activator.CreateInstance(commandType);

            string result = commandInstance.Execute(commandArgs);

            return result.ToString();
        }
    }
}
