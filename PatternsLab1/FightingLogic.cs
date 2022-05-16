using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     abstract class FightingLogic
     {
          IEnemy enemy;
          public FightingLogic(IEnemy enemy)
          {
               this.enemy = enemy;
          }
          public void Fight()
          {
               Attack();
               UseSkill();
               Heal();
               MakeDefense();
          }
          public void Attack()
          {
               enemy.Attack();
          }
          abstract public void UseSkill();
          abstract public void Heal();
          abstract public void MakeDefense();

     }
     class FightingMage : FightingLogic
     {
          public FightingMage(IEnemy enemy):base(enemy)
          {

          }
          public override void UseSkill()
          {
               Console.WriteLine("Casting some spells");
          }
          public override void Heal()
          {
               Console.WriteLine("Using potions to heal");
          }
          public override void MakeDefense()
          {
               
          }

     }
     class FightingElf : FightingLogic
     {
          public FightingElf(IEnemy enemy) : base(enemy)
          {

          }
          public override void UseSkill()
          {
               
          }
          public override void Heal()
          {
               Console.WriteLine("Eating herbs to heal");
          }
          public override void MakeDefense()
          {
               Console.WriteLine("Hiding behind trees");
          }

     }
     class FightingDwarf : FightingLogic
     {
          public FightingDwarf(IEnemy enemy) : base(enemy)
          {

          }
          public override void UseSkill()
          {
               Console.WriteLine("Taunting the opponent");
          }
          public override void Heal()
          {
               
          }
          public override void MakeDefense()
          {
               Console.WriteLine("Raising shields");
          }

     }
}
