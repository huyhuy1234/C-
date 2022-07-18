using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyTryingOOP
{
    class Father
    {
        public string brand = "Sport";
        public void huy()
        {
            Console.WriteLine("Un` Un`!");
        }
    }

    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound: ");
        }
    }

    abstract class Money
    {
        public abstract void KindOfMoney();
        public void Other()
        {
            Console.WriteLine("Gold, Silver...");
        }
    }
}
