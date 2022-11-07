using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyKnowledge
{
    class Person
    {
		private int _age;
		public Person(int age)
		{
			Age = age;
		}

		public int Age
		{
			get { return _age; }
			set
			{
				if (_age < 0)
				{
					throw new ArgumentException("Age must be greater than zero!");
				}
				else
					_age = value;
			}
		}
	}
}

