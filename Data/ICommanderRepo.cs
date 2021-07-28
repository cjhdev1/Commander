using System.Collections.Generic;
using Commander.Models;
// Interfaces always start with "I"

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}