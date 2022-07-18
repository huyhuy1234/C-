using System;

namespace HuyTryingOOP
{
    class Car
    {
        string color = "purple";
        string ownr = "Huy";

        static void Main(string[] args)
        {
            Car audi = new Car();
            Console.WriteLine("My color car is: " + audi.color);
            Console.WriteLine("Duoc so huu boi " + audi.ownr);


            //random
            //TestOOP test = new TestOOP();
            //int index = rd.Next(0, test.kindofcar.Length);
            //Console.WriteLine(test.kindofcar[index]);
            Random rd = new Random();// bắt buộc
            int index = rd.Next(0, TestOOP.kindofcar.Length);
            Console.WriteLine(TestOOP.kindofcar[index]);
        }
    }
}
