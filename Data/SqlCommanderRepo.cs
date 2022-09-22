using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

// Actual repo

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        //instance of DB context class
        private readonly CommanderContext _context;

        //Constructor injection
        // context: db data
        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {

            return _context.Commands.ToList();  //list of all commands of our db
        }

        public Command GetCommandById(int id)
        {
            //FirstOrDefault = C# LINQ command (first member where the id matches)
            return _context.Commands.FirstOrDefault(p => p.Id == id); 
        }
        
        //adds a command obj to our _context db, saving is needed afterwards
        public void CreateCommand(Command cmd)
        {
            if(cmd == null){
                throw new ArgumentNullException(nameof(cmd));
            }
            
            _context.Commands.Add(cmd);
        }

        //every time you make change via dbcontext, the data won't be changed in db unless you use SaveChanges()
        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0 );
        }

        //PUT endpoint
        public void UpdateCommand(Command cmd)
        {
            //Nothing!
        }

        //DELETE endpoint (no need DTO)
        public void DeleteCommand(Command cmd)
        {
            if(cmd == null){
                throw new ArgumentNullException(nameof(cmd));
            }
            
            //remove selected command model
            _context.Commands.Remove(cmd);
        }
    }
}