using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg1", Line="Boil water1", Platform="Kettle and Pan1"},
                new Command{Id=1, HowTo="Boil an egg2", Line="Boil water2", Platform="Kettle and Pan2"},
                new Command{Id=2, HowTo="Boil an egg3", Line="Boil water3", Platform="Kettle and Pan3"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg0", Line="Boil water0", Platform="Kettle and Pan0"};
        }
    }
}