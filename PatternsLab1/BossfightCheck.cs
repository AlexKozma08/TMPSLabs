using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     abstract class BossfightCheck : IBossfightCheck
     {
          private IBossfightCheck nextHandler;
          public virtual object Handle(string request)
          {
               if (this.nextHandler != null)
                    return this.nextHandler.Handle(request);
               else
                    return null;
          }

          public IBossfightCheck SetNext(IBossfightCheck handler)
          {
               this.nextHandler = handler;
               return handler;
          }
     }
     class LevelCheck : BossfightCheck
     {
          public override object Handle(string request)
          {
               if (request == "low level")
                    return "You should get more experience before facing the boss!";
               else
                    return base.Handle(request);
          }
     }
     class HealthCheck : BossfightCheck
     {
          public override object Handle(string request)
          {
               if (request == "low HP")
                    return "You should get healed before facing the boss!";
               else
                    return base.Handle(request);
          }
     }
     class EquipmentCheck : BossfightCheck
     {
          public override object Handle(string request)
          {
               if (request == "broken equipment")
                    return "You should repair your equipment before facing the boss!";
               else
                    return base.Handle(request);
          }
     }
}
