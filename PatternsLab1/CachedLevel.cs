using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class CachedLevel : ILevel
     {
          private ILevel level;
          private string ambient;
          private string light;
          private string landscape;
          private Locations location;
          public string GetLevelAmbient()
          {
               throw new NotImplementedException();
          }

          public string GetLevelLandscape()
          {
               throw new NotImplementedException();
          }

          public string GetLevelLight()
          {
               throw new NotImplementedException();
          }

          public Locations GetLevelLocation()
          {
               throw new NotImplementedException();
          }
     }
}
