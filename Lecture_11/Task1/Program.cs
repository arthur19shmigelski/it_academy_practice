using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void Method(IFigure figure)
        {
            IFigure[] myArray = new IFigure[5];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = figure;
            }
        }
    }
    public interface IFigure
    {
        double CalculateAreaSquare();
        double CalculateAreaCircle();
        double CalculateAreaTriangle();
    }
    class Circle : IFigure
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double Radius 
        {
            get { return _radius; } 
            set
            {
                if (value < 1)
                    _radius = 1;
                else if (value > 10)
                    _radius = 10;
            }
        }
        public double CalculateAreaCircle()
        {
            double S = Math.PI * Radius * Radius;
            return S;
        }

        public double CalculateAreaSquare()
        {
            throw new NotImplementedException();
        }

        public double CalculateAreaTriangle()
        {
            throw new NotImplementedException();
        }
    }
    class Square : IFigure
    {
        private double _side;
        public double Side 
        {
            get { return _side; }
            set
            {
                if (value < 1)
                    _side = 1;
                else if (value > 10)
                    _side = 10;
            }
        }
        public double CalculateAreaCircle()
        {
            throw new NotImplementedException();
        }

        public double CalculateAreaSquare()
        {
            double S = Side * Side;
            return S;
        }

        public double CalculateAreaTriangle()
        {
            throw new NotImplementedException();
        }
    }
    class Triangle : IFigure
    {
        private double _side;
        private double _height;
        public double Side
        {
            get { return _side; }
            set
            {
                if (value < 1)
                    _side = 1;
                else if (value > 10)
                    _side = 10;
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 1)
                    _height = 1;
                else if (value > 10)
                    _height = 10;
            }
        }
        public Triangle(double side, double height)
        {
            Side = side;
            Height = height;
        }
        public double CalculateAreaCircle()
        {
            throw new NotImplementedException();
        }

        public double CalculateAreaSquare()
        {
            throw new NotImplementedException();
        }

        public double CalculateAreaTriangle()
        {
            double S = 0.5 * Side * Height;
            return S;
        }
    }
  
}
