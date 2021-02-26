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
        public Stack<int> GetNumbersIn(int a)
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
         * the 5 digits. to do that i borrowed this code from https://stackoverflow.com/questions/829174/is-there-an-easy-way-to-turn-an-int-into-an-array-of-ints-of-each-digit
         * i don't fully know how it works and i havent been able to get it to work completely. but this method
         * was able to return a stack of separated integers.*/
           if (a == 0) return new Stack<int>();
           var numbers = GetNumbersIn(a / 10);

           numbers.Push(a % 10);
         //since i am not familiar with stacks i converted the stack values into an array
           int[] m = numbers.ToArray();
         //i then assigned new variables to the integers in the array so it is easier to work with
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
            * to show direction and number of steps to take. But my issue is the Stack class now which is
            not able to a return string type. Once this code had started to work we can scale it up to other integer inputs
           to get the whole set of instructions*/
           return signal + x.ToString() + y.ToString() + z.ToString();

        }


    }
}
