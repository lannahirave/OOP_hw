using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher N_G_Rusina = new Teacher();
            Student V_Nikitin = new Student(99);
            Adapter adapter = new Adapter(V_Nikitin, N_G_Rusina);
            Console.WriteLine($"{adapter.GetGrade()} is final grade.");
            
        }
    }
}