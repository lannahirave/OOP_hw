using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще
  
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, 
розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи 
книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та 
верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/
namespace Solid4
{
    interface IItem
    {
        void SetColor(byte color);
        void SetSize(byte size);

        void SetPrice(double price);
    }

    interface IDiscount
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
    }

    class Book : IItem, IDiscount
    {
        protected double _price;

        public void SetPrice(double price)
        {
            _price = price;
        }

        public void SetColor(byte color)
        {
        }

        public void SetSize(byte size)
        {
        }

        public void ApplyDiscount(string discount)
        {
            double _discount = Convert.ToDouble(discount);
            _price = _price * (1 - _discount);
        }

        public void ApplyPromocode(String promocode)
        {
            double _discount = 1;
            if (promocode == "1111")
                _discount = 0.1;
            _price = _price * (1 - _discount);
        }
    }

    class Outerwear : IItem, IDiscount
    {
        protected double _price;
        protected byte _color;
        protected private byte _size;

        public void SetPrice(double price)
        {
            _price = price;
        }

        public void SetColor(byte color)
        {
            _color = color;
        }

        public void SetSize(byte size)
        {
            _size = size;
        }

        public void ApplyDiscount(string discount)
        {
            double _discount = Convert.ToDouble(discount);
            _price = _price * (1 - _discount);
        }

        public void ApplyPromocode(String promocode)
        {
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.ReadKey();
    }
}