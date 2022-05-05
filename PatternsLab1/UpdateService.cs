using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class UpdateService : IUpdateService
     {
          public float CurrentVersion = 1.0f;
          public Server server = new Server();
          public bool CheckForUpdates()
          {
               Console.WriteLine("Looking for the last version on server...");
               Console.WriteLine("The last version is " + server.GetLatestVersion().ToString());
               return CurrentVersion < server.GetLatestVersion();
          }

          public void GetUpdates()
          {
               Console.WriteLine("Updating game with " + server.DownloadUpdates());
               CurrentVersion = server.GetLatestVersion();
          }
     }
}
