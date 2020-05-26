using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*класс для экспортирования питон скрипта из ресурсов
 Выполнил Мечислав принев*/
namespace SpaceStatistics.ExplorerPackage.Bots
{
    internal static class ExtractBot
    {
        //имя скрипта
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

        private static string GetNameEXE()
        {
            string botName = string.Empty;
            int num = 1;
            while (File.Exists(botName + num.ToString() + ".exe"))
            {
                num++;
            }
            return botName + num.ToString() + ".exe";
        }
        //экспорт
        public static string Extract(string BotName)
        {
            byte[] bot;
            string name;
            //поиск нужного скрипта
            switch (BotName)
            {
                case "QuizBot": bot = ResourceBots.QuizBot;
                    name  = GetName();
                    break;
                case "PresentBot":
                    bot = ResourceBots.bot_present;
                    name = GetNameEXE();
                    break;
                default: return null;
            }
            
            //создание файла
            File.WriteAllBytes(name, bot);
            return name;
        }
    }
}
