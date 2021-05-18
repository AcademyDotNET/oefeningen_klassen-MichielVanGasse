using System;

namespace SolidOef2
{
	class Program
	{
		static void Main(string[] args)
		{
			IConnection connection = new MySQLConnection();
			PasswordReminder password = new PasswordReminder(connection);
		}
	}
}
