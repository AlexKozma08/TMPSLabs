using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class UpdateManager
     {
          private IUpdateService service;
          public UpdateManager(IUpdateService service)
          {
               this.service = service;
          }
          public void UpdateGame()
          {
               if (service.CheckForUpdates())
               {
                    service.GetUpdates();
               }
          }
     }
}
