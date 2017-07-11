using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Date: July 11th, 2017
 * Description: This is the Power data type.
 * Version : 0.2 - Added constructor for name and rank
 */
namespace Comp123_Week09
{
    /// <summary>
    /// The power class contains the data and structure of the each super power.
    /// 
    /// </summary>
    public class Power
    {
        //public properties
        public string Name { get; set; }
        public int Rank { get; set; }

        //constructors
        /// <summary>
        /// This is the power constructor 
        /// Takes two parameters - name (string) rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;

        }
    }
}