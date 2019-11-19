using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Lab_CreateMyOwn
{
    class ShortHair:Cat
    {
        public ShortHair(string nameSH, int ageSH, string genderSH, bool neuturedSpayedSH)
        {
            name = nameSH;
            age = ageSH;
            gender = genderSH;
            isFixed = neuturedSpayedSH;
        }

        public ShortHair()
        {
            //gather from cat class
        }

        public override void CleanSelf()
        {
            Console.WriteLine($"{name} grooms itself for 10 minutes.");
        }

        public override void Brush()
        {
            Console.WriteLine($"You brush {name}'s fur. They seem shinier now.");
        }
    }
}
