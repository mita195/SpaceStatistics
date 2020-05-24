using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceStatistics.ExplorerPackage;
using SpaceStatistics.ExplorerPackage.Bots;

namespace SpaceStatistics
{
    public class SystemConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            IBot bot = new VkQuizBot();
            Console.WriteLine(bot.BotName);
            Console.WriteLine(bot.SocialNetwork);
            bot.Start(new string[]{ "+79081323492", "figo86", "25"});
            Console.WriteLine("END");
            Console.Read();
        }
    }
}
