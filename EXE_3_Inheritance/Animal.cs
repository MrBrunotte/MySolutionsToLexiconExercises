using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_3_Inheritance
{
    /// <summary>
    /// Abstract class is something that can have abstract methods and ordinary methods (with implementation),
    /// you can have properties and constructors but you cannot insantiate an abstract class.
    /// You can only inherit from one abstract class.
    /// You can only have abstract methods in an abstract class, and you need to override them.
    /// An abstract method does not have any implementation (method body)
    /// </summary>
    public abstract class Animal
    {
        // 1 Properties
        public string Type { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        // 3 Constructor
        public Animal(string type, double weight, string color)
        {
            Type = type;
            Weight = weight;
            Color = color;
        }

        // 2 Abstract method must be implemented in the abstract class that inherit from Animal
        public abstract void DoSound();

        // 3.3 1) Create method Stats() with return type string and we should be able to override it in the
        // subclasses, the method should return all Animal properties.
        public virtual string Stats()
        {
            return $"{Type} {Weight} {Color}";
        }
    }
}
