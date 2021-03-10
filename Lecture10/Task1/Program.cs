using System;

namespace Task1
{
    class Program
    {
        static Motocycle StartProgram()
        {
            Console.Write("Input model {string}");
            string inpModel = Console.ReadLine();

            Console.Write("Input proizvoditel {string}");
            string inpProizvoditel = Console.ReadLine();

            Console.Write("Input probeg {int}");
            int inpProbeg = int.Parse(Console.ReadLine());

            Console.Write("Input vSize {int}");
            int intvSize = int.Parse(Console.ReadLine());

            Console.Write("Input power {int}");
            int intPower = int.Parse(Console.ReadLine());

            Console.Write("Input yearBirth {int}");
            int dateBirth = int.Parse(Console.ReadLine());

            Motocycle moto = new Motocycle(inpModel, inpProizvoditel, inpProbeg, intvSize, intPower, dateBirth);
            Random random = new Random();
            moto.ID = random.Next(1,100);
            return moto;
        }
        static void Main(string[] args)
        {

            
            Motocycle[] motoArray = new Motocycle[3];
            motoArray[0] = Program.StartProgram();
            motoArray[1] = Program.StartProgram();
            motoArray[2] = Program.StartProgram();

            foreach (var item in motoArray)
            {
                Console.WriteLine("Id = "+item.ID + "| Model = "+item.Model + "| Probeg = " + item.Probeg + "| Proizvoditel = " +item.Proizvoditel + "| BirthYear = " + item.BirthYear);
            }
        }
    }
    class Motocycle
    {
        public Motocycle(string inpModel, string inpProizvoditel, int inpPropeg, int intvSize, int intPower,int dateBirth)
        {
            Model = inpModel;
            Proizvoditel  = inpProizvoditel;
            Probeg =  inpPropeg;
            BirthYear = dateBirth;
            Engine engine = new Engine(intvSize, intPower);
        }


        private int _id;

        public int ID
        {
            get { return _id; }
            //Не работает init. C# < 9.0.
            set
            {
                _id = value;
            }
        }

        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                if (value == string.Empty)
                {
                    System.Console.WriteLine("Error in Model. Model value == string.Empty. Set new value --- unknown value");
                    _model = "unknown value.";
                }
                else
                    _model = value;
            }
        }
        private string _proizvoditel;

        public string Proizvoditel
        {
            get { return _proizvoditel; }
            set
            {
                if (value == string.Empty)
                {
                    System.Console.WriteLine("Error in Proizvoditel. Proizvoditel value == string.Empty. Set new value --- unknown value");
                    _proizvoditel = "unknown value.";
                }

                else
                    _proizvoditel = value;
            }
        }
        private int _birthYear;

        public int BirthYear
        {
            get { return _birthYear; }
            set
            {
                if (string.Equals(2021, value) == true)
                {
                    _birthYear = value;
                }
                else
                {
                    System.Console.WriteLine("Error in BirthYear. string.Equals(2021, value.ToString()) != true ");
                    _birthYear = 2021;
                }
            }
        }
        private int _probeg;

        public int Probeg
        {
            get { return _probeg; }
            set
            {
                if (value > 100)
                {
                    System.Console.WriteLine("ERROR Propeg > 100. Because value % 100");
                    _probeg = value % 100;
                }
                else
                    _probeg = value;
            }
        }
        private void ConfigurationToDefault()
        {
            ID = 0;
            Model = string.Empty;
            Proizvoditel = string.Empty;
            BirthYear = 0;
            Probeg = 0;
        }


        class Engine
        {
            public Engine(int vsize, int power)
            {
                VSIZE = vsize;
                Power = power;
            }
            private int _vSize;

            public int VSIZE
            {
                get { return _vSize; }
                set
                {
                    if (value >= 125 && value < 3200)
                        _vSize = value;
                    else
                    {
                        Console.WriteLine("ERROR VSIZE. value < 125 && value > 3200");
                        _vSize = 125;
                    }
                }
            }

            private int _power;
            public int Power
            {
                get { return _power; }
                set
                {
                    if (value >= 50 && value < 300)
                        _power = value;
                    else
                    {
                        Console.WriteLine("ERROR in Power. value < 50 && value > 300 ");
                        _power = 50;
                    }
                }
            }

        }
    }
}