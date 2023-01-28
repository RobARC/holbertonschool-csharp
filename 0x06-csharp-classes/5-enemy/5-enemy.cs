using System;

namespace Enemies
{
    ///<summary>Defines a Zombie.</summary>
    public class Zombie
    {
        ///<summary>Zombie Health</summary>
        private int health;
        ///<summary>Zombie name</summary>
        private string name = "(No name)";

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
         
         /// <summary>Gets or sets the name of the zombie.</summary>
          public string Name { get { return name; } set { name = value; } }
        ///<summary>Public method return health of the zombie.</summary>
         public int GetHealth()
        {
            return health;
        }

        ///<summary>Prints the zombie's name and health'.</summary>
        public override string ToString()
        {
            return $"Zombie Name: {name} / Health: {health}";

        }

    }
}
