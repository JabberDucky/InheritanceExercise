using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var Emu = new Bird();
            Emu.NumOfLegs = 2;
            Emu.IsMammal = "No";
            Emu.WaterOrLand = "land";
            Emu.HotOrCold = "warm blooded";
            Emu.CanFly = false;
            Emu.HasFeathers = true;
            Emu.Sound = "buh buh grunt";
            Emu.EatsSeeds = "fruits and insects";

            var Snake = new Reptile();
            Snake.NumOfLegs = 0;
            Snake.IsMammal = "not a mammal";
            Snake.WaterOrLand = "land";
            Snake.HotOrCold = "cold blooded";
            Snake.CanSwim = true;
            Snake.HasScales = true;
            Snake.LayEggs = "lay eggs";
            Snake.HaveVertebrates = "have an inner skeleton";

            while (true)
            {
                Console.WriteLine("Want to learn about some animals?");
                string answer = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (answer == "yes")
                {
                    Console.WriteLine("---Emus---");
                    Console.WriteLine($"Are Emus mammals? {Emu.IsMammal}, even though they have {Emu.NumOfLegs} legs. " +
                    $"It is {Emu.HasFeathers} that an Emu has feathers, but it is {Emu.CanFly} they can fly. Emu's are " +
                    $"{Emu.HotOrCold} {Emu.WaterOrLand} avians. They like to eat {Emu.EatsSeeds}" +
                    $" and they make a {Emu.Sound} sound.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Aww shucks, maybe next time!");
                }

                Console.WriteLine("Want to learn more?");
                string answer2 = Console.ReadLine().ToLower();
                Console.WriteLine();


                if (answer2 == "yes")
                {
                    Console.WriteLine("---Snakes---");
                    Console.WriteLine($"Snakes are {Snake.IsMammal}, they are part of the reptile family. Snakes have " +
                        $"{Snake.NumOfLegs} legs and are {Snake.HotOrCold}. Snakes typically live on {Snake.WaterOrLand}, but it's" +
                        $"{Snake.CanSwim} they can swim. It is also {Snake.HasScales} that snakes have scales and {Snake.HaveVertebrates}." +
                        $"Since snakes are reptiles they {Snake.LayEggs}.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Thanks for learning!");
                }

                Console.WriteLine("Do you want to repeat?");
                answer = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (answer == "yes")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Animals are cool, see you next time!");
                    return;
                }

            }


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }    
    }
}
