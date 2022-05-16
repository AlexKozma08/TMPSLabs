using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class MovingContext 
     {
          private IMoving movingStrategy;
          public void setStrategy(IMoving strategy)
          {
               this.movingStrategy = strategy;
          }
          public void Move(float x, float y)
          {
               movingStrategy.Move(x,y);
          }
     }
     class MoveOnFeet : IMoving
     {
          public void Move(float x,float y)
          {
               Console.WriteLine("Moving slowly on feet toward coordinates: x = " + x.ToString() + ", y = " + y.ToString());
          }
     }
     class MoveOnMount : IMoving
     {
          public void Move(float x, float y)
          {
               Console.WriteLine("Calling the mount");
               Console.WriteLine("Moving fast on mount toward coordinates: x = " + x.ToString() + ", y = " + y.ToString());
          }
     }
     class MoveViaTeleport : IMoving
     {
          public void Move(float x, float y)
          {
               Console.WriteLine("Reading teleportation scroll");
               Console.WriteLine("Moving immediatly on coordinates: x = " + x.ToString() + ", y = " + y.ToString());
          }
     }
}
