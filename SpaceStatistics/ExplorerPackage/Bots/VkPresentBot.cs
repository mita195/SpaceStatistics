using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SpaceStatistics.SocialNetworkPackage.Elements;

namespace SpaceStatistics.ExplorerPackage.Bots
{
    public class VkPresentBot : IBot
    {
        public SocialNetworkEnum SocialNetwork { get; }

        public string BotName { get; set; }
        public VkPresentBot()
        {
            BotName = "Поздравление";
        }

        public string Start(string[] command)
        {
            //достаем бота из ресурсов
            string bot = ExtractBot.Extract("PresentBot");
            //создаем файлов настроек
            using (StreamWriter sw = new StreamWriter("present.op"))
            {
                foreach (string st in command)
                {
                    sw.WriteLine(st);
                }
                sw.Close();
            }
            //запускаем скрипт
            Process p = new Process();
            p.StartInfo.FileName = bot;
            p.Start();
            //ждем пока не закончится
            while (!p.HasExited)
            {
                Thread.Sleep(100);
            }
            //удаляем скрипт
            File.Delete(bot);
            File.Delete("present.op");
            return "not file";
        }
    }
}
