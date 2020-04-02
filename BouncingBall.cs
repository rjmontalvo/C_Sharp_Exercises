using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Coding_Exercises
{
    class BouncingBall
    {
        /*A child is playing with a ball on the nth floor of a tall building.The height of this floor, h, is known.

            He drops the ball out of the window.The ball bounces (for example), to two-thirds of its height(a bounce of 0.66).

            His mother looks out of a window 1.5 meters from the ground.

            How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing?

            Three conditions must be met for a valid experiment:
            Float parameter "h" in meters must be greater than 0
            Float parameter "bounce" must be greater than 0 and less than 1
            Float parameter "window" must be less than h.
            If all three conditions above are fulfilled, return a positive integer, otherwise return -1.

            Note:
            The ball can only be seen if the height of the rebounding ball is strictly greater than the window parameter.*/
        
    public static int bouncingBall(double h, double bounce, double window)
        {

            if (h <= 0 || bounce >= 1 || bounce <= 0 || window >= h) return -1;


            else
            {
                //Bounces is a minimum of 1 because the ball falls passed the window
                
                //Ball Drops
                int bounces = 1;

                //Ball bounces
                h *= bounce;

                //If the new height of the ball is higher than the window,
                //increment the bounces and continue to bounce
                while (h > window)
                {
                    bounces += 2;
                    h *= bounce;
                }

                return bounces;
            }
        }
    }
}
