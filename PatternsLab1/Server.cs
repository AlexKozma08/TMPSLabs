using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class Server
     {
          private const string Ip = "95.138.118.56";
          private const string Port = "12345";
          private const string Username = "User1";
          private const string Password = "Pass1";
          private bool ConnectToServer()
          {
               Console.WriteLine("Establishing connection to the server " + Ip + ":" + Port + " as " + Username);
               if (Password == "Pass1")
               {
                    Thread.Sleep(2000);
                    Console.WriteLine("Connected successfully");
                    return true;
               }
               else
               {
                    Console.WriteLine("Connection failed!");
                    return false;
               }
          }
          public float GetLatestVersion()
          {
               if (ConnectToServer())
               {
                    Thread.Sleep(500);
                    return 2.0f;
               }
               return 1.0f;
          }
          public string DownloadUpdates()
          {
               if (ConnectToServer())
               {
                    Console.WriteLine("Downloading updates...");
                    Thread.Sleep(5000);
                    Console.WriteLine("Updates have been downloaded");
                    return "Some updated data";
               }
               return "";
          }
     }
}
