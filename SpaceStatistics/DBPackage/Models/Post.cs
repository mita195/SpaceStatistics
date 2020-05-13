
using SpaceStatistics.SocialNetworkPackage.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStatistics.DBPackage.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SocialNetworkEnum socialNetwork { get; set; }
    }
}
