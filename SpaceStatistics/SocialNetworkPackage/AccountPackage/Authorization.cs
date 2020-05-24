using SpaceStatistics.SocialNetworkPackage.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStatistics.SocialNetworkPackage.AccountPackage
{
    //класс авторизации в соцсети
    public class Authorization
    {
        public object Token { get; set; }
        private SocialNetworkEnum SocialNetwork;
        public Authorization(string login, string password,SocialNetworkEnum socialNetwork,ulong appId)
        {
            SocialNetwork = socialNetwork;
            switch(SocialNetwork)
            {
                case SocialNetworkEnum.Vk:
                    Token = new Tokens.VkToken(login, password, appId);
                    break;
            }
        }
    }
}
