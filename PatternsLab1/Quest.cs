using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     class Quest
     {
          public string name;
          public int reward;
          private QuestState state;
          public Quest(string name, int reward)
          {
               this.name = name;
               this.reward = reward;
               this.state = new OfferedQuest(this);
          }
          public void CheckQuest()
          {
               state.CheckQuest();
          }
          public void StartQuest()
          {
               state.StartQuest();
          }
          public void DeclineQuest()
          {
               state.DeclineQuest();
          }
          public void CompleteQuest()
          {
               state.CompleteQuest();
          }
          public void ChangeState(QuestState state)
          {
               this.state = state;
          }
     }
}
