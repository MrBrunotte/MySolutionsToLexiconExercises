using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMyKnowledge;

namespace TestMyKnowledge
{
    class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }
        public Person CreatePerson(int age)
        {
            //create new Person object
            Person person = new Person(age);
            person.Age = age;

            return person;
        }
    }
}