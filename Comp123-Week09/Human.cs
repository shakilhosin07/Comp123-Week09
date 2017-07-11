using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * shakil hosin
 * july 11th 2017
 * this is the abstract class human which other 
 * subclasses will derive from
 * Version : 0.1 - Class created
 */
namespace Comp123_Week09
{
    // <summary>
    /// this is the human abstract class
    /// </summary>
    
    public abstract class Human
    {
        //private fields (instance variables)
        private string _name;
        // public properties 
        private string Name {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }



        }
        //Constructors
        /// <summary>
        /// This is the constructor for the human abstract class.
        /// it requires one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
    }
}