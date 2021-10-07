using System;

namespace currency
{
    /*
     * 
     * Використовуючи Visual Studio, створіть проект за 
    шаблоном  Console  Application.  Створіть  клас  Converter.  В  тілі  класу 
    створити  користувацький  конструктор,  який  приймає  два  дійсні 
    аргументи, і ініціалізує поля, які відповідають курсу долара та євро по 
    відношенню до гривні – public Converter(double usd, double eur).  
    Напишіть програму, яка буде виконувати конвертацію з гривні в 
    одну з зазначених валют та навпаки.*/
    
    class Converter
    {
        double USDRate;
        double EURRate;
        public Converter(double USD, double EUR)
        {
            this.USDRate = USD;
            this.EURRate = EUR;
        }

        public void FromUAH(double UAH)
        {   
            if(UAH <= 0)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            Console.WriteLine("{0} UAHS", UAH);
            Console.WriteLine("{0} USD", UAH/USDRate);
            Console.WriteLine("{0} EURS", UAH/EURRate);
        }
        public void ToUAH(string Currency, double amount)
        {
            if (Currency.ToLower() == "usd")
            {
                Console.WriteLine("{0} USD is {1} UAH", amount, amount * USDRate);
            }
            else if (Currency.ToLower() == "eur")
            {
                Console.WriteLine("{0} EUR is {1} UAH", amount, amount * EURRate);
            }
            else Console.WriteLine("Wrong input");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double USD; double EUR;
            do
            {
                Console.WriteLine("Enter current USD exchange rate: ");
                USD = Convert.ToDouble((Console.ReadLine()));
                Console.WriteLine("Enter current EUR exchange rate: ");
                EUR = Convert.ToDouble((Console.ReadLine()));
            }
            while (USD <= 0 || EUR <= 0);
         
            Converter conv = new Converter(USD, EUR);
            double UAH;
            do
            {
                Console.WriteLine("Enter UAH amount: ");
                UAH = Convert.ToDouble((Console.ReadLine()));
            }
            while (UAH <= 0);
            conv.FromUAH(UAH);
            do
            {
                Console.WriteLine("Enter EUR amount: ");
                EUR = Convert.ToDouble((Console.ReadLine()));
            }
            while (EUR <= 0);
            conv.ToUAH("EUR", EUR);
            do
            {
                Console.WriteLine("Enter USD amount: ");
                USD = Convert.ToDouble((Console.ReadLine()));
            }
            while (USD <= 0);
            conv.ToUAH("USD", USD);

        }
    }
}
