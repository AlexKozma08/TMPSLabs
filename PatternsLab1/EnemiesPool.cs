using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class EnemiesPool
     {
          private int maxSize;
          private int currentSize = 0;
          private ConcurrentBag<IEnemy> available;
          private EnemyCreator creator;
          private static EnemiesPool instance;
          private EnemiesPool(EnemyCreator creator, int size = 3)
          {
               this.creator = creator;
               maxSize = size;
               available = new ConcurrentBag<IEnemy>();
          }
          private IEnemy Create()
          {
               IEnemy a = creator.SpawnEnemy();
               return a;
          }
          public IEnemy CheckOut()
          {
               IEnemy COObject;
               if (available.TryTake(out COObject))
                    return COObject;
               else if (currentSize < maxSize)
               {
                    COObject = Create();
                    currentSize++;
                    return COObject;
               }
               else
               {
                    Console.WriteLine("The limit of the enemies was reached!");
                    return null;
               }
          }
          public void CheckIn(IEnemy CIObject)
          {
               available.Add(CIObject);
          }
          public static EnemiesPool getInstance(EnemyCreator creator)
          {
               if (instance == null)
                    instance = new EnemiesPool(creator);
               return instance;
          }
     }
}
