using System;
using Windows.UI.Notifications;
using CommandLine;
using notif;
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications;

namespace Noti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<MiCommand>(args).WithParsed<MiCommand>(opt =>
            {
                RunProgram(opt);
            }).WithNotParsed(errors => HandleParsingErrors(errors));        }

        static void RunProgram(MiCommand options)
        {
            /* var xml= ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText01);
              //var text = xml.GetElementsByTagName("text");
              var text = xml.GetElementsByTagName("text");
              text[0].AppendChild(xml.CreateTextNode(options.Body));
              var toast = new ToastNotification(xml);

              ToastNotificationManager.CreateToastNotifier(options.Head).Show(toast);*/



            new ToastContentBuilder()
     .AddArgument("action", "viewConversation")
     .AddArgument("conversationId", 9813)
     .AddText(options.Head)
     .AddText(options.Body)
     .Show();
        }

        static void HandleParsingErrors(IEnumerable<Error> errors)
        {
            Console.WriteLine("Errors: " +  errors);    
        }
    }
}