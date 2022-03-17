using System;
using System.Collections.Concurrent;

namespace PatternsLab1
{
     class Program
     {
          static void Main(string[] args)
          {
               Level level = InitializeLevel();
               EnemiesPool pool;
               if (level.Location == Locations.Woods)
                    pool = EnemiesPool.getInstance(new ElfEnemyCreator());
               else if (level.Location == Locations.Mountains)
                    pool = EnemiesPool.getInstance(new DwarfEnemyCreator());
               else //if (level.Location == Locations.Tower)
                    pool = EnemiesPool.getInstance(new MageEnemyCreator());
               LookAround(level);
               IEnemy enemy1 = pool.CheckOut();
               IEnemy enemy2 = pool.CheckOut();
               IEnemy enemy3 = pool.CheckOut();
               pool.CheckIn(enemy1);
               IEnemy enemy4 = pool.CheckOut();
               enemy1.Attack();
               enemy2.Attack();
               enemy3.Attack();
               enemy4.Attack();
          }
          static Level InitializeLevel()
          {
               LevelDirector director = new LevelDirector();
               LevelBuilder builder = new LevelBuilder();
               director.MakeForestLevel(builder);
               return builder.getLevel();
          }
          static void LookAround(Level level)
          {
               Console.WriteLine("You appear in " + level.Location + " with " + level.Landscape + " and " + level.Light + ".You hear " + level.Ambient);
          }
     }
}
