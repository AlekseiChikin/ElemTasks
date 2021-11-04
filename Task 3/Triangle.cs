using System;

namespace Task_3
{
    class Triangle
    {
        public string Name { get; init; }
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
        public double Area { get; init; }
        public bool isValid { get; init; }
        public Triangle(string name, double a, double b, double c)
        {
            Name = name;
            SideA = a;
            SideB = b;
            SideC = c;
            Area = AreaOfATriangle();
            isValid = CheckValidity();
        }
        private bool CheckValidity()
        {
            return !Double.IsNaN(Area);
        }
        private double AreaOfATriangle()
        {
            //Heron's formula
            double p = (SideA + SideB + SideC) / 2;
            double result = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

            return result;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
