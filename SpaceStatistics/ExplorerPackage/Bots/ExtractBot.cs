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
        //экспорт
        public static string Extract(string BotName)
        {
            byte[] bot;
            //поиск нужного скрипта
            switch(BotName)
            {
                case "QuizBot": bot = ResourceBots.QuizBot;
                    break;
                default: return null;
            }
            string name = GetName();
            //создание файла
            File.WriteAllBytes(name, bot);
            return name;
        }
    }
}
