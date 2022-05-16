using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPSLab4
{
     class ISPClass
     {
     }
     /*
     interface IWeapon
     {
          public void Shoot();
          public void Throw();
     }
     class Grenade : IWeapon
     {
          public void Shoot()
          {
               // Impossible to shoot from grenade
          }

          public void Throw()
          {
               Console.WriteLine("Throwing grenade");
          }
     }

     class Gun : IWeapon
     {
          public void Shoot()
          {
               Console.WriteLine("Shooting from gun");
          }

          public void Throw()
          {
               Console.WriteLine("Throwing gun");
          }
     }*/

     interface IThrowable
     {
          public void Throw();
     }
     interface IShootable
     {
          public void Shoot();
     }
     class Grenade : IThrowable
     {
          public void Shoot()
          {
               // Impossible to shoot from grenade
          }

          public void Throw()
          {
               Console.WriteLine("Throwing grenade");
          }
     }

     class Gun : IShootable, IThrowable
     {
          public void Shoot()
          {
               Console.WriteLine("Shooting from gun");
          }

          public void Throw()
          {
               Console.WriteLine("Throwing gun");
          }
     }
}
