using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Boy : Asian , IStudent
    {
        //Multi Level inheritance
        public Boy(string name, string race, int age) : base(name, race, age)
        {
        }

        public void Study()
        {
            Console.WriteLine("I study");
        }

        
        /*public override void GetName()
        {
            Console.WriteLine($"My new name is {_name}");
        }*/
    }
}
