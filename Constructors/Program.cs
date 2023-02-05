using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Asian _asian1 = new Asian("Man", "Asian", 26);
            _asian1.Talk();
            _asian1.GetName();

            Asian _asian2 = new Asian(_asian1);
            _asian2.GetName();
            
            African _african1 = new African("Manny", "African", 32);
            _african1.Talk();

            //UpCasting - Convert from Child class to Parent Class
            //DownCasting - Convert from Parent class to Child Class


            //Use of Static Counter class
            Counter.countHumans();

            //Can not create a abstract class object
            //Human _human1 = new Human("Manny", "African", 32);

            Console.ReadKey();
        }
    }
}
