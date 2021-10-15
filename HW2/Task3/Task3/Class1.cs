using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	public abstract class Triangle
	{
		protected double a, b, angle;
		public Triangle() { }
		public virtual void getSquare(){ }
		public virtual void getPerimeter() { }
	}
	public class RightTriangle: Triangle
	{
		public new double getSquare()
		{
			return a * b * Math.Sin(angle * 180 / Math.PI);
		}
		public new double getPerimeter()
		{
			// cos^2(a) + sin^2(a) = 1
			double cos = Math.Cos(angle);
			double c = Math.Sqrt(a*a + b*b -2*a*b*cos);
			return a + b + c;
		}
	}
	public class IsoscelesTriangle: Triangle
	{
		public new double getSquare()
		{
			return a * b * Math.Sin(angle * 180 / Math.PI);
		}
		public new double getPerimeter()
		{
			// cos^2(a) + sin^2(a) = 1
			double cos = Math.Cos(angle);
			double c = Math.Sqrt(a * a + b * b - 2 * a * b * cos);
			return a + b + c;
		}
	}
}


