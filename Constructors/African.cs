using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class African : Human
    {
        private string _race;
        public static readonly DateTime _dayStartTime;
        public African(string name, string race, int age) : base(name, age)
        {
            this._race = race;
        }
        
        //Static can not be inherited from base class, but can used in child if defination provied in child class
        static African()
        {
            _dayStartTime = DateTime.Now;

            Console.WriteLine("Static constructor sets day start time to {0}", _dayStartTime.ToLongTimeString());
        }

        public override void Talk()
        {
            Console.WriteLine("I talk in African");
        }
    }
}
