using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_RPG
{
	class GameObjects
	{
        public string Name { get; set; }
        public string Description { get; set; }

        public void Describe()
        {
            Console.WriteLine(Name + "," + Description + ".");
        }
    }
}
