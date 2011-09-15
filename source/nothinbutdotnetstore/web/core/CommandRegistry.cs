using System;
using System.Linq;
namespace nothinbutdotnetstore.web.core
{
    public class CommandRegistry : ICanFindCommands
    {
        IEnumerable<IProcessARequest> all_commands;

        public CommandRegistry(IEnumerable<IProcessARequest> all_command)
        {
            this.all_commands = all_commands; 
        }


        public IProcessARequest get_the_command_that_can_process(IContainRequestInformation the_request)
        {
            foreach (var command in all_commands)
            {
                if (command == the_request)
                    return command;
            }
           
        }
    }
}