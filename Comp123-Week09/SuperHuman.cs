using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Date: July 11th, 2017
 * Description: This is the Superhuman sub class.
 * Version : Added Private Initialize Method
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
    }
}