using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2.Controllers
{
    [Route("api/J3/{a}")]
    public class J3Controller : ApiController
    {
        public string GetNumbersIn(int[] a)
        {//J3 problem: https://cemc.math.uwaterloo.ca/contests/computing/2021/ccc/juniorEF.pdf
         //Each instruction is a sequence of five digits which represents a direction to turn and the
         //number of steps to take.
         //The first two digits represent the direction to turn:
         //• If their sum is odd, then the direction to turn is left.
         //• If their sum is even and not zero, then the direction to turn is right.
         //• If their sum is zero, then the direction to turn is the same as the previous instruction.
         //The remaining three digits represent the number of steps to take which will always be at
         //least 100.
         /*Since the user input is a sequence of 5 digits, we need to first separate
         * the 5 digits. the input thus comes in the form of an integer array. then use two loops to extract
         individual integers from that array.*/
           int i = 0;
           while (a[i] == 99999 ){
                //this loop would separate the individual items in the array
                //it will stop when the value in the array equals 99999
                //but i am not sure how I would code for the rest
                //the output for the loop would be a list or stack perhaps
                //which could then be used to access individual numbers to then extract digits
           }
           for (i = 0; i = 5; i++)
            {
                //this loop would then separate the 5 individual digits in the integers
                //extracted from the first loop
            }
           //digits extracted from the FOR loop would be added into another array
           //i would then create int variables to assign those digits to them and make it easier to work with
           int v = m[0];
           int w = m[1];
           int x = m[2];
           int y = m[3];
           int z = m[4];
           int sum = v + w;
           string signal;
        /*then it is basically a combination of if statements to determine whether is sum is odd or even
         * and whether the sum = 0*/
           if (sum % 2 == 0 && sum != 0)
           {
               signal = "Turn right";
           }
           else if (sum % 2 != 0)
           {
               signal = "Turn left";
           }
           else if (sum == 0)
           {
               return "Turn the same direction as last instruction";
           }
           else
           {
               return "You have entered incorrect values";
           }
           /*once all this was sorted, it would have been easy to just return the string and integer values
            * to show direction and number of steps to take. */
           return signal + x.ToString() + y.ToString() + z.ToString();

        }


    }
}
