using System;

namespace fabric_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Uni sheva = new SHEVA();
            var studentSheva = sheva.CreateStudent();
            studentSheva.Status();
            Uni kpi = new KPI();
            var studentKpi = kpi.CreateStudent();
            studentKpi.Status();
        }
    }
}
