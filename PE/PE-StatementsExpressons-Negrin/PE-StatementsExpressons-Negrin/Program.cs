using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace PE_StatementsExpressons_Negrin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Your character must have a name. Print a line to the console with a label and your character’s name.
            Console.WriteLine("Arthur Pendragon");

            // Your character will have 50 total points to allocate to its various stats.  
            // The character’s first stat should be equal to 20% of the total points. 
            Console.WriteLine("Strength: " + 50 * .2);

            // Second Stat - The second stat should always be half of the first stat.
            Console.WriteLine("Dexterity: " + (50 * .2)*.5);

            // Third Stat The third stat should always be exactly 7 points. Print the label and value.
            Console.WriteLine("Intelligence: " + 7);

            // Fourth Stat The fourth stat is the sum of second and third stats, minus 2 points.Create a statement and expression to calculate the entire thing(and print it out, with a label).  
            Console.WriteLine("Health: " + ((50 * .2) * .5) + 7) - 2);



            /* 
                * Strength
            Dexterity
            Intelligence
            Health
            Charisma
            */






        }
    }
}
