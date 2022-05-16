using System;

namespace PatternsLab1
{
     public class EnemyElf : IEnemy
     {
          public void Accept(IVisitor visitor)
          {
               visitor.VisitElf(this);
          }

          public void Attack()
          {
               Console.WriteLine("Shoot!");
          }
     }
}
