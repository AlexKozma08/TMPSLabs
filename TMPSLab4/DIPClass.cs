using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPSLab4
{
     class DIPClass
     {
     }
     /*
     class PostgresqlDB
     {
          public string Connect()
          {
               return "Connected to postgresql database";
          }
     }
     class DataLoader
     {
          private PostgresqlDB database;
          public DataLoader(PostgresqlDB database)
          {
               this.database = database;
          }
     }*/
     interface IDatabaseConnection
     {
          public string Connect();
     }

     class PostgresqlDB : IDatabaseConnection
     {
          public string Connect()
          {
               return "Connected to postgresql database";
          }
     }
     class DataLoader
     {
          private IDatabaseConnection database;
          public DataLoader(IDatabaseConnection database)
          {
               this.database = database;
          }
     }
}
