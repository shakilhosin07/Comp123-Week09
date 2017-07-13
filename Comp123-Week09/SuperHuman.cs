using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Date: July 11th, 2017
 * Description: This is the Superhuman sub class.
 * Version 0.7 : Added the DisplaySkills stub method to satisfy the Human super class requirements. 
 */ 
namespace Comp123_Week09
{
    /// <summary>
    /// Thsi is the SuperHuman sub class.
    /// It inherits fromt he Human Superclass
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE FIELDS
        private List<Power> _powers;
        //PUBLIC PROPERTIES
         public List<Power> Powers{
            get
            {
                return this._powers; //returns a reference to the Powers List
            }
        }
        //CONSTRUCTORS
        public SuperHuman(string name)
            :base(name)
        {
            this._initialize();
        }
        // PRIVATE METHODS
/// <summary>
/// This method initializes and assigs default values to class fields
/// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();
        }
        //PUBLIC METHODS
        /// <summary>
        /// This method adds a Power to the Power List
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        /// <summary>
        /// This emthod displays each of the powers stored in the powers list
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Name: " + power.Name + " Rank: " + power.Rank);
            }
        }
        /// <summary>
        /// The Tostring method overrides the built in object.tostring method
        /// it outputs a string that displays the superhuman's name 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "======================================================================\n";
            outputString += "Name: " + this.Name + "\n";
            outputString += "======================================================================\n";
                foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + "Rank: " + power.Rank + "\n";
            }
            outputString += "======================================================================\n";
             return outputString;
        }
        /// <summary>
        /// This method overrides the Human abstract superclass DisplaySkills method
        /// This method will display a list of skills to the console.
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not implemented!");
        }
    }
}