using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPublisher.Libraries.Services
{
    public static class WebsiteManager
    {
        public static void CreateWebsite(string name, int port = 80)
        {
            string strhostname = name + ".local";
            string stripaddress = "*";
            string bindinginfo = stripaddress + ":80:" + strhostname;

            ServerManager serverManager = new ServerManager();

            Site site = serverManager.Sites.Add(name, "http", bindinginfo, @"C:\inetpub\wwwroot\" + name);

            serverManager.ApplicationPools.Add(name);

            site.ApplicationDefaults.ApplicationPoolName = name;
            site.TraceFailedRequestsLogging.Enabled = true;
            site.TraceFailedRequestsLogging.Directory = @"C:\inetpub\wwwroot\" + name;

            site.ServerAutoStart = true;
            serverManager.CommitChanges();
        }
    }
}
