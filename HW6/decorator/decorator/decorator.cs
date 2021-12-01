using System;
using System.Collections.Generic;


namespace decorator
{
    public abstract class DecorationsForTree
    { }
    public class Bulb: DecorationsForTree
    { }
    public class Jewelry : DecorationsForTree
    { }
    public abstract class ChristmasTree
    {
        public List<DecorationsForTree> decorations = new List<DecorationsForTree>();

        public void AddDecor(DecorationsForTree decor)
        {
            decorations.Add(decor);
        }
        public abstract void DoLight();
    }

    public class Fir : ChristmasTree
    {
        
        public override void DoLight()
        {

            foreach (var item in decorations)
            {
                string name = item.GetType().Name;
                string status = "";
                if (name == "Bulb")
                {
                    status = "lights";
                }
                Console.WriteLine($"{name} {status}");
            }
        }
    }

    public abstract class Decorator: ChristmasTree
    {
        protected ChristmasTree _tree;

        public Decorator(ChristmasTree component)
        {
            this._tree = component;
        }
        
        public void SetComponent(ChristmasTree component)
        {
            this._tree = component;
        }

        // The Decorator delegates all work to the wrapped component.
        public override void DoLight()
        {
            if (this._tree != null)
            {
                this._tree.DoLight();
            }
            else
            {
                Console.WriteLine("Nothing on the tree.");
            }
        }
    }

    public class DecoratorA : Decorator
    {
        public DecoratorA(ChristmasTree tree): base(tree){}
        public new void DoLight()
        {
            base.DoLight();
        }
    }

    public class Client
    {
        public void ClientCode(ChristmasTree tree)
        {
            tree.DoLight();
        }
    }
}