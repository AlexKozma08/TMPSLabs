namespace PatternsLab1
{
     class LevelBuilder : ILevelBuilder
     {
          private Level level;
          public LevelBuilder()
          {
               Reset();
          }
          public void Reset()
          {
               level = new Level();
          }

          public void SetAmbient(string ambient)
          {
               level.Ambient = ambient;
          }

          public void SetLandscape(string landscape)
          {
               level.Landscape = landscape;
          }

          public void SetLight(string light)
          {
               level.Light = light;
          }

          public void SetLocation(Locations location)
          {
               level.Location = location;
          }
          public Level getLevel()
          {
               Level product = level;
               Reset();
               return product;
          }
     }
}
