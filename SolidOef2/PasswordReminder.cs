using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidOef2
{
	class PasswordReminder
	{
		private IConnection connection;
		public PasswordReminder(IConnection con)
		{
			connection = con;
		}
	}
}
