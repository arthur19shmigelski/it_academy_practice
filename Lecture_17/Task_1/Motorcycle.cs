using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public delegate Motorcycle MyDelegate(List<Motorcycle> list);
    public class Motorcycle
    {
        public Guid Id { get; private set; }
        public string Model { get; set; }
        public int Odometer { get; set; }
        public string MadeIn { get; set; }
        
        public static Motorcycle FirstOrDefault(MyDelegate my, List<Motorcycle> list)
        {
            var value = my(list);
            return value;
        }
        public static Motorcycle GetMotorcycleWithOdometer(List<Motorcycle> list)
        {
            foreach (var item in list)
            {
                if (item.Odometer >= 50_000)
                    return item;
                else
                    continue;
            }
            return null;
        }
        public static Motorcycle GetMotorcycleWithChina(List<Motorcycle> list)
        {
            foreach (var item in list)
            {
                if (item.MadeIn == "Cnina")
                    return item;
                else
                    continue;
            }
            return null;
        }

        public static Motorcycle GetMotorcycleWithOdometerAndJapan(List<Motorcycle> list)
        {
            foreach (var item in list)
            {
                if (item.Odometer >= 25_00 && item.MadeIn == "Japan")
                    return item;
                else
                    continue;
            }
            return null;
        }
    }
}
