using System;

namespace PatternsLab1
{
     public class EnemyMage : IEnemy
     {
          public void Accept(IVisitor visitor)
          {
               visitor.VisitMage(this);
          }

          public void Attack()
          {
               Console.WriteLine("Avada Kedavra!");
          }
     }
}
