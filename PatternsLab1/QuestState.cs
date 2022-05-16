using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     abstract class QuestState
     {
          protected Quest quest;
          public QuestState(Quest quest)
          {
               this.quest = quest; 
          }
          abstract public void StartQuest();
          abstract public void DeclineQuest();
          abstract public void CheckQuest();
          abstract public void CompleteQuest();

     }
     class OfferedQuest : QuestState
     {
          public OfferedQuest(Quest quest) : base(quest)
          {

          }
          public override void StartQuest()
          {
               quest.ChangeState(new StartedQuest(quest));
               Console.WriteLine("You started quest: " + quest.name);
          }
          public override void DeclineQuest()
          {
               quest.ChangeState(new FailedQuest(quest));
               Console.WriteLine("You declined quest: " + quest.name);
          }
          public override void CheckQuest()
          {
               Console.WriteLine("The quest - " + quest.name + " will give you - " + quest.reward + " gold");
          }

          public override void CompleteQuest()
          {
               // Does nothing
          }
     }
     class StartedQuest : QuestState
     {
          public StartedQuest(Quest quest) : base(quest)
          {

          }
          public override void StartQuest()
          {
               // Does nothing
          }
          public override void DeclineQuest()
          {
               quest.ChangeState(new FailedQuest(quest));
               Console.WriteLine("You failed quest: " + quest.name);
          }
          public override void CheckQuest()
          {
               Console.WriteLine("Marking quest on the map");
          }

          public override void CompleteQuest()
          {
               quest.ChangeState(new CompletedQuest(quest));
               Console.WriteLine("Completing quest: " + quest.name);
          }
     }
     class CompletedQuest : QuestState
     {
          public CompletedQuest(Quest quest) : base(quest)
          {

          }
          public override void StartQuest()
          {
               // Does nothing
          }
          public override void DeclineQuest()
          {
               // Does nothing
          }
          public override void CheckQuest()
          {
               Console.WriteLine("Marking reward on the map");
          }

          public override void CompleteQuest()
          {
               // Does nothing
          }
     }
     class FailedQuest : QuestState
     {
          public FailedQuest(Quest quest) : base(quest)
          {

          }
          public override void StartQuest()
          {
               quest.ChangeState(new StartedQuest(quest));
               Console.WriteLine("Starting again quest: " + quest.name);
          }
          public override void DeclineQuest()
          {
               // Does nothing
          }
          public override void CheckQuest()
          {
               Console.WriteLine("The quest " + quest.name + " is failed" );
          }

          public override void CompleteQuest()
          {
               // Does nothing
          }
     }
}
