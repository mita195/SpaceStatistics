using SpaceStatistics.SocialNetworkPackage.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStatistics.SocialNetworkPackage.AccountPackage
{
    public class Authorization
    {
        public object Token { get; set; }
        private SocialNetworkEnum SocialNetwork;
        public Authorization(string login, string password,SocialNetworkEnum socialNetwork)
        {

        }
    }
}
