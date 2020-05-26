using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceStatistics.ExplorerPackage;
using SpaceStatistics.ExplorerPackage.Bots;
using SpaceStatistics.ExplorerPackage.Bots.BotForms;
using SpaceStatistics.GraphPackage.GraphForm;
using SpaceStatistics.SocialNetworkPackage.AccountPackage;
using SpaceStatistics.SocialNetworkPackage.AccountPackage.Tokens;

namespace SpaceStatistics
{
    //Системная консоль для проверки работоспособности
    public class SystemConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            /*  IBot bot = new VkQuizBot();
              Console.WriteLine(bot.BotName);
              Console.WriteLine(bot.SocialNetwork);
           //   Authorization a = new Authorization();
              VkToken t = (VkToken)a.Token;
              Console.WriteLine(t.Name + " " + t.SurName);
              string[] s = new string[] { t.login, t.pass, "25" };
              bot.Start(s);
              Console.WriteLine("END");*/
            QuizForm qf = new QuizForm();
            qf.ShowDialog();
            
            /*  Authorization a = new Authorization();
               VkToken t = (VkToken)a.Token;
               string[] s = new string[] { t.login, t.pass };
               IBot bot = new VkPresentBot();
               Console.WriteLine("START");
               bot.Start(s);
               Console.WriteLine("STOP");*/
           /* GraphForm form = new GraphForm();
            form.ShowDialog();*/
            Console.Read();
        }
    }
}
