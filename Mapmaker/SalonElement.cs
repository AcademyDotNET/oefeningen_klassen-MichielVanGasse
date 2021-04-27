using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapmaker
{
    class SalonElement : MapObject
    {
        private List<MapObject> elementen = new List<MapObject>();

        public SalonElement(Point salonLoc)
        {

            elementen.Add(new ZetelElement(new Point(2 + salonLoc.X, 2 + salonLoc.Y), 3, '+'));
            elementen.Add(new ZetelElement(new Point(5 + salonLoc.X, 9 + salonLoc.Y), 3, '+'));

            Location = salonLoc;
        }

        public override void Paint()
        {
            for (int i = 0; i < elementen.Count; i++)
            {
                elementen[i].Paint();
            }

        }
    }
}
