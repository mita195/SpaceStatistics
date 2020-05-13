using SpaceStatistics.SocialNetworkPackage.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStatistics.SocialNetworkPackage.AccountPackage
{
    public class DeferredPosts
    {
        public Authorization auth { get; set; }
        public List<Post> posts { get; set; }
        public int PublishPosts()
        {
            return 0;
        }
    }
}
