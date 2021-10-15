using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
	public partial class Form1 : Form
	{
		private Figure figure;
		public Form1()
		{
			InitializeComponent();
		}
		private void check()
		{
			if (figure.Status == "Created.")
			{
				button7.Show();
				button8.Show();
			}
			else
			{
				button7.Hide();
				button8.Hide();
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			// Triangle
			figure = new Triangle();
			label1.Text = "Enter sides: ";
			textBox1.Show();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox2.Show();
			textBox3.Show();
			textBox4.Hide();
			button7.Hide();
			button8.Hide();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			//Square
			label1.Text = "Enter a side: ";
			figure = new Square();
			textBox1.Show();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox2.Hide();
			textBox3.Hide();
			textBox4.Hide();
			button7.Hide();
			button8.Hide();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			// Circle
			label1.Text = "Enter a radius: ";
			figure = new Circle();
			textBox1.Show();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox2.Hide();
			textBox3.Hide();
			textBox4.Hide();
			button7.Hide();
			button8.Hide();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			// Rectangle
			label1.Text = "Enter sides: ";
			figure = new Rectangle();
			textBox1.Show();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox2.Show();
			textBox3.Hide();
			textBox4.Hide();
			button7.Hide();
			button8.Hide();
		}
		private void button5_Click(object sender, EventArgs e)
		{
			// Rhombus
			label1.Text = "Enter a side and an angle: ";
			figure = new Rhombus();
			textBox1.Show();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox2.Show();
			textBox3.Hide();
			textBox4.Hide();
			button7.Hide();
			button8.Hide();
		}
		private void button6_Click(object sender, EventArgs e)
		{
			// Enter button
			double a, b, c;
			try
			{
				Console.WriteLine(figure is Triangle);
				if (figure is Triangle)
				{
					a = Convert.ToDouble(textBox1.Text);
					b = Convert.ToDouble(textBox2.Text);
					c = Convert.ToDouble(textBox3.Text);
					figure = new Triangle(a, b, c);
					textBox4.Show();
					textBox4.Clear();
					textBox4.AppendText(figure.Status);
				}
				else if (figure is Square)
				{
					a = Convert.ToDouble(textBox1.Text);
					figure = new Square(a);
					if (figure.Status == "Created.")
					{
						button7.Show();
						button8.Show();
					}
					textBox4.Clear();
					textBox4.Show();
					textBox4.Text = figure.Status;
				}
				else if (figure is Rectangle)
				{
					a = Convert.ToDouble(textBox1.Text);
					b = Convert.ToDouble(textBox2.Text);
					figure = new Rectangle(a, b);
					if (figure.Status == "Created.")
					{
						button7.Show();
						button8.Show();
					}
					textBox4.Clear();
					textBox4.Show();
					textBox4.Text = figure.Status;
				}
				else if (figure is Circle)
				{
					a = Convert.ToDouble(textBox1.Text);
					figure = new Circle(a);
					if (figure.Status == "Created.")
					{
						button7.Show();
						button8.Show();
					}
					textBox4.Clear();
					textBox4.Show();
					textBox4.Text = figure.Status;
				}
				else if (figure is Rhombus)
				{
					a = Convert.ToDouble(textBox1.Text);
					b = Convert.ToDouble(textBox2.Text);
					figure = new Rhombus(a, b);
					if (figure.Status == "Created.")
					{
					button7.Show();
					button8.Show();
					}
					textBox4.Clear();
					textBox4.Show();
					textBox4.Text = figure.Status;
				}
			}
			catch (Exception exp)
			{
				textBox4.Clear();
				textBox4.Text = $"Wrong input: {exp}";
			}
		}
		private void Form1_Load(object sender, EventArgs e) { }

		private void button7_Click(object sender, EventArgs e)
		{
			//get square
			textBox4.Clear();
			textBox4.AppendText($"Area is {figure.GetSquare()} units.");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			// get perimeter
			textBox4.Clear();
			textBox4.AppendText($"Perimeter is {figure.GetPerimeter()} units.");
		}
	}
}
