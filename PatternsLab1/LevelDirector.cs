namespace PatternsLab1
{
     class LevelDirector
     {
          public void MakeMountainLevel(ILevelBuilder builder)
          {
               builder.Reset();
               builder.SetLocation(Locations.Mountains);
               builder.SetAmbient("Working blacksmith's sounds");
               builder.SetLandscape("Rocks everywhere");
               builder.SetLight("Scorching sunlight");
          }
          public void MakeForestLevel(ILevelBuilder builder)
          {
               builder.Reset();
               builder.SetLocation(Locations.Woods);
               builder.SetAmbient("Animals' sounds");
               builder.SetLandscape("A lot of trees");
               builder.SetLight("Weak sunbeams breaking through the trees");
          }
          public void MakeTowerLevel(ILevelBuilder builder)
          {
               builder.Reset();
               builder.SetLocation(Locations.Tower);
               builder.SetAmbient("Sounds of books, falling off the shelves");
               builder.SetLandscape("A lot of floors with different rooms");
               builder.SetLight("Light from torches and candles");
          }
     }
}
