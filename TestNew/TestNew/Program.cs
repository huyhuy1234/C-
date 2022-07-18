using System;

namespace TestAPI
{
    class Test
    {


        public static void Run()
        {
            string[] Animal = { "Dog", "Cat" };
            string[] Dog = { "Red", "Cherry", "Khoai Lang", "Khoai Tay", "OG" };
            string[] Cat = { "Tim", "Rin", "Huan", "Bon", "TH" };



            Random KindOfAnimal = new Random();
            int index = KindOfAnimal.Next(0, Animal.Length);
            Console.WriteLine("Kind Of Animal: " + Animal[index]);
            string flag = Animal[index];
            if (flag == "Dog")
            {
                Random NameOfDog = new Random();
                int index2 = NameOfDog.Next(0, Dog.Length);
                Console.WriteLine("Name Of Dog: " + Dog[index2]);
            }
            else if (flag == "Cat")
            {
                Random NameOfCat = new Random();
                int index3 = NameOfCat.Next(0, Cat.Length);
                Console.WriteLine("Name Of Cat: " + Cat[index3]);
            }
        }
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                if (i < 5)
                {
                    Run();
                    Console.WriteLine();
                }
            }

        }
    }
}