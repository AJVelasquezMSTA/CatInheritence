using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Lab_CreateMyOwn
{
    class LongHair:Cat
    {
        public LongHair(string nameSH, int ageSH, string genderSH, bool neuturedSpayedSH) //copied pasted from short hair, but this should work here too
        {
            name = nameSH;
            age = ageSH;
            gender = genderSH;
            isFixed = neuturedSpayedSH;
        }

        public LongHair()
        {
            //gather from cat class
        }

        public override void CleanSelf()
        {
            Console.WriteLine($"{name} grooms itself for 20 minutes.");
        }

        public override void Brush()
        {
            Console.WriteLine($"You brush {name}'s fur. Lots of fur came out. {name} seems happier.");
        }
    }
}
