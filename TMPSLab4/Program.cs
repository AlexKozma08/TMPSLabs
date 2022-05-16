using System;
using System.Collections.Generic;

namespace TMPSLab4
{
     class Program
     {
          static void Main(string[] args)
          {
               List<Mammals> mammals = new List<Mammals>() {new Human(), new Dog(), new Whale() };
               foreach (var mammal in mammals)
                    Console.WriteLine(mammal.GetName() + " has " + mammal.GetNumberOfLegs().ToString() + " legs");
          }
     }
}
