using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyTryingOOP
{
    class Children : Father
    {
        public string Moto = "Z1000";
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: Meow Meow");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: Gau Gau");
        }
    }

    class myMoney : Money
    {
        public override void KindOfMoney()
        {
            Console.WriteLine("Viet Nam Dong");
        }
    }
}
