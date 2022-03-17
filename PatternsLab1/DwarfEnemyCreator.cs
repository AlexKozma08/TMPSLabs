namespace PatternsLab1
{
     class DwarfEnemyCreator : EnemyCreator
     {
          public override IEnemy SpawnEnemy()
          {
               return new EnemyDwarf();
          }
     }
}
