using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     public interface IEnemy
     {
          public void Attack();
          public void Accept(IVisitor visitor);
     }
     public interface IUpdateService
     {
          public bool CheckForUpdates();
          public void GetUpdates();
     }
     public interface IMicrotransactions
     {
          public void Donate(double money);
     }

     public interface ILevel
     {
          public Locations GetLevelLocation();
          public string GetLevelAmbient();
          public string GetLevelLandscape();
          public string GetLevelLight();
     }
     public interface ILevelBuilder
     {
          public void Reset();
          public void SetLocation(Locations location);
          public void SetAmbient(string ambient);
          public void SetLandscape(string landscape);
          public void SetLight(string light);
     }
     public interface IMoving
     {
          public void Move(float x,float y);
     }
     public interface IBossfightCheck
     {
          public IBossfightCheck SetNext(IBossfightCheck handler);
          public object Handle(string request);
     }
     public interface IVisitor
     {
          public void VisitMage(EnemyMage mage);
          public void VisitElf(EnemyElf elf);
          public void VisitDwarf(EnemyDwarf dwarf);
     }
}
