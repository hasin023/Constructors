using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Constructors
{
    public abstract class Human
    {
        private string _name { get; set; }
        private string _race { get; set; }
        private int _age { get; set; }

        // Static variable used by all Human instances.
        // Represents the time the first human of the day starts its route.
        public static readonly DateTime dayStartTime;

        public Human() { }

        //A private constructor
        //private Human() { }

        public Human(string name, string race, int age)
        {
            this._name = name;
            this._race = race;
            this._age = age;
        }

        //Copy constructor
        public Human(Human previousPerson)
        {
            this._name = previousPerson._name;
            this._race = previousPerson._race;
            this._age = previousPerson._age;
        }

        // Static constructor to initialize the static variable.
        // It is invoked before the first instance constructor is run.
        static Human()
        {
            dayStartTime = DateTime.Now;

            // The following statement produces the first line of output,
            // and the line occurs only once.
            Console.WriteLine("Static constructor sets day start time to {0}", dayStartTime.ToLongTimeString());

        }

        public void Sleep(int _duration)
        {
            Console.WriteLine($"Been asleep for {_duration} hours");
        }

        public abstract void Talk();

    }
}
