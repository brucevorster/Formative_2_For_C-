using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG521_Formative_2;

namespace PRG521_Formative_2
{
    internal class Dolphin : Animals, IFeedable, IMovable
    {
        //Properties for Dolphin
        public string? Name = "Willie";
        public int Age = 2;
        public string? habitat = "Ocean";

        //Override method to make sound
        public override void Make_sound()
        {
            Console.WriteLine("\n*whistle Click click!!!*");
        }
        //Overload method to eat
        public void Eat(string food, int amount)
        {
            Console.WriteLine("\nThe Dolphin has been fed " + amount + " healthy " + food);
        }
        //Overload method to eat
        public void Eat(int amount, string food)
        {
            Console.WriteLine("\nThe Dolphin has been fed " + amount + " stink " + food);
        }
        //Override to wake up
        public override void Wake_Up()
        {
            Console.WriteLine("\nThe Dolphin has been woken up and is now awake");
        }
        //Override to move
        public void Move()
        {
            Console.WriteLine("\nMove Willie to the Showcase area or Pool?  1.Show | 2.Pool");
        }
        //Override to display info
        public override void Info()
        {
            Console.WriteLine("\nDolphin");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Habitat: " + habitat);
        }
    }
}
