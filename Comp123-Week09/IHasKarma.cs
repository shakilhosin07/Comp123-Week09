using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Shakil Hosin
 * Date: July 13th, 2017
 * Description: This interface lists the signature for any super hero subclass.
 * Version 0.1 : Declared the Karma property 
 */

namespace Comp123_Week09
{
    public interface IHasKarma
    {
        // PUBLIC PROPERTIES
        int Karma { get; set; } 
    }
}