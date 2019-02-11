using Company.Manager.DataAccess.Concrete.Contexts;
using Company.Project.DataAccess.Concrete.Contexts;
using System;

namespace DatabaseCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ManagerContext())
            {
                //context.Database.EnsureDeleted();
                //Console.WriteLine("Manager Database was deleted!");

                context.Database.EnsureCreated();
                Console.WriteLine("Manager Database was created!");
            }

            using (var context = new ProjectContext())
            {
                //context.Database.EnsureDeleted();
                //Console.WriteLine("Project Database was deleted!");

                context.Database.EnsureCreated();
                Console.WriteLine("Project Database was created!");
            }

            Console.ReadLine();
        }
    }
}
