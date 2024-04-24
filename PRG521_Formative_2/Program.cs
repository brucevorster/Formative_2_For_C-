using System.Diagnostics;
using System.Runtime.CompilerServices;
using PRG521_Formative_2;

class Program
{
    public static void Main(string[] args)
    {
        //Declairs method as object
        Elephant elephant = new Elephant();
        Lion kitten = new Lion();
        Monkey monkey = new Monkey();
        Dolphin dolphin = new Dolphin();

        //====================List For animals so that users can add new animals======================
        List<object> animalDisplay = new List<object>();
        animalDisplay.Add("\n...............................");
        animalDisplay.Add("ELEPHANT");
        animalDisplay.Add("Name: " + elephant.Name);
        animalDisplay.Add("Age: " + elephant.Age);
        animalDisplay.Add("Habitat: " + elephant.habitat);
        animalDisplay.Add("...............................");
        animalDisplay.Add("\n...............................");
        animalDisplay.Add("LION");
        animalDisplay.Add("Name: " + kitten.Name);
        animalDisplay.Add("Age: " + kitten.Age);
        animalDisplay.Add("Habitat: " + kitten.habitat);
        animalDisplay.Add("...............................");
        animalDisplay.Add("\n...............................");
        animalDisplay.Add("MONKEY");
        animalDisplay.Add("Name: " + monkey.Name);
        animalDisplay.Add("Age: " + monkey.Age);
        animalDisplay.Add("Habitat: " + monkey.habitat);
        animalDisplay.Add("...............................");
        animalDisplay.Add("\n...............................");
        animalDisplay.Add("DOLPHIN");
        animalDisplay.Add("Name: " + dolphin.Name);
        animalDisplay.Add("Age: " + dolphin.Age);
        animalDisplay.Add("Habitat: " + dolphin.habitat);
        animalDisplay.Add("...............................");

        //runs the while loop
        Boolean Zoo_Open = true;

        while (Zoo_Open == true) 
        {
            //Options for the user to proform.
            Console.WriteLine("\n//////////////////  Virtual Zoo  //////////////////\n");
            Console.WriteLine("1. Display all animals");
            Console.WriteLine("2. select an animal");
            Console.WriteLine("3. Add animal");
            Console.WriteLine("4. Exit Zoo");

            try
            {
                //prompts user to input a number according to the options
                Console.WriteLine("\nChoose an action by entering the number: ");
                //converts input to int
                int userInput = Convert.ToInt32(Console.ReadLine());

                //manages options chosen by the user
                switch (userInput)
                {
                    //displays all animals in virtual zoo
                    case 1:
                        animalDisplay.ForEach(Console.WriteLine);
                        break;

                    //prompts user to choose animal and actions followed by the animal
                    case 2:
                        //Method in order to give animal actions
                        use_animal();
                        break;

                    //Allows user to add their own animal 
                    case 3:

                        //prompts user to enter their animals name
                        Console.WriteLine("\nEnter animal Name:");
                        string? useranimalname = Console.ReadLine();

                        //prompts user to enter their animals age
                        Console.WriteLine("\nEnter animal Age:");
                        int useranimalage = Convert.ToInt32(Console.ReadLine());

                        //prompts user to enter their animals habitat
                        Console.WriteLine("\nEnter animal Habitat:");
                        string? useranimalhabitat = Console.ReadLine();

                        //Adds the users inputs to the animalDisplay List
                        animalDisplay.Add("\n...............................");
                        animalDisplay.Add(useranimalname.ToUpper());
                        animalDisplay.Add("Name: " + useranimalname);
                        animalDisplay.Add("Age: " + useranimalage);
                        animalDisplay.Add("Habitat: " + useranimalhabitat);
                        animalDisplay.Add("...............................");
                        break;

                    //Exits the program
                    case 4:
                        Console.WriteLine("\nLeaving the Zoo....");
                        System.Environment.Exit(0);
                        break;

                    //Default case to handel miss inputs
                    default:
                        Console.WriteLine("Incorrect number!");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter a number associated with the list.");
            }
        }
    }

    //====================Outside the main class======================

    //Method in order to give the zoo animals actions
    static void use_animal()
    {
        //Declairs method as object
        Elephant elephant = new Elephant();
        Lion kitten = new Lion();
        Monkey monkey = new Monkey();
        Dolphin dolphin = new Dolphin();

        //select animal
        Console.WriteLine("_________________________________________________________________________");
        Console.WriteLine("\nSelect animal: | 1.Lion | 2.Elephant | 3.Monkey | 4.Dolphin | 5.Go Back");
        Console.WriteLine("_________________________________________________________________________");
        //user prompt from case 2 in the switch statement
        string? select_animal = Console.ReadLine();

        //if statement to display actions and run the actions for each animal

        //*****************************__LION__*****************************
        if (select_animal == "Lion" | select_animal == "1")
        {
            //actions
            Console.WriteLine("\n( 1.Feed , 2.Sleep , 3.Wake up , 4.Move , 5.Noise )");
            string? user_action = Console.ReadLine();
            //runs the .Eat() Method
            if (user_action == "Feed" | user_action == "1")
            {
                Console.WriteLine("\nDo you want to feed the lion Meat or Cabbages? 1.Meat | 2.Cabbages");
                string? animal_food = Console.ReadLine();
                if (animal_food == "Meat" | animal_food == "1")
                {
                    kitten.Eat("Steaks", 7);
                }
                else if (animal_food == "Cabbages" | animal_food == "2")
                {
                    kitten.Eat(2, "Cabbages");
                }
                else
                {
                    Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
                }
            }
            //runs the .Sleep() Method
            else if (user_action == "Sleep" | user_action == "2")
            {
                kitten.Sleep();
            }
            //runs the .Wake_Up() Method
            else if (user_action == "Wake up" | user_action == "3")
            {
                kitten.Wake_Up();
            }
            //runs the .Move() Method
            else if (user_action == "Move" | user_action == "4")
            {
                kitten.Move();
                //the .Move methods displays text to the user to choose Pen or Pool to move the animal
                string? move_animal = Console.ReadLine();
                //Pen
                if (move_animal == "Pen" | move_animal == "1")
                {
                    Console.WriteLine("\nSimba has been moved to the Pen");
                }
                //Pool
                else if (move_animal == "Pool"| move_animal == "2")
                {
                    Console.WriteLine("\nSimba has been moved to the Pool");
                }
                //else for the error handeling
                else
                {
                    Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
                }
            }
            //runs the .Make_sound() Method
            else if (user_action == "Noise" | user_action == "5")
            {
                kitten.Make_sound();
            }
            //else for the error handeling
            else
            {
                Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
            }
        }

        //*****************************__Elephant__*****************************
        else if (select_animal == "Elephant" | select_animal == "2")
        {
            //actions
            Console.WriteLine("\n1.Feed , 2.Sleep , 3.Wake up , 4.Move , 5.Noise ");
            string? user_action2 = Console.ReadLine();
            //runs the .Eat() Method
            if (user_action2 == "Feed" | user_action2 == "1")
            {
                Console.WriteLine("\nDo you want to feed the elephant Pumkins or Peanuts? 1.Pumkins | 2.Peanuts");
                string? animal_food = Console.ReadLine();
                if (animal_food == "Pumkins" | animal_food == "1")
                {
                    elephant.Eat("Pumkins", 7);
                }
                else if (animal_food == "Peanuts" | animal_food == "2")
                {
                    elephant.Eat(70, "Peanuts");
                }
                else
                {
                    Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
                }    
            }
            //runs the .Sleep() Method
            else if (user_action2 == "Sleep" | user_action2 == "2")
            {
                elephant.Sleep();
            }
            //runs the .Wake_Up() Method
            else if (user_action2 == "Wake up" | user_action2 == "3")
            {
                elephant.Wake_Up();
            }
            //runs the .Move() Method
            else if (user_action2 == "Move" | user_action2 == "4")
            {
                elephant.Move();
                //the .Move methods displays text to the user to choose Pen or Pool to move the animal
                string? move_animal = Console.ReadLine();
                //Pen
                if (move_animal == "Pen" | move_animal == "1")
                {
                    Console.WriteLine("\nDumbo has been moved to the Pen");
                }
                //Pool
                else if (move_animal == "Pool" | move_animal == "2")
                {
                    Console.WriteLine("\nDumbo has been moved to the Pool");
                }
                //else for the error handeling
                else
                {
                    Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
                }
            }
            //runs the .Make_sound() Method
            else if (user_action2 == "Noise" | user_action2 == "5")
            {
                elephant.Make_sound();
            }
            //else for the error handeling
            else
            {
                Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
            }
        }
        //*****************************__Monkey__*****************************
        else if (select_animal == "Monkey" | select_animal == "3")
        {
            //actions
            Console.WriteLine("\n1.Feed , 2.Sleep , 3.Wake up , 4.Move , 5.Noise ");
            string? user_action2 = Console.ReadLine();
            //runs the .Eat() Method
            if (user_action2 == "Feed" | user_action2 == "1")
            {
                Console.WriteLine("\nDo you want to feed the monkey Banannas or bugs? 1.Banannas | 2.Bugs");
                string? animal_food = Console.ReadLine();
                if (animal_food == "Banannas" | animal_food == "1")
                {
                    monkey.Eat(7, "Banannas");
                }
                else if (animal_food == "Bugs" | animal_food == "2")
                {
                    monkey.Eat("Bugs", 73);
                }
                else
                {
                    Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
                }
            }
            //runs the .Sleep() Method
            else if (user_action2 == "Sleep" | user_action2 == "2")
            {
                monkey.Sleep();
            }
            //runs the .Wake_Up() Method
            else if (user_action2 == "Wake up" | user_action2 == "3")
            {
                monkey.Wake_Up();
            }
            //runs the .Move() Method
            else if (user_action2 == "Move" | user_action2 == "4")
            {
                monkey.Move();
                //the .Move methods displays text to the user to choose Pen or Pool to move the animal
                string? move_animal = Console.ReadLine();
                //Pen
                if (move_animal == "Pen" | move_animal == "1")
                {
                    Console.WriteLine("\nTarzan has been moved to the Pen");
                }
                //Pool
                else if (move_animal == "Pool" | move_animal == "2")
                {
                    Console.WriteLine("\nTarzan has been moved to the Pool");
                }
                //else for the error handeling
                else
                {
                    Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
                }
            }
            //runs the .Make_sound() Method
            else if (user_action2 == "Noise" | user_action2 == "5")
            {
                monkey.Make_sound();
            }
            //else for the error handeling
            else
            {
                Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
            }
        }
        //*****************************__Dolphin__*****************************
        else if (select_animal == "Dolphin" | select_animal == "4")
        {
            //actions
            Console.WriteLine("\n1.Feed , 2.Sleep , 3.Wake up , 4.Move , 5.Noise ");
            string? user_action2 = Console.ReadLine();
            //runs the .Eat() Method
            if (user_action2 == "Feed" | user_action2 == "1")
            {
                Console.WriteLine("\nDo you want to feed the dolphin Fish or Seaweed? 1.Fish | 2.Seaweed");
                string? animal_food = Console.ReadLine();
                if (animal_food == "Fish" | animal_food == "1")
                {
                    dolphin.Eat(4, "Fish");
                }
                else if (animal_food == "Seaweed" | animal_food == "2")
                {
                    dolphin.Eat("Seaweed", 12);
                }
                else
                {
                    Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
                }
            }
            //runs the .Sleep() Method
            else if (user_action2 == "Sleep" | user_action2 == "2")
            {
                dolphin.Sleep();
            }
            //runs the .Wake_Up() Method
            else if (user_action2 == "Wake up" | user_action2 == "3")
            {
                dolphin.Wake_Up();
            }
            //runs the .Move() Method
            else if (user_action2 == "Move" | user_action2 == "4")
            {
                dolphin.Move();
                //the .Move methods displays text to the user to choose Pen or Pool to move the animal
                string? move_animal = Console.ReadLine();
                //Pen
                if (move_animal == "Show" | move_animal == "1")
                {
                    Console.WriteLine("\nWillie has been moved to the Showcase Area");
                }
                //Pool
                else if (move_animal == "Pool" | move_animal == "2")
                {
                    Console.WriteLine("\nWillie has been moved to the Pool");
                }
                //else for the error handeling
                else
                {
                    Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
                }
            }
            //runs the .Make_sound() Method
            else if (user_action2 == "Noise" | user_action2 == "5")
            {
                dolphin.Make_sound();
            }
            //else for the error handeling
            else
            {
                Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
            }
        }
        //Go Back
        else if (select_animal == "Go Back" | select_animal == "5")
        {
            Main(null);
        }
        //else for the error handeling
        else
        {
            Console.WriteLine("\nSorry an error occured make sure you entered the correct input!!!");
        }
        use_animal();
    }
}