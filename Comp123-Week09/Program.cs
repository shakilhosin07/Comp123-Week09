using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * shakil hosin
 * july 11th 2017
 * This is the driver class for my project
 * Version : 0.5 - Implemented the Tostring method of the superhuman class
 */
namespace Comp123_Week09
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Teleportation", 50));
            superHuman.AddPower("Webcasting", 40);
            superHuman.DisplayPowers();
            Console.WriteLine(superHuman.ToString());
        }
        
    }
}
