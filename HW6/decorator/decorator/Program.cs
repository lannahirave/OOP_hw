using System;
using System.Runtime.CompilerServices;

namespace decorator
{
    public class Do
    {
        public string GetName()
        {
            return this.GetType().Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Client client = new Client();
            var fir = new Fir();
            fir.AddDecor(new Bulb());
            fir.AddDecor(new Jewelry());
            fir.AddDecor(new Bulb());
            DecoratorA decorator1 = new DecoratorA(fir);
            client.ClientCode(decorator1);

        }
    }
}