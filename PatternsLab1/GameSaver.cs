using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class GameSaver
     {
          public GameStateRecorder recorder;
          public SteamCloudSynchronizer synchronizer;
          public GameSaver(GameStateRecorder recorder, SteamCloudSynchronizer synchronizer)
          {
               this.recorder = recorder;
               this.synchronizer = synchronizer;
          }
          public void SaveGame(string filePath,string data)
          {
               Console.WriteLine("Saving game to " + filePath);
               synchronizer.SynchronizeWithSteam(data);
               Console.WriteLine("Synchronization was done");
          }
     }
     class XMLToJSONAdapter : XMLSerializer
     {
          public GameSaver adaptee;
          public XMLToJSONAdapter(GameSaver adaptee)
          {
               this.adaptee = adaptee;
          }
          public void SaveGame(string filePath,string data) 
          {
               string xml,newdata;
               xml = XMLSerialize(adaptee.recorder.GetGameState() + adaptee.recorder.GetPlayerState());
               newdata = ConvertToJSON(xml);
               adaptee.SaveGame(filePath, newdata);
          }
          public string ConvertToJSON(string xml)
          {
               return xml + "Converted to JSON";
          }
     }

     class GameStateRecorder
     {
          public string GetGameState() 
          {
               return "Info about locations, quests, time, events";
          }
          public string GetPlayerState()
          {
               return "Info about player coordinates, inventory, level, parameters";
          }
     }
     class XMLSerializer
     {
          /*A lot of methods*/
          public string XMLSerialize(string data)
          {
               Console.WriteLine("Serializing data in XML...");
               return "<?xml version=\"1.0\"?>\n<data>" + data + "</data>";
          }
     }
     class SteamCloudSynchronizer
     {
          /*Connection to Steam Cloud*/
          public void SynchronizeWithSteam(string data)
          {
               Console.WriteLine("Moving saves to Steam Cloud...");
          }
     }
}
