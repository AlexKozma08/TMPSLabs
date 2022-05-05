namespace PatternsLab1
{
     class LevelDirector
     {
          private ILevelBuilder builder;
          public LevelDirector(ILevelBuilder builder)
          {
               this.builder = builder;
          }
          public void MakeMountainLevel()
          {
               builder.Reset();
               builder.SetLocation(Locations.Mountains);
               builder.SetAmbient("Working blacksmith's sounds");
               builder.SetLandscape("Rocks everywhere");
               builder.SetLight("Scorching sunlight");
          }
          public void MakeForestLevel()
          {
               builder.Reset();
               builder.SetLocation(Locations.Woods);
               builder.SetAmbient("Animals' sounds");
               builder.SetLandscape("A lot of trees");
               builder.SetLight("Weak sunbeams breaking through the trees");
          }
          public void MakeTowerLevel()
          {
               builder.Reset();
               builder.SetLocation(Locations.Tower);
               builder.SetAmbient("Sounds of books, falling off the shelves");
               builder.SetLandscape("A lot of floors with different rooms");
               builder.SetLight("Light from torches and candles");
          }
          public void ChangeLocation(Locations location)
          {
               builder.SetLocation(location);
          }
          public void MuteAmbient()
          {
               builder.SetAmbient("nothing at all");
          }
          public void FlatEarth()
          {
               builder.SetLandscape("nothing bothering your view");
          }
          public void MakeItDark()
          {
               builder.SetLight(" you can't see a damn thing");
          }
     }
}
