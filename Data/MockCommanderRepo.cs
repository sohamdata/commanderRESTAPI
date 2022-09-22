//Mock Repository, not used in db

using System.Collections.Generic;
using Commander.Models;


//Data = repository
namespace Commander.Data
{
    // Decoupling code
    //Implementing ICommanderRepo interface
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
                //mock data
                // {}: objects
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Cut Bread", Line="Get knife", Platform="Table"},
                new Command{Id=2, HowTo="Make tea", Line="Place Teabag", Platform="Kettle cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            //mock data
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
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