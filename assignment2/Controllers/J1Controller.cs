using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2.App_Start
{
    [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
    public class J1Controller : ApiController
    {
        public string GetChoices(int burger, int drink, int side, int dessert)
        {//<summary> Solution for a J1 problem of counting calories for a restaurant menu
         //the method recieves 4 integer values from the user and selects items from the
         //menu accordingly. first integer for the burger choice, 2nd for drink, 3rd for side
         //4th for dessert. for each category choice, the user has 4 options. and each item
         //has its own assigned calorie count.</summary>
         //<param>{int burger 'for burger choice'}/{int drink 'for drink choice'}
         ///{int side 'for side choice'}/{int dessert 'for dessert choice'} </param>
         //<example>GET api/j1/menu/1/2/3/4 -> Your total calorie count is 619 </example>

            //declaring variables
            int cheeseburger = 461;
            int fishburger = 431;
            int veggieburger = 420;
            int noburger = 0;
            int finalburger;
            int softdrink = 130;
            int orange = 160;
            int milk = 118;
            int nodrink = 0;
            int finaldrink;
            int fries = 100;
            int bakepotato = 57;
            int salad = 70;
            int noside = 0;
            int finalside;
            int applepie = 167;
            int sundae = 266;
            int fruitcup = 75;
            int nodessert = 0;
            int finaldessert;
            int totalcal;

            //if/else logic for burger selection
            if (burger == 1)
            {
                finalburger = cheeseburger;
            } 
            else if(burger == 2)
            {
                finalburger = fishburger;
            }
            else if(burger == 3)
            {
                finalburger = veggieburger;
            }
            else if(burger == 4)
            {
                finalburger = noburger;
            }
            else
            {
                return "invalid choice";
            }
            //if/else logic for drink selection
            if (drink == 1)
            {
                finaldrink = softdrink;
            }
            else if (drink == 2)
            {
                finaldrink = orange;
            }
            else if (drink == 3)
            {
                finaldrink = milk;
            }
            else if (drink == 4)
            {
                finaldrink = nodrink;
            }
            else
            {
                return "invalid choice";
            }
            //if/else logic for side selection
            if (side == 1)
            {
                finalside = fries;
            }
            else if(side == 2)
            {
                finalside = bakepotato;
            }
            else if (side == 3)
            {
                finalside = salad;
            }
            else if (side == 4)
            {
                finalside = noside;
            }
            else
            {
                return "invalid choice";
            }
            //if/else logic for dessert selection
            if (dessert == 1)
            {
                finaldessert = applepie;
            }
            else if (dessert == 2)
            {
                finaldessert = sundae;
            }
            else if (dessert == 3)
            {
                finaldessert = fruitcup;
            }
            else if (dessert == 4)
            {
                finaldessert = nodessert;
            }
            else
            {
                return "invalid choice";
            }
            //adding up total calories
            totalcal = finalburger + finaldrink + finalside + finaldessert;
            //return string with total calorie count
            return "Your total calorie count is " + totalcal.ToString();
        }

     }
}
    
