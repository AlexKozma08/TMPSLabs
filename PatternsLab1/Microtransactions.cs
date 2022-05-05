using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class Microtransactions : IMicrotransactions
     {
          public int XPMultiplier;
          public void Donate(double money)
          {
               if (money == 2.00)
                    XPMultiplier = 2;
               else if (money == 5.00)
                    XPMultiplier = 5;
               else if (money == 10.00)
                    XPMultiplier = 10;
          }
     }
}
