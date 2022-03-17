namespace PatternsLab1
{
     class MageEnemyCreator : EnemyCreator
     {
          public override IEnemy SpawnEnemy()
          {
               return new EnemyMage();
          }
     }
}
