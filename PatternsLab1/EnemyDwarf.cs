using System;

namespace PatternsLab1
{
     public class EnemyDwarf : IEnemy
     {
          public void Accept(IVisitor visitor)
          {
               visitor.VisitDwarf(this);
          }

          public void Attack()
          {
               Console.WriteLine("Bonk!");
          }
     }
}
