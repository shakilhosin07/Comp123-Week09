using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * shakil hosin
 * july 11th 2017
 * This is the driver class for my project
 * Version : 0.7 - Formatted the output of the supervillain class using console writeline.
 */
namespace Comp123_Week09
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SuperVillain superVillain = new SuperVillain("Green Goblin", 10);
            superVillain.Powers.Add(new Power("Invisibility", 20));
            Console.WriteLine("-----------Malice Points----------------------------------------------");
            Console.WriteLine(superVillain.Malice);
            Console.WriteLine(superVillain.ToString());
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Teleportation", 50));
            superHuman.AddPower("Webcasting", 40);
            Console.WriteLine(superHuman.ToString());
           
        }
        
    }
}
