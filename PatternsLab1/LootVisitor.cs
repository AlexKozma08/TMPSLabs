using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class LootVisitor : IVisitor
     {
          Random rand = new Random();
          int rewardGold;
          public void VisitDwarf(EnemyDwarf enemy)
          {
               rewardGold = rand.Next(10, 50);
               Console.WriteLine("Enemy drops weapons, ores and " + rewardGold.ToString() + " gold");
          }

          public void VisitElf(EnemyElf enemy)
          {
               rewardGold = rand.Next(50, 100);
               Console.WriteLine("Enemy drops bows, herbs and " + rewardGold.ToString() + " gold");
          }

          public void VisitMage(EnemyMage enemy)
          {
               rewardGold = rand.Next(100, 150);
               Console.WriteLine("Enemy drops staffs, potions and " + rewardGold.ToString() + " gold");
          }
     }
}
