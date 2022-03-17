namespace PatternsLab1
{
     class ElfEnemyCreator : EnemyCreator
     {
          public override IEnemy SpawnEnemy()
          {
               return new EnemyElf();
          }
     }
}
