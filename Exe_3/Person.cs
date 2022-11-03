using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_3
{
    class Person
    {
		private int _age;
		private string? _fName;
		private string? _lName;
		public double Height { get; set; }
		public double Weight { get; set; }

		public string? LastName
		{
			get { return _lName; }
			set
			{
				if (value.Length < 3 || value.Length > 15)
				{
					throw new ArgumentException("Last name cannot have less than 3 or more than 15 characters");
				}
				_lName = value;
			}
		}


		public string FirstName
		{
			get { return _fName; }
			set
			{
				if (value.Length < 2 || value.Length > 10)
				{
					throw new ArgumentException("First name cannot have less than 2 or more than 10 characters");
				}
				_fName = value;
			}
		}


		public int Age
		{
			get { return _age; }
			set
			{
				if (Age < 0)
				{
					throw new ArgumentException("Age must be greater than 0");
				}
				_age = value;
			}
		}

		public Person(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}
		public override string ToString()
		{
			return $"{FirstName} {LastName}";
		}
	}
}
