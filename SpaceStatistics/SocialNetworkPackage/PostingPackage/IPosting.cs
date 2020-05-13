using SpaceStatistics.SocialNetworkPackage.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStatistics.SocialNetworkPackage
{
    public interface IPosting
    {
        void Posting(Post post, object token);
    }
}
