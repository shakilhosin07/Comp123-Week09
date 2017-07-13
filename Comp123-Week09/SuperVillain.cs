using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Date: July 13th, 2017
 * Description: This is the SuperVillain child class which inherits the superhuman class
 * Version 0.1: Added the instance varaible malice in the supervillain child class of the SuperHuman class
 */

namespace Comp123_Week09
{
    public class SuperVillain : SuperHuman, IHasMalice
    {
        //PRIVATE INSTANCE VARIABLES
        private int _malice;
        //PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }
        //CONSTRUCTORS 
        public SuperVillain(string name, int malice)
        :base(name)
        {
            this.Malice = malice;

        }

    }
}