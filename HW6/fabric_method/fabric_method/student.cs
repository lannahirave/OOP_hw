using System;

namespace fabric_method
{
    public interface IStudent
    {
        public void Status();
    }

    class GoodStudent : IStudent
    {
        public void Status()
        {
            Console.WriteLine("I`m GOOD STUDENT");
        }
    }

    class BadStudent : IStudent
    {
        public void Status()
        {
            Console.WriteLine("I`m BAD STUDENT");
        }
    }

    public abstract class Uni
    {
        public abstract IStudent CreateStudent();
    }

    public class KPI : Uni
    {
        public override IStudent CreateStudent()
        {
            return new GoodStudent();
        }
    }

    public class SHEVA : Uni
    {
        public override IStudent CreateStudent()
        {
            return new BadStudent();
        }
    }
}