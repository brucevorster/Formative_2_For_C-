using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG521_Formative_2;

namespace PRG521_Formative_2
{
    internal class Lion : Animals, IFeedable, IMovable
    {
        //Properties for Lion
        public string? Name = "Simba";
        public int Age = 5;
        public string? habitat = "Safari";

        //Override method to make sound
        public override void Make_sound()
        {
            Console.WriteLine("\n*Roaaaarrrr!!!*");
        }
        //Overload method to eat
        public void Eat(string food, int amount)
        {
            Console.WriteLine("\nThe Lion has been fed " + amount + " juicy " + food);
        }
        //Overload method to eat
        public void Eat(int amount, string food)
        {
            Console.WriteLine("\nThe Lion has been fed " + amount +  " healthy " + food);
        }
        //Override to wake up
        public override void Wake_Up()
        {
            Console.WriteLine("\nThe Lion has been woken up and is now awake");
        }
        //Override to move
        public void Move()
        {
            Console.WriteLine("\nMove Simba to the Pen or Pool?  1.Pen | 2.Pool");
        }
        //Override to display info
        public override void Info()
        {
            Console.WriteLine("\nLion");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Habitat: " + habitat);
        }
    }
}