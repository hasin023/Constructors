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
        protected string _name { get; set; }
        protected int _age { get; set; }

        // Static variable used by all Human instances.
        // Represents the time the first human of the day starts its route.
        public static readonly DateTime dayStartTime;

        //Default Constructor
        public Human() { }

        //A private constructor
        //private Human() { }

        //Parameterized Constructor
        public Human(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        //Copy constructor
        public Human(Human previousPerson)
        {
            this._name = previousPerson._name;
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

        //Method Overloading - Static
        public void Sleep(int _duration)
        {
            Console.WriteLine($"Been asleep for {_duration} hours");
        }
        public void Sleep(string _hname, int _duration)
        {
            Console.WriteLine($"{_hname} has been asleep for {_duration} hours");
        }
        public void Sleep(int _duration, string _hname)
        {
            Console.WriteLine($"{_hname} has been asleep for {_duration} hours");
        }
        public void Sleep(string _name)
        {
            Console.WriteLine($"{_name} has been asleep for hours");
        }

        /* Changing name of Parameters or the defination doesn't work 
        public void Sleep(string _jname)
        {
            Console.WriteLine($"{_jname}");
        }*/


        //Virtual Method
        public virtual void GetName()
        {
            Console.WriteLine($"My name is {_name}");
        }

        //Abstract Method
        public abstract void Talk();

    }
}
