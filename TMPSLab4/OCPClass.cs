using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPSLab4
{
     class OCPClass
     {
          public float CalculateCalories(IFood food)
          {
               if (food.GetType() == typeof(Pizza))
                    return 100;
               else if (food.GetType() == typeof(Hamburger))
                    return 75;
               else if (food.GetType() == typeof(Fries))
                    return 50;
               else 
                    return 0;
          }
     }
     public interface IFood
     {
          public float GetCalories();
     }
     class Pizza : IFood
     {
          public float GetCalories()
          {
               return 100;
          }
     }
     class Hamburger : IFood
     {
          public float GetCalories()
          {
               return 75;
          }
     }
     class Fries : IFood
     {
          public float GetCalories()
          {
               return 50;
          }
     }
     class CaloriesCalculator
     {
          public float CalculateCalories(IFood food)
          {
               return food.GetCalories();
          }
     }
}
