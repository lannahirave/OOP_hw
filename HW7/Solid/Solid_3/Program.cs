using System;

namespace Solid3
{

    class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetRectangleArea()
        {
            return Width * Height;
        }
    }

//квадрат наслідується від прямокутника!!!
    class Square : Rectangle
    {
        public override int Width
        {
            get { return base.Width; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

        public override int Height
        {
            get { return base.Width; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
                Rectangle rect = new Square();
                rect.Width = 5;
                rect.Height = 101;

                Console.WriteLine(rect.GetRectangleArea());
                //Відповідь 100? Що не так???
                Console.ReadKey();
            }
        }
    }
