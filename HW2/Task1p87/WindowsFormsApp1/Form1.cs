using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private Triangle triangle;

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox4.Clear();
			double a, b, c;
			try
			{
				a = Convert.ToDouble(textBox1.Text);
				b = Convert.ToDouble(textBox2.Text);
				c = Convert.ToDouble(textBox3.Text);
				if (a <= 0 || b <= 0 || c <= 0)
				{
					textBox4.AppendText("Some side is 0");
					button2.Hide();
					button3.Hide();
					button4.Hide();
					return;
				}
				if (a == b && b == c)
				{
					triangle = new EquilateralTriangle(a, b, c);
					button4.Show();
				}
				else
				{
					this.triangle = new Triangle(a, b, c);
					button4.Hide();
				}
				textBox4.AppendText(triangle.Status);
				if (triangle.Status == "Wrong sides input.")
				{
					button2.Hide();
					button3.Hide();
					button4.Hide();
					return;
				}
				button2.Show();
				button3.Show();
			}
			catch (Exception ex)
			{
				textBox4.AppendText(ex.Message);
				button2.Hide();
				button3.Hide();
				button4.Hide();
				return;
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox4.Clear();
			double perimeter = triangle.GetPerimeter();
			textBox4.AppendText($"Perimeter is {perimeter} units.");
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			textBox4.Clear();
			string text = triangle.Angles();
			textBox4.AppendText(text);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox4.Clear();
			string text = $"Square of equilateral triangle is {triangle.GetSquare()} units.";
			textBox4.AppendText(text);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
