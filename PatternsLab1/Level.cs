using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class Level : ILevel
     {
          public string Ambient { get; set; }
          public Locations Location { get; set; }
          public string Landscape { get; set; }
          public string Light { get; set; }
          public Level()
          {

          }
          public Level(Level level)
          {
               this.Ambient = level.Ambient;
               this.Location = level.Location;
               this.Landscape = level.Landscape;
               this.Light = level.Light;
          }
          public Level Clone()
          {
               return new Level(this);
          }

          public Locations GetLevelLocation()
          {
               return Location;
          }

          public string GetLevelAmbient()
          {
               return Ambient;
          }

          public string GetLevelLandscape()
          {
               return Landscape;
          }

          public string GetLevelLight()
          {
               return Light;
          }
     }
}
