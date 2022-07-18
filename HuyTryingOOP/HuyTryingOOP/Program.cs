using System;
using System.Linq;
using System.IO;




namespace HuyTryingOOP
{
    class Car
    {
        string color = "purple";
        string ownr = "Huy";

        public string FromWhere;
        public long Price;

        public Car(string Where, long PriceOfCar)
        {
            FromWhere = Where;
            Price = PriceOfCar;
        }

        enum Enumable
        {
            Rin, Tim, Huan, Huy, Tuan, Tin, Rim
        }

        

        static void Main(string[] args)
        {
            Car audi = new Car("Germany", 15000000000000);
            Console.WriteLine("This car from: " + audi.FromWhere + " " + "And price is : " + audi.Price + "$");
            Console.WriteLine("My color car is: " + audi.color);
            Console.WriteLine("Duoc so huu boi " + audi.ownr);

            TestOOP sc = new TestOOP();
            sc.Secret = "Limited";
            Console.WriteLine(sc.Secret);


            //random
            //TestOOP test = new TestOOP();
            //int index = rd.Next(0, test.kindofcar.Length);
            //Console.WriteLine(test.kindofcar[index]);


            Random rd = new Random();// bắt buộc
            int index = rd.Next(0, TestOOP.kindofcar.Length);
            Console.WriteLine(TestOOP.kindofcar[index]);



            Children myMoto = new Children();
            Console.WriteLine(myMoto.Moto + " " + myMoto.brand);
            myMoto.huy();


            //Animal

            Animal myAnimal = new Animal();
            Animal myCat = new Cat();
            Animal myDog = new Dog();

            myAnimal.animalSound();
            myCat.animalSound();
            myDog.animalSound();

            //Money

            myMoney myMoneys = new myMoney();
            myMoneys.KindOfMoney();
            myMoneys.Other();

            //random Enum
            Console.WriteLine();
            Random rd2 = new Random();
            int index2 = rd2.Next(Enum.GetNames(typeof(Enumable)).Length);
            Console.WriteLine(Enum.GetNames(typeof(Enumable))[index2]);

            string writeTest = "Huy Huy rat la dep trai";
            File.WriteAllText("huyhuy.txt", writeTest);

            string readTest = File.ReadAllText("huyhuy.txt");
            Console.WriteLine(readTest);


            /*Console.WriteLine("Enter your age: ");
            var age = Convert.ToString(Console.ReadLine());
            Console.WriteLine(age);*/

            // Console.WriteLine(9/3);
            for (int test = 0; test <= 100; test++)
            {
                if (test % 2 == 0)
                {
                    continue;
                }
                Console.Write(test + " ");
            }
            

        }
    }
}
