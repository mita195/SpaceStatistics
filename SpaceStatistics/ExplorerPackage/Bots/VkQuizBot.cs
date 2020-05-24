using SpaceStatistics.SocialNetworkPackage.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace SpaceStatistics.ExplorerPackage.Bots
{
    public class VkQuizBot : IBot
    {
        public SocialNetworkEnum SocialNetwork { get { return SocialNetworkEnum.Vk; } }

        public string BotName { get; set; }

        public bool IsLoaded { get; }

        public VkQuizBot()
        {
            IsLoaded = false;
            BotName = "Викторина";
        }
        public string Start(string[] command)
        {
            string bot = ExtractBot.Extract("QuizBot");
            using(StreamWriter sw = new StreamWriter("commandFileQuizBot.op"))
            {
                foreach(string st in command)
                {
                    sw.WriteLine(st);
                }
                sw.Close();
            }
            Process p = new Process();
            p.StartInfo.FileName = bot;
            p.Start();
            while(!p.HasExited)
            {
                Thread.Sleep(100);
            }
            File.Delete(bot);
            return "usersvoite.txt";
        }
    }
}
