using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     public interface IEnemy
     {
          public void Attack();
     }
     interface ILevelBuilder
     {
          public void Reset();
          public void SetLocation(Locations location);
          public void SetAmbient(string ambient);
          public void SetLandscape(string landscape);
          public void SetLight(string light);
     }
}
