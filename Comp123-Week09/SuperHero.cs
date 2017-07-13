using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Date: July 13th, 2017
 * Description: This is the superhero class which inherits the superhuman class
 * Version 0.1: added the instance variable karma
 */
namespace Comp123_Week09
{
   ///
    public class SuperHero : SuperHuman, IHasKarma
    {
        //PRIVATE INSTANCE VARIABLES
        private int _karma;
        //PUBLIC PROPERTIES 
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }
        //CONSTRUCTORS
        public SuperHero(string name, int karma)
        :base(name)
        {
            this.Karma = karma;
        
        }
        //PRIVATE METHODS 
        
        //PUBLIC METHODS 
    }
}