using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	interface IMoveable
	{
		public void MoveDown();
		public void MoveLeft();
		public void MoveRight();
		public void MoveUp();
	}
}
