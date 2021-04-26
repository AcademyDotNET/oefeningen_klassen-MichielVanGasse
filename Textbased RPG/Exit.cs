using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_RPG
{
    enum Directions
    {
        North, South, West, East
    }
    class Exit
	{
        public Exit()
        {
            NeedsObject = new List<GameObjects>();
        }
        public Directions ExitDirection { get; set; }
        public Location GoesToLocation { get; set; }

        public List<GameObjects> NeedsObject { get; set; }

        public bool TestPassCondition(List<GameObjects> playerInventory)
        {
            int passCount = 0;
            for (int i = 0; i < NeedsObject.Count; i++)
            {
                if (playerInventory.Contains(NeedsObject[i]))
                    passCount++;
            }

            if (passCount == NeedsObject.Count)
                return true;
            else
            {
                return false;
            }
        }
    }
}
