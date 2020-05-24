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
    //Бот для викорин в ВК
    public class VkQuizBot : IBot
    {
        public SocialNetworkEnum SocialNetwork { get { return SocialNetworkEnum.Vk; } }

        public string BotName { get; set; }


        public VkQuizBot()
        {
            //имя бота
            BotName = "Викторина";
        }
        //запуск
        public string Start(string[] command)
        {
            //достаем бота из ресурсов
            string bot = ExtractBot.Extract("QuizBot");
            //создаем файлов настроек
            using(StreamWriter sw = new StreamWriter("commandFileQuizBot.op"))
            {
                foreach(string st in command)
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
            while(!p.HasExited)
            {
                Thread.Sleep(100);
            }
            //удаляем скрипт
            File.Delete(bot);
            return "usersvoite.txt";
        }
    }
}
