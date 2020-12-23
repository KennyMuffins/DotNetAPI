using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "How to Code Core API", Line = "Code API", Platform = "NET CORE" },
                new Command { Id = 1, HowTo = "How to Code Core API 1 ", Line = "Code API 1", Platform = "NET CORE 1" },
                new Command { Id = 2, HowTo = "How to Code Core API 2", Line = "Code API 2", Platform = "NET CORE 2" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "How to Code Core API", Line = "Code API", Platform = "NET CORE" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}