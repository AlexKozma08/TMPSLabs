using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPSLab4
{
     class SRPClass
     {
          public float ConvertFahToCel(float temp)
          {
               return (temp - 32) * 5 / 9;
          }
          public float ConvertCelToFah(float temp)
          {
               return temp * 9 / 5 + 32;
          }
          public string DeleteSpaces(string str)
          {
               return str.Replace(" ","");
          }
     }
     class TemperatureConverter
     {
          public float ConvertFahToCel(float temp)
          {
               return (temp - 32) * 5 / 9;
          }
          public float ConvertCelToFah(float temp)
          {
               return temp * 9 / 5 + 32;
          }
     }
     class StringFormatter
     {
          public string DeleteSpaces(string str)
          {
               return str.Replace(" ", "");
          }
     }
}
