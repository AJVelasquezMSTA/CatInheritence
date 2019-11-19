using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Lab_CreateMyOwn
{
    class Cat
    {
        private string catName;
        private int catAge;
        private string catGender;
        private bool isNeuteredSpayed;

        public Cat(string name, int age, string gender, bool neuturedSpayed)
        {
            catName = name;
            catAge = age;
            catGender = gender;
            isNeuteredSpayed = neuturedSpayed;
        }

        public void Meow()
        {
            Console.Write("MEEE");
            Console.Beep(1700, 900);
            Console.Write("OW\n");
            Console.Beep(1400, 600);
        }

        public virtual void CleanSelf()
        {
            Console.WriteLine($"{name} grooms itself.");
        }

        public Cat() //default cat
        {
            catName = "Bob";
            catAge = 1;
            catGender = "Male";
            isNeuteredSpayed = true;

        }

        public string name
        {
            get { return catName; }
            set { catName = value; }
        }

        public int age
        {
            get { return catAge; }
            set { catAge = value; }
        }

        public string gender
        {
            get { return catGender; }
            set { catGender = value; }
        }

        public bool isFixed
        {
            get { return isNeuteredSpayed; }
            set { isNeuteredSpayed = value; }
        }

        public void CatTreat()
        {
            Console.WriteLine($"\nPlease select a treat for {name} to eat!\nChoices: fish, chicken, catnip");
            string treat = Console.ReadLine();

            if (treat == "fish")
                Console.WriteLine($"{name} eats fish treat.");
            else if (treat == "chicken")
                Console.WriteLine($"{name} eats chicken treat.");
            else if (treat == "catnip")
                Console.WriteLine($"{name} eats catnip treat.");
            else
            {
                Console.WriteLine($"{treat} is not an acceptable treat!!");
            }
        }

        public void FeedCat() //overloading
        {
            Console.WriteLine($"{name} eats its food.");
        }

        public void FeedCat(string food)
        {
            Console.WriteLine($"{name} eats the {food}.");
        }

        public void Play()
        {
            Console.WriteLine($"You play with {name} with a string toy.");
        }

        public void Nap()
        {
            Console.WriteLine($"{name} is taking a catnap.");
        }

        public virtual void Brush()
        {
            Console.WriteLine($"You brush {name}'s fur.");
        }
    }
}
