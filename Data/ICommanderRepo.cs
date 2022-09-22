using System.IO.MemoryMappedFiles;
using System.Reflection;
using System.Collections.Generic;
using Commander.Models;

//'Data' is our repository
namespace Commander.Data
{
    //Interface class.
    //It shows the CRUD functionalities
    public interface ICommanderRepo
    {
        //every time you make change via dbcontext, the data won't be changed in db unless you use SaveChanges()
        bool SaveChanges();


        //All commands
        IEnumerable<Command> GetAllCommands();

        // Command as provided by ID
        Command GetCommandById(int id);

        //POST 
        void CreateCommand(Command cmd);

        //PUT
        void UpdateCommand(Command cmd);

        //DELETE
        void DeleteCommand(Command cmd);
    }
}