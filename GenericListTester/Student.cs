using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListTester
{
	class Student
	{
		public string Name { get; set; }
		public Student(string name)
		{
			Name = name;
		}
		public override string ToString()
		{
			return Name;
		}
	}
}
