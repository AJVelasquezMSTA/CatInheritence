using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Lab_CreateMyOwn
{
    class Program
    {
        static void Main(string[] args)
        {
            //NPC cats
            Cat stray = new Cat("Tobi", 1, "male", false);
            ShortHair ippo = new ShortHair("Ippo",6,"male",true);
            LongHair fluffy = new LongHair("Fluffy", 2,"female",true);
            
            Console.WriteLine("Hello! Welcome to the Cat Program. Please create your cat.");
            Console.WriteLine($"First off, what is your cat's name?");
            string newCatName = Console.ReadLine();
            Console.WriteLine($"Your cat's name is {newCatName}.\n\nWould you like a longhair or shorthair cat?\nChoices: Long, Short, Don't matter");
            string playerPickType = Console.ReadLine();
            string pickedType = playerPickType.ToUpper();

            int numberOfType = 0;
            string playerCatGender = "";
            int playercatAge = 0;
            bool playerFixedCat = false;

            if (pickedType == "LONG")
            {
                Console.WriteLine($"{newCatName} is now a {pickedType}HAIR.");
                numberOfType = 1;

            }
            else if (pickedType=="SHORT")
            {
                Console.WriteLine($"{newCatName} is now a {pickedType}HAIR.");
                numberOfType = 2;
            }
            else if (pickedType=="DON'T MATTER" || pickedType == "DONT MATTER")
            {
                Console.WriteLine($"{newCatName} is a typical cat.");
                numberOfType = 3;
            }
            else
            {
                Console.Beep(1200, 100);
                Console.WriteLine("Error: Invalid input.");
            }

            Console.WriteLine($"What gender is {newCatName}?");
            playerCatGender = Console.ReadLine();

            Console.WriteLine($"How old is {newCatName}?\nChoose a whole number between 0 and 14");
            playercatAge = Convert.ToInt32 (Console.ReadLine());

            switch (numberOfType)
            {
                case numberOfType=1:
                    break;

            }

        
            
        }
        

    }
}
