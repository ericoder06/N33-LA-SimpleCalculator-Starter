using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class CalcUtilities
    {
        public static double add( double a, double b )
            { return a + b; }

        public static double subtract( double a, double b ) 
        { return a - b; }

        public static double multiply( double a, double b ) {
            return a * b; }

        public static double divide( double a, double b ) {
            if (b == 0)
            {
                throw new DivideByZeroException("You cannot divide by 0. Error");           
                    }
            return a / b; }

    } 


}
