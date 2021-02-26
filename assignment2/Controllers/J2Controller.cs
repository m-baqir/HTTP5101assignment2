using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2.Controllers
{
    [Route("api/J2/{N}/{k}")]
    public class J2Controller : ApiController
    {
        public double GetShiftysum(int N, int k)
        {//J2 problem solution: https://cemc.math.uwaterloo.ca/contests/computing/2017/stage%201/juniorEF.pdf
         //This is essentially a math problem that keeps the running total of 
         //a value while it is multiplied by 10. This is repeated k times.
            //declaring variables
            double total=0;
            double product;
            //for loop to find the product and then keep running total
            for (int i=0; i<k+1; i++)
            {
                product = (N * Math.Pow(10, i));
                total = total + product;
            }
            //returning the final total value
            return total;
        }
    }
}
