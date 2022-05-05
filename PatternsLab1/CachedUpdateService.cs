using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class CachedUpdateService : IUpdateService
     {
          private UpdateService service;
          private float CachedVersion;
          private string CachedUpdates;
          public float CurrentVersion = 1.0f;
          public CachedUpdateService(UpdateService service)
          {
               this.service = service;
          }
          public bool CheckForUpdates()
          {
               Console.WriteLine("Looking for the last version...");
               if (CachedVersion == 0)
               {
                    CachedVersion = service.server.GetLatestVersion();
               }
               Console.WriteLine("The last version is " + CachedVersion.ToString());
               return CurrentVersion < CachedVersion; 
          }

          public void GetUpdates()
          {
               if (CachedVersion == 0)
               {
                    CachedVersion = service.server.GetLatestVersion();
               }
               if (CachedUpdates == null)
               {
                    CachedUpdates = service.server.DownloadUpdates();
               }
               Console.WriteLine("Updating game with " + CachedUpdates);
               CurrentVersion = CachedVersion;
          }
     }
}
