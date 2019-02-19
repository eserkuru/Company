using Microsoft.Web.Administration;
using ProjectPublisher.Libraries.Services;
using System;
using System.IO;
using System.Linq;

namespace ProjectPublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your application name?");
            var applicationName = Console.ReadLine();

            Console.WriteLine("Which version do you want to install? v1.01 | v1.02");
            var version = Console.ReadLine();

            var sourceDir = @"D:\GitHub\Company\ProjectPublisher\Source\Project\" + version;
            var destDir = @"C:\inetpub\wwwroot\" + applicationName;

            Console.WriteLine("Publish was started...");

            WebsiteManager.CreateWebsite(applicationName);
            FileManager.DirectoryCopy(sourceDir, destDir, true);

            Console.WriteLine("Publish was completed...");
            Console.ReadLine();

        }

        //private static void WebsiteManager2()
        //{
        //    var server = new ServerManager();
        //    var site = server.Sites.FirstOrDefault(s => s.Name == "companyproject.local");
        //    if (site != null)
        //    {
        //        //stop the site...
        //        Console.WriteLine("Website is stoping...");
        //        site.Stop();
        //        Console.WriteLine("Website was stoped...");
        //        if (site.State == ObjectState.Stopped)
        //        {

        //        }
        //        else
        //        {
        //            throw new InvalidOperationException("Could not stop website!");
        //        }
        //        //restart the site...
        //        Console.WriteLine("Website is starting...");
        //        site.Start();
        //        Console.WriteLine("Website was started...");

        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("Could not find website!");
        //    }
        //}
    }
}
