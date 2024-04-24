using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG521_Formative_2;

namespace PRG521_Formative_2
{
    internal class Animals
    {
        //Properties for the animal classes
        public string? Name;
        public int Age;
        public string? habitat;

        //Virtual method for animal sound
        public virtual void Make_sound()
        {
            Console.WriteLine("Animal sound");
        }
        //Virtual method for animal sleep
        public virtual void Sleep()
        {
            Console.WriteLine("\nZzzzz");
        }
        //Virtual method for animal wake up
        public virtual void Wake_Up()
        {
            Console.WriteLine("Animal wake up");
        }
        //Virtual method for animal information
        public virtual void Info()
        {
            //Display info for all the animals
            Console.WriteLine("No Details for Animal");
        }
    }
}

//Interfaces for the eat method
interface IFeedable
{
    void Eat(string food, int amount); // interface method (does not have a body)
    void Eat(int amount, string food);
}

//Interfaces for the Move method
interface IMovable
{
    void Move(); // interface method (does not have a body)
}