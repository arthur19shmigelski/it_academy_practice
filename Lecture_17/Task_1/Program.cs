using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle[] arr = new Motorcycle[5];

            arr[0] = new Motorcycle { Model = "Minsk X250", MadeIn = "China", Odometer = 6_000 };
            arr[1] = new Motorcycle { Model = "Honda CB500F", MadeIn = "Japan", Odometer = 11_500 };
            arr[2] = new Motorcycle { Model = "BMW G1200R", MadeIn = "Germany", Odometer = 20_000 };
            arr[3] = new Motorcycle { Model = "Triumph Tiger 800", MadeIn = "China", Odometer = 30_000 };
            arr[4] = new Motorcycle { Model = "Honda CB1100RR", MadeIn = "Japan", Odometer = 26_000 };

            var listArray = arr.ToList();

            MyDelegate my1 = new MyDelegate(Motorcycle.GetMotorcycleWithOdometer);
            MyDelegate my2 = new MyDelegate(Motorcycle.GetMotorcycleWithChina);
            MyDelegate my3 = new MyDelegate(Motorcycle.GetMotorcycleWithOdometerAndJapan);

            var value1 = Motorcycle.FirstOrDefault(my1,listArray);
            if(value1 == null)
                Console.WriteLine("Null");
            else
                Console.WriteLine(value1.ToString());



            var value2 = Motorcycle.FirstOrDefault(my2, listArray);
            if (value2 == null)
                Console.WriteLine("Null");
            else
                Console.WriteLine(value2.ToString());

            var value3 = Motorcycle.FirstOrDefault(my3, listArray);
            if (value3 == null)
                Console.WriteLine("Null");
            else
                Console.WriteLine(value3.ToString());
        }
    }
}
