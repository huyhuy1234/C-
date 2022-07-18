using System;
using System.Linq;


namespace HuyTryingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //kk();

            //Syntax();

            //IEI();

            //WDW();

            //SC();

            //FOR();  

            Method();
            Method("USA ", 2022);

            Console.WriteLine(Calc(20, 18, 0));

            MyCat(c1: "Rin", c2: "Tim", c3: "Huan");



            //OOP
       

        }


        static void kk()
        {
            Console.WriteLine("its work");
        }

        static void Syntax()
        {
            string huyhuy = "HuyHuy";
            Console.WriteLine(huyhuy);


            double myD = 9.153;
            int myI = (int)myD;
            Console.WriteLine(myI);


            Console.Write("Username: ");
            string userName = Console.ReadLine();
            //readline() là hàm nhập
            Console.WriteLine("Username: " + userName);



            Console.Write("Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);


            Console.WriteLine(Math.Max(myD, age));
            Console.WriteLine(Math.Min(myD, age));

            Console.WriteLine(Math.Sqrt(50));
            Console.WriteLine(Math.Abs(-58));
            Console.WriteLine(Math.Round(myD));
            Console.WriteLine(Math.Max(5, 9));

            string txt = "abdcfsdfsdfetghffhthth15fgffdf48ef24dfdf";
            Console.WriteLine("Length of txt is : " + txt.Length);


            string txt2 = "Henry Bezos";
            Console.WriteLine(txt2.ToUpper()); // VIET HOA HET
            Console.WriteLine(txt2.ToLower()); // viet thuong het

            string fname = "Quoc";
            string lname = "Huy";
            string name = fname + " " + lname;
            Console.WriteLine(name);


            string frname = "Henry ";
            string laname = "Bezos";
            string name2 = string.Concat(frname, laname);   // nối 2 chuỗi 
            Console.WriteLine(name2);

            string fname2 = "Quoc";
            string lname2 = "Huy";
            string name3 = $"My name is: {fname2} {lname2}";
            Console.WriteLine(name3);

            Console.WriteLine(fname[1]); // vị trí số 1     
            Console.WriteLine(fname.IndexOf("c")); // tìm vị trí chữ c trả lại số thứ tự 
            string fake = fname.Substring(fname.IndexOf("c"));
            Console.WriteLine(fake);

            int x = 10;
            int y = 20;
            Console.WriteLine(x == y);
            bool x2 = true;
            bool y2 = false;
            Console.WriteLine(x2 == y2);


        }

        static void IEI()
        {
            string x = "Huy";
            string y = "Tuan";

            if (x.Length == y.Length)
            {
                Console.WriteLine("Hay vailol");
            }
            else if (y.Length < x.Length)
            {
                Console.WriteLine("hhaha");
            }
            else
            {
                Console.WriteLine("dmm");
            }

            string otherif = (x.Length < y.Length) ? "Điều kiện đúng thì nằm ở đầu tiên" : "Còn điều kiện sai thì nằm ở sau";
            Console.WriteLine(otherif);
        }

        static void WDW()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Do/While");

            int i2 = 0;
            do
            {
                Console.WriteLine(i2);
                i2++;
            }
            while (i2 < 5);
        }

        static void SC()
        {
            int ToDay = 8;
            switch (ToDay)
            {
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Deo co cai ngay nay");
                    break;
            }
        }

        static void FOR()
        {

            for (int a = 0; a < 5; a++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            for (int i = 0; i <= 10; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();



            string[] cars = { "BMW", "Mercerdes", "VinFast", "G63" };

            //foreach chỉ sài cho mảng
            foreach (string b in cars)
            {
                Console.WriteLine(b);
            }


            Console.WriteLine();


            cars[3] = "Hondai";
            Array.Sort(cars);
            for (int c = 0; c < cars.Length; c++)
            {
                Console.WriteLine(cars[c]);
            }

            int[] myNumbers = { 9, 7, 8, 5, 6 };
            Console.WriteLine(myNumbers.Max());
            Console.WriteLine(myNumbers.Min());
            Console.WriteLine(myNumbers.Sum());
            Console.WriteLine();
            Array.Sort(myNumbers);
            for (int m = 0; m < myNumbers.Length; m++)
            {
                Console.WriteLine(myNumbers[m]);

            }
        }

        static void Method(string country = "HuyLand ", int year = 0)
        {
            Console.WriteLine(country + "cuaVietNam" + " Nam " + year);
        }

        public static int Calc(int x, int y, int z)
        {
            return y + x + z;
        }

        private static void MyCat(string c1, string c2, string c3)
        {
            Console.WriteLine("Yougest cat is : " + c3);
            
        }


    }
}