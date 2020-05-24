using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceStatistics.SocialNetworkPackage.Elements;

namespace SpaceStatistics.ExplorerPackage
{
    //интерфейс для подключения к боту
    //Выполнил Мечислав Принев
    public interface IBot
    {
        SocialNetworkEnum SocialNetwork { get; }
        string BotName { get; set; }
        string Start(string[] command);

    }
}
