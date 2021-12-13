using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // Instead of creating difeerent clases just add code in single file..
    // Land Animals
    public class Cat : IAnimal
    {
        public string speak()
        {
            return "Meow Meow Meow";
        }
    }

    public class Lion : IAnimal
    {
        public string speak()
        {
            return "Roar";
        }
    }

    public class Dog : IAnimal
    {
        public string speak()
        {
            return "Bark bark";
        }
    }

    /// <summary>
    /// Sea Animals
    /// </summary>
    public class Octopus : IAnimal
    {
        public string speak()
        {
            return "SQUAWCK";
        }
    }

    public class Shark : IAnimal
    {
        public string speak()
        {
            return "Cannot Speak";
        }
    }
}
