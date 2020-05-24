using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace SpaceStatistics.SocialNetworkPackage.AccountPackage.Tokens
{
    //токен для вк
    public class VkToken
    {
        public string login { get; set; }
        public string pass { get; set; }
        public ulong appId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public VkToken(string log, string pass,ulong appId)
        {
            //получение имени и фамилии
            VkApi api = new VkApi();
            api.Authorize(new ApiAuthParams
            {
                ApplicationId = appId,
                Login = log,
                Password = pass,
                Settings = Settings.All
            });
            var p = api.Account.GetProfileInfo();
            Name = p.FirstName;
            SurName = p.LastName;
            login = log;
            this.pass = pass;
        }
    }
}
