using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Hello");
            Console.Write("Input model -");
            string userInpModel = Console.ReadLine();
            string userInpManufactured = Console.ReadLine();
            int userInputMileage = int.Parse(Console.ReadLine());


            Motorcycle moto1 = new Motorcycle();
        }
    }
    internal class Motorcycle
    {
        class Engine
        {
            private int _vSize;
            private int _power;

            public int vSizeProperty
            {
                get { return _vSize; }
                set
                {
                    if (_vSize > 125 && _vSize < 3200)
                    { _vSize = value; }
                    else { Console.WriteLine("Not correct. Vsize only > 125 and < 3200"); }
                }
            }
            public int PowerProperty
            {
                get { return _power; }
                set
                {
                    if (_power > 50 && _power < 300)
                    { _power = value; }
                    else { Console.WriteLine("Not correct. Vsize only > 125 and < 3200"); }
                }
            }

        }
        public Motorcycle(int guid, string model, string manufacturer, int mileage)
        {
            guid = GUID;
            model = Model;
            manufacturer = Manufacturer;
            mileage = Mileage;
            BirthYear = DateTime.Now.Year;
        }
        public void ConfigurationToDefault(Motorcycle motorcycle)
        {
            motorcycle.GUID = 0;
            motorcycle.Model = "UNKNOWN";
            motorcycle.Manufacturer = "UNKNOWN";
            motorcycle.BirthYear = 0;
            motorcycle.Mileage = 0;
        }
        public int GUID { get; private set; }
        private string Model { get; set; }
        private string Manufacturer { get; set; }
        private int BirthYear { get; set; }
        private int Mileage;


    }
}
