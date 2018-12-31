using Company.Project.DataAccess.Concrete.Contexts;
using System;

namespace PublishDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NearbyContext())
            {
                context.Database.EnsureDeleted();
                Console.WriteLine("Nearby Database was deleted!");

                context.Database.EnsureCreated();
                Console.WriteLine("Nearby Database was created!");
            }

            using (var context = new RemoteContext())
            {
                context.Database.EnsureDeleted();
                Console.WriteLine("Remote Database was deleted!");

                context.Database.EnsureCreated();
                Console.WriteLine("Remote Database was created!");
            }

            Console.ReadLine();
        }
    }
}
