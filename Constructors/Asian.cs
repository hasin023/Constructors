using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Constructors
{
    public class Asian : Human
    {
        private string _race { get; set; }
        public Asian(string name, string race, int age) : base(name, age) 
        {
            this._race= race;
        }

        public Asian(Asian previousPerson) : base(previousPerson) { }


        //Method Overriding
        //Sealed Method
        public sealed override void GetName()
        {
            Console.WriteLine($"My name was {_name}");
        }

        //Polymorphisom - Dynamic
        public override void Talk()
        {
            Console.WriteLine("I talk in Asian");
        }
    }
}
