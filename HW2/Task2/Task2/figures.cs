using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Figure
{	
	public Figure() {
		Status = "Empty figure";
	}
	public abstract string Status { get; set; }
	public abstract double GetPerimeter();
	public abstract double GetSquare();
}

public class Triangle : Figure
{
	protected double a, b, c;
	public override string Status { get; set; }
	public Triangle()
	{
		Status = "Empty triangle.";
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

	
	public override double GetPerimeter()
	{
		return a + b + c;
	}
	protected bool CheckSides(double side1, double side2, double side3)
	{
		return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1 && side1 > 0 && side2 > 0 && side3 > 0;
	}
	public override double GetSquare()
	{
		double p = this.GetPerimeter();
		double s = Math.Sqrt(p / 2 * (p / 2 - a) * (p / 2 - b) * (p / 2 - c));
		return s;
	}
}

public class Square: Figure
{
	protected double a;
	public override string Status { get; set; }
	public  Square() 
	{
		Status = "Empty square.";
	}
	public Square(double side)
	{
		if (!CheckSide(side))
		{
			Status = "Wrong side.";
			return;
		}
		a = side;
		Status = "Created.";
	}
	public bool CheckSide(double side){
		return side > 0;
	}
	public override double GetPerimeter()
	{
		return 4*a;
	}
	public override double GetSquare()
	{
		return a * a;
	}
}

public class Circle : Figure
{
	protected double radius;
	public override string Status { get; set; }
	public Circle()
	{
		Status = "Empty circle.";
	}
	public Circle(double r)
	{
		if (!CheckRadius(r))
		{
			Status = "Wrong radius.";
			return;
		}
		radius = r;
		Status = "Created.";
	}
	public bool CheckRadius(double radius){
		return radius > 0;
	}

	public override double GetPerimeter()
	{
		return 2*Math.PI*radius;
	}
	public override double GetSquare()
	{
		return Math.PI * radius * radius;
	}
}

public class Rectangle : Figure
{
	protected double a, b;
	public override string Status { get; set; }
	public Rectangle()
	{
		Status = "Empty rectangle.";
	}
	public Rectangle(double side1, double side2)
	{
		if (!CheckSide(side1, side2))
		{
			Status = "Wrong sides.";
			return;
		}
		a = side1;
		b = side2;
		Status = "Created.";
	}
	public bool CheckSide(double side1, double side2)
	{
		return side1 > 0 && side2 > 0;
	}
	public override double GetPerimeter()
	{
		return 4*a;
	}
	public override double GetSquare()
	{
		return a*b;
	}
}

public class Rhombus : Figure
{
	protected double a, sin;
	public override string Status { get; set; }
	public Rhombus()
	{
		Status = "Empty rhombus.";
	}
	public Rhombus(double side1, double angle)
	{
		try
		{
			if (angle > 0 && angle < 180)
			{
				sin = Math.Sin(angle * 180 / Math.PI);
				a = side1;
				Status = "Created.";
			}
			else
			{
				Status = "Wrong angle";
				return;
			}
		}
		catch (Exception exp)
		{
			Status = $"{exp}";
		}
	}
	public override double GetPerimeter()
	{
		return 4*a;
	}
	public override double GetSquare()
	{
		return a*a*sin;
	}
}




