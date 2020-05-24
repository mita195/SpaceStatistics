using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceStatistics.SocialNetworkPackage.Elements;

namespace SpaceStatistics.ExplorerPackage
{
    public interface IBot
    {
        SocialNetworkEnum SocialNetwork { get; }
        string BotName { get; set; }
        bool IsLoaded { get; }
        string Start(string[] command);

    }
}
