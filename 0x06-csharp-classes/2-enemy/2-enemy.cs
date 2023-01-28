using System;

namespace Enemies
{
    ///<summary>Defines a Zombie.</summary>
    public class Zombie
    {
        ///<summary>Defines a Zombie.</summary>
        public int health;

        ///<summary>Constructor Method Initialize a new instance of <see cref="Zombie"/>.</summary>
        public Zombie()
        {
            health = 0;
        } 

        /*<summary>You can write the constructor method this way:
            public Zombie() => health = 0;
         </summary>*/

        ///<summary>New constructor method Initialize a new instance of <see cref="Zombie"/>.</summary>
         public Zombie(int value)
         {
            if(value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            } 
            else
            {
                health = value;
            }

         }


    }
}

