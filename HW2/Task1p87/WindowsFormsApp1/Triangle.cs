using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class Triangle
    {
        public double a, b, c;
        protected const double RADIAN = 180 / Math.PI;
        public string Status { get; set; }
        public Triangle()
		{
            a = b = c = 0;
		}
        public Triangle(double side1, double side2, double side3)
        {
            if (!CheckSides(side1, side2, side3))
            {
                Status = "Wrong sides input.";
                return;
            };
            a = side1;
            b = side2;
            c = side3;
            Status = "Created.";
        }
        public Triangle(int side1, int side2, int side3)
        {
            if (!CheckSides(side1, side2, side3))
            {
                Status = "Wrong sides input.";
                return;
            };
            a = side1;
            b = side2;
            c = side3;
            Status = "Created.";


        }
        public bool ChangeSides(int side, double value)
        {
            switch (side)
            {
                case 1:
                    if (!CheckSides(value, b, c))
                    {
                        return false;
                    }

                    a = value;
                    break;
                case 2:
                    if (!CheckSides(a, value, c))
                    {
                        return false;
                    }
                    b = value;
                    break;
                case 3:
                    if (!CheckSides(a, b, value))
                    {
                        return false;
                    }
                    c = value;
                    break;
                default:
                    Console.WriteLine("Unknown side.");
                    break;
            }
            return true;
        }

        protected bool CheckSides(double side1, double side2, double side3)
        {
            return side1 + side2 >= side3 && side1 + side3 >= side2 && side2 + side3 >= side1;
        }

        public string Angles()
        {
            string text;
            double value = (a * a + b * b - c * c) / (2 * a * b);
            double angle = Math.Acos(value) * RADIAN;
            text = $"Angle between sides A and B: {angle}*\r\n";

            value = (c * c + b * b - a * a) / (2 * b * c);
            angle = Math.Acos(value) * RADIAN;
            text += $"Angle between sides C and B: {angle}*\r\n";

            value = (a * a + c * c - b * b) / (2 * a * c);
            angle = Math.Acos(value) * RADIAN;
            text += $"Angle between sides A and C: {angle}*";
            return text;
        }
        public double GetPerimeter()
        {
            return a + b + c;
        }
        public virtual double GetSquare() {
            return 0;
        }
    }
    public class EquilateralTriangle : Triangle
    {
        protected double square;

        public EquilateralTriangle(double a, double b, double c) : base(a, b, c) { }
        public override double GetSquare()
		{
            square = Math.Sqrt(3)*a*a/4;
            return square;
		}
    }
	
}


