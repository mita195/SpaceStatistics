using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStatistics.GraphPackage
{
    class DrawGraph : IDraw
    {
        public Bitmap GetGraph(string[] op)
        {
            Bitmap gr = new Bitmap(1280, 920);
            using (Graphics g = Graphics.FromImage(gr))
            {
            }
            return null;
        }
    }
}
