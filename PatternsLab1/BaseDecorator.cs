using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab1
{
     abstract class BaseDecorator : IMicrotransactions
     {
          protected IMicrotransactions wrappee;
          public BaseDecorator(IMicrotransactions wrappee)
          {
               this.wrappee = wrappee;
          }
          public virtual void Donate(double money)
          {
               wrappee.Donate(money);
          }
     }
     class VisaDecorator : BaseDecorator
     {
          public VisaDecorator(IMicrotransactions wrappee):base(wrappee)
          { 
          }
          public override void Donate(double money)
          {
               Console.WriteLine("Taking money from Visa card...");
               wrappee.Donate(money);
          }
     }
     class MastercardDecorator : BaseDecorator
     {
          public MastercardDecorator(IMicrotransactions wrappee) : base(wrappee)
          {
          }
          public override void Donate(double money)
          {
               Console.WriteLine("Taking money from Mastercard...");
               wrappee.Donate(money);
          }
     }
     class QiwiDecorator : BaseDecorator
     {
          public QiwiDecorator(IMicrotransactions wrappee) : base(wrappee)
          {
          }
          public override void Donate(double money)
          {
               Console.WriteLine("Taking money from Qiwi wallet...");
               wrappee.Donate(money);
          }
     }
     class WebmoneyDecorator : BaseDecorator
     {
          public WebmoneyDecorator(IMicrotransactions wrappee) : base(wrappee)
          {
          }
          public override void Donate(double money)
          {
               Console.WriteLine("Taking money from Webmoney account...");
               wrappee.Donate(money);
          }
     }
     class SteamDecorator : BaseDecorator
     {
          public SteamDecorator(IMicrotransactions wrappee) : base(wrappee)
          {
          }
          public override void Donate(double money)
          {
               Console.WriteLine("Taking money from Steam wallet...");
               wrappee.Donate(money);
          }
     }
}
