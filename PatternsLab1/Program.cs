using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace PatternsLab1
{
     class Program
     {
          static void Main(string[] args)
          {
               Level level = InitializeLevel();
               EnemiesPool pool;
               FightingLogic fight;
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

               //////////////// Template Method //////////////////

               /*if (level.Location == Locations.Woods)
                    fight = new FightingElf(pool.CheckOut());
               else if (level.Location == Locations.Mountains)
                    fight = new FightingDwarf(pool.CheckOut());
               else
                    fight = new FightingMage(pool.CheckOut());
               fight.Fight();*/

               //////////////// Strategy //////////////////

               /*MovingContext context = new MovingContext();
               context.setStrategy(new MoveOnFeet());
               context.Move(100, 100);
               context.setStrategy(new MoveOnMount());
               context.Move(200, 200);
               context.setStrategy(new MoveViaTeleport());
               context.Move(300, 300);*/

               //////////////// State //////////////////

               /*Quest quest = new Quest("Save the world", 1000);
               quest.CheckQuest();
               quest.StartQuest();
               quest.CheckQuest();
               quest.DeclineQuest();
               quest.CheckQuest();
               quest.StartQuest();
               quest.CompleteQuest();
               quest.CheckQuest();*/

               //////////////// Chain of Responsability //////////////////

               /*BossfightCheck levelCheck = new LevelCheck();
               BossfightCheck healthCheck = new HealthCheck();
               BossfightCheck equipmentCheck = new EquipmentCheck();
               levelCheck.SetNext(healthCheck).SetNext(equipmentCheck);
               string result = (string)levelCheck.Handle("broken equipment");
               Console.WriteLine(result ?? "You are ready to fight the boss!");*/

               //////////////// Visitor //////////////////

               /*List<IEnemy> defeatedEnemies = new List<IEnemy>() {new EnemyMage(), new EnemyDwarf(), new EnemyMage(), new EnemyElf(), new EnemyDwarf() };
               IVisitor visitor = new LootVisitor();
               foreach (var enemy in defeatedEnemies)
                    enemy.Accept(visitor);*/
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
