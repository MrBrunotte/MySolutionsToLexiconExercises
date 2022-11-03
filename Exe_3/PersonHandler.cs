using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_3
{
    class PersonHandler
    {
        /// <summary>
        /// Method SetAge sets the age of the Person object, we pass in the Person type as person and set the Property Age to the parameter age.
        /// </summary>
        /// <param name="pers"></param>
        /// <param name="age"></param>
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        /// <summary>
        /// SetWeightAndHeight sets the weight and height of the Person object, we pass in the Person type as person and set the Properties Weight and Height to the parameters weight and height.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        public void SetWeightAndHeight(Person person, double weight, double height)
        {
            person.Weight = weight;
            person.Height = height;
        }

        /// <summary>
        /// The method CreatePErson creates a new person object from the Person class, fname and lname must be
        /// instantiated from the constructor in the Person class.
        /// We then set the properties Age, Weight, Height to the corresponding method parameters.
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="age"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public Person CreatePerson(string fname, string lname, int age, double weight, double height)
        {
            Person person = new Person(fname, lname);
            person.Age = age;
            person.Weight = weight;
            person.Height = height;

            Console.WriteLine($"{fname} {lname} \nAge: {age} \nWeight: {weight} \nHeight: {height}");
            return person;
        }
    }
}