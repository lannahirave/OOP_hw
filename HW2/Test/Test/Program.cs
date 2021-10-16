using System;
namespace Test
{
	private class A
	{
		protected int a;
		public int b;
		void methodA(A a1, B b1)
		{
			a1.a = 1;
			b1.a = 1;
		}
	}
	public class B: A
	{
		void methodB(A a1, B b1)
		{
			a1.a = 1;
			this.a = 10;
			b1.a = 2;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			A a = new A();
			a.mA();
		}
	}
}
