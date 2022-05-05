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
               else 
                    pool = EnemiesPool.getInstance(new MageEnemyCreator());
               LookAround(level);
               /*GameSaver gameSaver = new GameSaver(new GameStateRecorder(), new SteamCloudSynchronizer());
               gameSaver.SaveGame("c:\\saves.xml");*/
               /*IEnemy enemy1 = pool.CheckOut();
               IEnemy enemy2 = pool.CheckOut();
               IEnemy enemy3 = pool.CheckOut();
               pool.CheckIn(enemy1);
               IEnemy enemy4 = pool.CheckOut();
               enemy2.Attack();
               enemy3.Attack();
               enemy4.Attack();*/
               /*UpdateService updateService = new UpdateService();
               CachedUpdateService cachedUpdateService = new CachedUpdateService(updateService);
               UpdateManager updateManager = new UpdateManager(cachedUpdateService);
               updateManager.UpdateGame();
               updateManager.UpdateGame();*/
               /*BaseDecorator steam = new SteamDecorator(new Microtransactions());
               steam.Donate(10);*/
          }
          static Level InitializeLevel()
          {
               LevelBuilder builder = new LevelBuilder();
               LevelDirector director = new LevelDirector(builder);
               director.MakeForestLevel();
               director.ChangeLocation(Locations.Tower);
               director.MuteAmbient();
               director.FlatEarth();
               director.MakeItDark();
               return builder.getLevel();
          }
          static void LookAround(Level level)
          {
               Console.WriteLine("You appear in " + level.Location + " with " + level.Landscape + " and " + level.Light + ".You hear " + level.Ambient);
          }
     }
}
