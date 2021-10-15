using System;

public abstract class Figure
{
	public abstract double GetPerimeter();
	public abstract double GetSquare();
}

public class Triangle: Figure
{
	double a, b, c;
	public string Status { get; set; }
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
	public override double GetPerimeter()
	{
		return a + b + c;
	}
	protected bool CheckSides(double side1, double side2, double side3)
	{
		return side1 + side2 >= side3 && side1 + side3 >= side2 && side2 + side3 >= side1;
	}
}
