using System;
using System.Linq;
using System.Collections.Generic;


namespace linq
{
	public class Student
	{
		public int Age;
		public string Name;
	}

	class Program
	{
		static void Main(string[] args)
		{
			var myStudents1 = new List<Student>
			{
				new Student() {Age=18, Name="Alice"},
				new Student() {Age=20, Name="Tom"},
				new Student() {Age=18, Name="Bot"},
				new Student() {Age=18, Name="Alice"},
			};
			var myStudents2 = new List<Student>
			{
				new Student() {Name="Alice"},
				new Student() {Name="Tom"},
				new Student() {Name="Tim"},
				new Student() {Name="Alice"},
			};
			Console.WriteLine(myStudents1.Distinct().Count());
			Console.ReadKey();
		}
	}
}
