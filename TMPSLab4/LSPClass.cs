using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPSLab4
{
     class LSPClass
     {

     }
     class Mammals
     {
          public virtual string GetName()
          {
               return "Mammal";
          }
          public virtual int? GetNumberOfLegs()
          {
               return 4;
          }

     }
     class Human : Mammals
     {
          public override string GetName()
          {
               return "Human";
          }
          public override int? GetNumberOfLegs()
          {
               return 2;
          }

     }
     class Dog : Mammals
     {
          public override string GetName()
          {
               return "Dog";
          }
          public override int? GetNumberOfLegs()
          {
               return 4;
          }

     }
     class Whale : Mammals
     {
          public override string GetName()
          {
               return "Whale";
          }
          public override int? GetNumberOfLegs()
          {
               return null;
          }

     }
     /*class Whale : Mammals
     {
     public virtual string GetName()
          {
               return "Whale";
          }
          public override int? GetNumberOfLegs()
          {
               return 0;
          }

     }*/
}
