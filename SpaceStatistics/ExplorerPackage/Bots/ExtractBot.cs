using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpaceStatistics.ExplorerPackage.Bots
{
    internal static class ExtractBot
    {
        private static string GetName()
        {
            string botName = string.Empty;
            int num = 1;
            while(File.Exists(botName+num.ToString()+".py"))
            {
                num++;
            }
            return botName + num.ToString() + ".py";
        }
        public static string Extract(string BotName)
        {
            byte[] bot;
            switch(BotName)
            {
                case "QuizBot": bot = ResourceBots.QuizBot;
                    break;
                default: return null;
            }
            string name = GetName();
            File.WriteAllBytes(name, bot);
            return name;
        }
    }
}
