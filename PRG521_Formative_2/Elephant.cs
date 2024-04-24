using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG521_Formative_2;

namespace PRG521_Formative_2
{
    internal class Elephant : Animals, IFeedable, IMovable
    {
        //Properties for Elephant
        public string? Name = "Dumbo";
        public int Age = 7;
        public string? habitat = "Safari";

        //Override method to make sound
        public override void Make_sound()
        {
            Console.WriteLine("\n*Rumbling!!!*");
        }
        //Overload method to eat
        public void Eat(string food, int amount)
        {
            Console.WriteLine("\nThe Elephant has been fed " + amount + " healthy " + food);
        }
        //Overload method to eat
        public void Eat(int amount, string food)
        {
            Console.WriteLine("\nThe Elephant has been fed " + amount + " jummy " + food);
        }
        //Override to wake up
        public override void Wake_Up()
        {
            Console.WriteLine("\nElephant has been woken up and is now awake");
        }
        //Override to move
        public void Move()
        {
            Console.WriteLine("\nMove Simba to the Pen or Pool?  1.Pen | 2.Pool");
        }
        //Override to display info
        public override void Info()
        {
            Console.WriteLine("\nElephant");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Habitat: " + habitat);
        }
    }
}
