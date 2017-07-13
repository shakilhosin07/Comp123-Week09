using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * shakil hosin
 * july 11th 2017
 * This is the driver class for my project
 * Version : 0.6 - Created a new object of the SuperVillain class
 */
namespace Comp123_Week09
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperVillain superVillain = new SuperVillain("Green Goblin", 10);
            Console.WriteLine(superVillain.ToString());
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Teleportation", 50));
            superHuman.AddPower("Webcasting", 40);
            Console.WriteLine(superHuman.ToString());
        }
        
    }
}
