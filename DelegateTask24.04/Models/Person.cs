using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask24._04.Models
{
    internal class Person
    {
		private string _name;
		private string  _surname;
		private byte _age;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string  Surname
		{
			get { return _surname; }
			set { _surname = value; }
		}

		public byte Age
		{
			get { return _age; }
			set { _age = value; }
		}
        public Person(string name,string surname,byte age)
        {
			Name = name;
			Surname = surname;
			Age = age;
        }


    }
}
